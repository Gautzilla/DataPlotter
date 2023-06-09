using DataPlotter.DataPlotterLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataPlotter.UserControls
{
    public partial class VariableSelector : UserControl
    {
        public string VariableType
        {
            get { return labelVariableType.Text; }
            set { labelVariableType.Text = value; _isYVar = value.Contains("Y-axis"); }
        }
        public VariableSelector NextVariableSelector 
        { 
            get; 
            set; 
        }

        public Forms.Home Home { get; set; }

        private bool _isYVar;

        private IndependantVariable _selectedVariable;

        public VariableSelector()
        {
            InitializeComponent();
            NextVariableSelector = null;
            listBoxVariables.DisplayMember = "Name";
        }

        public void AddVariable(IndependantVariable variable)
        {
            listBoxVariables.Items.Add(variable);            
        }

        public void Clear()
        {
            if (listBoxVariables.SelectedItems.Count > 0) Home.ChartInfo.LevelsToPlot.Remove((IndependantVariable)listBoxVariables.SelectedItem);

            listBoxVariables.Items.Clear();
            listBoxLevels.Items.Clear();

            if (NextVariableSelector == null) return;
            NextVariableSelector.Clear();
        }

        private void listBoxVariables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxVariables.SelectedIndex == -1) return;

            IndependantVariable selectedVariable = listBoxVariables.SelectedItem as IndependantVariable;

            if (NextVariableSelector != null) NextVariableSelector.Clear(); // It has to be put here otherwise LevelsToPlot might be overwritten then deleted when the next variableselectors are cleared

            if (_isYVar)
            {
                if (_selectedVariable != null) Home.ChartInfo.LevelsToPlot.Remove(_selectedVariable); // selected before it changed
                if (!Home.ChartInfo.LevelsToPlot.ContainsKey(selectedVariable)) Home.ChartInfo.LevelsToPlot.Add(selectedVariable, new List<string>());
            }

            _selectedVariable = selectedVariable;

            listBoxLevels.Items.Clear();

            string[] levelsCleanName = selectedVariable.Levels.Select(l => l.Remove(0, selectedVariable.Name.Length + 1)).ToArray();

            if (levelsCleanName.All(l => int.TryParse(l, out int n)))
            {
                List<int> levels = levelsCleanName.Select(l => int.Parse(l)).OrderBy(n => n).ToList();
                foreach (int level in levels) listBoxLevels.Items.Add(level);
            } else
            {
                List<string> levels = levelsCleanName.OrderBy(l => l).ToList();
                foreach (string level in levels) listBoxLevels.Items.Add(level);
            }

            for (int i = 0; i < listBoxLevels.Items.Count; i++) listBoxLevels.SetSelected(i, true);

            if (NextVariableSelector == null) return;

            foreach (IndependantVariable variable in listBoxVariables.Items)
            {
                if (variable != selectedVariable) NextVariableSelector.AddVariable(variable);
            }
        }

        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isYVar) return;

            List<string> selectedLevels = new List<string>();

            foreach (var level in listBoxLevels.SelectedItems)
            {
                selectedLevels.Add(level.ToString());
            }
            
            Home.ChartInfo.LevelsToPlot[(IndependantVariable)listBoxVariables.SelectedItem] = new List<string>(selectedLevels);
        }
    }
}
