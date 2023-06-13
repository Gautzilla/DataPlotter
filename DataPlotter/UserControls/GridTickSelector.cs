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
using static DataPlotter.UserControls.GridTickSelector;

namespace DataPlotter.UserControls
{
    public partial class GridTickSelector : UserControl
    {
        private Home _home;

        public Home Home
        {
            get { return _home; }
            set { _home = value; }
        }

        private List<float> _ticks;

        public List<float> Ticks
        {
            get { return _ticks; }
            set 
            {
                _ticks = value;
                listBoxTicks.DataSource = Ticks;
            }
        }


        public override string Text
        {
            get { return labelTicks.Text; }
            set { labelTicks.Text = value; }
        }


        public GridTickSelector()
        {
            InitializeComponent();
        }

        private void RefreshListBox()
        {
            listBoxTicks.DataSource = null;
            listBoxTicks.DataSource = _ticks.OrderBy(t => t).ToList();
            Console.WriteLine(String.Join(" - ", Home.ChartInfo.MajorTicks.x));
            Console.WriteLine(String.Join(" - ", Ticks));
        }

        private void buttonAddTick_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxTick.Text, out float tick))
            {
                if (!Ticks.Contains(tick)) Ticks.Add(tick);
            }

            RefreshListBox();
            textBoxTick.Text = string.Empty;
        }

        private void buttonRemoveTick_Click(object sender, EventArgs e)
        {
            if (_home.ChartInfo == null) return;
            if (listBoxTicks.SelectedIndex == -1) return;

            Ticks.RemoveAll(f => listBoxTicks.SelectedItems.OfType<float>().ToList().Contains(f));

            RefreshListBox();
        }

        private void textBoxTick_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space || e.KeyCode == Keys.Add)
            {
                buttonAddTick_Click(sender, e);
            }
        }

        private void listBoxTicks_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Subtract)
            {
                buttonRemoveTick_Click(sender, e);
            }
        }

        public void SetMinorTick(float tickInterval)
        {
            textBoxMinorTicks.Text = tickInterval.ToString();
        }

        private void textBoxMinorTicks_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBoxMinorTicks.Text, out float minorTicks))
            {
                // Not that elegant
                if (Text.Contains("Y-axis"))
                {
                    Home.ChartInfo.MinorTicksInterval = (Home.ChartInfo.MinorTicksInterval.x, minorTicks);
                }
                if (Text.Contains("X-axis"))
                {
                    Home.ChartInfo.MinorTicksInterval = (minorTicks, Home.ChartInfo.MinorTicksInterval.y);
                }
            }
        }
    }
}
