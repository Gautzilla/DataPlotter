using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DataPlotter.DataPlotterLibrary;
using System.IO;
using System.Drawing.Imaging;
using DataPlotter.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DataPlotter.DataPlotterUI
{
    public partial class Plot : Form
    {
        private readonly Home _home;
        private readonly DataManager _data;
        private readonly ChartInfo _chartInfo;
        private readonly List<(int YVarIndex, IndependantVariable variable, List<string> levels)> _levelsToPlot;
        
        private static List<(List<string> name, List<(string x, float y)> values)> _meanLines;
        private static List<Func<double, double>> _regressionFunc;
        private static List<List<(string x, (float l, float h) y)>> _std;

        private static readonly float _lineWidth = 3f;
        private static readonly Pen[] _pens =
        {
            new Pen(Color.FromArgb(63, 78, 79)) { Width = _lineWidth },
            new Pen(Color.FromArgb(162, 123, 92)){DashPattern = new float[]{ 1f, 2f } , Width = _lineWidth},
            new Pen(Color.CadetBlue){DashPattern = new float[]{ 4f, 3f } , Width = _lineWidth},

        };

        // TODO: User-defined font
        private static readonly Font _font = new Font("Consolas", 24);


        private static readonly float _xOffsetRatio = 0.02f; // Offset between each line
        private static float _xOffset; // Offset between each line
        internal Plot(Home home)
        {
            InitializeComponent();

            _home = home;
            _data = _home.dataManager;
            _chartInfo = _home.ChartInfo;
            _levelsToPlot = _chartInfo.LevelsToPlot;

            _meanLines = new List<(List<string>, List<(string x, float y)>)>();
            _regressionFunc = new List<Func<double, double>>();
            _std = new List<List<(string x, (float l, float h) y)>>();
        }

        private void Plot_Load(object sender, EventArgs e)
        {
            FormParameters();
            PlotChart();
        }

        private void FormParameters()
        {
            chart.Dock = DockStyle.Fill;

            Size = new Size(_chartInfo.Size.w > 0 ? _chartInfo.Size.w : Size.Width, _chartInfo.Size.h > 0 ? _chartInfo.Size.h : Size.Width);
        }

        /// <summary>
        /// Plots the specified effect/interaction.
        /// </summary>
        private void PlotChart()
        {
            chart.Series.Clear();

            // MEAN : are plotted in the PaintLine event handler
            _meanLines = _data.MeanLine(_chartInfo.XVariable, _chartInfo.IsAxisLog.y, _levelsToPlot);
            if (_chartInfo.Regression)  _regressionFunc = _data.Regression(_chartInfo.XVariable, _chartInfo.IsAxisLog.y, _levelsToPlot);

            _std = _data.Std( _chartInfo.XVariable, _chartInfo.IsAxisLog.y, _levelsToPlot );

            PlotLines();

            ChartDisplay();
        }

        private void PlotLines()
        {
            IndependantVariable mainYVar = _levelsToPlot.Count > 0 ? _levelsToPlot.Single(tuple => tuple.YVarIndex == 0).variable : _chartInfo.XVariable;

            for (int line = 0; line < _meanLines.Count; line++)
            {
                int lineStyle = line % _meanLines.Where(mL => mL.name.Any(var => var.Contains(mainYVar.Name))).Count();

                _xOffset = LinesOffset(_meanLines.Count, lineStyle, _xOffsetRatio);

                string lineName = String.Join(" x ", _meanLines[line].name);

                // CONFIDENCE INTERVAL
                PlotConfidenceInterval(lineName, line);
                ErrorBarDisplay();                

            }
        }

        /// <summary>
        /// Computes the offset to apply to each line depending on if there are 2 or 3 lines.
        /// </summary>
        private float LinesOffset(int numberOfLines, int currentLine, float ratio)
        {
            switch (numberOfLines)
            {
                case 1: ratio *= 0; break;
                case 2: ratio *= (currentLine == 0 ? -1 : 1); break;
                default: ratio *= (currentLine - 1); break;
            }  

            return ratio;
        }

        private void PlotConfidenceInterval(string lineName, int lineIndex)
        {
            var sdLine = _std[lineIndex];
            chart.Series.Add($"{lineName} sd");

            chart.Series[lineIndex].ChartType = SeriesChartType.ErrorBar;
            chart.Series[lineIndex].BorderWidth = (int)_lineWidth;
            chart.Series[lineIndex].IsVisibleInLegend = false;

            int x = 0;

            foreach (var point in sdLine)
            {
                if (int.TryParse(point.x, out int xVal))
                {
                    float xPos = _chartInfo.IsAxisLog.x ? (xVal * (1 + _xOffset)) : (xVal + _xOffset);
                    chart.Series[$"{lineName} sd"].Points.AddXY(xPos, 0, point.y.l, point.y.h);
                 }
                else
                {
                    x++;
                    chart.Series[$"{lineName} sd"].Points.AddXY(x + _xOffset, 0, point.y.l, point.y.h);
                }
            }
        }

        private void ErrorBarDisplay()
        {
            int iD = 0;
            foreach (var series in chart.Series)
            {
                series.Color = _pens[iD].Color;
                series.CustomProperties = "PixelPointWidth = 10";
                iD++;
                iD %= _levelsToPlot.Count() > 0 ? _levelsToPlot.Count(level => level.YVarIndex == 0) : chart.Series.Count() ;
            }
        }

        private void Chart_Paint(object sender, PaintEventArgs e)
        {
            DrawExtraGraphics(e.Graphics);
        }

        private void DrawExtraGraphics(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            bool xIsNumerical = _meanLines.All(mL => mL.values.All(mean => float.TryParse(mean.x, out float numMean)));

            for (int line = 0; line < _meanLines.Count; line++)
            {

                int lineStyle = line;
                if (_levelsToPlot.Count() > 0) lineStyle %= _levelsToPlot.Single(tuple => tuple.YVarIndex == 0).levels.Count();

                int linesToOffset = _levelsToPlot.Count() > 0 ? _levelsToPlot.Single(tuple => tuple.YVarIndex == 0).levels.Count() : 1;

                Pen pen = _pens[lineStyle % _pens.Length];
                
                _xOffset = LinesOffset(linesToOffset, lineStyle, _xOffsetRatio);
                float x = 0;

                if (xIsNumerical)
                {
                    List<(float x, float y)> points = _meanLines[line].values.Select(mean => (_chartInfo.IsAxisLog.x ? (float.Parse(mean.x) * (1 + _xOffset)) : (float.Parse(mean.x) + _xOffset), mean.y)).ToList();

                    List<Point> meanPoints = points.Select(p => new Point((int)chart.ChartAreas[0].AxisX.ValueToPixelPosition(p.x), (int)chart.ChartAreas[0].AxisY.ValueToPixelPosition(p.y))).ToList();

                    List<Point> regressionPoints = new List<Point>();
                    if (_chartInfo.Regression) regressionPoints = points.Select(p => new Point((int)chart.ChartAreas[0].AxisX.ValueToPixelPosition(p.x), (int)chart.ChartAreas[0].AxisY.ValueToPixelPosition(_regressionFunc[line](p.x)))).ToList();

                    for (int p = 1; p < meanPoints.Count; p++)
                    {

                        if (_chartInfo.Regression)
                        {
                            g.DrawLine(pen, regressionPoints[p - 1], regressionPoints[p]);
                            continue;
                        }

                        g.DrawLine(pen, meanPoints[p - 1], meanPoints[p]);
                    }

                    for (int p = 0; p < meanPoints.Count; p++)
                    {
                        int meanMarkerSize = 6;

                        Pen markerPen = (Pen)_pens.First().Clone(); // Solid line pen
                        markerPen.Color = _pens[lineStyle].Color;

                        Rectangle meanMarkerPosition = new Rectangle(meanPoints[p].X - meanMarkerSize / 2, meanPoints[p].Y - meanMarkerSize / 2, meanMarkerSize, meanMarkerSize);

                        g.DrawEllipse(markerPen, meanMarkerPosition);
                    }

                }
                else
                {
                    int meanMarkerSize = 6;
                    Pen markerPen = (Pen)_pens.First().Clone(); // Solid line pen
                    markerPen.Color = _pens[lineStyle%_pens.Length].Color;

                    List<(float x, float y)> points = _meanLines[line].values.Select(mean => (++x + _xOffset, mean.y)).ToList();
                    List<Point> pointsList = points.Select(p => new Point((int)chart.ChartAreas[0].AxisX.ValueToPixelPosition(p.x), (int)chart.ChartAreas[0].AxisY.ValueToPixelPosition(p.y))).ToList();

                    for (int p = 0; p < points.Count; p++)
                    {
                        Rectangle meanMarkerPosition = new Rectangle(pointsList[p].X - meanMarkerSize / 2, pointsList[p].Y - meanMarkerSize / 2, meanMarkerSize, meanMarkerSize);
                        g.DrawEllipse(markerPen, meanMarkerPosition);
                    }
                }
            }
        }

        private void ChartDisplay()
        {
            AxisDisplay("x");
            AxisDisplay("y");
            if (_levelsToPlot.Count > 0) LegendDisplay();
            chart.ChartAreas.First().BorderWidth = 2;
            chart.ChartAreas.First().BorderColor = Color.Black;
            chart.ChartAreas.First().BorderDashStyle = ChartDashStyle.Solid;
        }

        private void AxisDisplay(string axis)
        {
            ChartArea cA = chart.ChartAreas.First();
            Axis axis1 = axis == "x" ? cA.AxisX : cA.AxisY;
            Axis axis2 = axis == "x" ? cA.AxisX2 : cA.AxisY2;

            axis1.MajorTickMark.Enabled = false;
            axis2.MajorTickMark.Enabled = false;

            // Offset for labels fromPosition and toPosition
            float labelOffset = 0.3f;

            Variable var = axis == "x" ? _chartInfo.XVariable : _data.DepVariable as Variable;

            float dynamic = axis == "x" ? _data.GetLevels(var.Name).Count : 1;

            float axisMargin = 0.2f * dynamic;
            axis1.Minimum = 1 - axisMargin;
            axis2.Minimum = axis1.Minimum;
            axis1.Maximum = dynamic + axisMargin;
            axis2.Maximum = axis1.Maximum;

            if (var.IsNum)
            {

                float min = axis == "x" ? _chartInfo.XRange.min : _chartInfo.YRange.min;
                float max = axis == "x" ? _chartInfo.XRange.max : _chartInfo.YRange.max;
                bool isLog = axis == "x" ? _chartInfo.IsAxisLog.x : _chartInfo.IsAxisLog.y;

                if (!(var.IsLog && min == 0)) axis1.Minimum = min;
                if (!(var.IsLog && max == 0)) axis1.Maximum = max;

                axis2.Enabled = AxisEnabled.True;
                axis2.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
                axis2.MajorGrid.LineWidth = 1;
                axis2.MajorGrid.LineColor = Color.LightGray;
                axis2.LabelStyle.Enabled = false;
                axis2.LineWidth = 0;

                axis2.Minimum = axis1.Minimum;
                axis2.Maximum = axis1.Maximum;

                axis1.IsLogarithmic = isLog;
                axis2.IsLogarithmic = isLog;

                List<float> majorTicks = axis == "x" ? _chartInfo.MajorTicks.x : _chartInfo.MajorTicks.y;
                float minorTicksInterval = axis == "x" ? _chartInfo.MinorTicksInterval.x : _chartInfo.MinorTicksInterval.y;

                if (isLog)
                {
                    axis1.LogarithmBase = 2;
                    axis2.LogarithmBase = 2;
                }

                if (majorTicks.Count > 0)
                {
                    var ticks = GetNumLabels((int)min, (int)Math.Ceiling(max), majorTicks, labelOffset, minorTicksInterval, isLog);
                    foreach (var tick in ticks.major) axis1.CustomLabels.Add(tick);
                    foreach (var tick in ticks.minor) axis2.CustomLabels.Add(tick);
                }
            }
            else
            {
                foreach (var tick in GetQualitativeLabels(var, labelOffset)) axis1.CustomLabels.Add(tick);
            }

            axis1.LineWidth = 0;
            axis1.MajorGrid.LineColor = Color.Gray;
            string unit = string.IsNullOrEmpty(var.Unit) ? string.Empty : $" ({var.Unit})";
            axis1.Title = var.Name + unit;
            axis1.TitleFont = _font;
            axis2.TitleFont = _font;
            axis1.LabelStyle.Font = _font;
            axis2.LabelStyle.Font = _font;
        }

        private (List<CustomLabel> major, List<CustomLabel> minor) GetNumLabels(int min, int max, List<float> majorTicks, float offset, float tickInterval, bool logAxis)
        {
            List<CustomLabel> majorCL = new List<CustomLabel>();
            List<CustomLabel> minorCL = new List<CustomLabel>();

            // TODO: float major ticks
            int[] majorTicksInt = majorTicks.Select(f => (int)f).ToArray();

            float[] tickPositions = Enumerable.Range(min, (int)((max - min) / tickInterval) + 1).Select((i, x) => min + x * tickInterval).ToArray();

            foreach (float tick in tickPositions)
            {
                double linPos = logAxis ? Math.Log(tick, 2) : tick; // Log values on linear axis

                CustomLabel cL = new CustomLabel();

                cL.FromPosition = linPos - offset;
                cL.ToPosition = linPos + offset;

                cL.Text = tick.ToString();

                cL.LabelMark = LabelMarkStyle.Box;
                cL.GridTicks = GridTickTypes.Gridline;

                if (majorTicksInt.Any(t => Math.Abs(t - tick) < 0.00001f)) majorCL.Add(cL);
                else minorCL.Add(cL);
            }
            return (majorCL, minorCL);
        }

        private List<CustomLabel> GetQualitativeLabels(Variable var, float offset)
        {
            List<CustomLabel> ticks = new List<CustomLabel>();
            string[] labels = _data.GetLevels(var.Name).ToArray();

            foreach (int tick in Enumerable.Range(1, labels.Length))
            {
                CustomLabel cL = new CustomLabel();

                cL.FromPosition = tick - offset;
                cL.ToPosition = tick + offset;

                cL.Text = labels[tick-1];

                cL.LabelMark = LabelMarkStyle.Box;
                cL.GridTicks = GridTickTypes.Gridline;

                ticks.Add(cL);
            }
            return ticks;
        }

        private void LegendDisplay()
        {
            // TODO: Add legend control in the UI

            Legend newL = new Legend();
            newL.Position = chart.Legends.First().Position;  // copy a few settings:
            newL.Docking = chart.Legends.First().Docking;
            newL.Alignment = chart.Legends.First().Alignment;

            int scale = 2;


            int iw = 32 * scale - 5; int iw2 = iw / 2; int ih = 18 * scale - 5; int ih2 = ih / 2;
            int ew = 5 * scale;
            int markerSize = 3 * scale;
            int offset = 2;

            chart.ApplyPaletteColors();

            // Either the only Yvar for simple effects or the 2nd Yvar for interactions.
            var tupleToBeDisplayedInLegend = _levelsToPlot.Single(level => level.YVarIndex == (_levelsToPlot.Count() > 1 ? 1 : 0));

            int legendItems = tupleToBeDisplayedInLegend.levels.Count();

            for (int legendItem = 0; legendItem < legendItems; legendItem++)
            {
                Bitmap bmp = new Bitmap(iw, ih);
                Graphics G = Graphics.FromImage(bmp);
                Pen pen = _pens[legendItem];
                Pen solidPen = (Pen)_pens.First().Clone();
                solidPen.Color = _pens[legendItem].Color;


                G.DrawLine(pen, 0, ih2, iw, ih2); // Data line
                G.DrawLine(solidPen, iw2, 1 + offset, iw2, ih - offset); // ErrorBar vertical line
                G.DrawLine(solidPen, iw2-ew, 0 + offset, iw2+ew, 0 + offset); // ErrorBar bottom line
                G.DrawLine(solidPen, iw2-ew, ih-1 - offset, iw2+ew, ih-1 - offset); // ErrorBar top line

                G.DrawEllipse(solidPen, iw2 - markerSize / 2, ih2 - markerSize / 2, markerSize, markerSize);


                // add a new NamesImage
                string name = tupleToBeDisplayedInLegend.variable.CleanLevel(tupleToBeDisplayedInLegend.levels[legendItem]);
                NamedImage ni = new NamedImage(name, bmp);
                chart.Images.Add(ni);
                // create and add the custom legend item
                LegendItem lit = new LegendItem(name, Color.Red, name);
                newL.CustomItems.Add(lit);
            }
            chart.Legends.First().Enabled = false;
            chart.Legends.Add(newL);
            newL.IsDockedInsideChartArea = true;
            newL.DockedToChartArea = chart.ChartAreas.First().Name;
            // TODO: user-controlled docking position
            newL.Docking = _chartInfo.LegendDocking;
            newL.Font = _font;
            newL.TableStyle = LegendTableStyle.Tall;
            newL.BorderWidth = 1;
            newL.BorderDashStyle = ChartDashStyle.Solid;
            newL.BorderColor = Color.Black;
            //chart.Legends.First().Position = new ElementPosition(0, 0, 100, 100);
        }

        private void Plot_FormClosing(object sender, FormClosingEventArgs e)
        {
            _home.Show();
        }

        /// <summary>
        /// Saves the plot as an emf file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chart_Click(object sender, EventArgs e)
        {
            string figureName = _chartInfo.DepVarName.RemoveWhiteSpaces() + "_";
            figureName += _chartInfo.XVariable.Name.RemoveWhiteSpaces();

            if (_chartInfo.LevelsToPlot.Count > 0)
            {
                figureName += "x" + _chartInfo.LevelsToPlot.Select(tuple => String.Join("x", tuple.levels));
            }            

            figureName = $@"C:\Users\User\Documents\DataPlotter\{figureName}.emf";
            MemoryStream ms = new MemoryStream();
            chart.SaveImage(ms, ImageFormat.Emf);
            ms.Seek(0, SeekOrigin.Begin);
            using (var mf0 = new Metafile(ms))
            {
                // "this" can be the form, that will be sufficient
                using (var gfx = this.CreateGraphics())
                {
                    // this creates an empty EMF file
                    using (var mf = new Metafile(figureName, gfx.GetHdc()))
                    {                        
                        // gfx context for drawing in the file
                        using (var igfx = Graphics.FromImage(mf))
                        {
                            // draw the chart without mean lines
                            igfx.DrawImage(mf0, 0, 0);
                            // draw the mean lines
                            DrawExtraGraphics(igfx);
                        }
                    }
                }
            }
        }
    }
}