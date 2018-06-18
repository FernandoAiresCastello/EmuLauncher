using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmuLauncher
{
    public class ROMImage
    {
        public GameSystem System = null;
        public string Name = "";
        public string Notes = "";

        public ROMImage(string name, GameSystem system)
        {
            Name = name;
            System = system;
        }
        public override string ToString()
        {
            return Name;
        }
    }

    public class ROMImageList : List<ROMImage>
    {
    }
}
