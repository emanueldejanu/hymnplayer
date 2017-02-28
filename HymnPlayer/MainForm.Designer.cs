namespace HymnPlayer
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numStartHymn = new System.Windows.Forms.NumericUpDown();
            this.numEndHymn = new System.Windows.Forms.NumericUpDown();
            this.btnNumber1 = new System.Windows.Forms.Button();
            this.btnNumber2 = new System.Windows.Forms.Button();
            this.btnNumber3 = new System.Windows.Forms.Button();
            this.btnNumber4 = new System.Windows.Forms.Button();
            this.btnNumber5 = new System.Windows.Forms.Button();
            this.btnNumber6 = new System.Windows.Forms.Button();
            this.btnNumber8 = new System.Windows.Forms.Button();
            this.btnNumber9 = new System.Windows.Forms.Button();
            this.btnNumber7 = new System.Windows.Forms.Button();
            this.btnShowStartHymn = new System.Windows.Forms.Button();
            this.btnNumber0 = new System.Windows.Forms.Button();
            this.btnShowEndHymn = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuHymns = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowStartHymn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowEndHymn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKeepWindowOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartHymn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndHymn)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 3);
            this.pictureBox1.Image = global::HymnPlayer.Properties.Resources.Hymn;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numStartHymn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numEndHymn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNumber1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNumber2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNumber3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNumber4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNumber5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNumber6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNumber8, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNumber9, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNumber7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnShowStartHymn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnNumber0, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnShowEndHymn, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(276, 466);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // numStartHymn
            // 
            this.numStartHymn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numStartHymn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numStartHymn.Location = new System.Drawing.Point(3, 137);
            this.numStartHymn.Maximum = new decimal(new int[] {
            920,
            0,
            0,
            0});
            this.numStartHymn.MinimumSize = new System.Drawing.Size(75, 0);
            this.numStartHymn.Name = "numStartHymn";
            this.numStartHymn.Size = new System.Drawing.Size(86, 30);
            this.numStartHymn.TabIndex = 1;
            this.numStartHymn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numStartHymn.Enter += new System.EventHandler(this.NumericControlActivated);
            // 
            // numEndHymn
            // 
            this.numEndHymn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numEndHymn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEndHymn.Location = new System.Drawing.Point(187, 137);
            this.numEndHymn.Maximum = new decimal(new int[] {
            920,
            0,
            0,
            0});
            this.numEndHymn.Name = "numEndHymn";
            this.numEndHymn.Size = new System.Drawing.Size(86, 30);
            this.numEndHymn.TabIndex = 2;
            this.numEndHymn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numEndHymn.Enter += new System.EventHandler(this.NumericControlActivated);
            // 
            // btnNumber1
            // 
            this.btnNumber1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber1.Location = new System.Drawing.Point(3, 173);
            this.btnNumber1.MinimumSize = new System.Drawing.Size(65, 65);
            this.btnNumber1.Name = "btnNumber1";
            this.btnNumber1.Size = new System.Drawing.Size(86, 65);
            this.btnNumber1.TabIndex = 3;
            this.btnNumber1.Text = "1";
            this.btnNumber1.UseVisualStyleBackColor = true;
            this.btnNumber1.Click += new System.EventHandler(this.KeyPadButtonClick);
            // 
            // btnNumber2
            // 
            this.btnNumber2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber2.Location = new System.Drawing.Point(95, 173);
            this.btnNumber2.MinimumSize = new System.Drawing.Size(65, 65);
            this.btnNumber2.Name = "btnNumber2";
            this.btnNumber2.Size = new System.Drawing.Size(86, 65);
            this.btnNumber2.TabIndex = 4;
            this.btnNumber2.Text = "2";
            this.btnNumber2.UseVisualStyleBackColor = true;
            this.btnNumber2.Click += new System.EventHandler(this.KeyPadButtonClick);
            // 
            // btnNumber3
            // 
            this.btnNumber3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber3.Location = new System.Drawing.Point(187, 173);
            this.btnNumber3.MinimumSize = new System.Drawing.Size(65, 65);
            this.btnNumber3.Name = "btnNumber3";
            this.btnNumber3.Size = new System.Drawing.Size(86, 65);
            this.btnNumber3.TabIndex = 5;
            this.btnNumber3.Text = "3";
            this.btnNumber3.UseVisualStyleBackColor = true;
            this.btnNumber3.Click += new System.EventHandler(this.KeyPadButtonClick);
            // 
            // btnNumber4
            // 
            this.btnNumber4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber4.Location = new System.Drawing.Point(3, 244);
            this.btnNumber4.MinimumSize = new System.Drawing.Size(65, 65);
            this.btnNumber4.Name = "btnNumber4";
            this.btnNumber4.Size = new System.Drawing.Size(86, 65);
            this.btnNumber4.TabIndex = 6;
            this.btnNumber4.Text = "4";
            this.btnNumber4.UseVisualStyleBackColor = true;
            this.btnNumber4.Click += new System.EventHandler(this.KeyPadButtonClick);
            // 
            // btnNumber5
            // 
            this.btnNumber5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber5.Location = new System.Drawing.Point(95, 244);
            this.btnNumber5.MinimumSize = new System.Drawing.Size(65, 65);
            this.btnNumber5.Name = "btnNumber5";
            this.btnNumber5.Size = new System.Drawing.Size(86, 65);
            this.btnNumber5.TabIndex = 7;
            this.btnNumber5.Text = "5";
            this.btnNumber5.UseVisualStyleBackColor = true;
            this.btnNumber5.Click += new System.EventHandler(this.KeyPadButtonClick);
            // 
            // btnNumber6
            // 
            this.btnNumber6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber6.Location = new System.Drawing.Point(187, 244);
            this.btnNumber6.MinimumSize = new System.Drawing.Size(65, 65);
            this.btnNumber6.Name = "btnNumber6";
            this.btnNumber6.Size = new System.Drawing.Size(86, 65);
            this.btnNumber6.TabIndex = 8;
            this.btnNumber6.Text = "6";
            this.btnNumber6.UseVisualStyleBackColor = true;
            this.btnNumber6.Click += new System.EventHandler(this.KeyPadButtonClick);
            // 
            // btnNumber8
            // 
            this.btnNumber8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber8.Location = new System.Drawing.Point(95, 315);
            this.btnNumber8.MinimumSize = new System.Drawing.Size(65, 65);
            this.btnNumber8.Name = "btnNumber8";
            this.btnNumber8.Size = new System.Drawing.Size(86, 65);
            this.btnNumber8.TabIndex = 10;
            this.btnNumber8.Text = "8";
            this.btnNumber8.UseVisualStyleBackColor = true;
            this.btnNumber8.Click += new System.EventHandler(this.KeyPadButtonClick);
            // 
            // btnNumber9
            // 
            this.btnNumber9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber9.Location = new System.Drawing.Point(187, 315);
            this.btnNumber9.MinimumSize = new System.Drawing.Size(65, 65);
            this.btnNumber9.Name = "btnNumber9";
            this.btnNumber9.Size = new System.Drawing.Size(86, 65);
            this.btnNumber9.TabIndex = 11;
            this.btnNumber9.Text = "9";
            this.btnNumber9.UseVisualStyleBackColor = true;
            this.btnNumber9.Click += new System.EventHandler(this.KeyPadButtonClick);
            // 
            // btnNumber7
            // 
            this.btnNumber7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber7.Location = new System.Drawing.Point(3, 315);
            this.btnNumber7.MinimumSize = new System.Drawing.Size(65, 65);
            this.btnNumber7.Name = "btnNumber7";
            this.btnNumber7.Size = new System.Drawing.Size(86, 65);
            this.btnNumber7.TabIndex = 9;
            this.btnNumber7.Text = "7";
            this.btnNumber7.UseVisualStyleBackColor = true;
            this.btnNumber7.Click += new System.EventHandler(this.KeyPadButtonClick);
            // 
            // btnShowStartHymn
            // 
            this.btnShowStartHymn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowStartHymn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowStartHymn.Location = new System.Drawing.Point(3, 386);
            this.btnShowStartHymn.MinimumSize = new System.Drawing.Size(65, 65);
            this.btnShowStartHymn.Name = "btnShowStartHymn";
            this.btnShowStartHymn.Size = new System.Drawing.Size(86, 65);
            this.btnShowStartHymn.TabIndex = 12;
            this.btnShowStartHymn.Text = "Început";
            this.btnShowStartHymn.UseVisualStyleBackColor = true;
            this.btnShowStartHymn.Click += new System.EventHandler(this.ShowStartHymnClick);
            // 
            // btnNumber0
            // 
            this.btnNumber0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNumber0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumber0.Location = new System.Drawing.Point(95, 386);
            this.btnNumber0.MinimumSize = new System.Drawing.Size(65, 65);
            this.btnNumber0.Name = "btnNumber0";
            this.btnNumber0.Size = new System.Drawing.Size(86, 65);
            this.btnNumber0.TabIndex = 13;
            this.btnNumber0.Text = "0";
            this.btnNumber0.UseVisualStyleBackColor = true;
            this.btnNumber0.Click += new System.EventHandler(this.KeyPadButtonClick);
            // 
            // btnShowEndHymn
            // 
            this.btnShowEndHymn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowEndHymn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowEndHymn.Location = new System.Drawing.Point(187, 386);
            this.btnShowEndHymn.MinimumSize = new System.Drawing.Size(65, 65);
            this.btnShowEndHymn.Name = "btnShowEndHymn";
            this.btnShowEndHymn.Size = new System.Drawing.Size(86, 65);
            this.btnShowEndHymn.TabIndex = 14;
            this.btnShowEndHymn.Text = "Sfârșit";
            this.btnShowEndHymn.UseVisualStyleBackColor = true;
            this.btnShowEndHymn.Click += new System.EventHandler(this.ShowEndHymnClick);
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHymns,
            this.mnuOptions,
            this.mnuHelp});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(276, 28);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "mainMenu";
            // 
            // mnuHymns
            // 
            this.mnuHymns.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShowStartHymn,
            this.mnuShowEndHymn,
            this.toolStripSeparator1,
            this.mnuExit});
            this.mnuHymns.Name = "mnuHymns";
            this.mnuHymns.Size = new System.Drawing.Size(63, 24);
            this.mnuHymns.Text = "Imnuri";
            // 
            // mnuShowStartHymn
            // 
            this.mnuShowStartHymn.Name = "mnuShowStartHymn";
            this.mnuShowStartHymn.Size = new System.Drawing.Size(256, 26);
            this.mnuShowStartHymn.Text = "Pornește imnul de început";
            this.mnuShowStartHymn.Click += new System.EventHandler(this.ShowStartHymnClick);
            // 
            // mnuShowEndHymn
            // 
            this.mnuShowEndHymn.Name = "mnuShowEndHymn";
            this.mnuShowEndHymn.Size = new System.Drawing.Size(256, 26);
            this.mnuShowEndHymn.Text = "Pornește imnul de sfârșit";
            this.mnuShowEndHymn.Click += new System.EventHandler(this.ShowEndHymnClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(253, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(256, 26);
            this.mnuExit.Text = "Închide aplicația";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKeepWindowOnTop});
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(74, 24);
            this.mnuOptions.Text = "&Opțiunii";
            // 
            // mnuKeepWindowOnTop
            // 
            this.mnuKeepWindowOnTop.Checked = true;
            this.mnuKeepWindowOnTop.CheckOnClick = true;
            this.mnuKeepWindowOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuKeepWindowOnTop.Name = "mnuKeepWindowOnTop";
            this.mnuKeepWindowOnTop.Size = new System.Drawing.Size(239, 26);
            this.mnuKeepWindowOnTop.Text = "Ține fereastra deasupra";
            this.mnuKeepWindowOnTop.Click += new System.EventHandler(this.mnuKeepWindowOnTop_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(62, 24);
            this.mnuHelp.Text = "&Ajutor";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(181, 26);
            this.mnuAbout.Text = "&Despre";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 494);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Hymn Player";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartHymn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndHymn)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown numStartHymn;
        private System.Windows.Forms.NumericUpDown numEndHymn;
        private System.Windows.Forms.Button btnNumber1;
        private System.Windows.Forms.Button btnNumber2;
        private System.Windows.Forms.Button btnNumber3;
        private System.Windows.Forms.Button btnNumber4;
        private System.Windows.Forms.Button btnNumber5;
        private System.Windows.Forms.Button btnNumber6;
        private System.Windows.Forms.Button btnNumber8;
        private System.Windows.Forms.Button btnNumber9;
        private System.Windows.Forms.Button btnNumber7;
        private System.Windows.Forms.Button btnShowStartHymn;
        private System.Windows.Forms.Button btnNumber0;
        private System.Windows.Forms.Button btnShowEndHymn;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuHymns;
        private System.Windows.Forms.ToolStripMenuItem mnuShowStartHymn;
        private System.Windows.Forms.ToolStripMenuItem mnuShowEndHymn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuKeepWindowOnTop;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
    }
}

