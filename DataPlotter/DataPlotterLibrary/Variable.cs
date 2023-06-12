using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataPlotter.DataPlotterLibrary
{
    public class Variable
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

        public virtual string WriteParameters()
        {
            string type = IsNum ? (IsLog ? "log" : "lin") : "qualitative";
            string[] parameters = new string[] { Name, type, Unit }.Where(s => s != string.Empty).ToArray();
            return String.Join(" ; ", parameters);
        }
    }

    public class IndependantVariable : Variable
    {
        private string[] levels;

        /// <summary>
        /// Levels formatted as "variableName_levelName"
        /// </summary>
        public string[] Levels
        {
            get { return levels; }
            private set { levels = value; }
        }


        [JsonConstructor]
        public IndependantVariable()
        {
            
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

        public override string WriteParameters()
        {
            string type = IsNum ? (IsLog ? "log" : "lin") : "qualitative";
            string[] parameters = new string[] { Name, type, String.Join(", ", Levels) , Unit }.Where(s => s != string.Empty).ToArray();
            return String.Join(" ; ", parameters);
        }

        public void AddLevel(string level)
        {
            levels = levels.Append(level).ToArray();
        }

        public void RemoveLevel(string level)
        {
            levels = levels.Where(l => l != level).ToArray();
        }

        /// <summary>
        /// Return the level formatted as "levelName" instead of "variableName_levelName"
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public string CleanLevel(string level) => level.Remove(0, Name.Length + 1);
    }

    public class DependantVariable : Variable
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
