using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace EmuLauncher
{
    public partial class SystemSelectionForm : Form
    {
        private readonly string EmulatorListFile = "emulators.ini";
        private readonly string ConfigFile = "config.ini";
        private readonly string FavoritesFile = "favorites.ini";

        private GameSystemList GameSystems = new GameSystemList();
        private ROMImageList FavoriteROMs = new ROMImageList();

        public string ScreenshotsFolder { set; get; }
        public string NotesFolder { set; get; }

        public SystemSelectionForm()
        {
            InitializeComponent();
            LoadConfig();
            LoadSystems();
            LoadFavorites();

            Text = "EmuLauncher (C) 2015 by Fernando Aires Castello";
        }

        private void LoadConfig()
        {
            if (!File.Exists(ConfigFile))
                return;

            using (StreamReader reader = new StreamReader(ConfigFile))
            {
                while (!reader.EndOfStream)
                {
                    ScreenshotsFolder = reader.ReadLine();
                    NotesFolder = reader.ReadLine();
                }
            }
        }

        public void SaveConfig()
        {
            using (StreamWriter writer = new StreamWriter(ConfigFile))
            {
                writer.WriteLine(ScreenshotsFolder);
                writer.WriteLine(NotesFolder);

                writer.Flush();
                writer.Close();
            }
        }

        public void LoadFavorites()
        {
            if (!File.Exists(FavoritesFile))
                return;

            FavoriteROMs.Clear();

            using (StreamReader reader = new StreamReader(FavoritesFile))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine() ;
                    string[] systemAndGame = line.Split(',');
                    string system = systemAndGame[0].Trim();
                    string game = systemAndGame[1].Trim();

                    ROMImage rom = new ROMImage(game, GameSystems.Find(sys => sys.Name == system));
                    FavoriteROMs.Add(rom);
                }
            }

            UpdateFavoritesButton();
        }

        private void SaveFavorites()
        {
            using (StreamWriter writer = new StreamWriter(FavoritesFile))
            {
                foreach (ROMImage rom in FavoriteROMs)
                    writer.WriteLine(rom.System.Name + ", " + rom.Name);

                writer.Flush();
                writer.Close();
            }
        }

        public void AddFavorite(ROMImage rom)
        {
            FavoriteROMs.Add(rom);
            SaveFavorites();

            MessageBox.Show(
                rom.Name + " was added to favorites!",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateFavoritesButton();
        }

        public void RemoveFavorite(ROMImage rom)
        {
            FavoriteROMs.Remove(FavoriteROMs.Find(fav => fav.Name == rom.Name && fav.System.Name == rom.System.Name));
            SaveFavorites();

            MessageBox.Show(
                rom.Name + " was removed from favorites.",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateFavoritesButton();
        }

        private void UpdateFavoritesButton()
        {
            BtnFavorites.Text = "Favorites (" + FavoriteROMs.Count + ")";
        }

        public bool HasFavorite(ROMImage rom)
        {
            return FavoriteROMs.Find(r => r.Name == rom.Name && r.System.Name == rom.System.Name) != null;
        }

        private void LoadSystems()
        {
            GameSystems.Clear();

            if (!File.Exists(EmulatorListFile))
                File.Create(EmulatorListFile).Close();

            using (StreamReader reader = new StreamReader(EmulatorListFile))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] param = line.Split(',');
                    for (int i = 0; i < param.Length; i++)
                        param[i] = param[i].Trim();

                    GameSystems.Add(new GameSystem(
                        param[0], param[1], param[2], param[3], param[4],
                        param.Length > 5 ? param[5] : "",
                        param.Length > 6 ? param[6] : ""));
                }
            }

            ListGameSystems.Items.Clear();
            foreach (GameSystem sys in GameSystems)
                ListGameSystems.Items.Add(sys);

            StTotalEmulators.Text = "Emulators: " + GameSystems.Count;

            if (ListGameSystems.Items.Count > 0)
            {
                ListGameSystems.SelectedIndex = 0;
                StInfo.Text = "";
                StInfo.Visible = false;
            }
            else
            {
                LblGameSystem.Text = "";
                ImgGameSystem.Image = null;
                StInfo.Text = "The emulator list is empty. Press CTRL+E to setup emulators.";
                StInfo.Visible = true;
            }
        }

        public void SaveSystems()
        {
            using (StreamWriter writer = new StreamWriter(EmulatorListFile))
            {
                foreach (GameSystem sys in GameSystems)
                {
                    writer.WriteLine(
                        sys.Name + "," + 
                        sys.ImageFile + "," + 
                        sys.ROMsFolder + "," +
                        sys.ROMExtensions + "," +
                        sys.EmulatorPath + "," +
                        sys.EmulatorCommandLineParams + "," +
                        sys.EmulatorCommandLineParamsByExtension);
                }

                writer.Flush();
                writer.Close();
            }
        }

        public void UpdateSystem(int index, GameSystem updatedSystem)
        {
            GameSystems[index] = updatedSystem;
            SaveSystems();
            LoadSystems();
        }

        public void AddSystem(GameSystem system)
        {
            GameSystems.Add(system);
            SaveSystems();
            LoadSystems();
        }

        public void RemoveSystem(string name)
        {
            GameSystems.Remove(GameSystems.Find(sys => sys.Name == name));
            SaveSystems();
            LoadSystems();
        }

        private ROMImageList LoadROMs(GameSystem system)
        {
            if (!Directory.Exists(system.ROMsFolder))
            {
                MessageBox.Show(
                    "The ROM folder configured for this system does not exist.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }

            DirectoryInfo dir = new DirectoryInfo(system.ROMsFolder);
            FileInfo[] files = dir.GetFiles();
            string[] extensions = system.ROMExtensions.Split('|');
            ROMImageList roms = new ROMImageList();

            foreach (FileInfo file in files)
            {
                foreach (string ext in extensions)
                {
                    if (!file.Name.Trim().ToLower().EndsWith("." + ext.Trim().ToLower()))
                        continue;

                    roms.Add(new ROMImage(file.Name, system));
                }
            }

            return roms;
        }

        private void ListGameSystems_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox list = sender as ListBox;
            GameSystem sys = list.SelectedItem as GameSystem;
            LblGameSystem.Text = sys.Name;
            string imagefile = sys.ImageFile;

            if (File.Exists(imagefile))
                ImgGameSystem.Image = Image.FromFile(imagefile);
            else
                ImgGameSystem.Image = null;
        }

        private void ListGameSystems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListBox list = sender as ListBox;
            GameSystem sys = list.SelectedItem as GameSystem;
            ROMImageList roms = LoadROMs(sys);
            if (roms == null)
                return;

            if (roms.Count == 0)
            {
                MessageBox.Show(
                    "There are no games to display for this system.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Hide();
            ROMSelectionForm romSelector = new ROMSelectionForm(this, roms, sys.Name);
            romSelector.Show();
        }

        private void favoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFavorites();
        }

        private void BtnFavorites_Click(object sender, EventArgs e)
        {
            ShowFavorites();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemListEditForm form = new SystemListEditForm(this, GameSystems);
            form.ShowDialog();
            LoadSystems();
        }

        private void ShowFavorites()
        {
            if (FavoriteROMs.Count == 0)
            {
                MessageBox.Show(
                    "There are no favorites.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Hide();
            ROMSelectionForm romSelector = new ROMSelectionForm(this, FavoriteROMs, "Favorites");
            romSelector.Show();
        }

        private void BtnSetWindowColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog(this) == DialogResult.OK)
                MainPanel.BackColor = dialog.Color;
        }
    }
}
