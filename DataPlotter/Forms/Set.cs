using DataPlotter.DataPlotterLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DataPlotter.Forms
{
    public partial class Set : Form
    {
        private Home _home;

        public Set(Home home)
        {
            InitializeComponent();
            _home = home;
            RefreshControls();
        }

        private void RefreshControls()
        {
            checkBoxDataFileLoaded.Checked = _home.ChartInfo.DataFilePath != string.Empty;
            checkBoxInfoFileLoaded.Checked = _home.ChartInfo.InfoFilePath != string.Empty;

            buttonGatherData.Enabled = checkBoxDataFileLoaded.Checked && checkBoxInfoFileLoaded.Checked;
        }

        private void buttonBrowseInfofile_Click(object sender, EventArgs e)
        {
            _home.ChartInfo.InfoFilePath = BrowseFile(openFileDialogInfoFile);
            RefreshControls();
        }

        private void buttonBrowseDatafile_Click(object sender, EventArgs e)
        {
            _home.ChartInfo.DataFilePath  = BrowseFile(openFileDialogDataFile);
            RefreshControls();
        }

        private string BrowseFile(OpenFileDialog openFileDialog)
        {
            openFileDialog.ShowDialog();
            string filePath = openFileDialog.FileName;

            if (!File.Exists(filePath)) return string.Empty;

            return filePath;
        }

        private void buttonGatherData_Click(object sender, EventArgs e)
        {
            if (_home.ChartInfo.InfoFilePath == string.Empty || _home.ChartInfo.DataFilePath == string.Empty) return;

            try
            {
                _home.dataManager = new DataManager(_home.ChartInfo.DataFilePath, _home.ChartInfo.InfoFilePath);
            }
            catch
            {
                MessageBox.Show("The specified data do not match the specified info file.");
                return;
            }

            MessageBox.Show("The data were succesfully gathered.");
        }

        private void buttonRecallPreset_Click(object sender, EventArgs e)
        {
            _home.ChangeActiveForm(new SetLoading(_home), sender);
        }
    }
}
