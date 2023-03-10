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
using DataPlotter.DataPlotterUI;
using System.Windows.Forms.DataVisualization.Charting;

namespace DataPlotter
{
    public partial class Home : Form
    {
        private ChartInfo _chartInfo;
        private static List<ChartInfo> _savedCharts;

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

            _savedCharts = PresetManager.LoadPresets();

            _chartInfo = new ChartInfo();
            _chartInfo.IsAxisLog = (CheckBox_isXLog.Checked, CheckBox_isYLog.Checked);

            Btn_infoFilePath.Enabled = false;
        }

        private void Btn_dataFilePath_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            _dataFilePath = openFileDialog1.FileName;
            string dataFileName = _dataFilePath.Split('\\').Last();
            label_dataPath.Text = dataFileName;
            Btn_infoFilePath.Enabled = true;
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
            UpdateDependantVariableTextBox();
        }

        private void UpdateXvarListBox()
        {
            _variableNames = _dataManager.Variables.Select(var => var.Name).ToArray();
            ListBox_xVar.Items.Clear();
            ListBox_xVar.Items.AddRange(_variableNames);
        }

        private void UpdateDependantVariableTextBox()
        {
            TextBox_depVarName.Text = _dataManager.DepVariable.Name;
            CheckBox_isDepVarNum.Checked = _dataManager.DepVariable.IsNum;
            CheckBox_isYLog.Checked = _dataManager.DepVariable.IsLog;

            _chartInfo.DepVarName = _dataManager.DepVariable.Name;
            _chartInfo.IsDepVarNum = _dataManager.DepVariable.IsNum;
            _chartInfo.IsDepVarLog = _dataManager.DepVariable.IsLog;
        }

        private void ListBox_xVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            _chartInfo.XVar = ListBox_xVar.SelectedItem.ToString();
            UpdateYvar1ListBox();
        }

        private void UpdateYvar1ListBox()
        {
            ListBox_yVar.Items.Clear();
            ListBox_yVar.Items.Add("None (simple effect)");
            ListBox_yVar.Items.AddRange(_variableNames.Where(var => var != _chartInfo.XVar).ToArray());
        }

        private void ListBox_yVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            _chartInfo.YVar = ListBox_yVar.SelectedIndex == 0 ? String.Empty : ListBox_yVar.SelectedItem.ToString();
            UpdateYvar2ListBox();
        }
        
        private void UpdateYvar2ListBox()
        {
            ListBox_yVar2.Items.Clear();
            if (_chartInfo.YVar == String.Empty) return;
            ListBox_yVar2.Items.Add("None (2-factors interaction)");
            ListBox_yVar2.Items.AddRange(_variableNames.Where(var => var != _chartInfo.XVar && var != _chartInfo.YVar).ToArray());
        }

        private void ListBox_yVar2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _chartInfo.YVar2 = ListBox_yVar2.SelectedIndex == 0 ? String.Empty : ListBox_yVar2.SelectedItem.ToString();
            if (!_chartInfo.TripleInteractionSamePlot) UpdateYvar2LevelsListBox();
        }

        private void UpdateYvar2LevelsListBox()
        {
            ListBox_yVar2Levels.Items.Clear();
            if (_chartInfo.YVar2 == String.Empty) return;
            ListBox_yVar2Levels.Items.AddRange(_dataManager.GetLevels(_chartInfo.YVar2).ToArray());
        }

        private void ListBox_yVar2Levels_SelectedIndexChanged(object sender, EventArgs e)
        {
            _chartInfo.YVar2Level = ListBox_yVar2Levels.SelectedItem.ToString();
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

            if (textBox.Equals(TextBox_chartWidth)) _chartInfo.Size = (chartSize, _chartInfo.Size.h);
            if (textBox.Equals(TextBox_chartHeight)) _chartInfo.Size = (_chartInfo.Size.w, chartSize);
        }

        private void TextBox_depVarName_Leave(object sender, EventArgs e)
        {
            _chartInfo.DepVarName = TextBox_depVarName.Text;
            _dataManager.DepVariable.Name = _chartInfo.DepVarName;
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

            if (textBox.Equals(TextBox_xMin)) _chartInfo.XRange = (rangeValue, _chartInfo.XRange.max);
            if (textBox.Equals(TextBox_xMax)) _chartInfo.XRange = (_chartInfo.XRange.min, rangeValue);
            if (textBox.Equals(TextBox_yMin)) _chartInfo.YRange = (rangeValue, _chartInfo.YRange.max);
            if (textBox.Equals(TextBox_yMax)) _chartInfo.YRange = (_chartInfo.YRange.min, rangeValue);
        }

        private void CheckBox_isAxisLog_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox.Equals(CheckBox_isXLog)) _chartInfo.IsAxisLog = (checkBox.Checked, _chartInfo.IsAxisLog.y);
            if (checkBox.Equals(CheckBox_isYLog)) _chartInfo.IsAxisLog = (_chartInfo.IsAxisLog.x, checkBox.Checked);
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
            List<float> tickList = button == Btn_addXMajorTick ? _chartInfo.MajorTicks.x : _chartInfo.MajorTicks.y;
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
            List<float> tickList = button == Btn_removeXMajorTick ? _chartInfo.MajorTicks.x : _chartInfo.MajorTicks.y;
            ListBox listBox = button == Btn_removeXMajorTick ? ListBox_xMajorTicks : ListBox_yMajorTicks;

            if (listBox.SelectedItem == null) return;

            tickList.RemoveAll(t => t.ToString() == listBox.SelectedItem.ToString());
            UpdateMajorTickListBox(listBox);
        }

        private void UpdateMajorTickListBox(ListBox listBox)
        {
            List<float> updatedList = listBox == ListBox_xMajorTicks ? _chartInfo.MajorTicks.x : _chartInfo.MajorTicks.y;
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

            if (textBox.Equals(TextBox_xMinorTicksInterval)) _chartInfo.MinorTicksInterval = (minorTicksInterval, _chartInfo.MinorTicksInterval.y);
            if (textBox.Equals(TextBox_yMinorTicksInterval)) _chartInfo.MinorTicksInterval = (_chartInfo.MinorTicksInterval.x, minorTicksInterval);
        }

        #endregion

        private void TextBox_chartName_Leave(object sender, EventArgs e)
        {
            _chartInfo.Name = TextBox_chartName.Text;
        }

        private void LoadChartPreset()
        {
            if (PresetManager.DoesPresetExists(_chartInfo, _dataFilePath))
            {
                _chartInfo = PresetManager.LoadPreset(_chartInfo, _dataFilePath);
                LoadChartInfos(_chartInfo);
            }
        }

        private void LoadChartInfos(ChartInfo chartInfo)
        {
            _chartInfo = chartInfo;
            UpdateGUI();
        }

        private void UpdateGUI()
        {
            // Parameters
            TextBox_chartName.Text = _chartInfo.Name;
            TextBox_chartWidth.Text = _chartInfo.Size.w.ToString();
            TextBox_chartHeight.Text = _chartInfo.Size.h.ToString();
            CheckBox_TripleInteractionSamePlot.Checked = _chartInfo.TripleInteractionSamePlot;
            CheckBox_regression.Checked = _chartInfo.Regression;

            // Grid ticks
            ListBox_xMajorTicks.Items.Clear();
            ListBox_yMajorTicks.Items.Clear();
            ListBox_xMajorTicks.Items.AddRange(_chartInfo.MajorTicks.x.Select(x => x.ToString()).ToArray());
            ListBox_yMajorTicks.Items.AddRange(_chartInfo.MajorTicks.y.Select(x => x.ToString()).ToArray());
            TextBox_xMinorTicksInterval.Text = _chartInfo.MinorTicksInterval.x.ToString();
            TextBox_yMinorTicksInterval.Text = _chartInfo.MinorTicksInterval.y.ToString();

            // Axes parameters
            TextBox_depVarName.Text = _chartInfo.DepVarName;
            TextBox_xMin.Text = _chartInfo.XRange.min.ToString();
            TextBox_xMax.Text = _chartInfo.XRange.max.ToString();
            TextBox_yMin.Text = _chartInfo.YRange.min.ToString();
            TextBox_yMax.Text = _chartInfo.YRange.max.ToString();
            CheckBox_isXLog.Checked = _chartInfo.IsAxisLog.x;
            CheckBox_isYLog.Checked = _chartInfo.IsAxisLog.y;
            CheckBox_isDepVarNum.Checked = _chartInfo.IsDepVarNum;
        }

        private void Btn_plot_Click(object sender, EventArgs e)
        {
            if (!ValidInputs(_chartInfo))
            {
                return;
            }

            Plot plotForm = new Plot(_dataManager, _chartInfo, this);
            plotForm.Show();
            this.Hide();
        }

        private bool ValidInputs(ChartInfo chart)
        {
            return true;
        }

        private void CheckBox_isDepVarNum_CheckedChanged(object sender, EventArgs e)
        {
            _chartInfo.IsDepVarNum = CheckBox_isDepVarNum.Checked;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Btn_savePreset_Click(object sender, EventArgs e)
        {
            PresetManager.UpdatePresets(_chartInfo, _dataFilePath);
        }

        private void Btn_loadPreset_Click(object sender, EventArgs e)
        {
            LoadChartPreset();
        }

        private void CheckBox_regression_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox regression = sender as CheckBox;

            _chartInfo.Regression = regression.Checked;
        }

        private void CheckBox_TripleInteractionSamePlot_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            _chartInfo.TripleInteractionSamePlot = checkBox.Checked;

            if (checkBox.Checked)
            {
                ListBox_yVar2Levels.Items.Clear();
                _chartInfo.YVar2Level = String.Empty;
            }
            else UpdateYvar2LevelsListBox();
            

        }

        #region LegendButtons

        private void Btn_legendTopLeft_Click(object sender, EventArgs e)
        {
            _chartInfo.LegendDocking = Docking.Left;
            SetLegendButtonColors(sender as Button);
        }

        private void Btn_legendTopRight_Click(object sender, EventArgs e)
        {
            _chartInfo.LegendDocking = Docking.Right;
            SetLegendButtonColors(sender as Button);
        }

        private void Btn_legendBottomLeft_Click(object sender, EventArgs e)
        {
            _chartInfo.LegendDocking = Docking.Bottom;
            SetLegendButtonColors(sender as Button);
        }

        private void Btn_legendBottomRight_Click(object sender, EventArgs e)
        {
            _chartInfo.LegendDocking = Docking.Top;
            SetLegendButtonColors(sender as Button);
        }

        private void SetLegendButtonColors(Button litButton)
        {
            Button[] legendButtons = { Btn_legendTopLeft, Btn_legendTopRight, Btn_legendBottomLeft, Btn_legendBottomRight };
            
            Color litColor = Color.FromArgb(162, 123, 92);
            Color unlitColor = Color.FromArgb(63, 78, 79);

            foreach (Button button in legendButtons) button.BackColor = button == litButton ? litColor : unlitColor;       
        }

        #endregion

        private void Btn_infoFilePath_EnabledChanged(object sender, EventArgs e)
        {
            Color enabledColor = Color.FromArgb(162, 123, 92);
            Color unabledColor = Color.FromArgb(63, 78, 79);

            Button btn = sender as Button;

            btn.ForeColor = btn.Enabled ? enabledColor : unabledColor;
        }

        private void Btn_manageInfoFile_Click(object sender, EventArgs e)
        {
            InfoFileManager infoFileManager = new InfoFileManager();

            infoFileManager.Show();
        }

        private void label_dataPath_Click(object sender, EventArgs e)
        {

        }
    }
}
