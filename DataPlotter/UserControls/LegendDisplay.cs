using DataPlotter.DataPlotterLibrary;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace DataPlotter.UserControls
{
    public partial class LegendDisplay : UserControl
    {
        private Home _home;

        public Home Home
        {
            get { return _home; }
            set 
            { 
                _home = value;
                RefreshButtonsColor();
            }
        }

        private readonly Color _unlitColor = Color.FromArgb(46, 63, 60);
        private readonly Color _litColor = Color.FromArgb(246, 186, 111);

        public LegendDisplay()
        {
            InitializeComponent();
        }

        public void RefreshButtonsColor()
        {
            if (Home == null) return;

            switch (Home.ChartInfo.LegendDocking)
            {
                case Docking.Top:
                    buttonLegendTopLeft.BackColor = _unlitColor;
                    buttonLegendTopRight.BackColor = _unlitColor;
                    buttonLegendBottomLeft.BackColor = _unlitColor;
                    buttonLegendBottomRight.BackColor = _litColor;
                    break;
                case Docking.Right:
                    buttonLegendTopLeft.BackColor = _unlitColor;
                    buttonLegendTopRight.BackColor = _litColor;
                    buttonLegendBottomLeft.BackColor = _unlitColor;
                    buttonLegendBottomRight.BackColor = _unlitColor;
                    break;
                case Docking.Bottom:
                    buttonLegendTopLeft.BackColor = _unlitColor;
                    buttonLegendTopRight.BackColor = _unlitColor;
                    buttonLegendBottomLeft.BackColor = _litColor;
                    buttonLegendBottomRight.BackColor = _unlitColor;
                    break;
                case Docking.Left:
                    buttonLegendTopLeft.BackColor = _litColor;
                    buttonLegendTopRight.BackColor = _unlitColor;
                    buttonLegendBottomLeft.BackColor = _unlitColor;
                    buttonLegendBottomRight.BackColor = _unlitColor;
                    break;
                default:
                    buttonLegendTopLeft.BackColor = _unlitColor;
                    buttonLegendTopRight.BackColor = _unlitColor;
                    buttonLegendBottomLeft.BackColor = _unlitColor;
                    buttonLegendBottomRight.BackColor = _unlitColor;
                    break;
            }
        }

        private void SetLegendDocking(Docking docking)
        {
            if (Home.ChartInfo == null) return;

            Home.ChartInfo.LegendDocking = docking;
            RefreshButtonsColor();
        }

        private void buttonLegendTopLeft_Click(object sender, EventArgs e)
        {
            SetLegendDocking(Docking.Left);
        }

        private void buttonLegendTopRight_Click(object sender, EventArgs e)
        {
            SetLegendDocking(Docking.Right);
        }

        private void buttonLegendBottomLeft_Click(object sender, EventArgs e)
        {
            SetLegendDocking(Docking.Bottom);
        }

        private void buttonLegendBottomRight_Click(object sender, EventArgs e)
        {
            SetLegendDocking(Docking.Top);
        }
    }
}
