namespace EmuLauncher
{
    partial class SystemEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRomFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtRomExt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtGlobalParams = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtExtParams = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtImageFile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnPath = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnRomFolder = new System.Windows.Forms.Button();
            this.BtnImageFile = new System.Windows.Forms.Button();
            this.GrInstructions = new System.Windows.Forms.GroupBox();
            this.TxtInstructions = new System.Windows.Forms.TextBox();
            this.GrInstructions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(159, 15);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(265, 22);
            this.TxtName.TabIndex = 1;
            this.TxtName.Enter += new System.EventHandler(this.TxtName_Enter);
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(159, 43);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.Size = new System.Drawing.Size(221, 22);
            this.TxtPath.TabIndex = 3;
            this.TxtPath.Enter += new System.EventHandler(this.TxtPath_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path";
            // 
            // TxtRomFolder
            // 
            this.TxtRomFolder.Location = new System.Drawing.Point(159, 71);
            this.TxtRomFolder.Name = "TxtRomFolder";
            this.TxtRomFolder.Size = new System.Drawing.Size(221, 22);
            this.TxtRomFolder.TabIndex = 5;
            this.TxtRomFolder.Enter += new System.EventHandler(this.TxtRomFolder_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "ROMs folder";
            // 
            // TxtRomExt
            // 
            this.TxtRomExt.Location = new System.Drawing.Point(159, 99);
            this.TxtRomExt.Name = "TxtRomExt";
            this.TxtRomExt.Size = new System.Drawing.Size(265, 22);
            this.TxtRomExt.TabIndex = 7;
            this.TxtRomExt.Enter += new System.EventHandler(this.TxtRomExt_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "ROM extensions";
            // 
            // TxtGlobalParams
            // 
            this.TxtGlobalParams.Location = new System.Drawing.Point(159, 127);
            this.TxtGlobalParams.Name = "TxtGlobalParams";
            this.TxtGlobalParams.Size = new System.Drawing.Size(265, 22);
            this.TxtGlobalParams.TabIndex = 9;
            this.TxtGlobalParams.Enter += new System.EventHandler(this.TxtGlobalParams_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Global params";
            // 
            // TxtExtParams
            // 
            this.TxtExtParams.Location = new System.Drawing.Point(159, 155);
            this.TxtExtParams.Name = "TxtExtParams";
            this.TxtExtParams.Size = new System.Drawing.Size(265, 22);
            this.TxtExtParams.TabIndex = 11;
            this.TxtExtParams.Enter += new System.EventHandler(this.TxtExtParams_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Params by extension";
            // 
            // TxtImageFile
            // 
            this.TxtImageFile.Location = new System.Drawing.Point(159, 183);
            this.TxtImageFile.Name = "TxtImageFile";
            this.TxtImageFile.Size = new System.Drawing.Size(221, 22);
            this.TxtImageFile.TabIndex = 13;
            this.TxtImageFile.Enter += new System.EventHandler(this.TxtImageFile_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Image file";
            // 
            // BtnPath
            // 
            this.BtnPath.Image = global::EmuLauncher.Properties.Resources.folder;
            this.BtnPath.Location = new System.Drawing.Point(386, 43);
            this.BtnPath.Name = "BtnPath";
            this.BtnPath.Size = new System.Drawing.Size(37, 22);
            this.BtnPath.TabIndex = 16;
            this.BtnPath.UseVisualStyleBackColor = true;
            this.BtnPath.Click += new System.EventHandler(this.BtnPath_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Image = global::EmuLauncher.Properties.Resources.cross;
            this.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancel.Location = new System.Drawing.Point(226, 228);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(198, 38);
            this.BtnCancel.TabIndex = 15;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSave.Image = global::EmuLauncher.Properties.Resources.disk;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(15, 228);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(198, 38);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Save";
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnRomFolder
            // 
            this.BtnRomFolder.Image = global::EmuLauncher.Properties.Resources.folder;
            this.BtnRomFolder.Location = new System.Drawing.Point(386, 71);
            this.BtnRomFolder.Name = "BtnRomFolder";
            this.BtnRomFolder.Size = new System.Drawing.Size(37, 22);
            this.BtnRomFolder.TabIndex = 17;
            this.BtnRomFolder.UseVisualStyleBackColor = true;
            this.BtnRomFolder.Click += new System.EventHandler(this.BtnRomFolder_Click);
            // 
            // BtnImageFile
            // 
            this.BtnImageFile.Image = global::EmuLauncher.Properties.Resources.folder;
            this.BtnImageFile.Location = new System.Drawing.Point(386, 183);
            this.BtnImageFile.Name = "BtnImageFile";
            this.BtnImageFile.Size = new System.Drawing.Size(37, 22);
            this.BtnImageFile.TabIndex = 18;
            this.BtnImageFile.UseVisualStyleBackColor = true;
            this.BtnImageFile.Click += new System.EventHandler(this.BtnImageFile_Click);
            // 
            // GrInstructions
            // 
            this.GrInstructions.Controls.Add(this.TxtInstructions);
            this.GrInstructions.Location = new System.Drawing.Point(441, 7);
            this.GrInstructions.Name = "GrInstructions";
            this.GrInstructions.Size = new System.Drawing.Size(218, 259);
            this.GrInstructions.TabIndex = 19;
            this.GrInstructions.TabStop = false;
            this.GrInstructions.Text = "Info";
            // 
            // TxtInstructions
            // 
            this.TxtInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInstructions.Location = new System.Drawing.Point(12, 25);
            this.TxtInstructions.Multiline = true;
            this.TxtInstructions.Name = "TxtInstructions";
            this.TxtInstructions.ReadOnly = true;
            this.TxtInstructions.Size = new System.Drawing.Size(194, 220);
            this.TxtInstructions.TabIndex = 1;
            this.TxtInstructions.Text = "Info about focused field";
            // 
            // SystemEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 280);
            this.Controls.Add(this.GrInstructions);
            this.Controls.Add(this.BtnImageFile);
            this.Controls.Add(this.BtnRomFolder);
            this.Controls.Add(this.BtnPath);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtImageFile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtExtParams);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtGlobalParams);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtRomExt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtRomFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SystemEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemEditForm";
            this.GrInstructions.ResumeLayout(false);
            this.GrInstructions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtRomFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtRomExt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtGlobalParams;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtExtParams;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtImageFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnPath;
        private System.Windows.Forms.Button BtnRomFolder;
        private System.Windows.Forms.Button BtnImageFile;
        private System.Windows.Forms.GroupBox GrInstructions;
        private System.Windows.Forms.TextBox TxtInstructions;

    }
}