namespace EmuLauncher
{
    partial class ROMSelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StSystem = new System.Windows.Forms.ToolStripStatusLabel();
            this.StTotalGames = new System.Windows.Forms.ToolStripStatusLabel();
            this.StGameName = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ListROMs = new System.Windows.Forms.ListBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LblSystem = new System.Windows.Forms.Label();
            this.LblGameName = new System.Windows.Forms.Label();
            this.TxtNote = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ImgGame = new System.Windows.Forms.PictureBox();
            this.BtnChangeEmulator = new System.Windows.Forms.ToolStripButton();
            this.BtnAddFavorite = new System.Windows.Forms.ToolStripButton();
            this.BtnRemoveFavorite = new System.Windows.Forms.ToolStripButton();
            this.StFavorite = new System.Windows.Forms.ToolStripStatusLabel();
            this.changeGameSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFromFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openROMFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDefaultScreenshotsFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openScreenshotsFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setNotesFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNotesFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgGame)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeGameSystemToolStripMenuItem,
            this.toolStripSeparator1,
            this.addToFavoritesToolStripMenuItem,
            this.removeFromFavoritesToolStripMenuItem,
            this.toolStripSeparator3,
            this.openROMFolderToolStripMenuItem,
            this.setDefaultScreenshotsFolderToolStripMenuItem,
            this.openScreenshotsFolderToolStripMenuItem,
            this.setNotesFolderToolStripMenuItem,
            this.openNotesFolderToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.fileToolStripMenuItem.Text = "Options";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(263, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(263, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(263, 6);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StSystem,
            this.StTotalGames,
            this.StGameName,
            this.StFavorite});
            this.statusStrip1.Location = new System.Drawing.Point(0, 414);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(818, 25);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StSystem
            // 
            this.StSystem.BackColor = System.Drawing.Color.Transparent;
            this.StSystem.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.StSystem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.StSystem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StSystem.Name = "StSystem";
            this.StSystem.Size = new System.Drawing.Size(52, 20);
            this.StSystem.Text = "System";
            // 
            // StTotalGames
            // 
            this.StTotalGames.BackColor = System.Drawing.Color.Transparent;
            this.StTotalGames.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.StTotalGames.Name = "StTotalGames";
            this.StTotalGames.Size = new System.Drawing.Size(59, 20);
            this.StTotalGames.Text = "Games: 0";
            // 
            // StGameName
            // 
            this.StGameName.BackColor = System.Drawing.Color.Transparent;
            this.StGameName.Name = "StGameName";
            this.StGameName.Size = new System.Drawing.Size(71, 20);
            this.StGameName.Text = "Game name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(818, 351);
            this.panel1.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(5, 5);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(808, 341);
            this.splitContainer1.SplitterDistance = 348;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.ListROMs, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.TxtSearch, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.788512F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.21149F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(348, 341);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // ListROMs
            // 
            this.ListROMs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListROMs.FormattingEnabled = true;
            this.ListROMs.ItemHeight = 16;
            this.ListROMs.Location = new System.Drawing.Point(3, 26);
            this.ListROMs.Name = "ListROMs";
            this.ListROMs.ScrollAlwaysVisible = true;
            this.ListROMs.Size = new System.Drawing.Size(342, 312);
            this.ListROMs.Sorted = true;
            this.ListROMs.TabIndex = 1;
            this.ListROMs.TabStop = false;
            this.ListROMs.SelectedIndexChanged += new System.EventHandler(this.ListROMs_SelectedIndexChanged);
            this.ListROMs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ListROMs_KeyPress);
            this.ListROMs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListROMs_MouseDoubleClick);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSearch.Location = new System.Drawing.Point(3, 3);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(342, 22);
            this.TxtSearch.TabIndex = 0;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ImgGame, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtNote, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(455, 341);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.LblSystem, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.LblGameName, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(449, 39);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // LblSystem
            // 
            this.LblSystem.AutoSize = true;
            this.LblSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.LblSystem.Location = new System.Drawing.Point(3, 0);
            this.LblSystem.Name = "LblSystem";
            this.LblSystem.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.LblSystem.Size = new System.Drawing.Size(443, 11);
            this.LblSystem.TabIndex = 1;
            this.LblSystem.Text = "Game System";
            this.LblSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblGameName
            // 
            this.LblGameName.AutoSize = true;
            this.LblGameName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LblGameName.Location = new System.Drawing.Point(3, 11);
            this.LblGameName.Name = "LblGameName";
            this.LblGameName.Size = new System.Drawing.Size(443, 28);
            this.LblGameName.TabIndex = 2;
            this.LblGameName.Text = "LblGameName";
            this.LblGameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtNote
            // 
            this.TxtNote.BackColor = System.Drawing.Color.White;
            this.TxtNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNote.Font = new System.Drawing.Font("Consolas", 8F);
            this.TxtNote.Location = new System.Drawing.Point(3, 273);
            this.TxtNote.Multiline = true;
            this.TxtNote.Name = "TxtNote";
            this.TxtNote.ReadOnly = true;
            this.TxtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtNote.Size = new System.Drawing.Size(449, 65);
            this.TxtNote.TabIndex = 4;
            this.TxtNote.TabStop = false;
            this.TxtNote.Text = "Notes";
            this.TxtNote.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtNotes_MouseClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnChangeEmulator,
            this.BtnAddFavorite,
            this.BtnRemoveFavorite});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(818, 39);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ImgGame
            // 
            this.ImgGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgGame.Location = new System.Drawing.Point(3, 48);
            this.ImgGame.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.ImgGame.Name = "ImgGame";
            this.ImgGame.Size = new System.Drawing.Size(449, 212);
            this.ImgGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgGame.TabIndex = 1;
            this.ImgGame.TabStop = false;
            // 
            // BtnChangeEmulator
            // 
            this.BtnChangeEmulator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnChangeEmulator.Image = global::EmuLauncher.Properties.Resources.controller;
            this.BtnChangeEmulator.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnChangeEmulator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnChangeEmulator.Name = "BtnChangeEmulator";
            this.BtnChangeEmulator.Size = new System.Drawing.Size(36, 36);
            this.BtnChangeEmulator.Text = "toolStripButton1";
            this.BtnChangeEmulator.ToolTipText = "Select System";
            this.BtnChangeEmulator.Click += new System.EventHandler(this.changeGameSystemToolStripMenuItem_Click);
            // 
            // BtnAddFavorite
            // 
            this.BtnAddFavorite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAddFavorite.Image = global::EmuLauncher.Properties.Resources.award_star_add1;
            this.BtnAddFavorite.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnAddFavorite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAddFavorite.Name = "BtnAddFavorite";
            this.BtnAddFavorite.Size = new System.Drawing.Size(36, 36);
            this.BtnAddFavorite.Text = "toolStripButton1";
            this.BtnAddFavorite.ToolTipText = "Add selected ROM to favorites";
            this.BtnAddFavorite.Click += new System.EventHandler(this.addToFavoritesToolStripMenuItem_Click);
            // 
            // BtnRemoveFavorite
            // 
            this.BtnRemoveFavorite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRemoveFavorite.Image = global::EmuLauncher.Properties.Resources.award_star_delete1;
            this.BtnRemoveFavorite.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnRemoveFavorite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRemoveFavorite.Name = "BtnRemoveFavorite";
            this.BtnRemoveFavorite.Size = new System.Drawing.Size(36, 36);
            this.BtnRemoveFavorite.Text = "toolStripButton2";
            this.BtnRemoveFavorite.ToolTipText = "Remove selected ROM from favorites";
            this.BtnRemoveFavorite.Click += new System.EventHandler(this.removeFromFavoritesToolStripMenuItem_Click);
            // 
            // StFavorite
            // 
            this.StFavorite.BackColor = System.Drawing.Color.Transparent;
            this.StFavorite.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.StFavorite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StFavorite.Image = global::EmuLauncher.Properties.Resources.star;
            this.StFavorite.Name = "StFavorite";
            this.StFavorite.Size = new System.Drawing.Size(20, 20);
            this.StFavorite.Text = "Favorite";
            // 
            // changeGameSystemToolStripMenuItem
            // 
            this.changeGameSystemToolStripMenuItem.Image = global::EmuLauncher.Properties.Resources.joystick;
            this.changeGameSystemToolStripMenuItem.Name = "changeGameSystemToolStripMenuItem";
            this.changeGameSystemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.changeGameSystemToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.changeGameSystemToolStripMenuItem.Text = "Change emulator";
            this.changeGameSystemToolStripMenuItem.Click += new System.EventHandler(this.changeGameSystemToolStripMenuItem_Click);
            // 
            // addToFavoritesToolStripMenuItem
            // 
            this.addToFavoritesToolStripMenuItem.Image = global::EmuLauncher.Properties.Resources.award_star_add;
            this.addToFavoritesToolStripMenuItem.Name = "addToFavoritesToolStripMenuItem";
            this.addToFavoritesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.addToFavoritesToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.addToFavoritesToolStripMenuItem.Text = "Add to favorites";
            this.addToFavoritesToolStripMenuItem.Click += new System.EventHandler(this.addToFavoritesToolStripMenuItem_Click);
            // 
            // removeFromFavoritesToolStripMenuItem
            // 
            this.removeFromFavoritesToolStripMenuItem.Image = global::EmuLauncher.Properties.Resources.award_star_delete;
            this.removeFromFavoritesToolStripMenuItem.Name = "removeFromFavoritesToolStripMenuItem";
            this.removeFromFavoritesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.removeFromFavoritesToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.removeFromFavoritesToolStripMenuItem.Text = "Remove from favorites";
            this.removeFromFavoritesToolStripMenuItem.Click += new System.EventHandler(this.removeFromFavoritesToolStripMenuItem_Click);
            // 
            // openROMFolderToolStripMenuItem
            // 
            this.openROMFolderToolStripMenuItem.Image = global::EmuLauncher.Properties.Resources.folder;
            this.openROMFolderToolStripMenuItem.Name = "openROMFolderToolStripMenuItem";
            this.openROMFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openROMFolderToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.openROMFolderToolStripMenuItem.Text = "Open ROM folder";
            this.openROMFolderToolStripMenuItem.Click += new System.EventHandler(this.openROMFolderToolStripMenuItem_Click);
            // 
            // setDefaultScreenshotsFolderToolStripMenuItem
            // 
            this.setDefaultScreenshotsFolderToolStripMenuItem.Image = global::EmuLauncher.Properties.Resources.folder_picture;
            this.setDefaultScreenshotsFolderToolStripMenuItem.Name = "setDefaultScreenshotsFolderToolStripMenuItem";
            this.setDefaultScreenshotsFolderToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.setDefaultScreenshotsFolderToolStripMenuItem.Text = "Set screenshots folder";
            this.setDefaultScreenshotsFolderToolStripMenuItem.Click += new System.EventHandler(this.setDefaultScreenshotsFolderToolStripMenuItem_Click);
            // 
            // openScreenshotsFolderToolStripMenuItem
            // 
            this.openScreenshotsFolderToolStripMenuItem.Image = global::EmuLauncher.Properties.Resources.folder_picture;
            this.openScreenshotsFolderToolStripMenuItem.Name = "openScreenshotsFolderToolStripMenuItem";
            this.openScreenshotsFolderToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.openScreenshotsFolderToolStripMenuItem.Text = "Open screenshots folder";
            this.openScreenshotsFolderToolStripMenuItem.Click += new System.EventHandler(this.openScreenshotsFolderToolStripMenuItem_Click);
            // 
            // setNotesFolderToolStripMenuItem
            // 
            this.setNotesFolderToolStripMenuItem.Image = global::EmuLauncher.Properties.Resources.folder_page_white;
            this.setNotesFolderToolStripMenuItem.Name = "setNotesFolderToolStripMenuItem";
            this.setNotesFolderToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.setNotesFolderToolStripMenuItem.Text = "Set notes folder";
            this.setNotesFolderToolStripMenuItem.Click += new System.EventHandler(this.setNotesFolderToolStripMenuItem_Click);
            // 
            // openNotesFolderToolStripMenuItem
            // 
            this.openNotesFolderToolStripMenuItem.Image = global::EmuLauncher.Properties.Resources.folder_page_white;
            this.openNotesFolderToolStripMenuItem.Name = "openNotesFolderToolStripMenuItem";
            this.openNotesFolderToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.openNotesFolderToolStripMenuItem.Text = "Open notes folder";
            this.openNotesFolderToolStripMenuItem.Click += new System.EventHandler(this.openNotesFolderToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::EmuLauncher.Properties.Resources.cross;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ROMSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 439);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ROMSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "EmuLauncher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ROMSelectionForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox ListROMs;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeGameSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripStatusLabel StTotalGames;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.ToolStripStatusLabel StGameName;
        private System.Windows.Forms.PictureBox ImgGame;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label LblSystem;
        private System.Windows.Forms.Label LblGameName;
        private System.Windows.Forms.ToolStripMenuItem setDefaultScreenshotsFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setNotesFolderToolStripMenuItem;
        public System.Windows.Forms.TextBox TxtNote;
        private System.Windows.Forms.ToolStripMenuItem addToFavoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel StSystem;
        private System.Windows.Forms.ToolStripMenuItem removeFromFavoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel StFavorite;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem openROMFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openScreenshotsFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNotesFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnChangeEmulator;
        private System.Windows.Forms.ToolStripButton BtnAddFavorite;
        private System.Windows.Forms.ToolStripButton BtnRemoveFavorite;
    }
}