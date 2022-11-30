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
        #region Data Settings

        private string _dataFilePath = string.Empty;
        private string _infoFilePath = string.Empty;
        private DataManager _dataManager;
        private string[] _variableNames;

        #endregion

        #region Chart Variables Settings

        private string _xVar = string.Empty;
        private string _yVar = string.Empty;
        private string _yVar2 = string.Empty;
        private string _yVar2Level = string.Empty;

        #endregion

        #region Chart Display Settings

        private (int w, int h) _chartSize = (0,0);
        private string _depVarName = string.Empty;
        private (float min, float max) _xRange = (0f, 0f);
        private (float min, float max) _yRange = (0f, 0f);
        private (bool x, bool y) _IsAxisLog;
        private (List<float> x, List<float> y) _majorTicks = (new List<float>(), new List<float>());
        private (float x, float y) _minorTicksInterval = (0f, 0f);

        #endregion

        public Home()
        {
            InitializeComponent();
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            _IsAxisLog = (CheckBox_isXLog.Checked, CheckBox_isYLog.Checked);
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
            _xVar = ListBox_xVar.SelectedItem.ToString();
            UpdateYvar1ListBox();
        }

        private void UpdateYvar1ListBox()
        {
            ListBox_yVar.Items.Clear();
            ListBox_yVar.Items.Add("None (simple effect)");
            ListBox_yVar.Items.AddRange(_variableNames.Where(var => var != _xVar).ToArray());
        }

        private void ListBox_yVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            _yVar = ListBox_yVar.SelectedIndex == 0 ? String.Empty : ListBox_yVar.SelectedItem.ToString();
            UpdateYvar2ListBox();
        }
        
        private void UpdateYvar2ListBox()
        {
            ListBox_yVar2.Items.Clear();
            if (_yVar == String.Empty) return;
            ListBox_yVar2.Items.Add("None (2-factors interaction)");
            ListBox_yVar2.Items.AddRange(_variableNames.Where(var => var != _xVar && var != _yVar).ToArray());
        }

        private void ListBox_yVar2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _yVar2 = ListBox_yVar2.SelectedIndex == 0 ? String.Empty : ListBox_yVar2.SelectedItem.ToString();
            UpdateYvar2LevelsListBox();
        }

        private void UpdateYvar2LevelsListBox()
        {
            ListBox_yVar2Levels.Items.Clear();
            if (_yVar2 == String.Empty) return;
            ListBox_yVar2Levels.Items.AddRange(_dataManager.GetLevels(_yVar2).ToArray());
        }

        private void ListBox_yVar2Levels_SelectedIndexChanged(object sender, EventArgs e)
        {
            _yVar2Level = ListBox_yVar2Levels.SelectedItem.ToString();
        }

        private void TextBox_chartSize_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (int.TryParse(textBox.Text, out int chartSize))
            {
                if (textBox.Equals(TextBox_chartWidth)) _chartSize.w = chartSize;
                if (textBox.Equals(TextBox_chartHeight)) _chartSize.h = chartSize;
            } else
            {
                if (textBox.Equals(TextBox_chartWidth)) _chartSize.w = 0;
                if (textBox.Equals(TextBox_chartHeight)) _chartSize.h = 0;
                textBox.Text = String.Empty;
            }
        }

        private void TextBox_depVarName_Leave(object sender, EventArgs e)
        {
            _depVarName = TextBox_depVarName.Text;
        }

        private void TextBox_axisRange_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (float.TryParse(textBox.Text, out float rangeValue))
            {
                if (textBox.Equals(TextBox_xMin)) _xRange.min = rangeValue;
                if (textBox.Equals(TextBox_xMax)) _xRange.max = rangeValue;
                if (textBox.Equals(TextBox_yMin)) _yRange.min = rangeValue;
                if (textBox.Equals(TextBox_xMax)) _yRange.max = rangeValue;
            } else
            {
                textBox.Text = String.Empty;
                if (textBox.Equals(TextBox_xMin)) _xRange.min = 0f;
                if (textBox.Equals(TextBox_xMax)) _xRange.max = 0f;
                if (textBox.Equals(TextBox_yMin)) _yRange.min = 0f;
                if (textBox.Equals(TextBox_xMax)) _yRange.max = 0f;
            }
        }

        private void CheckBox_isAxisLog_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox.Equals(CheckBox_isXLog)) _IsAxisLog.x = checkBox.Checked;
            if (checkBox.Equals(CheckBox_isYLog)) _IsAxisLog.y = checkBox.Checked;
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
            List<float> tickList = button == Btn_addXMajorTick ? _majorTicks.x : _majorTicks.y;
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
            List<float> tickList = button == Btn_removeXMajorTick ? _majorTicks.x : _majorTicks.y;
            ListBox listBox = button == Btn_removeXMajorTick ? ListBox_xMajorTicks : ListBox_yMajorTicks;

            if (listBox.SelectedItem == null) return;

            tickList.RemoveAll(t => t.ToString() == listBox.SelectedItem.ToString());
            UpdateMajorTickListBox(listBox);
        }

        private void UpdateMajorTickListBox(ListBox listBox)
        {
            List<float> updatedList = listBox == ListBox_xMajorTicks ? _majorTicks.x : _majorTicks.y;
            listBox.Items.Clear();
            listBox.Items.AddRange(updatedList.OrderBy(f => f).Select(f => f.ToString()).ToArray());
        }

        private void TextBox_MinorTicksInterval_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (float.TryParse(textBox.Text, out float minorTicksInterval))
            {
                if (textBox.Equals(TextBox_xMinorTicksInterval)) _minorTicksInterval.x = minorTicksInterval;
                if (textBox.Equals(TextBox_yMinorTicksInterval)) _minorTicksInterval.y = minorTicksInterval;
            } else
            {
                if (textBox.Equals(TextBox_xMinorTicksInterval)) _minorTicksInterval.x = 0f;
                if (textBox.Equals(TextBox_yMinorTicksInterval)) _minorTicksInterval.y = 0f;
                textBox.Text = String.Empty;
            }
        }

        #endregion
    }
}
