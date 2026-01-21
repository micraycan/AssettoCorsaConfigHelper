using AssettoCorsaConfigHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AssettoCorsaConfigHelper
{
    internal class ContentLoader
    {
        public Content? content;

        public EventHandler<Content>? ContentUpdated;

        public void FindDirectory(object? s, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.OK) { return; }

            LoadPath(dialog.SelectedPath);
        }

        public void LoadPath(string path)
        {
            content = new Content(path);
            ContentUpdated?.Invoke(this, content);

            LoadCars();
            LoadTracks();
        }

        private void LoadCars()
        {
            if (content == null) { return; }

            string carPath = Path.Combine(content.Path, "cars");
            if (!Directory.Exists(carPath)) { return; }

            foreach (var carDir in Directory.GetDirectories(carPath))
            {
                if (!Directory.EnumerateFileSystemEntries(carDir).Any()) { continue; }

                string carID = Path.GetFileName(carDir);
                string carName = GetCarName(carDir);
                string skinsPath = Path.Combine(carDir, "skins");
                string[] skins = Array.Empty<string>();

                if (Directory.Exists(skinsPath))
                {
                    skins = Directory.GetDirectories(skinsPath)
                        .Select(s => Path.GetFileName(s))
                        .ToArray();
                }

                content.AddCar(new Car(carID, carName, skins));
            }

            ContentUpdated?.Invoke(this, content);
        }

        private void LoadTracks()
        {

        }

        private string GetCarName(string carDirectory)
        {
            string uiPath = Path.Combine(carDirectory, "ui", "ui_car.json");

            if (!File.Exists(uiPath)) { return Path.GetFileName(carDirectory); }

            string text = File.ReadAllText(uiPath);
            // why are AC ui json files broken
            var match = Regex.Match(text, "\"name\"\\s*:\\s*\"(?<name>.*?)\"", RegexOptions.IgnoreCase | RegexOptions.Singleline);

            if (match.Success) { return match.Groups["name"].Value.Trim(); }
            else { return Path.GetFileName(carDirectory); }
        }
    }
}
