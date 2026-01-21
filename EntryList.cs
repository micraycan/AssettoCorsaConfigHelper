using AssettoCorsaConfigHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssettoCorsaConfigHelper
{
    internal class EntryList
    {
        private List<Entry> _entries = new();

        public void AddEntry(string car, string skin)
        {
            _entries.Add(new Entry(car, skin));
        }

        public bool AnyDuplicateSkins(string skin) => _entries.Any(s => s.Skin == skin);

        public string BuildEntryList()
        {
            StringBuilder builder = new();
            
            for (int i = 0; i < _entries.Count; i++)
            {
                builder.AppendLine($"[CAR_{i}]");
                builder.AppendLine($"MODEL={_entries[i].Car}");
                builder.AppendLine($"SKIN={_entries[i].Skin}");
                builder.AppendLine("SPECTATOR_MODE=0");
                builder.AppendLine("DRIVERNAME=");
                builder.AppendLine("TEAM=");
                builder.AppendLine("GUID=");
                builder.AppendLine("BALLAST=0");
                builder.AppendLine("");
            }

            return builder.ToString();
        }

        public string BuildCarSelection()
        {
            StringBuilder builder = new();
            List<string> cars = _entries.Select(e => e.Car).Distinct().ToList();

            foreach (string car in cars)
            {
                builder.Append($"{car};");
            }

            return builder.ToString().TrimEnd(';');
        }

        public void Clear()
        {
            _entries.Clear();
        }
    }
}
