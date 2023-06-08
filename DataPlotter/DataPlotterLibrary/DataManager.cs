using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;

namespace DataPlotter.DataPlotterLibrary
{
    public class DataManager
    {
        private static List<IndependantVariable> _variables;
        private static string[] _variablesOrdering;
        private static DependantVariable _dependantVariable;

        public List<IndependantVariable> Variables
        {
            get { return _variables; }
            private set { _variables = value; }
        }

        public DependantVariable DepVariable 
        { 
            get => _dependantVariable; 
            set => _dependantVariable = value; 
        }

        private List<(List<string> var, List<float> val)> _data; // Stores data as a tuple: list of the levels of the variables as Item1 and list of subjects values as Item2

        /// <summary>
        /// Parse a .csv file.
        /// </summary>
        /// <param name="dataFilePath">Absolute path of the .csv dataFile path</param>
        /// <param name="infoFilePath">Absolute path of the .txt infoFile path</param>
        public DataManager(string dataFilePath, string infoFilePath)
        {
            Variables = new List<IndependantVariable>();
            DepVariable = new DependantVariable("dependant variable", true);
            ParseDependantVariable(infoFilePath);
            SortFactors(infoFilePath);
            SortData(dataFilePath);
        }

        /// <summary>
        /// Parse all files containing the participants' results and combine them in a dataFile.
        /// </summary>
        /// <param name="resultsFolderPath">Absolute path of the folder containing the raw result files</param>
        /// <param name="infoFilePath">Absolute path of the .txt infoFile path</param>
        public DataManager(string resultsFolderPath, string infoFilePath, string dataFileName, int valuesToSkip)
        {
            Variables = new List<IndependantVariable>();
            DepVariable = new DependantVariable("dependant variable", true);

            ParseDependantVariable(infoFilePath);
            SortFactors(infoFilePath);
            GatherData(resultsFolderPath, valuesToSkip);
            WriteDataFile(dataFileName);
        }

        private void ParseDependantVariable(string path)
        {
            string[] fields = File.ReadAllLines(path).First().Split(';').Select(s => s.Trim()).ToArray();

            _dependantVariable.Name = fields[0];
            _dependantVariable.IsNum = fields[1] != "qualitative";
            _dependantVariable.IsLog = fields[1] == "log";
            _dependantVariable.Unit = fields.Length > 2 ? fields[2] : string.Empty;
        }

        private void SortFactors(string path)
        {
            var lines = File.ReadAllLines(path).Skip(1);
            _variablesOrdering = lines.Select(l => l.Split(';').First().Trim()).ToArray();

            foreach (string line in lines)
            {
                string[] fields = line.Split(';').Select(s => s.Trim()).ToArray();
                string name = fields[0];
                bool isNum = fields[1] != "qualitative";
                bool isLog = fields[1] == "log";
                string[] levels = fields[2].Split(',').Select(l => name + "_" + l.Trim()).ToArray();
                string unit = fields.Length > 3 ? fields[3] : string.Empty;

                if (!isNum) Variables.Add(new IndependantVariable(name, levels, isNum));
                else Variables.Add(new IndependantVariable(name, levels, isNum, isLog, unit));
            }
        }

        private void GatherData(string path, int valuesToSkip)
        {
            _data = new List<(List<string> var, List<float> val)>();

            foreach (string file in Directory.EnumerateFiles(path))
            {
                if (file.EndsWith(".gitignore")) continue;

                ExtractData(File.ReadAllLines(file), valuesToSkip);
            }
        }

        /// <summary>
        /// Extract the data corresponding to each variable combination (each line).
        /// </summary>
        /// <param name="file">File containing a participant's results.</param>
        private void ExtractData(string[] file, int valuesToSkip)
        {
            file = file.Where(line => line != string.Empty).Select(line => line.TrimEnd(';')).ToArray();

            foreach (string line in file)
            {
                List<string> var = line.Split(',')[1].Split(' ').Where(level => _variables.Any(variable => variable.Levels.Contains(level))).ToList();
                // TODO: Add option to skip data points (e.g. adaptive curve) or to treat each datapoint differently
                float val = line.Split(',').Last().Trim().Split(' ').Skip(valuesToSkip).Select(v => v == string.Empty? 1f/3 : float.Parse(v)).Average();

                if (_data.Any(v => Enumerable.SequenceEqual(v.var, var))) _data.Single(v => Enumerable.SequenceEqual(v.var, var)).val.Add(val);
                else _data.Add((var, new List<float>() { val }));
            }
        }

        private void WriteDataFile(string fileName)
        {
            int varCombinations = _variables.Select(v => v.Levels.Length).Aggregate((a, b) => a * b);

            float[,] results = new float[varCombinations,_data.Max(d => d.val.Count)];

            for (int varComb = 0; varComb < varCombinations; varComb++)
            {
                List<string> variableLevels = _variablesOrdering
                    .Select(v => _variables.FirstOrDefault(var => var.Name == v).Levels[varComb / LevelsAfter(v) % _variables.FirstOrDefault(var => var.Name == v).Levels.Length])
                    .ToList();

                for (int participant = 0; participant < results.GetLength(1); participant++)
                {
                    results[varComb, participant] = _data.Single(d => variableLevels.All(level => d.var.Contains(level))).val[participant];
                }
            }

            float[][] jaggedResults = new float[results.GetLength(1)][];

            for (int participant = 0; participant < jaggedResults.Length; participant++)
            {
                jaggedResults[participant] = new float[results.GetLength(0)];
                for (int varComb = 0; varComb < results.GetLength(0); varComb++)
                {
                    jaggedResults[participant][varComb] = results[varComb, participant];
                }
            }

            File.WriteAllText(fileName, String.Join("\r\n", jaggedResults.Select(jR => String.Join(",", jR))));
        }

        private void SortData(string path)
        {
            var lines = File.ReadAllLines(path);

            _data = new List<(List<string> var, List<float> val)>();

            int varCombinations = _variables.Select(v => v.Levels.Length).Aggregate((a, b) => a * b);

            for (int varComb = 0; varComb < varCombinations; varComb++)
            {
                List<string> variableLevels = _variablesOrdering
                    .Select(v => _variables.FirstOrDefault(var => var.Name == v).Levels[varComb / LevelsAfter(v) % _variables.FirstOrDefault(var => var.Name == v).Levels.Length])
                    .ToList();

                _data.Add((variableLevels, lines.Select(l => float.Parse(l.Split(',').ToArray()[varComb])).ToList()));
            }
        }

        /// <summary>
        /// Access the amount of combinations of factors that follow a given variable.
        /// </summary>
        /// <param name="variable"> Name of the variable as stored in _variablesOrdering.</param>
        /// <returns>The number of variable levels combinations for the variable following the one passed as input.</returns>
        private static int LevelsAfter(string variable)
        {
            return _variablesOrdering.Last() == variable ? 1 : _variablesOrdering.Skip(Array.IndexOf(_variablesOrdering, variable) + 1).Select(nextV => _variables.FirstOrDefault(v => v.Name == nextV).Levels.Length).Aggregate((a, b) => a * b);
        }

        /// <summary>
        /// Returns all the values matching a given set of levels.
        /// </summary>
        /// <param name="levels">The varaibles' levels at which the values are needed.</param>
        /// <returns>The raw data (a list of same size as the subjects sample) matching the specified variable levels</returns>
        private List<float> GetData(List<string> levels) => _data.Where(dat => levels.Where(l => l != null).All(v => dat.var.Contains(v))).SelectMany(d => d.val).ToList();

        /// <summary>
        /// Returns the levels of a given variable.
        /// </summary>
        /// <param name="variable">Name of the variable.</param>
        /// <returns>List of the variable's levels.</returns>
        public List<string> GetLevels(string variable)
        {
            return variable == string.Empty ? new List<string>() { null } : _variables.Single(v => v.Name == variable).Levels.ToList();
        }

        /// <summary>
        /// Compute the mean points along levels of a given effect or interaction.
        /// </summary>
        /// <param name="variableY">The variable which levels are plotted as separate lines (null if simple effect).</param>
        /// <param name="variableX">The variable to be plotted on the x axis.</param>
        /// <param name="logY">True is the Y-axis is logarithmic, false if it's linear.</param>
        /// <param name="variableY2">Additional levels that have to be taken into account, for plotting higher-than-2-factors interactions.</param>
        /// <returns>A list of lines, which contains the coordinates of the mean points accross subjects for a given interaction.</returns>
        public List<List<(string x, float y)>> MeanLine(string variableX, bool logY, string variableY, string variableY2)
        {
            if (logY) return GetLevels(variableY).Select(level => GetLevels(variableX).Select(x => (x, (float)Math.Pow(10, GetData(new List<string>() { x, level }.Concat(variableY2 == string.Empty ? new List<string>() : new List<string>() { variableY2 }).ToList()).Select(y => (float)Math.Log10(y)).Average()))).ToList()).ToList();
            return GetLevels(variableY).Select(level => GetLevels(variableX).Select(x => (x, GetData(new List<string>() { x, level }.Concat(variableY2 == string.Empty ? new List<string>() : new List<string>() { variableY2 }).ToList()).Average())).ToList()).ToList();
        }

        /// <summary>
        /// Compute the confidence intervals along levels of a given effect or interaction.
        /// </summary>
        /// <param name="variableY">The variable which levels are plotted as separate lines (null if simple effect).</param>
        /// <param name="variableX">The variable to be plotted on the x axis.</param>
        ///  <param name="restrictionLevels">Additional levels that have to be taken into account, for plotting higher-than-2-factors interactions.</param>
        /// <returns>A list of lists of error bars, which contains the coordinates of the low and high point of the intervals.</returns>
        public List<List<(string x, (float l, float h) y)>> Std(string variableX, bool logY, string variableY = null, string variableY2 = null)
        {
            return GetLevels(variableY).Select(level => GetLevels(variableX).Select(x => (x, ConfidenceInterval(GetData(new List<string>() { x, level }.Concat(variableY2 == string.Empty ? new List<string>() : new List<string>() { variableY2 }).ToList()), logY))).ToList()).ToList();
        }

        /// <summary>
        /// Computes the 95% confidence interval of a given series.
        /// </summary>
        /// <param name="dat">Lis of floats that form the series.</param>
        /// <returns>The low and high ends of the 95% confidence interval.</returns>
        private (float l, float h) ConfidenceInterval(List<float> dat, bool logY)
        {
            if (logY) dat = dat.Select(d => (float)Math.Log10(d)).ToList();

            float mean = dat.Average();
            double sd = Math.Sqrt(dat.Select(d => Math.Pow(d - mean, 2) / dat.Count).Sum());
            float standardError = (float)(1.96 * sd / Math.Sqrt(dat.Count));

            if (logY) return ((float)Math.Pow(10, mean - standardError), (float)Math.Pow(10, mean + standardError));
            return (mean - standardError, mean + standardError);
        }

        /// <summary>
        /// Computes the power fitting functions of the lines.
        /// </summary>
        /// <param name="variableY">The variable which levels are plotted as separate lines (null if simple effect).</param>
        /// <param name="variableX">The variable to be plotted on the x axis.</param>
        /// <param name="logY">True is the Y-axis is logarithmic, false if it's linear.</param>
        /// <param name="variableY2">Additional levels that have to be taken into account, for plotting higher-than-2-factors interactions.</param>
        /// <returns>A list of functions depicting the y=k*x^b power functions.</returns>
        /// <exception cref="InvalidDataException"></exception>
        public List<Func<double, double>> Regression (string variableX, bool logY, string variableY, string variableY2)
        {
            if (!_variables.Single(v => v.Name == variableX).IsNum) throw new InvalidDataException("The X variable is qualitative: regression curves can't be computed.");

            List<List<(string x, float y)>> meanLine = MeanLine(variableX, logY, variableY, variableY2);

            if (logY)
                return meanLine
                .Select(ml => ml.Select(point => (double.Parse(point.x), (double)point.y)))
                .Select(ml => Fit.PowerFunc(ml.Select(m => m.Item1).ToArray(), ml.Select(m => m.Item2).ToArray()))
                .ToList();

            return meanLine
                .Select(ml => ml.Select(point => (double.Parse(point.x), (double)point.y)))
                .Select(ml => Fit.LineFunc(ml.Select(m => m.Item1).ToArray(), ml.Select(m => m.Item2).ToArray()))
                .ToList();
        }
    }
}
