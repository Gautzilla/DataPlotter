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

namespace DataPlotter.DataPlotterUI
{
    public partial class Plot : Form
    {
        private readonly Home _home;
        private readonly DataManager _data;
        private readonly ChartInfo _chartInfo;
        private static List<List<(string x, float y)>> _meanLines;

        private static readonly float _lineWidth = 2f;
        private static readonly Pen[] _pens =
        {
            new Pen(Color.Black) { Width = _lineWidth },
            new Pen(Color.Black){DashPattern = new float[]{ 1f, 2f } , Width = _lineWidth},
            new Pen(Color.Black){DashPattern = new float[]{ 4f, 3f } , Width = _lineWidth},

        };


        private static readonly float _xOffsetRatio = 0.02f; // Offset between each line
        private static float _xOffset; // Offset between each line
        internal Plot(DataManager data, ChartInfo chartInfo, Home home)
        {
            InitializeComponent();
            _data = data;
            _chartInfo = chartInfo;
            _home = home;
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

            List<string> yVarLevels = _data.GetLevels(_chartInfo.YVar);

            for (int line = 0; line < yVarLevels.Count; line++)
            {
                _xOffset = LinesOffset(yVarLevels.Count, line, _xOffsetRatio);

                string lineName = yVarLevels[line] ?? _chartInfo.XVar;


                // CONFIDENCE INTERVAL
                PlotConfidenceInterval(lineName, line);
                ErrorBarDisplay();

                // MEAN : are plotted in the PaintLine event handler
                _meanLines = _data.MeanLine(_chartInfo.XVar, _chartInfo.IsAxisLog.y, _chartInfo.YVar, _chartInfo.YVar2Level);
            }

            ChartDisplay();
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

            foreach (var point in sdLine[lineIndex])
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
            foreach (var series in chart.Series)
            {
                series.Color = Color.Black;
                series.CustomProperties = "PixelPointWidth = 10";
            }
        }

        private void Chart_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            bool xIsNumerical = _meanLines.All(mL => mL.All(mean => float.TryParse(mean.x, out float numMean)));

            for (int line = 0; line < _meanLines.Count; line++)
            {
                Pen pen = _pens[line];

                _xOffset = LinesOffset(_meanLines.Count, line, _xOffsetRatio);
                float x = 0;

                if (xIsNumerical)
                {
                    List<(float x, float y)> points = _meanLines[line].Select(mean => (float.Parse(mean.x) * (1 + _xOffset), mean.y)).ToList();
                    PaintLine(g, pen, points);
                }
                else
                {
                    List<(float x, float y)> points = _meanLines[line].Select(mean => (x, mean.y)).ToList();
                    x++;
                    PaintLine(g, pen, points);
                }
            }
        }

        private void PaintLine(Graphics g, Pen pen, List<(float x, float y)> points)
        {
            List<Point> pointsList = points.Select(p => new Point((int)chart.ChartAreas[0].AxisX.ValueToPixelPosition(p.x), (int)chart.ChartAreas[0].AxisY.ValueToPixelPosition(p.y))).ToList();

            for (int p = 1; p < pointsList.Count; p++)
            {
                g.DrawLine(pen, pointsList[p - 1], pointsList[p]);
            }
        }

        private void ChartDisplay()
        {
            AxisDisplay("x");
            AxisDisplay("y");
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

            if (var.IsNum)
            {
                float min = axis == "x" ? _chartInfo.XRange.min : _chartInfo.YRange.min;
                float max = axis == "x" ? _chartInfo.XRange.max : _chartInfo.YRange.max;
                bool isLog = axis == "x" ? _chartInfo.IsAxisLog.x : _chartInfo.IsAxisLog.y;

                axis1.Minimum = min;
                axis1.Maximum = max;

                axis2.Enabled = AxisEnabled.True;
                axis2.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
                axis2.MajorGrid.LineWidth = 1;
                axis2.MajorGrid.LineColor = Color.LightGray;
                axis2.LabelStyle.Enabled = false;
                axis2.LineWidth = 0;

                axis2.Minimum = cA.AxisX.Minimum;
                axis2.Maximum = cA.AxisX.Maximum;

                axis1.IsLogarithmic = isLog;
                axis2.IsLogarithmic = isLog;
                axis1.LogarithmBase = 2;
                axis2.LogarithmBase = 2;

                if (isLog)
                {
                    List<float> majorTicks = axis == "x" ? _chartInfo.MajorTicks.x : _chartInfo.MajorTicks.y;
                    float minorTicksInterval = axis == "x" ? _chartInfo.MinorTicksInterval.x : _chartInfo.MinorTicksInterval.y;

                    var ticks = GetLogLabels((int)min, (int)Math.Ceiling(max), majorTicks, labelOffset, minorTicksInterval);
                    foreach (var tick in ticks.major) axis1.CustomLabels.Add(tick);
                    foreach (var tick in ticks.minor) axis2.CustomLabels.Add(tick);
                }

                axis1.LineWidth = 0;
                axis1.MajorGrid.LineColor = Color.Gray;
                string unit = var.Unit == string.Empty ? string.Empty : $" ({var.Unit})";
                axis1.Title = var.Name + unit;
            }
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

        private void Plot_FormClosing(object sender, FormClosingEventArgs e)
        {
            _home.Show();
        }
    }
}
