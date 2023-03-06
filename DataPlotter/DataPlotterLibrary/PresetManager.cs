using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlotter.DataPlotterLibrary
{
    internal static class PresetManager
    {
        private static readonly string _documentsPath;
        private static readonly string _filePath;
        static PresetManager()
        {
            _documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            _filePath = _documentsPath + @"\DataPlotter\presets.txt";

            if (File.Exists(_filePath))
            {

            }
            else
            {
                Directory.CreateDirectory(_documentsPath + @"\DataPlotter");
                File.Create(_filePath);
            }
        }
        public static List<ChartInfo> LoadPresets()
        {
            List<ChartInfo> charts = new List<ChartInfo>();
            return charts;
        }

        public static void UpdatePresets(ChartInfo chart, string dataFile)
        {
            string preset = CreatePreset(chart, dataFile);
            string chartId = string.Join("@", preset.Split("@".ToCharArray()).Take(2));

            List<string> presets = File.ReadAllLines(_filePath).ToList();
            presets.RemoveAll(p => p.Contains(chartId));
            presets.Add(preset);

            File.WriteAllLines(_filePath, presets);
        }

        private static string CreatePreset(ChartInfo chart, string dataFile)
        {
            string dF = "dataFile: " + dataFile;
            string vars = "variables: " + WriteVariables(chart);
            string name = "name: " + chart.Name;
            string width = "width: " + chart.Size.w;
            string height = "height: " + chart.Size.h;
            string xMajorTicks = "xMajorTicks: " + string.Join("&", chart.MajorTicks.x);
            string xMinTick = "xMinTick: " + chart.MinorTicksInterval.x;
            string yMajorTicks = "yMajorTicks: " + string.Join("&", chart.MajorTicks.y);
            string yMinTick = "yMinTick: " + chart.MinorTicksInterval.y;
            string depVar = "depVar: " + chart.DepVarName;
            string xMin = "xMin: " + chart.XRange.min;
            string xMax = "xMax: " + chart.XRange.max;
            string yMin = "yMin: " + chart.YRange.min;
            string yMax = "yMax: " + chart.YRange.max;
            string xLog = "xLog; " + chart.IsAxisLog.x;
            string yLog = "yLog; " + chart.IsAxisLog.y;
            string regressionLine = "regressionLine; " + chart.Regression;
            string samePlotAllLevels = "samePlot; " + chart.TripleInteractionSamePlot;

            return string.Join("@", new string[] { dF, vars, name, width, height, xMajorTicks, xMinTick, yMajorTicks, yMinTick, depVar, xMin, xMax, yMin, yMax, xLog, yLog, regressionLine, samePlotAllLevels});
        }
        private static string WriteVariables(ChartInfo chart) => String.Join("*", new string[] { chart.XVar, chart.YVar, chart.YVar2, chart.YVar2Level }).TrimEnd('*');

        public static bool DoesPresetExists(ChartInfo chart, string dataFile)
        {
            string chartId = GetChartId(chart, dataFile);

            return File.ReadAllLines(_filePath).Any(l => l.Contains(chartId));
        }

        public static ChartInfo LoadPreset(ChartInfo chart, string dataFile)
        {
            string chartId = GetChartId(chart, dataFile);

            return new ChartInfo(File.ReadAllLines(_filePath).First(l => l.Contains(chartId)));
        }

        private static string GetChartId(ChartInfo chart, string dataFile) => "dataFile: " + dataFile + "@" + "variables: " + WriteVariables(chart);
    }
}
