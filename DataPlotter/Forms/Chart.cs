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

            legendDisplay.Home = _home;

            InitializeAxisRanges();
            
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
            gridTickSelectorXAxisTicks.SetMinorTick(_home.ChartInfo.MinorTicksInterval.x);
            gridTickSelectorYAxisTicks.SetMinorTick(_home.ChartInfo.MinorTicksInterval.y);

            checkBoxRegression.Checked = _home.ChartInfo.Regression;
        }

        private void InitializeAxisRanges()
        {
            axisRangeX.Home = _home;
            axisRangeY.Home = _home;

            axisRangeX.Axis = "X-axis";
            axisRangeY.Axis = "Y-axis";

            axisRangeX.RefreshDisplay();
            axisRangeY.RefreshDisplay();
        }

        private void RefreshDisplay()
        {
            if (_home.ChartInfo == null) return;

            textBoxChartName.Text = _home.ChartInfo.Name;
            textBoxChartWidth.Text = _home.ChartInfo.Size.w.ToString();
            textBoxChartHeight.Text = _home.ChartInfo.Size.h.ToString();

            textBoxDependantVariableName.Text = _home.ChartInfo.DepVarName;

            legendDisplay.RefreshButtonsColor();
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

        private void textBoxDependantVariableName_TextChanged(object sender, EventArgs e)
        {
            if (_home.ChartInfo == null) return;

            _home.dataManager.DepVariable.Name = textBoxDependantVariableName.Text;
        }

        private void checkBoxRegression_CheckedChanged(object sender, EventArgs e)
        {
            if (_home.ChartInfo == null) return;

            _home.ChartInfo.Regression = checkBoxRegression.Checked;
        }
    }
}
