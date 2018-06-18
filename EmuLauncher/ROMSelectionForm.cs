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
    public partial class ROMSelectionForm : Form
    {
        private ROMImageList ROMList;
        private SystemSelectionForm SystemSelectionForm;

        public ROMSelectionForm(SystemSelectionForm form, ROMImageList roms, string system)
        {
            InitializeComponent();
            SystemSelectionForm = form;
            ROMList = roms;
            StSystem.Text = system;
            UpdateListBox();
            if (ListROMs.Items.Count > 0)
                ListROMs.SelectedIndex = 0;

            this.Icon = SystemSelectionForm.Icon;
            this.Text = SystemSelectionForm.Text;
            this.WindowState = SystemSelectionForm.WindowState;
            this.Location = SystemSelectionForm.Location;
            this.Size = SystemSelectionForm.Size;
        }

        private void UpdateListBox()
        {
            ListROMs.Items.Clear();

            string textToSearch = TxtSearch.Text.ToLower();
            ListROMs.Items.Clear();
            ListROMs.Items.AddRange(
                ROMList.FindAll(rom => rom.Name.ToLower().Contains(textToSearch)).ToArray());

            StTotalGames.Text = "Games: " + ROMList.Count;
        }

        private void ROMSelectionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SystemSelectionForm.WindowState = this.WindowState;
            SystemSelectionForm.Location = this.Location;
            SystemSelectionForm.Size = this.Size;

            SystemSelectionForm.Show();
        }

        private void ListROMs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox list = sender as ListBox;
            ROMImage rom = list.SelectedItem as ROMImage;
            LblSystem.Text = rom.System.Name;
            LblGameName.Text = StGameName.Text = rom.Name;
            UpdateImageBox();
            UpdateNote();
            UpdateFavoritesMenu();
        }

        private void UpdateFavoritesMenu()
        {
            ROMImage rom = ListROMs.SelectedItem as ROMImage;
            if (SystemSelectionForm.HasFavorite(rom))
            {
                addToFavoritesToolStripMenuItem.Enabled = false;
                removeFromFavoritesToolStripMenuItem.Enabled = true;
                StFavorite.Visible = true;
            }
            else
            {
                addToFavoritesToolStripMenuItem.Enabled = true;
                removeFromFavoritesToolStripMenuItem.Enabled = false;
                StFavorite.Visible = false;
            }
        }

        private void ListROMs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LaunchSelectedGame();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void changeGameSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateImageBox()
        {
            ROMImage rom = ListROMs.SelectedItem as ROMImage;
            FileInfo file = new FileInfo(rom.Name);
            string png = SystemSelectionForm.ScreenshotsFolder + "\\" + file.Name.Replace(file.Extension, ".png");
            string jpg = SystemSelectionForm.ScreenshotsFolder + "\\" + file.Name.Replace(file.Extension, ".jpg");
            string bmp = SystemSelectionForm.ScreenshotsFolder + "\\" + file.Name.Replace(file.Extension, ".bmp");

            if (File.Exists(png))
                ImgGame.Image = Image.FromFile(png);
            else if (File.Exists(jpg))
                ImgGame.Image = Image.FromFile(jpg);
            else if (File.Exists(bmp))
                ImgGame.Image = Image.FromFile(bmp);
            else
                ImgGame.Image = null;
        }

        private void UpdateNote()
        {
            ROMImage rom = ListROMs.SelectedItem as ROMImage;
            FileInfo file = new FileInfo(rom.Name);
            string note = SystemSelectionForm.NotesFolder + "\\" + file.Name.Replace(file.Extension, ".txt");

            if (File.Exists(note))
                TxtNote.Text = File.ReadAllText(note);
            else
                TxtNote.Text = "";
        }

        private void ListROMs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                LaunchSelectedGame();
            }
        }

        private void LaunchSelectedGame()
        {
            ROMImage rom = ListROMs.SelectedItem as ROMImage;
            string romPath = rom.System.ROMsFolder + "\\" + rom.Name;
            string cmdParams = rom.System.EmulatorCommandLineParams;
            string prefixes = rom.System.EmulatorCommandLineParamsByExtension.Trim();
            string prefix = "";

            if (prefixes != "")
            {
                string[] extensionsAndPrefixes = prefixes.Trim().ToLower().Split('|');

                foreach (string extPrefixPair in extensionsAndPrefixes)
                {
                    string[] extPrefix = extPrefixPair.Trim().Split('=');
                    string extension = extPrefix[0].Trim();
                    if (rom.Name.Trim().ToLower().EndsWith("." + extension))
                    {
                        prefix = extPrefix[1].Trim();
                        break;
                    }
                }
            }

            string commandLine = (cmdParams + " " + prefix + " \"" + romPath + "\"").Trim();

            ProcessStartInfo info = new ProcessStartInfo(rom.System.EmulatorPath, commandLine);
            info.WorkingDirectory = new FileInfo(rom.System.EmulatorPath).DirectoryName;
            Process.Start(info);
        }

        private void setDefaultScreenshotsFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                SystemSelectionForm.ScreenshotsFolder = dialog.SelectedPath;
                SystemSelectionForm.SaveConfig();
            }
        }

        private void setNotesFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                SystemSelectionForm.NotesFolder = dialog.SelectedPath;
                SystemSelectionForm.SaveConfig();
            }
        }

        private void TxtNotes_MouseClick(object sender, MouseEventArgs e)
        {
            ROMImage rom = ListROMs.SelectedItem as ROMImage;
            ROMNoteEditForm form = new ROMNoteEditForm(this, rom.Name, TxtNote.Text);
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                string text = form.GetNote();
                FileInfo file = new FileInfo(rom.Name);
                string note = SystemSelectionForm.NotesFolder + "\\" + file.Name.Replace(file.Extension, ".txt");

                if (text.Trim() == "")
                    File.Delete(note);
                else
                    File.WriteAllText(note, text);
                
                UpdateNote();
            }
        }

        private bool IsFavoriteSelection()
        {
            return StSystem.Text == "Favorites";
        }

        private void addToFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ROMImage rom = ListROMs.SelectedItem as ROMImage;
            SystemSelectionForm.AddFavorite(rom);
            UpdateFavoritesMenu();
        }

        private void removeFromFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ROMImage rom = ListROMs.SelectedItem as ROMImage;
            SystemSelectionForm.RemoveFavorite(rom);
            UpdateFavoritesMenu();

            if (IsFavoriteSelection())
            {
                SystemSelectionForm.LoadFavorites();
                UpdateListBox();
                if (ListROMs.Items.Count == 0)
                    Close();
            }
        }

        private void openROMFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ROMImage rom = ListROMs.SelectedItem as ROMImage;
            Process.Start(rom.System.ROMsFolder);
        }

        private void openScreenshotsFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(SystemSelectionForm.ScreenshotsFolder);
        }

        private void openNotesFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(SystemSelectionForm.NotesFolder);
        }

        /*
        private void ListROMs_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();

            Graphics g = e.Graphics;
            ROMImage rom = ListROMs.Items[e.Index] as ROMImage;
            SolidBrush color;

            if (ListROMs.GetSelected(e.Index))
                color = new SolidBrush(Color.White);
            else
                color = new SolidBrush(Color.Black);

            g.DrawImage(Image.FromFile("Resources/processor.png"), e.Bounds.X, e.Bounds.Y);
            g.DrawString(rom.Name, ListROMs.Font, color, e.Bounds.X+24, e.Bounds.Y);

            color.Dispose();
        }
        */
    }
}
