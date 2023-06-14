using DataPlotter.DataPlotterLibrary;
using DataPlotter.DataPlotterUI;
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
        private Form currentForm;
        private Color activeButtonColor = Color.FromArgb(246, 186, 111);
        private Color unactiveButtonColor = Color.FromArgb(245, 239, 231);

        private bool _isDataGathered;

        public bool IsDataGathered
        {
            get { return _isDataGathered; }
            set 
            {
                _isDataGathered = value;
                labelLogoData.ForeColor = _isDataGathered ? Color.FromArgb(74, 169, 108) : Color.FromArgb(245, 92, 71);
            }
        }


        private ChartInfo chartInfo;

        public ChartInfo ChartInfo
        {
            get { return chartInfo; }
            set { chartInfo = value; GatherData(); }
        }


        public DataManager dataManager;
        
        public Home()
        {
            InitializeComponent();
            chartInfo = new ChartInfo();
            ChangeActiveForm(new Set(this), buttonSet);
        }

        public void ChangeActiveForm(Form newForm, object buttonSender)
        {
            SetCurrentButton(buttonSender);

            if (currentForm != null) currentForm.Close();

            currentForm = newForm;

            labelActiveForm.Text = currentForm.Text.ToUpper();
            currentForm.TopLevel = false;
            currentForm.Dock = DockStyle.Fill;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            panelDockingForm.Controls.Add(currentForm);
            currentForm.BringToFront();
            currentForm.Show();
        }

        private void SetCurrentButton(object buttonSender)
        {
            if (!((Button)buttonSender).Parent.Equals(panelMenu)) return;

            if (currentButton != null)
            {
                currentButton.ForeColor = unactiveButtonColor;
            }

            currentButton = (Button)buttonSender;
            currentButton.ForeColor = activeButtonColor;
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            ChangeActiveForm(new Set(this), sender);
        }

        private void buttonData_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet.");
            return;
            //ChangeActiveForm(new Data(), sender);
        }

        private void buttonVariables_Click(object sender, EventArgs e)
        {
            ChangeActiveForm(new Variables(this), sender);
        }

        private void buttonChart_Click(object sender, EventArgs e)
        {
            ChangeActiveForm(new Chart(this), sender);
        }

        public void GatherData()
        {
            if (ChartInfo.InfoFilePath == string.Empty || ChartInfo.DataFilePath == string.Empty) return;

            try
            {
                dataManager = new DataManager(ChartInfo.DataFilePath, ChartInfo.InfoFilePath);
            }
            catch
            {
                MessageBox.Show("The specified data do not match the specified info file.");
                return;
            }

            MessageBox.Show("The data were succesfully gathered.");
            IsDataGathered = true;
        }

        private void buttonPlot_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"levels to plot: \r\n{String.Join("\r\n", ChartInfo.LevelsToPlot.Select(tuple => $"{tuple.variable.Name} ({String.Join(" x ", tuple.levels.Select(l => tuple.variable.CleanLevel(l)))})"))}", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;

            try
            {
                Plot plotForm = new Plot(this);
                plotForm.Show();
            }
            catch
            {
                MessageBox.Show("An error occured.");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!IsDataGathered)
            {
                MessageBox.Show("Please gather data first.");
                return;
            }

            ChartInfo copy = DeepCopier.DeepCopy(ChartInfo);
            copy.SetID();
            PresetManager.WritePreset(copy);
        }
    }
}
