namespace EmuLauncher
{
    partial class SystemSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemSelectionForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StTotalEmulators = new System.Windows.Forms.ToolStripStatusLabel();
            this.StInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ListGameSystems = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblGameSystem = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ImgGameSystem = new System.Windows.Forms.PictureBox();
            this.BtnEditEmulators = new System.Windows.Forms.ToolStripButton();
            this.BtnFavorites = new System.Windows.Forms.ToolStripButton();
            this.BtnSetWindowColor = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgGameSystem)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StTotalEmulators,
            this.StInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(984, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StTotalEmulators
            // 
            this.StTotalEmulators.BackColor = System.Drawing.Color.Transparent;
            this.StTotalEmulators.Name = "StTotalEmulators";
            this.StTotalEmulators.Size = new System.Drawing.Size(72, 19);
            this.StTotalEmulators.Text = "Emulators: 0";
            // 
            // StInfo
            // 
            this.StInfo.BackColor = System.Drawing.Color.Transparent;
            this.StInfo.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.StInfo.Name = "StInfo";
            this.StInfo.Size = new System.Drawing.Size(74, 19);
            this.StInfo.Text = "Information";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(976, 490);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ListGameSystems, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.4127F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.587302F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(271, 490);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ListGameSystems
            // 
            this.ListGameSystems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListGameSystems.FormattingEnabled = true;
            this.ListGameSystems.ItemHeight = 16;
            this.ListGameSystems.Location = new System.Drawing.Point(4, 4);
            this.ListGameSystems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.ListGameSystems.Name = "ListGameSystems";
            this.ListGameSystems.ScrollAlwaysVisible = true;
            this.ListGameSystems.Size = new System.Drawing.Size(263, 478);
            this.ListGameSystems.Sorted = true;
            this.ListGameSystems.TabIndex = 0;
            this.ListGameSystems.SelectedIndexChanged += new System.EventHandler(this.ListGameSystems_SelectedIndexChanged);
            this.ListGameSystems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListGameSystems_MouseDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LblGameSystem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ImgGameSystem, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 490);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LblGameSystem
            // 
            this.LblGameSystem.AutoSize = true;
            this.LblGameSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblGameSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGameSystem.Location = new System.Drawing.Point(3, 0);
            this.LblGameSystem.Name = "LblGameSystem";
            this.LblGameSystem.Size = new System.Drawing.Size(694, 49);
            this.LblGameSystem.TabIndex = 0;
            this.LblGameSystem.Text = "Game System";
            this.LblGameSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.splitContainer1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 39);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(4);
            this.MainPanel.Size = new System.Drawing.Size(984, 498);
            this.MainPanel.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnEditEmulators,
            this.BtnFavorites,
            this.BtnSetWindowColor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(984, 39);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ImgGameSystem
            // 
            this.ImgGameSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgGameSystem.Location = new System.Drawing.Point(3, 52);
            this.ImgGameSystem.Name = "ImgGameSystem";
            this.ImgGameSystem.Size = new System.Drawing.Size(694, 435);
            this.ImgGameSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgGameSystem.TabIndex = 1;
            this.ImgGameSystem.TabStop = false;
            // 
            // BtnEditEmulators
            // 
            this.BtnEditEmulators.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnEditEmulators.Image = global::EmuLauncher.Properties.Resources.cog_edit1;
            this.BtnEditEmulators.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnEditEmulators.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditEmulators.Name = "BtnEditEmulators";
            this.BtnEditEmulators.Size = new System.Drawing.Size(36, 36);
            this.BtnEditEmulators.ToolTipText = "Manage systems";
            this.BtnEditEmulators.Click += new System.EventHandler(this.addNewSystemToolStripMenuItem_Click);
            // 
            // BtnFavorites
            // 
            this.BtnFavorites.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnFavorites.Image = global::EmuLauncher.Properties.Resources.star1;
            this.BtnFavorites.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnFavorites.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFavorites.Name = "BtnFavorites";
            this.BtnFavorites.Size = new System.Drawing.Size(36, 36);
            this.BtnFavorites.ToolTipText = "Favorite ROMs";
            this.BtnFavorites.Click += new System.EventHandler(this.BtnFavorites_Click);
            // 
            // BtnSetWindowColor
            // 
            this.BtnSetWindowColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSetWindowColor.Image = global::EmuLauncher.Properties.Resources.color_management;
            this.BtnSetWindowColor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnSetWindowColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSetWindowColor.Name = "BtnSetWindowColor";
            this.BtnSetWindowColor.Size = new System.Drawing.Size(36, 36);
            this.BtnSetWindowColor.Text = "toolStripButton1";
            this.BtnSetWindowColor.ToolTipText = "Set window color";
            this.BtnSetWindowColor.Visible = false;
            this.BtnSetWindowColor.Click += new System.EventHandler(this.BtnSetWindowColor_Click);
            // 
            // SystemSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SystemSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmuLauncher";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgGameSystem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox ListGameSystems;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblGameSystem;
        private System.Windows.Forms.PictureBox ImgGameSystem;
        private System.Windows.Forms.ToolStripStatusLabel StTotalEmulators;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripStatusLabel StInfo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnEditEmulators;
        private System.Windows.Forms.ToolStripButton BtnFavorites;
        private System.Windows.Forms.ToolStripButton BtnSetWindowColor;
    }
}