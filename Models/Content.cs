using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssettoCorsaConfigHelper.Models
{
    internal class Content
    {
        public string Path { get; }
        public List<Car> Cars { get; }
        public Dictionary<string, Car> CarLookup { get; }

        public Content(string path)
        {
            Path = path;
            Cars = new();
            CarLookup = new();
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
            CarLookup[car.Name] = car;
        }
    }
}
