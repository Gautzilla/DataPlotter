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

namespace DataPlotter.DataPlotterUI
{
    public partial class Plot : Form
    {
        private readonly Home _home;
        private readonly DataManager _data;
        private readonly ChartInfo _chartInfo;
        private static List<List<(string x, float y)>> _meanLines;
        private static List<Func<double, double>> _regressionFunc;

        private static readonly float _lineWidth = 3f;
        private static readonly Pen[] _pens =
        {
            new Pen(Color.DarkSlateGray) { Width = _lineWidth },
            new Pen(Color.Salmon){DashPattern = new float[]{ 1f, 2f } , Width = _lineWidth},
            new Pen(Color.CadetBlue){DashPattern = new float[]{ 4f, 3f } , Width = _lineWidth},

        };

        // TODO: User-defined font
        private static readonly Font _font = new Font("Tahoma", 24);


        private static readonly float _xOffsetRatio = 0.02f; // Offset between each line
        private static float _xOffset; // Offset between each line
        internal Plot(DataManager data, ChartInfo chartInfo, Home home)
        {
            InitializeComponent();
            _data = data;
            _chartInfo = chartInfo;
            _home = home;

            _meanLines = new List<List<(string x, float y)>>();
            _regressionFunc = new List<Func<double, double>>();
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
            List<string> yVar2Levels = _data.GetLevels(_chartInfo.YVar2);

            if (_chartInfo.TripleInteractionSamePlot)
            {
                for (int yVar2Level = 0; yVar2Level < yVar2Levels.Count(); yVar2Level++)
                {
                    _chartInfo.YVar2Level = yVar2Levels[yVar2Level];
                    PlotLines(yVar2Level * _data.GetLevels(_chartInfo.YVar).Count);
                }
            }
            else PlotLines(0);

            ChartDisplay();
        }

        private void PlotLines(int firstLineIndex)
        {
            List<string> yVarLevels = _data.GetLevels(_chartInfo.YVar);

            for (int line = firstLineIndex; line < firstLineIndex + yVarLevels.Count; line++)
            {
                int lineStyle = line % _data.GetLevels(_chartInfo.YVar).Count;

                _xOffset = LinesOffset(yVarLevels.Count, lineStyle, _xOffsetRatio);

                string lineName = yVarLevels[lineStyle] ?? _chartInfo.XVar;
                if (_chartInfo.TripleInteractionSamePlot) lineName += _chartInfo.YVar2Level;


                // CONFIDENCE INTERVAL
                PlotConfidenceInterval(lineName, line);
                ErrorBarDisplay();

                // MEAN : are plotted in the PaintLine event handler
                _meanLines = _meanLines.Append(_data.MeanLine(_chartInfo.XVar, _chartInfo.IsAxisLog.y, _chartInfo.YVar, _chartInfo.YVar2Level)[lineStyle]).ToList();

                if (_chartInfo.Regression) _regressionFunc = _regressionFunc.Append(_data.Regression(_chartInfo.XVar, _chartInfo.IsAxisLog.y, _chartInfo.YVar, _chartInfo.YVar2Level)[lineStyle]).ToList();
            }
        }

        /// <summary>
        /// Computes the offset to apply to each line depending on if there are 2 or 3 lines.
        /// </summary>
        private float LinesOffset(int numberOfLines, int currentLine, float ratio)
        {
            // TODO: LinesOffset for linear xAxis
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
            var sdLine = _data.Std(_chartInfo.XVar, _chartInfo.IsAxisLog.y, _chartInfo.YVar, _chartInfo.YVar2Level);
            chart.Series.Add($"{lineName} sd");

            chart.Series[lineIndex].ChartType = SeriesChartType.ErrorBar;
            chart.Series[lineIndex].BorderWidth = (int)_lineWidth;
            chart.Series[lineIndex].IsVisibleInLegend = false;

            int x = 0;

            foreach (var point in sdLine[lineIndex % _data.GetLevels(_chartInfo.YVar).Count])
            {
                if (int.TryParse(point.x, out int xVal))
                {
                    chart.Series[$"{lineName} sd"].Points.AddXY(xVal * (1 + _xOffset), 0, point.y.l, point.y.h);
                 }
                else
                {
                    chart.Series[$"{lineName} sd"].Points.AddXY(x + _xOffset, 0, point.y.l, point.y.h);
                    x++;
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
                if (_chartInfo.TripleInteractionSamePlot) iD %= _data.GetLevels(_chartInfo.YVar).Count;
            }
        }

        private void Chart_Paint(object sender, PaintEventArgs e)
        {
            DrawExtraGraphics(e.Graphics);
        }

        private void DrawExtraGraphics(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            bool xIsNumerical = _meanLines.All(mL => mL.All(mean => float.TryParse(mean.x, out float numMean)));

            for (int line = 0; line < _meanLines.Count; line++)
            {

                int lineStyle = line;
                int linesToOffset = _meanLines.Count;
                if (_chartInfo.TripleInteractionSamePlot)
                {
                    lineStyle %= _data.GetLevels(_chartInfo.YVar).Count;
                    linesToOffset %= _data.GetLevels(_chartInfo.YVar).Count;
                }

                Pen pen = _pens[lineStyle];

                _xOffset = LinesOffset(linesToOffset, lineStyle, _xOffsetRatio);
                float x = 0;

                if (xIsNumerical)
                {
                    List<(float x, float y)> points = _meanLines[line].Select(mean => (float.Parse(mean.x) * (1 + _xOffset), mean.y)).ToList();

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
                    List<(float x, float y)> points = _meanLines[line].Select(mean => (x, mean.y)).ToList();
                    x++;
                    List<Point> pointsList = points.Select(p => new Point((int)chart.ChartAreas[0].AxisX.ValueToPixelPosition(p.x), (int)chart.ChartAreas[0].AxisY.ValueToPixelPosition(p.y))).ToList();

                    for (int p = 1; p < pointsList.Count; p++)
                    {
                        g.DrawLine(pen, pointsList[p - 1], pointsList[p]);
                    }
                }
            }
        }

        private void ChartDisplay()
        {
            AxisDisplay("x");
            AxisDisplay("y");
            if (_chartInfo.YVar != String.Empty) LegendDisplay();
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
            float labelOffset = 0.2f;

            Variable var = axis == "x" ? _data.Variables.Single(v => v.Name == _chartInfo.XVar) : _data.DepVariable as Variable;

            axis1.Minimum = -0.2;
            axis2.Minimum = -0.2;
            axis1.Maximum = 1.2;
            axis2.Maximum = 1.2;

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

                if (isLog)
                {
                    axis1.LogarithmBase = 2;
                    axis2.LogarithmBase = 2;

                    List<float> majorTicks = axis == "x" ? _chartInfo.MajorTicks.x : _chartInfo.MajorTicks.y;
                    float minorTicksInterval = axis == "x" ? _chartInfo.MinorTicksInterval.x : _chartInfo.MinorTicksInterval.y;

                    if (majorTicks.Count > 0)
                    {
                        var ticks = GetLogLabels((int)min, (int)Math.Ceiling(max), majorTicks, labelOffset, minorTicksInterval);
                        foreach (var tick in ticks.major) axis1.CustomLabels.Add(tick);
                        foreach (var tick in ticks.minor) axis2.CustomLabels.Add(tick);
                    }
                }
            }
            axis1.LineWidth = 0;
            axis1.MajorGrid.LineColor = Color.Gray;
            string unit = var.Unit == string.Empty ? string.Empty : $" ({var.Unit})";
            axis1.Title = var.Name + unit;
            axis1.TitleFont = _font;
            axis2.TitleFont = _font;
            axis1.LabelStyle.Font = _font;
            axis2.LabelStyle.Font = _font;
        }

        private (List<CustomLabel> major, List<CustomLabel> minor) GetLogLabels(int min, int max, List<float> majorTicks, float offset, float tickInterval)
        {
            List<CustomLabel> majorCL = new List<CustomLabel>();
            List<CustomLabel> minorCL = new List<CustomLabel>();

            // TODO: float major ticks
            int[] majorTicksInt = majorTicks.Select(f => (int)f).ToArray();

            float[] tickPositions = Enumerable.Range(min, (int)((max - min) / tickInterval) + 1).Select((i, x) => min + x * tickInterval).ToArray();

            foreach (float tick in tickPositions)
            {
                double linPos = Math.Log(tick, 2); // Log values on linear axis
                //if (min > 0) linPos -= Math.Log(min, 2);

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

            int legendItems = _meanLines.Count;
            if (_chartInfo.TripleInteractionSamePlot) legendItems /= _data.GetLevels(_chartInfo.YVar2).Count;

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
                string name = _data.Variables.Single(v => v.Name == _chartInfo.YVar).Levels[legendItem];
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
            newL.Docking = Docking.Left;
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
            figureName += _chartInfo.XVar.RemoveWhiteSpaces();
            if (_chartInfo.YVar != string.Empty) figureName += "X" + _chartInfo.YVar.RemoveWhiteSpaces();
            if (_chartInfo.YVar2 != string.Empty)
            {
                figureName += "X" + _chartInfo.YVar2.RemoveWhiteSpaces();
                if (!_chartInfo.TripleInteractionSamePlot) figureName += $"({_chartInfo.YVar2Level.RemoveWhiteSpaces()})";
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