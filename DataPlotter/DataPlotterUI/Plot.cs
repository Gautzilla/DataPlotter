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
        private static readonly Pen[] _pens =
        {
            new Pen(Color.Black),
            new Pen(Color.Black){DashPattern = new float[]{ 4f, 2f, 1f, 3f } },
            new Pen(Color.Black){DashPattern = new float[]{ 1f, 1f, 1f, 3f } },

        };
        private static readonly float _xOffsetRatio = 0.2f; // Offset between each line
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

                // MEAN : are plotted in the PaintLine event handler
                _meanLines = _data.MeanLine(_chartInfo.XVar, _chartInfo.IsAxisLog.y, _chartInfo.YVar, _chartInfo.YVar2Level);
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

            chart.Series[lineIndex].CustomProperties = "PixelPointWidth = 10";
            //LineLook($"{lineName} sd", Color.Black, ChartDashStyle.Solid, MarkerStyle.None, false);

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

        private void Plot_FormClosing(object sender, FormClosingEventArgs e)
        {
            _home.Show();
        }
    }
}
