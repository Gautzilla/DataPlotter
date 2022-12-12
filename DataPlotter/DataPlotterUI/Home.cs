using System;
using System.Globalization;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataPlotter.DataPlotterLibrary;

namespace DataPlotter
{
    public partial class Home : Form
    {
        private Chart _chart;

        #region Data Settings

        private string _dataFilePath = string.Empty;
        private string _infoFilePath = string.Empty;
        private DataManager _dataManager;
        private string[] _variableNames;

        #endregion

        public Home()
        {
            InitializeComponent();
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            _chart = new Chart();
            _chart.IsAxisLog = (CheckBox_isXLog.Checked, CheckBox_isYLog.Checked);
        }

        private void Btn_dataFilePath_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            _dataFilePath = openFileDialog1.FileName;
            string dataFileName = _dataFilePath.Split('\\').Last();
            label_dataPath.Text = dataFileName;
        }

        private void Btn_infoFilePath_Click(object sender, EventArgs e)
        {
            if (_dataFilePath == string.Empty)
            {
                MessageBox.Show("Please load a data file first.");
                return;
            }

            openFileDialog2.ShowDialog();
            _infoFilePath = openFileDialog2.FileName;
            string infoFileName = _infoFilePath.Split('\\').Last();
            label_infoPath.Text = infoFileName;

            _dataManager = new DataManager(_dataFilePath, _infoFilePath);

            UpdateXvarListBox();
        }

        private void UpdateXvarListBox()
        {
            _variableNames = _dataManager.Variables.Select(var => var.Name).ToArray();

            ListBox_xVar.Items.AddRange(_variableNames);
        }

        private void ListBox_xVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            _chart.XVar = ListBox_xVar.SelectedItem.ToString();
            UpdateYvar1ListBox();
        }

        private void UpdateYvar1ListBox()
        {
            ListBox_yVar.Items.Clear();
            ListBox_yVar.Items.Add("None (simple effect)");
            ListBox_yVar.Items.AddRange(_variableNames.Where(var => var != _chart.XVar).ToArray());
        }

        private void ListBox_yVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            _chart.YVar = ListBox_yVar.SelectedIndex == 0 ? String.Empty : ListBox_yVar.SelectedItem.ToString();
            UpdateYvar2ListBox();
        }
        
        private void UpdateYvar2ListBox()
        {
            ListBox_yVar2.Items.Clear();
            if (_chart.YVar == String.Empty) return;
            ListBox_yVar2.Items.Add("None (2-factors interaction)");
            ListBox_yVar2.Items.AddRange(_variableNames.Where(var => var != _chart.XVar && var != _chart.YVar).ToArray());
        }

        private void ListBox_yVar2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _chart.YVar2 = ListBox_yVar2.SelectedIndex == 0 ? String.Empty : ListBox_yVar2.SelectedItem.ToString();
            UpdateYvar2LevelsListBox();
        }

        private void UpdateYvar2LevelsListBox()
        {
            ListBox_yVar2Levels.Items.Clear();
            if (_chart.YVar2 == String.Empty) return;
            ListBox_yVar2Levels.Items.AddRange(_dataManager.GetLevels(_chart.YVar2).ToArray());
        }

        private void ListBox_yVar2Levels_SelectedIndexChanged(object sender, EventArgs e)
        {
            _chart.YVar2Level = ListBox_yVar2Levels.SelectedItem.ToString();
        }

        private void TextBox_chartSize_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (int.TryParse(textBox.Text, out int chartSize))
            {
            }
            else
            {
                textBox.Text = String.Empty;
            }

            if (textBox.Equals(TextBox_chartWidth)) _chart.Size = (chartSize, _chart.Size.h);
            if (textBox.Equals(TextBox_chartHeight)) _chart.Size = (_chart.Size.w, chartSize);
        }

        private void TextBox_depVarName_Leave(object sender, EventArgs e)
        {
            _chart.DepVarName = TextBox_depVarName.Text;
        }

        private void TextBox_axisRange_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (float.TryParse(textBox.Text, out float rangeValue))
            {
            } else
            {
                textBox.Text = String.Empty;
            }

            if (textBox.Equals(TextBox_xMin)) _chart.XRange = (rangeValue, _chart.XRange.max);
            if (textBox.Equals(TextBox_xMax)) _chart.XRange = (_chart.XRange.min, rangeValue);
            if (textBox.Equals(TextBox_yMin)) _chart.YRange = (rangeValue, _chart.YRange.max);
            if (textBox.Equals(TextBox_yMax)) _chart.YRange = (_chart.YRange.min, rangeValue);
        }

        private void CheckBox_isAxisLog_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox.Equals(CheckBox_isXLog)) _chart.IsAxisLog = (checkBox.Checked, _chart.IsAxisLog.y);
            if (checkBox.Equals(CheckBox_isYLog)) _chart.IsAxisLog = (_chart.IsAxisLog.x, checkBox.Checked);
        }

        #region Ticks

        private void Btn_addXMajorTick_Click(object sender, EventArgs e) => AddMajorTick(Btn_addXMajorTick);
        private void Btn_removeXMajorTick_Click(object sender, EventArgs e) => RemoveMajorTick(Btn_removeXMajorTick);
        private void Btn_addYMajorTick_Click(object sender, EventArgs e) => AddMajorTick(Btn_addYMajorTick);
        private void Btn_removeYMajorTick_Click(object sender, EventArgs e) => RemoveMajorTick(Btn_removeYMajorTick);

        private void TextBox_MajorTick_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textBox = sender.Equals(TextBox_xMajorTick) ? TextBox_xMajorTick : TextBox_yMajorTick;
            Button button = sender.Equals(TextBox_xMajorTick) ? Btn_addXMajorTick : Btn_addYMajorTick;

            if (e.KeyCode == Keys.Return)
            {
                button.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                textBox.Text = String.Empty;
            }
        }

        private void AddMajorTick(Button button)
        {
            List<float> tickList = button == Btn_addXMajorTick ? _chart.MajorTicks.x : _chart.MajorTicks.y;
            TextBox textBox = button == Btn_addXMajorTick ? TextBox_xMajorTick : TextBox_yMajorTick;
            ListBox listBox = button == Btn_addXMajorTick ? ListBox_xMajorTicks : ListBox_yMajorTicks;

            if (float.TryParse(textBox.Text, out float majorTick))
            {
                if (!tickList.Contains(majorTick))
                {
                    tickList.Add(majorTick);
                    UpdateMajorTickListBox(listBox);
                }
            }

            textBox.Text = string.Empty;
        }

        private void RemoveMajorTick(Button button)
        {
            List<float> tickList = button == Btn_removeXMajorTick ? _chart.MajorTicks.x : _chart.MajorTicks.y;
            ListBox listBox = button == Btn_removeXMajorTick ? ListBox_xMajorTicks : ListBox_yMajorTicks;

            if (listBox.SelectedItem == null) return;

            tickList.RemoveAll(t => t.ToString() == listBox.SelectedItem.ToString());
            UpdateMajorTickListBox(listBox);
        }

        private void UpdateMajorTickListBox(ListBox listBox)
        {
            List<float> updatedList = listBox == ListBox_xMajorTicks ? _chart.MajorTicks.x : _chart.MajorTicks.y;
            listBox.Items.Clear();
            listBox.Items.AddRange(updatedList.OrderBy(f => f).Select(f => f.ToString()).ToArray());
        }

        private void TextBox_MinorTicksInterval_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (float.TryParse(textBox.Text, out float minorTicksInterval))
            {

            } else
            {
                textBox.Text = String.Empty;
            }

            if (textBox.Equals(TextBox_xMinorTicksInterval)) _chart.MinorTicksInterval = (minorTicksInterval, _chart.MinorTicksInterval.y);
            if (textBox.Equals(TextBox_yMinorTicksInterval)) _chart.MinorTicksInterval = (_chart.MinorTicksInterval.x, minorTicksInterval);
        }

        #endregion

        private void TextBox_chartName_Leave(object sender, EventArgs e)
        {
            _chart.Name = TextBox_chartName.Text;
        }

        private void LoadChartInfos(Chart chart)
        {
            // Parameters
            TextBox_chartName.Text = chart.Name;
            TextBox_chartWidth.Text = chart.Size.w.ToString();
            TextBox_chartHeight.Text = chart.Size.h.ToString();

            // Grid ticks
            ListBox_xMajorTicks.Items.AddRange(chart.MajorTicks.x.Select(x => x.ToString()).ToArray());
            ListBox_yMajorTicks.Items.AddRange(chart.MajorTicks.y.Select(x => x.ToString()).ToArray());
            TextBox_xMinorTicksInterval.Text = chart.MinorTicksInterval.x.ToString();
            TextBox_yMinorTicksInterval.Text = chart.MinorTicksInterval.y.ToString();

            // Axes parameters
            TextBox_depVarName.Text = chart.DepVarName;
            TextBox_xMin.Text = chart.XRange.min.ToString();
            TextBox_xMax.Text = chart.XRange.max.ToString();
            TextBox_yMin.Text = chart.YRange.min.ToString();
            TextBox_yMax.Text = chart.YRange.max.ToString();
            CheckBox_isXLog.Checked = chart.IsAxisLog.x;
            CheckBox_isYLog.Checked = chart.IsAxisLog.y;

            _chart = chart;
        }
    }
}
