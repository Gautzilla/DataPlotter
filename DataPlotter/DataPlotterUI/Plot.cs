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
        private readonly DataManager _data;
        private readonly ChartInfo _chartInfo;
        internal Plot(DataManager data, ChartInfo chartInfo)
        {
            InitializeComponent();
            _data = data;
            _chartInfo = chartInfo;
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
            List<string> yVarLevels = _data.GetLevels(_chartInfo.YVar);

            for (int line = 0; line < yVarLevels.Count; line++)
            {
                float xOffset = LinesOffset(yVarLevels.Count, line, 0.2f);

                string lineName = yVarLevels[line] ?? _chartInfo.XVar;


                // CONFIDENCE INTERVAL
                PlotConfidenceInterval(lineName, line, xOffset);

                // MEAN
                //_meanLines = data.MeanLine(variableX, logY, variableY, restrictionLevels);
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

        private void PlotConfidenceInterval(string lineName, int lineIndex, float xOffset)
        {
            var sdLine = _data.Std(_chartInfo.XVar, _chartInfo.IsAxisLog.y, _chartInfo.YVar, _chartInfo.YVar2Level);
            chart.Series.Add($"{lineName} sd");
            chart.Series[$"{lineName} sd"].ChartType = SeriesChartType.ErrorBar;
            //LineLook($"{lineName} sd", Color.Black, ChartDashStyle.Solid, MarkerStyle.None, false);

            int x = 0;

            foreach (var point in sdLine[lineIndex])
            {
                if (int.TryParse(point.x, out int xVal))
                {
                    chart.Series[$"{lineName} sd"].Points.AddXY(xVal * (1 + xOffset), 0, point.y.l, point.y.h);
                }
                else
                {
                    chart.Series[$"{lineName} sd"].Points.AddXY(x + xOffset, 0, point.y.l, point.y.h);
                    x++;
                }
            }
        }
    }
}
