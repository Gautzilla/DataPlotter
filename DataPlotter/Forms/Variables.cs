using DataPlotter.DataPlotterLibrary;
using DataPlotter.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataPlotter.Forms
{
    public partial class Variables : Form
    {
        private Home _home;
        private List<VariableSelector> _variableSelectors;
        public Variables(Home home)
        {
            InitializeComponent();
            _home = home;
            variableSelectorYVar.VariableType = "Y-axis variable";
            variableSelectorXVar.Home = _home;
            variableSelectorYVar.Home = _home;
            variableSelectorXVar.YVarIndex = -1;
            variableSelectorYVar.YVarIndex = 0;
            _variableSelectors = new List<VariableSelector>() { variableSelectorXVar, variableSelectorYVar };
            AddVariableSelectors();
            LinkVariableSelectors();
            PopulateListBoxes();
        }

        private void AddVariableSelectors()
        {
            if (_home.dataManager == null) return;

            for (int i = 0; i < _home.dataManager.Variables.Count - 2; i++)
            {
                VariableSelector newVS = new VariableSelector()
                {
                    VariableType = $"Y-axis variable #{i + 2}",
                    Size = new Size(400, 200),
                    Dock = DockStyle.Top,
                    Home = _home,
                    YVarIndex = i + 1
                    
                };
                this.Controls.Add(newVS);
                _variableSelectors.Add(newVS);

                // Dock ordering
                newVS.SendToBack();
                newVS.BringToFront();
            }            
        }

        private void LinkVariableSelectors()
        {
            for (int i = 0; i < _variableSelectors.Count - 1; i++)
            {
                _variableSelectors[i].NextVariableSelector = _variableSelectors[i + 1];
            }
        }

        private void PopulateListBoxes()
        {
            if (_home.dataManager == null) return;

            foreach (IndependantVariable var in _home.dataManager.Variables)
            {
                variableSelectorXVar.AddVariable(var);
            }

            if (_home.ChartInfo.XVariable == null) return;

            // TODO: There might be a cleaner way to retrieve the variables linked in the dataManager from the ChartInfo serializer
            IndependantVariable XVar = _home.ChartInfo.XVariable;
            _variableSelectors[0].SetSelectedItems(XVar, XVar.Levels.Select(level => XVar.CleanLevel(level)).ToList());

            // TODO: find a more elegant solution here!
            (IndependantVariable variable, List<string> levels)[] levelsToPlot = _home.ChartInfo.LevelsToPlot.OrderBy(tuple => tuple.YVarIndex).Select(tuple => (tuple.variable, tuple.levels.Select(level => tuple.variable.CleanLevel(level)).ToList())).ToArray();
            _home.ChartInfo.LevelsToPlot = new List<(int YVarIndex, IndependantVariable variable, List<string> levels)>();

            for (int i = 1; i <= levelsToPlot.Length; i++)
            {
                Console.WriteLine($"Attempt to select {levelsToPlot[i - 1].variable.Name} levels {String.Join(" - ", levelsToPlot[i - 1].levels)}");
                _variableSelectors[i].SetSelectedItems(levelsToPlot[i-1].variable, levelsToPlot[i-1].levels);
            }
        }
    }
}
