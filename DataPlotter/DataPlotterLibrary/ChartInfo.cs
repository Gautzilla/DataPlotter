using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlotter.DataPlotterLibrary
{
    internal class ChartInfo
    {
        private string iD;
        
        public string ID
        {
            get { return iD; }
            set { iD = value; }
        }

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

        public string Name { get => _name; set => _name = value; }
        public (int w, int h) Size { get => _size; set => _size = value; }
        public (float min, float max) XRange { get => _xRange; set => _xRange = value; }
        public (float min, float max) YRange { get => _yRange; set => _yRange = value; }
        public (bool x, bool y) IsAxisLog { get => _IsAxisLog; set => _IsAxisLog = value; }
        public (List<float> x, List<float> y) MajorTicks { get => _majorTicks; set => _majorTicks = value; }
        public (float x, float y) MinorTicksInterval { get => _minorTicksInterval; set => _minorTicksInterval = value; }


        #endregion

        
        public ChartInfo()
        {
            ID = "default";
        }

        public void SetID (string dataFilePath)
        {
            ID = dataFilePath + "_" + String.Join("_", new string[] { XVar, YVar, YVar2, YVar2Level }).TrimEnd('_');
        }
    }
}
