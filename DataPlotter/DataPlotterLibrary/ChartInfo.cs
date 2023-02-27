using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlotter.DataPlotterLibrary
{
    internal class ChartInfo
    {
        #region Variables Settings

        private string _xVar = string.Empty;
        private string _yVar = string.Empty;
        private string _yVar2 = string.Empty;
        private string _yVar2Level = string.Empty;
        private string _depVarName = string.Empty;
        private bool _isDepVarNum = true;
        private bool _isDepVarLog = true;

        public bool IsDepVarNum { get => _isDepVarNum; set => _isDepVarNum = value; }
        public bool IsDepVarLog { get => _isDepVarLog; set => _isDepVarLog = value; }
        public string DepVarName { get => _depVarName; set => _depVarName = value; }
        public string XVar { get => _xVar; set => _xVar = value; }
        public string YVar { get => _yVar; set => _yVar = value; }
        public string YVar2 { get => _yVar2; set => _yVar2 = value; }
        public string YVar2Level { get => _yVar2Level; set => _yVar2Level = value; }

        #endregion

        #region Display Settings

        private string _name = string.Empty;
        private (int w, int h) _size = (0, 0);
        private (float min, float max) _xRange = (0f, 0f);
        private (float min, float max) _yRange = (0f, 0f);
        private (bool x, bool y) _IsAxisLog;
        private (List<float> x, List<float> y) _majorTicks = (new List<float>(), new List<float>());
        private (float x, float y) _minorTicksInterval = (0f, 0f);
        private bool _regression;       


        public string Name { get => _name; set => _name = value; }
        public (int w, int h) Size { get => _size; set => _size = value; }
        public (float min, float max) XRange { get => _xRange; set => _xRange = value; }
        public (float min, float max) YRange { get => _yRange; set => _yRange = value; }
        public (bool x, bool y) IsAxisLog { get => _IsAxisLog; set => _IsAxisLog = value; }
        public (List<float> x, List<float> y) MajorTicks { get => _majorTicks; set => _majorTicks = value; }
        public (float x, float y) MinorTicksInterval { get => _minorTicksInterval; set => _minorTicksInterval = value; }
        public bool Regression { get => _regression;  set => _regression = value;  }

        #endregion

        public ChartInfo()
        {

        }

        public ChartInfo(string preset)
        {
            string[] param = preset.Split('@').ToArray();

            string[] variables = param.Single(s => s.StartsWith("variables:")).Remove(0, "variables: ".Length).Split('*');
            _xVar = variables[0];
            _yVar = variables.Length > 1 ? variables[1] : string.Empty;
            _yVar2 = variables.Length > 2 ? variables[2] : string.Empty;
            _yVar2Level = variables.Length > 3 ? variables[3] : string.Empty;

            _name = param[2].Split(' ').Last();

            int width = int.Parse(param[3].Split(' ').Last());
            int height = int.Parse(param[4].Split(' ').Last());
            _size = (width, height);

            _majorTicks.x = param[5].Split(' ').Last().Length > 0 ? param[5].Split(' ').Last().Split('&').Select(t => float.Parse(t)).ToList() : new List<float>();

            _minorTicksInterval.x = param[6].Split(' ').Last().Length > 0 ? float.Parse(param[6].Split(' ').Last()) : 1;

            _majorTicks.y = param[7].Split(' ').Last().Length > 0 ? param[7].Split(' ').Last().Split('&').Select(t => float.Parse(t)).ToList() : new List<float>();
            _minorTicksInterval.y = param[8].Split(' ').Last().Length > 0 ? float.Parse(param[8].Split(' ').Last()) : 1;

            _depVarName = param[9].Split(' ').Last();

            float xMin = float.Parse(param[10].Split(' ').Last());
            float xMax = float.Parse(param[11].Split(' ').Last());
            _xRange = (xMin, xMax);

            float yMin = float.Parse(param[12].Split(' ').Last());
            float yMax = float.Parse(param[13].Split(' ').Last());
            _yRange = (yMin, yMax);

            _IsAxisLog.x = param[14].Split(' ').Last() == "True";
            _IsAxisLog.y = param[15].Split(' ').Last() == "True";
        }
        
    }
}
