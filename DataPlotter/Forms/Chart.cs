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
    public partial class Chart : Form
    {
        private Home _home;
        public Chart(Home home)
        {
            InitializeComponent();
            _home = home;
            RefreshDisplay();
        }

        private void RefreshDisplay()
        {
            if (_home.ChartInfo == null) return;

            textBoxChartName.Text = _home.ChartInfo.Name;
        }

        private void textBoxChartName_TextChanged(object sender, EventArgs e)
        {
            if (_home.ChartInfo == null) return;

            _home.ChartInfo.Name = textBoxChartName.Text;
        }
    }
}
