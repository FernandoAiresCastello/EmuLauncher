using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmuLauncher
{
    public partial class SystemEditForm : Form
    {
        public GameSystem GameSystem = null;

        public SystemEditForm(GameSystem system)
        {
            InitializeComponent();
            GameSystem = system;

            if (system == null)
            {
                GameSystem = new GameSystem();
                Text = "New emulator";
            }
            else
                Text = system.Name;

            TxtName.Text = GameSystem.Name;
            TxtPath.Text = GameSystem.EmulatorPath;
            TxtRomFolder.Text = GameSystem.ROMsFolder;
            TxtRomExt.Text = GameSystem.ROMExtensions;
            TxtGlobalParams.Text = GameSystem.EmulatorCommandLineParams;
            TxtExtParams.Text = GameSystem.EmulatorCommandLineParamsByExtension;
            TxtImageFile.Text = GameSystem.ImageFile;
            
            TxtInstructions.Text = "";
        }

        private void SystemEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSystem();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveSystem();
        }

        private void SaveSystem()
        {
            GameSystem.Name = TxtName.Text;
            GameSystem.EmulatorPath = TxtPath.Text;
            GameSystem.ROMsFolder = TxtRomFolder.Text;
            GameSystem.ROMExtensions = TxtRomExt.Text;
            GameSystem.EmulatorCommandLineParams = TxtGlobalParams.Text;
            GameSystem.EmulatorCommandLineParamsByExtension = TxtExtParams.Text;
            GameSystem.ImageFile = TxtImageFile.Text;
        }

        private void BtnPath_Click(object sender, EventArgs e)
        {
            string file = SelectFile();
            if (file != null)
                TxtPath.Text = file;
        }

        private void BtnRomFolder_Click(object sender, EventArgs e)
        {
            string folder = SelectFolder();
            if (folder != null)
                TxtRomFolder.Text = folder;
        }

        private void BtnImageFile_Click(object sender, EventArgs e)
        {
            string file = SelectFile();
            if (file != null)
                TxtImageFile.Text = file;
        }

        private string SelectFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
                return dialog.FileName;

            return null;
        }

        private string SelectFolder()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
                return dialog.SelectedPath;

            return null;
        }

        private void SetInstructions(string title, string instructions)
        {
            GrInstructions.Text = title;
            TxtInstructions.Text = instructions;
        }

        private void TxtName_Enter(object sender, EventArgs e)
        {
            SetInstructions("Name", 
                "Enter the name of the emulator.");
        }

        private void TxtPath_Enter(object sender, EventArgs e)
        {
            SetInstructions("Path", 
                "Enter the path of the emulator executable file, or press the folder button to select it.");
        }

        private void TxtRomFolder_Enter(object sender, EventArgs e)
        {
            SetInstructions("ROMs folder",
                "Enter the path of the folder where ROM files for this emulator can be found, or press the folder button to select it.");
        }

        private void TxtRomExt_Enter(object sender, EventArgs e)
        {
            SetInstructions("ROM extensions", 
                "Enter the valid file extensions (not including the dot) of ROMS for this emulator. " +
                "Only files with these extensions will be displayed in the list. Multiple extensions must be " + 
                "separated by a vertical bar, for example: rom|bin|img");
        }

        private void TxtGlobalParams_Enter(object sender, EventArgs e)
        {
            SetInstructions("Global params", "Enter the global commandline parameters for this emulator. " +
                "These parameters will always be included when launching the emulator.");
        }

        private void TxtExtParams_Enter(object sender, EventArgs e)
        {
            SetInstructions("Params by extension", "Enter the commandline parameters for this emulator, for each file extension. " +
                "This is useful for emulators that require a parameter to indicate the type of the ROM being loaded. " +
                "You must follow this syntax: extension1=parameter1|extension2=parameter2|..." +
                Environment.NewLine + Environment.NewLine +
                "For example, to successfully launch BlueMSX ROMs, you must enter the following: cas=/cas|dsk=/diskA|rom=/rom1");
        }

        private void TxtImageFile_Enter(object sender, EventArgs e)
        {
            SetInstructions("Image file", "Enter the path of the image file for this emulator, or press the folder button to select it. " +
                "The image can be any PNG, JPG or BMP file, and it's usually a picture of the game console or computer for illustrative " +
                "purposes.");
        }
    }
}
