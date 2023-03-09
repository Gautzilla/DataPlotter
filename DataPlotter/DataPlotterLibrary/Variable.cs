using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlotter.DataPlotterLibrary
{
    internal class Variable
    {
        private string name;        
        private bool isNum;
        private bool isLog;
        private string unit;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool IsNum
        {
            get { return isNum; }
            set { isNum = value; }
        }

        public bool IsLog
        {
            get { return isLog; }
            set { isLog = value; }
        }

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
    }

    internal class IndependantVariable : Variable
    {
        private string[] levels;
        public string[] Levels
        {
            get { return levels; }
            private set { levels = value; }
        }

        public IndependantVariable(string name, string[] levels, bool isNum)
        {
            Name = name;
            IsNum = isNum;
            Levels = levels;
        }

        public IndependantVariable(string name, string[] levels, bool isNum, bool isLog, string unit)
        {
            Name = name;
            Levels = levels;
            IsNum = isNum;
            IsLog = isLog;
            Unit = unit;
        }
    }

    internal class DependantVariable : Variable
    {
        public DependantVariable(string name, bool isNum)
        {
            Name = name;
            IsNum = isNum;
        }

        public DependantVariable(string name, bool isNum, string unit)
        {
            Name = name;
            IsNum = isNum;
            Unit = unit;
        }

        public DependantVariable(string name, bool isNum, bool isLog, string unit)
        {
            Name = name;
            IsNum = isNum;
            IsLog = isLog;
            Unit = unit;
        }
    }
}
