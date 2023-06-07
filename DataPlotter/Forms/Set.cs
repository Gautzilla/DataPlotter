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
        private string _infoFilePath;
        private string _dataFilePath;

        private Home _home;

        private (bool infoFile, bool dataFile) _isFilepathSpecified = (false, false);
        public Set(Home home)
        {
            InitializeComponent();
            RefreshControls();
            _home = home;
        }

        private void RefreshControls()
        {
            checkBoxDataFileLoaded.Checked = _isFilepathSpecified.dataFile;
            checkBoxInfoFileLoaded.Checked = _isFilepathSpecified.infoFile;

            buttonGatherData.Enabled = _isFilepathSpecified.dataFile && _isFilepathSpecified.infoFile;
        }

        private void buttonBrowseInfofile_Click(object sender, EventArgs e)
        {
            (_infoFilePath, _isFilepathSpecified.infoFile) = BrowseFile(openFileDialogInfoFile);
            RefreshControls();
        }

        private void buttonBrowseDatafile_Click(object sender, EventArgs e)
        {
            (_dataFilePath, _isFilepathSpecified.dataFile)  = BrowseFile(openFileDialogDataFile);
            RefreshControls();
        }

        private (string, bool) BrowseFile(OpenFileDialog openFileDialog)
        {
            openFileDialog.ShowDialog();
            string filePath = openFileDialog.FileName;

            if (!File.Exists(filePath)) return (string.Empty, false);

            return (filePath, true);
        }

        private void buttonGatherData_Click(object sender, EventArgs e)
        {
            if (!(_isFilepathSpecified.infoFile && _isFilepathSpecified.dataFile)) return;

            try
            {
                _home.dataManager = new DataManager(_dataFilePath, _infoFilePath);
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
