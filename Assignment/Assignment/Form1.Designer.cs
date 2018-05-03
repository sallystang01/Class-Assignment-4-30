namespace Assignment
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbNames = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.msTop = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarySearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbInputBin = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.msTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNames
            // 
            this.lbNames.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNames.FormattingEnabled = true;
            this.lbNames.ItemHeight = 12;
            this.lbNames.Location = new System.Drawing.Point(12, 83);
            this.lbNames.Name = "lbNames";
            this.lbNames.Size = new System.Drawing.Size(261, 124);
            this.lbNames.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(111, 313);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(12, 57);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(261, 20);
            this.tbInput.TabIndex = 4;
            this.tbInput.Visible = false;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(260, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Enter a Name:";
            this.lblName.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Location = new System.Drawing.Point(12, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 82);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(9, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(242, 66);
            this.lblTime.TabIndex = 8;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // msTop
            // 
            this.msTop.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modeToolStripMenuItem});
            this.msTop.Location = new System.Drawing.Point(0, 0);
            this.msTop.Name = "msTop";
            this.msTop.Size = new System.Drawing.Size(284, 24);
            this.msTop.TabIndex = 9;
            this.msTop.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.sortResultsToolStripMenuItem,
            this.exportFileToolStripMenuItem,
            this.restartToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadFileToolStripMenuItem.Text = "&Load File";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // sortResultsToolStripMenuItem
            // 
            this.sortResultsToolStripMenuItem.Enabled = false;
            this.sortResultsToolStripMenuItem.Name = "sortResultsToolStripMenuItem";
            this.sortResultsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sortResultsToolStripMenuItem.Text = "&Sort Results";
            this.sortResultsToolStripMenuItem.Click += new System.EventHandler(this.sortResultsToolStripMenuItem_Click);
            // 
            // exportFileToolStripMenuItem
            // 
            this.exportFileToolStripMenuItem.Enabled = false;
            this.exportFileToolStripMenuItem.Name = "exportFileToolStripMenuItem";
            this.exportFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportFileToolStripMenuItem.Text = "E&xport File";
            this.exportFileToolStripMenuItem.Click += new System.EventHandler(this.exportFileToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restartToolStripMenuItem.Text = "&Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarySearchToolStripMenuItem,
            this.regularSearchToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.modeToolStripMenuItem.Text = "&Mode";
            // 
            // binarySearchToolStripMenuItem
            // 
            this.binarySearchToolStripMenuItem.Name = "binarySearchToolStripMenuItem";
            this.binarySearchToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.binarySearchToolStripMenuItem.Text = "&Binary Search";
            this.binarySearchToolStripMenuItem.Click += new System.EventHandler(this.binarySearchToolStripMenuItem_Click);
            // 
            // regularSearchToolStripMenuItem
            // 
            this.regularSearchToolStripMenuItem.Name = "regularSearchToolStripMenuItem";
            this.regularSearchToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.regularSearchToolStripMenuItem.Text = "&Regular Search";
            this.regularSearchToolStripMenuItem.Click += new System.EventHandler(this.regularSearchToolStripMenuItem_Click);
            // 
            // tbInputBin
            // 
            this.tbInputBin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInputBin.Location = new System.Drawing.Point(14, 57);
            this.tbInputBin.Name = "tbInputBin";
            this.tbInputBin.Size = new System.Drawing.Size(259, 20);
            this.tbInputBin.TabIndex = 10;
            this.tbInputBin.Visible = false;
            this.tbInputBin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInputBin_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 348);
            this.Controls.Add(this.tbInputBin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbNames);
            this.Controls.Add(this.msTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msTop;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Name Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.msTop.ResumeLayout(false);
            this.msTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNames;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MenuStrip msTop;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binarySearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularSearchToolStripMenuItem;
        private System.Windows.Forms.TextBox tbInputBin;
    }
}

