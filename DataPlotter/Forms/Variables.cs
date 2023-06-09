﻿using DataPlotter.DataPlotterLibrary;
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
        public Variables(Home home)
        {
            InitializeComponent();
            _home = home;
            variableSelectorYVar.VariableType = "Y-axis variable";

            PopulateListBoxes();
        }

        private void PopulateListBoxes()
        {
            if (_home.dataManager == null) return;

            foreach (IndependantVariable var in _home.dataManager.Variables)
            {
                variableSelectorXVar.AddVariable(var);
            }
        }
    }
}
