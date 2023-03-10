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
using System.IO;
using System.Drawing.Drawing2D;

namespace DataPlotter.DataPlotterUI
{
    internal partial class InfoFileManager : Form
    {
        private DependantVariable dependantVariable;

        public DependantVariable DependantVariable
        {
            get { return dependantVariable; }
            set { dependantVariable = value; }
        }

        private List<IndependantVariable> independantVariables;

        public List<IndependantVariable> IndependantVariables
        {
            get { return independantVariables; }
            set { independantVariables = value; }
        }



        public InfoFileManager()
        {
            InitializeComponent();
        }

        private void Btn_loadInfoFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog_infoFile.ShowDialog();

            string fileName = OpenFileDialog_infoFile.FileName;
            LoadInfo(fileName);

            RefreshInfo();
        }

        private void LoadInfo(string fileName)
        {
            string[] input = File.ReadAllLines(fileName);

            dependantVariable = ParseDependantVariable(input.First());
            independantVariables = input.Skip(1).Select(line => ParseIndependantVariable(line)).ToList();
        }

        private DependantVariable ParseDependantVariable(string line)
        {
            string[] parameters = line.Split(';').Select(s => s.Trim()).ToArray();

            string name = parameters[0];
            bool isNum = parameters[1] != "qualitative";
            bool isLog = parameters[1] == "log";

            if (parameters.Length == 2) return new DependantVariable(name, isNum, isLog, string.Empty);

            string unit = parameters[2];

            return new DependantVariable(name, isNum, isLog, unit);
        }

        private IndependantVariable ParseIndependantVariable(string line)
        {
            string[] parameters = line.Split(';').Select(s => s.Trim()).ToArray();

            string name = parameters[0];
            bool isNum = parameters[1] != "qualitative";
            bool isLog = parameters[1] == "log";

            string[] levels = parameters[2].Split(',').Select(s => s.Trim()).ToArray();

            if (parameters.Length == 3) return new IndependantVariable(name, levels, isNum, isLog, string.Empty);

            string unit = parameters[3];

            return new IndependantVariable(name, levels, isNum, isLog, unit);
        }

        private void RefreshInfo()
        {
            TextBox_depVarName.Text = dependantVariable.Name;
            ComboBox_depVarType.SelectedIndex = ComboBox_depVarType.Items.IndexOf(dependantVariable.IsNum ? (dependantVariable.IsLog ? "Logarithmic" : "Linear") : "Qualitative");
            TextBox_depVarUnit.Text = dependantVariable.Unit;

            ListBox_indepVar.Items.Clear();
            ListBox_indepVar.Items.AddRange(independantVariables.Select(var => var.Name).ToArray());
        }

        private void ListBox_indepVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox.SelectedIndex == -1) return;

            string selectedVarName = listBox.SelectedItem.ToString();

            IndependantVariable independantVariable = independantVariables.Single(var => var.Name == selectedVarName);
        
            TextBox_indepVarName.Text = independantVariable.Name;
            ComboBox_indepVarType.SelectedIndex = ComboBox_depVarType.Items.IndexOf(independantVariable.IsNum ? (independantVariable.IsLog ? "Logarithmic" : "Linear") : "Qualitative");
            TextBox_indepVarUnit.Text = independantVariable.Unit;

            ListBox_indepVarLevels.Items.Clear();
            ListBox_indepVarLevels.Items.AddRange(independantVariable.Levels);
        }

        private void RemoveSelected (ListBox listBox)
        {
            if (listBox.SelectedIndex == -1) return;

            int itemToRemove = listBox.SelectedIndex;
            listBox.SelectionMode = SelectionMode.None;
            listBox.Items.RemoveAt(itemToRemove);
            listBox.SelectionMode = SelectionMode.One;
        }

        private void Btn_removeIndepVar_Click(object sender, EventArgs e)
        {
            RemoveSelected(ListBox_indepVar);
        }

        private void Btn_removeIndepVarLevel_Click(object sender, EventArgs e)
        {
            RemoveSelected(ListBox_indepVarLevels);
        }

        private void Btn_addIndepVarLevel_Click(object sender, EventArgs e)
        {
            string newLevelName = TextBox_newLevelName.Text;

            if (newLevelName == string.Empty || ListBox_indepVarLevels.Items.Contains(newLevelName)) return;

            ListBox_indepVarLevels.Items.Add(newLevelName);

            TextBox_newLevelName.Clear();
        }

        private void Btn_addIndepVar_Click(object sender, EventArgs e)
        {
            string newIndepVar = "New Variable";

            if (ListBox_indepVar.Items.Contains(newIndepVar)) return;

            ListBox_indepVar.Items.Add(newIndepVar);
        }

        private void TextBox_indepVarName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode !=  Keys.Enter) return;

            SetIndepVarName();
        }

        private void TextBox_indepVarName_Leave(object sender, EventArgs e)
        {
            SetIndepVarName();
        }

        private void SetIndepVarName()
        {
            int varToRename = ListBox_indepVar.SelectedIndex;

            if (varToRename == -1) return;

            string oldName = ListBox_indepVar.Items[varToRename].ToString();
            string newName = TextBox_indepVarName.Text;

            if (newName == string.Empty) return;

            independantVariables.Single(var => var.Name == oldName).Name = newName;
            RefreshInfo();
        }
    }
}
