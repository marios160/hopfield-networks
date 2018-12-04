namespace DMU.Samples
{
    partial class Main
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTrainDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWeightDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.x2MatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x3MatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x4MatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x5MatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x8MatrixToolStripMenuItem_ClicknuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x10MatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x16MatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.toolsMenu,
            this.windowsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1304, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTrainDataToolStripMenuItem,
            this.saveWeightDataToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(44, 24);
            this.fileMenu.Text = "&File";
            // 
            // loadTrainDataToolStripMenuItem
            // 
            this.loadTrainDataToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.loadTrainDataToolStripMenuItem.Name = "loadTrainDataToolStripMenuItem";
            this.loadTrainDataToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadTrainDataToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.loadTrainDataToolStripMenuItem.Text = "L&oad Train Data";
            this.loadTrainDataToolStripMenuItem.Click += new System.EventHandler(this.loadTrainDataToolStripMenuItem_Click);
            // 
            // saveWeightDataToolStripMenuItem
            // 
            this.saveWeightDataToolStripMenuItem.Name = "saveWeightDataToolStripMenuItem";
            this.saveWeightDataToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.saveWeightDataToolStripMenuItem.Text = "&Save Pattern";
            this.saveWeightDataToolStripMenuItem.Click += new System.EventHandler(this.saveWeightDataToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(240, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x2MatrixToolStripMenuItem,
            this.x3MatrixToolStripMenuItem,
            this.x4MatrixToolStripMenuItem,
            this.x5MatrixToolStripMenuItem,
            this.x8MatrixToolStripMenuItem_ClicknuItem,
            this.x10MatrixToolStripMenuItem,
            this.x16MatrixToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(101, 24);
            this.toolsMenu.Text = "Recognition";
            // 
            // x2MatrixToolStripMenuItem
            // 
            this.x2MatrixToolStripMenuItem.Name = "x2MatrixToolStripMenuItem";
            this.x2MatrixToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.x2MatrixToolStripMenuItem.Text = "2 x 2 Matrix";
            this.x2MatrixToolStripMenuItem.Click += new System.EventHandler(this.x2MatrixToolStripMenuItem_Click);
            // 
            // x3MatrixToolStripMenuItem
            // 
            this.x3MatrixToolStripMenuItem.Name = "x3MatrixToolStripMenuItem";
            this.x3MatrixToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.x3MatrixToolStripMenuItem.Text = "3 x 3 Matrix";
            this.x3MatrixToolStripMenuItem.Click += new System.EventHandler(this.x3MatrixToolStripMenuItem_Click);
            // 
            // x4MatrixToolStripMenuItem
            // 
            this.x4MatrixToolStripMenuItem.Name = "x4MatrixToolStripMenuItem";
            this.x4MatrixToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.x4MatrixToolStripMenuItem.Text = "4 x 4 Matrix";
            this.x4MatrixToolStripMenuItem.Click += new System.EventHandler(this.x4MatrixToolStripMenuItem_Click);
            // 
            // x5MatrixToolStripMenuItem
            // 
            this.x5MatrixToolStripMenuItem.Name = "x5MatrixToolStripMenuItem";
            this.x5MatrixToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.x5MatrixToolStripMenuItem.Text = "5 x 5 Matrix";
            this.x5MatrixToolStripMenuItem.Click += new System.EventHandler(this.x5MatrixToolStripMenuItem_Click);
            // 
            // x8MatrixToolStripMenuItem_ClicknuItem
            // 
            this.x8MatrixToolStripMenuItem_ClicknuItem.Name = "x8MatrixToolStripMenuItem_ClicknuItem";
            this.x8MatrixToolStripMenuItem_ClicknuItem.Size = new System.Drawing.Size(181, 26);
            this.x8MatrixToolStripMenuItem_ClicknuItem.Text = "8 x 8 Matrix";
            this.x8MatrixToolStripMenuItem_ClicknuItem.Click += new System.EventHandler(this.x8MatrixToolStripMenuItem_Click);
            // 
            // x10MatrixToolStripMenuItem
            // 
            this.x10MatrixToolStripMenuItem.Name = "x10MatrixToolStripMenuItem";
            this.x10MatrixToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.x10MatrixToolStripMenuItem.Text = "10 x 10 Matrix";
            this.x10MatrixToolStripMenuItem.Click += new System.EventHandler(this.x10MatrixToolStripMenuItem_Click);
            // 
            // x16MatrixToolStripMenuItem
            // 
            this.x16MatrixToolStripMenuItem.Name = "x16MatrixToolStripMenuItem";
            this.x16MatrixToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.x16MatrixToolStripMenuItem.Text = "16 x 16 Matrix";
            this.x16MatrixToolStripMenuItem.Click += new System.EventHandler(this.x16MatrixToolStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeAllToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(82, 24);
            this.windowsMenu.Text = "&Windows";
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.closeAllToolStripMenuItem.Text = "C&lose All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 798);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1304, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 823);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem loadTrainDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem x8MatrixToolStripMenuItem_ClicknuItem;
        private System.Windows.Forms.ToolStripMenuItem x16MatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWeightDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x4MatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x3MatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x2MatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x5MatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x10MatrixToolStripMenuItem;
    }
}



