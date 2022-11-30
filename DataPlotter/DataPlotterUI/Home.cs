﻿using System;
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

        #endregion

        public Home()
        {
            InitializeComponent();

            _IsAxisLog = (CheckBox_isXLog.Checked, CheckBox_isYLog.Checked);
        }

        private void Btn_dataFilePath_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            _dataFilePath = openFileDialog1.FileName;
            string dataFileName = _dataFilePath.Split('\\').Last();
            label_dataPath.Text = dataFileName;
        }

        private void Btn_InfoPath_Click(object sender, EventArgs e)
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

        private void TextBox_chartWidth_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(TextBox_chartWidth.Text, out int chartWidth))
            {
                _chartSize.w = chartWidth;
            }
            else
            {
                MessageBox.Show("Chart width must be an integer.");
                TextBox_chartWidth.Text = String.Empty;
                _chartSize.w = 0;
            }
        }

        private void TextBox_chartHeight_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(TextBox_chartHeight.Text, out int chartHeight))
            {
                _chartSize.h = chartHeight;
            }
            else
            {
                MessageBox.Show("Chart height must be an integer.");
                TextBox_chartHeight.Text = String.Empty;
                _chartSize.h = 0;
            }
        }

        private void TextBox_depVarName_Leave(object sender, EventArgs e)
        {
            _depVarName = TextBox_depVarName.Text;
        }

        private void TextBox_xMin_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(TextBox_xMin.Text, out float xMin))
            {
                _xRange.min = xMin;
            } else
            {
                MessageBox.Show("x min value must be an float.");
                TextBox_xMin.Text = String.Empty;
                _xRange.min = 0f;
            }
        }

        private void TextBox_xMax_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(TextBox_xMax.Text, out float xMax))
            {
                _xRange.max = xMax;
            }
            else
            {
                MessageBox.Show("x max value must be an float.");
                TextBox_xMax.Text = String.Empty;
                _xRange.max = 0f;
            }
        }

        private void TextBox_yMin_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(TextBox_yMin.Text, out float yMin))
            {
                _yRange.min = yMin;
            }
            else
            {
                MessageBox.Show("y min value must be an float.");
                TextBox_yMin.Text = String.Empty;
                _yRange.min = 0f;
            }
        }

        private void TextBox_yMax_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(TextBox_yMax.Text, out float yMax))
            {
                _yRange.max = yMax;
            }
            else
            {
                MessageBox.Show("y max value must be an float.");
                TextBox_yMax.Text = String.Empty;
                _yRange.max = 0f;
            }
        }

        private void CheckBox_isXLog_CheckedChanged(object sender, EventArgs e)
        {
            _IsAxisLog.x = CheckBox_isXLog.Checked;
        }

        private void CheckBox_isYLog_CheckedChanged(object sender, EventArgs e)
        {
            _IsAxisLog.y = CheckBox_isYLog.Checked;
        }
    }
}
