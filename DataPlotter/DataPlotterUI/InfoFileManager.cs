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
using System.Runtime.InteropServices.ComTypes;

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

            DependantVariable = new DependantVariable(string.Empty, false);
            independantVariables = new List<IndependantVariable>();
        }

        public InfoFileManager(string infoFilePath)
        {
            InitializeComponent();

            LoadInfo(infoFilePath);
        }

        private void Btn_loadInfoFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog_infoFile.ShowDialog();

            string fileName = OpenFileDialog_infoFile.FileName;
            LoadInfo(fileName);
        }

        private void Btn_saveInfoFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                FileName = "infoFile.txt",
                DefaultExt = "txt"
            };

            if (saveFile.ShowDialog() != DialogResult.OK) return;

            string fileName = saveFile.FileName;

            string[] fileContent = new string[] { dependantVariable.WriteParameters() }.Concat(independantVariables.Select(var => var.WriteParameters()).ToArray()).ToArray();

            File.WriteAllLines(fileName, fileContent);

            MessageBox.Show($"File {fileName.Split('\\').Last()} written succesfully.");
        }

        private void LoadInfo(string fileName)
        {
            string[] input = File.ReadAllLines(fileName);

            dependantVariable = ParseDependantVariable(input.First());
            independantVariables = input.Skip(1).Select(line => ParseIndependantVariable(line)).ToList();

            RefreshInfo();
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

            ListBox_indepVar.SelectedIndex = -1;
            RefreshIndepVarParameters();
        }

        private void ListBox_indepVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshIndepVarParameters();
        }

        private void RefreshIndepVarParameters()
        {
            if (ListBox_indepVar.SelectedIndex == -1)
            {
                TextBox_indepVarName.Clear();
                ComboBox_indepVarType.SelectedIndex = -1;
                ListBox_indepVarLevels.Items.Clear();
                TextBox_indepVarUnit.Clear();
                return;
            }

            string selectedVarName = ListBox_indepVar.SelectedItem.ToString();

            IndependantVariable independantVariable = independantVariables.Single(var => var.Name == selectedVarName);

            TextBox_indepVarName.Text = independantVariable.Name;
            ComboBox_indepVarType.SelectedIndex = ComboBox_depVarType.Items.IndexOf(independantVariable.IsNum ? (independantVariable.IsLog ? "Logarithmic" : "Linear") : "Qualitative");
            TextBox_indepVarUnit.Text = independantVariable.Unit;

            ListBox_indepVarLevels.Items.Clear();
            ListBox_indepVarLevels.Items.AddRange(independantVariable.Levels);
        }

        private void Btn_removeIndepVar_Click(object sender, EventArgs e)
        {
            IndependantVariable indepVar = independantVariables.Single(var => var.Name == ListBox_indepVar.SelectedItem.ToString());

            independantVariables.Remove(indepVar);
            RefreshInfo();
        }

        private void Btn_removeIndepVarLevel_Click(object sender, EventArgs e)
        {
            IndependantVariable indepVar = independantVariables.Single(var => var.Name == ListBox_indepVar.SelectedItem.ToString());
            string levelToRemove = ListBox_indepVarLevels.SelectedItem.ToString();
            indepVar.RemoveLevel(levelToRemove);

            RefreshIndepVarParameters();
        }

        private void Btn_addIndepVarLevel_Click(object sender, EventArgs e)
        {
            IndependantVariable indepVar = independantVariables.Single(var => var.Name == ListBox_indepVar.SelectedItem.ToString());
            string newLevelName = TextBox_newLevelName.Text;

            if (newLevelName == string.Empty || indepVar.Levels.Any(level => level == newLevelName)) return;

            if (indepVar.IsNum)
            {
                if (!float.TryParse(newLevelName, out float level))
                {
                    MessageBox.Show("Quantitative variables must have numerical levels.");
                    return;
                }
            }

            indepVar.AddLevel(newLevelName);

            TextBox_newLevelName.Clear();
            RefreshIndepVarParameters();
        }

        private void Btn_addIndepVar_Click(object sender, EventArgs e)
        {
            string newIndepVar = "New Variable";

            if (independantVariables.Count > 0 && independantVariables.Any(var => var.Name == newIndepVar)) return;

            independantVariables.Add(new IndependantVariable(newIndepVar, new string[] { }, false));
            RefreshInfo();
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

            ListBox_indepVar.SelectedIndex = ListBox_indepVar.Items.IndexOf(newName);
        }

        private void ComboBox_indepVarType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ListBox_indepVar.SelectedIndex == -1) return;

            IndependantVariable indepVar = independantVariables.Single(var => var.Name == ListBox_indepVar.SelectedItem.ToString());

            indepVar.IsLog = (sender as ComboBox).Text == "Logarithmic";
            indepVar.IsNum = (sender as ComboBox).Text != "Qualitative";

            if (indepVar.IsNum && indepVar.Levels.Any(level => !float.TryParse(level, out float fLevel))) MessageBox.Show("WARNING: some levels are not numerical.");   
        }

        private void TextBox_depVarName_TextChanged(object sender, EventArgs e)
        {
            SetDependantVariableName();
        }



        private void SetDependantVariableName()
        {
            DependantVariable.Name = TextBox_depVarName.Text;
        }

        private void ComboBox_depVarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DependantVariable.IsLog = (sender as ComboBox).Text == "Logarithmic";
            DependantVariable.IsNum = (sender as ComboBox).Text != "Qualitative";
        }

        private void TextBox_depVarUnit_TextChanged(object sender, EventArgs e)
        {
            DependantVariable.Unit = TextBox_depVarUnit.Text;
        }

        private void TextBox_indepVarUnit_TextChanged(object sender, EventArgs e)
        {
            if (ListBox_indepVar.SelectedIndex == -1) return;
            IndependantVariable indepVar = IndependantVariables.Single(var => var.Name == ListBox_indepVar.SelectedItem.ToString());
            indepVar.Unit = TextBox_indepVarUnit.Text;
        }
    }
}
