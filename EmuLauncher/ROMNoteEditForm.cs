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
    public partial class ROMNoteEditForm : Form
    {
        public ROMNoteEditForm(ROMSelectionForm form, string gameName, string initialText)
        {
            InitializeComponent();
            Text = gameName;
            TxtNote.Text = initialText;
            TxtNote.Font = form.TxtNote.Font;
        }

        public string GetNote()
        {
            return TxtNote.Text;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtNote.Text = "";
        }
    }
}
