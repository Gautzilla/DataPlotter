using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataPlotter
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_dataFilePath_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string dataFilePath = openFileDialog1.FileName;
            string dataFileName = dataFilePath.Split('\\').Last();
            label_dataPath.Text = dataFileName;
        }

        private void btn_InfoPath_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            string infoFilePath = openFileDialog2.FileName;
            string infoFileName = infoFilePath.Split('\\').Last();
            label_infoPath.Text = infoFileName;
        }
    }
}
