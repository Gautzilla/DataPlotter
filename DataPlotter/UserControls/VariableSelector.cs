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

        public VariableSelector()
        {
            InitializeComponent();
        }
    }
}
