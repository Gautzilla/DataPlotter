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
using Newtonsoft.Json;
using System.IO;
using System.Text.RegularExpressions;

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
            _serializer = new JsonSerializer();
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
            listViewChartInfos.Columns.Add("X var");
            listViewChartInfos.Columns.Add("Y Var");
            listViewChartInfos.Columns.Add("Y Var2");

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
            item.Text = Regex.Match(chartInfo.ID, @"[^\\]*\.csv").Value;
            item.SubItems.Add(chartInfo.Name);
            item.SubItems.Add(chartInfo.XVar);
            item.SubItems.Add(chartInfo.YVar);
            item.SubItems.Add(chartInfo.YVar2);
            item.Tag = chartInfo;

            return item;
        }

        private void buttonLoadPreset_Click(object sender, EventArgs e)
        {
            if (listViewChartInfos.SelectedItems.Count == 0) return;

            _home.ChartInfo = (ChartInfo)listViewChartInfos.SelectedItems[0].Tag;

            MessageBox.Show("The selected data set was successfully loaded.");
        }
    }
}
