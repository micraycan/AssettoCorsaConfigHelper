using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssettoCorsaConfigHelper.Models
{
    internal class Entry
    {
        public string Car { get; }
        public string Skin { get; }

        public Entry(string car, string skin)
        {
            Car = car;
            Skin = skin;
        }
    }
}
