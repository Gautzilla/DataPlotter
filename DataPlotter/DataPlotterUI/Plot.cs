using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataPlotter.DataPlotterLibrary;

namespace DataPlotter.DataPlotterUI
{
    public partial class Plot : Form
    {
        internal Plot(DataManager data, ChartInfo chartInfo)
        {
            InitializeComponent();
        }

        private void Plot_Load(object sender, EventArgs e)
        {
            chart.Dock = DockStyle.Fill;
        }
    }
}
