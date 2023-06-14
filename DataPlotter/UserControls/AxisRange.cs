using DataPlotter.Forms;
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
    public partial class AxisRange : UserControl
    {
        private bool _isXAxis;

        private string _axis;

        public string Axis
        {
            get { return _axis; }
            set 
            { 
                _axis = value;

                if (_axis == null) return;
                _isXAxis = _axis.Contains("X-axis");
                labelAxis.Text = _axis;
            }
        }

        private Home _home;

        public Home Home
        {
            get { return _home; }
            set { _home = value; }
        }


        public AxisRange()
        {
            InitializeComponent();
        }

        public void RefreshDisplay()
        {
            if (_home.ChartInfo.XVariable == null) return;

            textBoxMin.Text = _isXAxis ? Home.ChartInfo.XRange.min.ToString() : Home.ChartInfo.YRange.min.ToString();
            textBoxMax.Text = _isXAxis ? Home.ChartInfo.XRange.max.ToString() : Home.ChartInfo.YRange.max.ToString();
            checkBoxLogarithmic.Checked = _isXAxis ? _home.ChartInfo.XVariable.IsLog : _home.dataManager.DepVariable.IsLog;
        }

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {
            if (Home.ChartInfo == null) return;

            if (float.TryParse(textBoxMin.Text, out float min))
            {
                if (_isXAxis) Home.ChartInfo.XRange = (min, Home.ChartInfo.XRange.max);
                else Home.ChartInfo.YRange = (min, Home.ChartInfo.YRange.max);
            }

            RefreshDisplay();
        }

        private void textBoxMax_TextChanged(object sender, EventArgs e)
        {
            if (Home.ChartInfo == null) return;

            if (float.TryParse(textBoxMax.Text, out float max))
            {
                if (_isXAxis) Home.ChartInfo.XRange = (Home.ChartInfo.XRange.min, max);
                else Home.ChartInfo.YRange = (Home.ChartInfo.YRange.min, max);
            }

            RefreshDisplay();
        }
    }
}
