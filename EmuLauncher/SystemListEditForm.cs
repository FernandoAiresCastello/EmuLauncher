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
    public partial class SystemListEditForm : Form
    {
        private SystemSelectionForm SystemSelectionForm;
        public GameSystemList SystemList;

        public SystemListEditForm(SystemSelectionForm form, GameSystemList systems)
        {
            InitializeComponent();
            SystemSelectionForm = form;
            SystemList = systems;

            GrdSystems.Font = new Font(Font.FontFamily, 8);

            UpdateGrid();
        }

        private void UpdateGrid()
        {
            GrdSystems.Rows.Clear();
            GrdSystems.Columns.Clear();
            
            GrdSystems.Columns.Add("emulator", "Name");
            GrdSystems.Columns.Add("emupath", "Path");
            GrdSystems.Columns.Add("romsfolder", "ROMs folder");
            GrdSystems.Columns.Add("romext", "ROM extensions");
            GrdSystems.Columns.Add("emucmd", "Global params");
            GrdSystems.Columns.Add("emucmdbyext", "Params by extension");
            GrdSystems.Columns.Add("imgfile", "Image file");

            if (SystemList.Count > 0)
            {
                GrdSystems.Rows.Add(SystemList.Count);

                int i = 0;
                foreach (GameSystem sys in SystemList)
                    UpdateGridRow(i++);
            }
        }

        private void UpdateGridRow(int row)
        {
            GameSystem sys = SystemList[row];
            GrdSystems.Rows[row].SetValues(
                sys.Name, sys.EmulatorPath, sys.ROMsFolder, sys.ROMExtensions,
                sys.EmulatorCommandLineParams, sys.EmulatorCommandLineParamsByExtension,
                sys.ImageFile);
        }

        private void GrdSystems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditSelected();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddNewEmulator();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            RemoveSelected();
        }

        private void GrdSystems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
                RemoveSelected();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                EditSelected();
            }
        }

        private DataGridViewRow GetSelectedRow()
        {
            DataGridViewSelectedRowCollection rows = GrdSystems.SelectedRows;
            if (rows.Count == 0)
                return null;

            return rows[0];
        }

        private void RemoveSelected()
        {
            DataGridViewRow row = GetSelectedRow();
            if (row == null)
                return;

            DialogResult result = MessageBox.Show("Really delete this emulator?", "Confirm delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                string name = SystemList[row.Index].Name;
                SystemList.RemoveAt(row.Index);
                SystemSelectionForm.RemoveSystem(name);
                UpdateGrid();
            }
        }

        private void EditSelected()
        {
            DataGridViewRow row = GetSelectedRow();
            if (row == null)
                return;
            
            GameSystem system = SystemList[row.Index];
            SystemEditForm form = new SystemEditForm(system);
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                SystemSelectionForm.UpdateSystem(row.Index, form.GameSystem);
                SystemSelectionForm.SaveSystems();
                UpdateGridRow(row.Index);
            }
        }

        private void AddNewEmulator()
        {
            SystemEditForm form = new SystemEditForm(null);
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                SystemSelectionForm.AddSystem(form.GameSystem);
                UpdateGrid();
            }
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
