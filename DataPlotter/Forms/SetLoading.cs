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
    public partial class SetLoading : Form
    {
        private Home _home;
        public SetLoading(Home home)
        {
            InitializeComponent();
            _home = home;
        }
    }
}
