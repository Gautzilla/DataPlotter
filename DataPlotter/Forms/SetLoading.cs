using DataPlotter.DataPlotterLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DataPlotter.Forms
{
    public partial class SetLoading : Form
    {
        private Home _home;

        private List<ChartInfo> _sets;
        private JsonSerializer _serializer;

        private string _setsFilePath;

        public SetLoading(Home home)
        {
            InitializeComponent();
            _home = home;
            _sets = new List<ChartInfo>();
            _serializer = new JsonSerializer() { Formatting = Formatting.Indented };
            CreateSetsFile();
            GatherSavedSets();
            CreateList();
        }

        private void CreateSetsFile()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            _setsFilePath = documentsPath + @"\DataPlotter\presets.json";

            if (File.Exists(_setsFilePath)) return;

            Directory.CreateDirectory(documentsPath + @"\DataPlotter");
            using (FileStream fs = File.Create(_setsFilePath)) { }
        }

        private void GatherSavedSets()
        {
            using (var streamReader = new StreamReader(_setsFilePath))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                _sets = _serializer.Deserialize<List<ChartInfo>>(jsonReader) ?? new List<ChartInfo>();
            }
        }

        private void CreateList()
        {
            listViewChartInfos.View = View.Details;
            listViewChartInfos.Columns.Add("Data file");
            listViewChartInfos.Columns.Add("Name");
            listViewChartInfos.Columns.Add("Dependant variable");

            RefreshListItems();
        }

        private void RefreshListItems()
        {
            listViewChartInfos.Items.Clear();

            foreach (var chartInfo in _sets)
            {
                listViewChartInfos.Items.Add(CreateListItem(chartInfo));
            }

            for (int i = 0; i < listViewChartInfos.Columns.Count; i++)
            {
                listViewChartInfos.AutoResizeColumn(i, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private ListViewItem CreateListItem(ChartInfo chartInfo)
        {
            ListViewItem item = new ListViewItem();
            item.Text = Regex.Match(chartInfo.DataFilePath, @"[^\\]*\.csv").Value;
            item.SubItems.Add(chartInfo.Name);
            item.SubItems.Add(chartInfo.DependantVariable.Name);
            item.Tag = chartInfo;

            return item;
        }

        public void WriteSet(ChartInfo chartInfo)
        {
            _sets.RemoveAll(cI => cI.Name == chartInfo.Name);
            _sets.Add(chartInfo);
            ExportPresets();
        }

        private void ExportPresets()
        {
            using (var streamWriter = new StreamWriter(_setsFilePath))
            using (var jsonWriter = new JsonTextWriter(streamWriter))
            {
                _serializer.Serialize(jsonWriter, _sets);
            }
        }

        private void buttonLoadPreset_Click(object sender, EventArgs e)
        {
            if (listViewChartInfos.SelectedItems.Count == 0) return;

            _home.ChartInfo = (ChartInfo)listViewChartInfos.SelectedItems[0].Tag;

            MessageBox.Show("The selected data set was successfully loaded.");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewChartInfos.SelectedItems == null) return;

            if (MessageBox.Show("Delete this set?", "WARNING", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;

            ListViewItem selected = listViewChartInfos.SelectedItems[0];
            ChartInfo selectedChartInfo = selected.Tag as ChartInfo;

            _sets.Remove(selectedChartInfo);
            ExportPresets();
            RefreshListItems();
        }
    }
}
