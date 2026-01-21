using AssettoCorsaConfigHelper.Models;

namespace AssettoCorsaConfigHelper
{
    public partial class ConfigHelperForm : Form
    {
        private ContentLoader _contentLoader = new();
        private EntryList _entryList = new();

        public ConfigHelperForm()
        {
            InitializeComponent();

            _contentLoader.ContentUpdated += OnContentUpdated;
            LoadLastPath();

            findDirectoryButton.Click += _contentLoader.FindDirectory;
            carComboBox.SelectedIndexChanged += OnCarSelected;
            addEntryButton.Click += OnAddEntry;
            clearEntryListButton.Click += OnClearEntryList;

            copyEntryListButton.Click += (s, e) =>
            {
               if (!string.IsNullOrEmpty(entryListTextBox.Text))
                {
                    Clipboard.SetText(entryListTextBox.Text);
                }
            };

            copyCarSelectionButton.Click += (s, e) =>
            {
                if (!string.IsNullOrEmpty(carSelectionTextBox.Text))
                {
                    Clipboard.SetText(carSelectionTextBox.Text);
                }
            };
        }

        private void OnContentUpdated(object? s, Content c)
        {
            directoryTextBox.Text = c.Path;

            Properties.Settings.Default.LastContentPath = c.Path;
            Properties.Settings.Default.Save();

            if (c.Cars.Count > 0)
            {
                carComboBox.Items.Clear();
                foreach (Car car in c.Cars)
                {
                    carComboBox.Items.Add(car.Name);
                }
            }
        }

        private void OnCarSelected(object? s, EventArgs e)
        {
            carSkinComboBox.Items.Clear();
            if (_contentLoader.content == null) { return; }

            string selectedValue = carComboBox.SelectedItem?.ToString() ?? string.Empty;

            if (!_contentLoader.content.CarLookup.TryGetValue(selectedValue, out Car? car)) { return; }
            foreach (string skin in car.Skins)
            {
                if (_entryList.AnyDuplicateSkins(skin)) { continue; }
                carSkinComboBox.Items.Add(skin);
            }
        }

        private void OnAddEntry(object? s, EventArgs e)
        {
            if (_contentLoader.content == null) { return; }
            string selectedCar = carComboBox.SelectedItem?.ToString() ?? string.Empty;
            string selectedSkin = carSkinComboBox.SelectedItem?.ToString() ?? string.Empty;
            if (string.IsNullOrEmpty(selectedCar) || string.IsNullOrEmpty(selectedSkin)) { return; }

            _entryList.AddEntry(_contentLoader.content.CarLookup[selectedCar].ID, selectedSkin);
            entryListTextBox.Text = _entryList.BuildEntryList();

            carSelectionTextBox.Text = _entryList.BuildCarSelection();

            carSkinComboBox.Items.Remove(selectedSkin);
        }

        private void OnClearEntryList(object? s, EventArgs e)
        {
            _entryList.Clear();
            carComboBox.SelectedIndex = -1;
            carSkinComboBox.SelectedIndex = -1;
            carSkinComboBox.Items.Clear();
            entryListTextBox.Clear();
            carSelectionTextBox.Clear();
        }

        private void LoadLastPath()
        {
            string lastPath = Properties.Settings.Default.LastContentPath;
            if (string.IsNullOrEmpty(lastPath)) { return; }

            directoryTextBox.Text = lastPath;
            _contentLoader.LoadPath(lastPath);
        }
    }
}
