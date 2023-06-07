using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPlotter.DataPlotterLibrary
{
    public static class Extensions
    {
        public static string RemoveWhiteSpaces(this string s) => String.Join("", s.Where(c => c != ' '));
    }
}
