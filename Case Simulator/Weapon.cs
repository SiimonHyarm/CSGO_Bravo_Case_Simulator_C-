using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Simulator
{
    class Weapon
    {
        public Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<string, float>>>>> color { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string wear { get; set; }
        public float price { get; set; }
    }
}
