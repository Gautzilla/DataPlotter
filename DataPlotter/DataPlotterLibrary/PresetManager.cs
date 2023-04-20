using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace DataPlotter.DataPlotterLibrary
{
    internal static class PresetManager
    {
        private static List<ChartInfo> _presets;
        private static JsonSerializer _serializer;

        private static string _presetsFilePath;

        static PresetManager()
        {
            _serializer = new JsonSerializer() { Formatting = Formatting.Indented };
            CreatePresetsFile();
            ImportPresets();
        }

        private static void CreatePresetsFile()
        {
            string _documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            _presetsFilePath = _documentsPath + @"\DataPlotter\presets.json";

            if (File.Exists(_presetsFilePath))
            {

            }
            else
            {
                Directory.CreateDirectory(_documentsPath + @"\DataPlotter");
                using (FileStream fs = File.Create(_presetsFilePath))
                {

                }
            }
        }
        

        public static void WritePreset(ChartInfo chartInfo)
        {
            Console.WriteLine(chartInfo.ID);
            _presets.RemoveAll(cI => cI.ID == chartInfo.ID);
            _presets.Add(chartInfo);
            ExportPresets();
        }

        public static ChartInfo LoadPreset(ChartInfo chartInfo)
        {
            Console.WriteLine(chartInfo.ID);
            return _presets.SingleOrDefault(cI => cI.ID == chartInfo.ID) ?? chartInfo;
        }

        private static void ImportPresets()
        {
            using (var streamReader = new StreamReader(_presetsFilePath))
            using (var jsonReader = new JsonTextReader(streamReader))
            {
                _presets = _serializer.Deserialize<List<ChartInfo>>(jsonReader) ?? new List<ChartInfo>();
            }
        }

        private static void ExportPresets()
        {
            using (var streamWriter = new StreamWriter(_presetsFilePath))
            using (var jsonWriter = new JsonTextWriter(streamWriter))
            {
                _serializer.Serialize(jsonWriter, _presets);
            }
        }
    }
}
