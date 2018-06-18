using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmuLauncher
{
    public class GameSystem
    {
        public string Name = "";
        public string ImageFile = "";
        public string ROMsFolder = "";
        public string ROMExtensions = "";
        public string EmulatorPath = "";
        public string EmulatorCommandLineParams = "";
        public string EmulatorCommandLineParamsByExtension = "";

        public GameSystem()
        {
        }

        public GameSystem(
            string name, string imagefile, string romsfolder, string romext, string emupath, string cmdparams, string cmdparamsbyext)
        {
            Name = name;
            ImageFile = imagefile;
            ROMsFolder = romsfolder;
            ROMExtensions = romext;
            EmulatorPath = emupath;
            EmulatorCommandLineParams = cmdparams;
            EmulatorCommandLineParamsByExtension = cmdparamsbyext;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class GameSystemList : List<GameSystem>
    {
    }
}
