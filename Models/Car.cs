using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssettoCorsaConfigHelper.Models
{
    internal class Car
    {
        public string ID { get; }
        public string Name { get; }
        public string[] Skins { get; }

        public Car(string id, string name, string[] skins)
        {
            ID = id;
            Name = name;
            Skins = skins;
        }
    }
}
