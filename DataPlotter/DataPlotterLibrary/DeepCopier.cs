using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DataPlotter.DataPlotterLibrary
{
    public static class DeepCopier
    {
        public static T DeepCopy<T>(T blueprint)
        {
            string serialized = JsonConvert.SerializeObject(blueprint, Formatting.None);

            return JsonConvert.DeserializeObject<T>(serialized);
        }
    }
}
