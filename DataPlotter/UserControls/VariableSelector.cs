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

namespace DataPlotter.UserControls
{
    public partial class VariableSelector : UserControl
    {
        public string VariableType
        {
            get { return labelVariableType.Text; }
            set { labelVariableType.Text = value; }
        }
        public VariableSelector NextVariableSelector 
        { 
            get; 
            set; 
        }

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
            listBoxVariables.Items.Clear();
            listBoxLevels.Items.Clear();

            if (NextVariableSelector == null) return;
            NextVariableSelector.Clear();
        }

        private void listBoxVariables_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndependantVariable selectedVariable = listBoxVariables.SelectedItem as IndependantVariable;

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

            NextVariableSelector.Clear();

            foreach (IndependantVariable variable in listBoxVariables.Items)
            {
                if (variable == selectedVariable) continue;

                NextVariableSelector.AddVariable(variable);
            }
        }
    }
}
