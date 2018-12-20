namespace Crestelia.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.fraSettings = new System.Windows.Forms.GroupBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutputFormat = new System.Windows.Forms.Label();
            this.txtOutputFormat = new System.Windows.Forms.TextBox();
            this.lblOutputPath = new System.Windows.Forms.Label();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.lblColumns = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.numericX = new System.Windows.Forms.NumericUpDown();
            this.numericY = new System.Windows.Forms.NumericUpDown();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.prgProgress = new System.Windows.Forms.ProgressBar();
            this.menuMain.SuspendLayout();
            this.fraSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(346, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(92, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // fraSettings
            // 
            this.fraSettings.Controls.Add(this.btnSplit);
            this.fraSettings.Controls.Add(this.label1);
            this.fraSettings.Controls.Add(this.lblOutputFormat);
            this.fraSettings.Controls.Add(this.txtOutputFormat);
            this.fraSettings.Controls.Add(this.lblOutputPath);
            this.fraSettings.Controls.Add(this.txtOutputPath);
            this.fraSettings.Controls.Add(this.lblColumns);
            this.fraSettings.Controls.Add(this.lblRows);
            this.fraSettings.Controls.Add(this.lblFile);
            this.fraSettings.Controls.Add(this.numericX);
            this.fraSettings.Controls.Add(this.numericY);
            this.fraSettings.Controls.Add(this.txtFile);
            this.fraSettings.Controls.Add(this.prgProgress);
            this.fraSettings.Location = new System.Drawing.Point(12, 27);
            this.fraSettings.Name = "fraSettings";
            this.fraSettings.Size = new System.Drawing.Size(323, 268);
            this.fraSettings.TabIndex = 1;
            this.fraSettings.TabStop = false;
            this.fraSettings.Text = "Settings";
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(224, 32);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(93, 23);
            this.btnSplit.TabIndex = 14;
            this.btnSplit.Text = "Split Image";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 104);
            this.label1.TabIndex = 13;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // lblOutputFormat
            // 
            this.lblOutputFormat.AutoSize = true;
            this.lblOutputFormat.Location = new System.Drawing.Point(6, 122);
            this.lblOutputFormat.Name = "lblOutputFormat";
            this.lblOutputFormat.Size = new System.Drawing.Size(123, 14);
            this.lblOutputFormat.TabIndex = 12;
            this.lblOutputFormat.Text = "Output File Format:";
            // 
            // txtOutputFormat
            // 
            this.txtOutputFormat.Location = new System.Drawing.Point(9, 139);
            this.txtOutputFormat.Name = "txtOutputFormat";
            this.txtOutputFormat.Size = new System.Drawing.Size(209, 20);
            this.txtOutputFormat.TabIndex = 11;
            this.txtOutputFormat.Text = "%f-%r-%c.%ext";
            // 
            // lblOutputPath
            // 
            this.lblOutputPath.AutoSize = true;
            this.lblOutputPath.Location = new System.Drawing.Point(6, 82);
            this.lblOutputPath.Name = "lblOutputPath";
            this.lblOutputPath.Size = new System.Drawing.Size(92, 14);
            this.lblOutputPath.TabIndex = 10;
            this.lblOutputPath.Text = "Output Folder:";
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(9, 99);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(209, 20);
            this.txtOutputPath.TabIndex = 9;
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(104, 61);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(58, 14);
            this.lblColumns.TabIndex = 8;
            this.lblColumns.Text = "Columns";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(6, 61);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(36, 14);
            this.lblRows.TabIndex = 7;
            this.lblRows.Text = "Rows";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(6, 16);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(62, 14);
            this.lblFile.TabIndex = 6;
            this.lblFile.Text = "File Path:";
            // 
            // numericX
            // 
            this.numericX.Location = new System.Drawing.Point(48, 59);
            this.numericX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericX.Name = "numericX";
            this.numericX.Size = new System.Drawing.Size(50, 20);
            this.numericX.TabIndex = 5;
            this.numericX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericY
            // 
            this.numericY.Location = new System.Drawing.Point(168, 59);
            this.numericY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericY.Name = "numericY";
            this.numericY.Size = new System.Drawing.Size(50, 20);
            this.numericY.TabIndex = 4;
            this.numericY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(9, 33);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(209, 20);
            this.txtFile.TabIndex = 3;
            this.txtFile.Validated += new System.EventHandler(this.txtFile_Validated);
            // 
            // prgProgress
            // 
            this.prgProgress.Location = new System.Drawing.Point(224, 33);
            this.prgProgress.Name = "prgProgress";
            this.prgProgress.Size = new System.Drawing.Size(93, 22);
            this.prgProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgProgress.TabIndex = 15;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 305);
            this.Controls.Add(this.fraSettings);
            this.Controls.Add(this.menuMain);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crestelia";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.fraSettings.ResumeLayout(false);
            this.fraSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox fraSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOutputFormat;
        private System.Windows.Forms.TextBox txtOutputFormat;
        private System.Windows.Forms.Label lblOutputPath;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.NumericUpDown numericX;
        private System.Windows.Forms.NumericUpDown numericY;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.ProgressBar prgProgress;
        private System.Windows.Forms.Button btnSplit;
    }
}