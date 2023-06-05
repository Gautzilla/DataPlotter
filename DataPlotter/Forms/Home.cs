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
    public partial class Home : Form
    {
        private Button currentButton;
        private Color activeButtonColor = Color.FromArgb(246, 186, 111);
        private Color unactiveButtonColor = Color.FromArgb(245, 239, 231);
        
        public Home()
        {
            InitializeComponent();
        }

        private void ChangeActiveForm(Form newForm, object buttonSender)
        {
            SetCurrentButton(buttonSender);

            labelActiveForm.Text = newForm.Text.ToUpper();
            newForm.Dock = DockStyle.Fill;
        }

        private void SetCurrentButton(object buttonSender)
        {
            if (currentButton != null)
            {
                currentButton.ForeColor = unactiveButtonColor;
            }

            currentButton = (Button)buttonSender;
            currentButton.ForeColor = activeButtonColor;
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            ChangeActiveForm(new Set(), sender);
        }

        private void buttonData_Click(object sender, EventArgs e)
        {
            ChangeActiveForm(new Data(), sender);
        }

        private void buttonVariables_Click(object sender, EventArgs e)
        {
            ChangeActiveForm(new Variables(), sender);
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            ChangeActiveForm(new Chart(), sender);
        }
    }
}
