using DataPlotter.DataPlotterLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataPlotter.UserControls;

namespace DataPlotter.Forms
{
    public partial class Chart : Form
    {
        private Home _home;
        public Chart(Home home)
        {
            InitializeComponent();

            _home = home;

            InitializeGridTicks();
            
            RefreshDisplay();
        }

        private void InitializeGridTicks()
        {
            gridTickSelectorXAxisTicks.Home = _home;
            gridTickSelectorYAxisTicks.Home = _home;
            gridTickSelectorYAxisTicks.Text = "Y-axis ticks";

            if (_home.ChartInfo == null) return;
            gridTickSelectorXAxisTicks.Ticks = _home.ChartInfo.MajorTicks.x;
            gridTickSelectorYAxisTicks.Ticks = _home.ChartInfo.MajorTicks.y;
        }

        private void RefreshDisplay()
        {
            if (_home.ChartInfo == null) return;

            textBoxChartName.Text = _home.ChartInfo.Name;
            textBoxChartWidth.Text = _home.ChartInfo.Size.w.ToString();
            textBoxChartHeight.Text = _home.ChartInfo.Size.h.ToString();
        }

        private void textBoxChartName_TextChanged(object sender, EventArgs e)
        {
            if (_home.ChartInfo == null) return;

            _home.ChartInfo.Name = textBoxChartName.Text;
        }

        private void textBoxChartWidth_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (int.TryParse(textBox.Text, out int width))
            {
                _home.ChartInfo.Size = (width, _home.ChartInfo.Size.h);
            }
            else textBox.Text = string.Empty;
        }

        private void textBoxChartHeight_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (int.TryParse(textBox.Text, out int height))
            {
                _home.ChartInfo.Size = (_home.ChartInfo.Size.w, height);
            }
            else textBox.Text = string.Empty;
        }
    }
}
