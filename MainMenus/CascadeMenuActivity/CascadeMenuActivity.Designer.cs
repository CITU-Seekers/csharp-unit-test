namespace CodeChum
{
    partial class CascadeMenuActivity
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
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontColorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GreenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BlueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.FormatMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(542, 28);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.OpenMenuItem,
            this.SaveMenuItem,
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(46, 24);
            this.FileMenuItem.Text = "File";
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.Size = new System.Drawing.Size(128, 26);
            this.NewMenuItem.Text = "New";
            this.NewMenuItem.Click += new System.EventHandler(this.displayText);
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(128, 26);
            this.OpenMenuItem.Text = "Open";
            this.OpenMenuItem.Click += new System.EventHandler(this.displayText);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(128, 26);
            this.SaveMenuItem.Text = "Save";
            this.SaveMenuItem.Click += new System.EventHandler(this.displayText);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(128, 26);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.displayText);
            // 
            // FormatMenuItem
            // 
            this.FormatMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontColorMenuItem});
            this.FormatMenuItem.Name = "FormatMenuItem";
            this.FormatMenuItem.Size = new System.Drawing.Size(70, 24);
            this.FormatMenuItem.Text = "Format";
            // 
            // FontColorMenuItem
            // 
            this.FontColorMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RedMenuItem,
            this.GreenMenuItem,
            this.BlueMenuItem});
            this.FontColorMenuItem.Name = "FontColorMenuItem";
            this.FontColorMenuItem.Size = new System.Drawing.Size(224, 26);
            this.FontColorMenuItem.Text = "Font Color";
            // 
            // RedMenuItem
            // 
            this.RedMenuItem.Name = "RedMenuItem";
            this.RedMenuItem.Size = new System.Drawing.Size(224, 26);
            this.RedMenuItem.Text = "Red";
            this.RedMenuItem.Click += new System.EventHandler(this.changeColor);
            // 
            // GreenMenuItem
            // 
            this.GreenMenuItem.Name = "GreenMenuItem";
            this.GreenMenuItem.Size = new System.Drawing.Size(224, 26);
            this.GreenMenuItem.Text = "Green";
            this.GreenMenuItem.Click += new System.EventHandler(this.changeColor);
            // 
            // BlueMenuItem
            // 
            this.BlueMenuItem.Name = "BlueMenuItem";
            this.BlueMenuItem.Size = new System.Drawing.Size(224, 26);
            this.BlueMenuItem.Text = "Blue";
            this.BlueMenuItem.Click += new System.EventHandler(this.changeColor);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.Location = new System.Drawing.Point(163, 87);
            this.StatusLabel.MaximumSize = new System.Drawing.Size(100, 100);
            this.StatusLabel.MinimumSize = new System.Drawing.Size(200, 50);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(200, 50);
            this.StatusLabel.TabIndex = 1;
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CascadeMenuActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 234);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "CascadeMenuActivity";
            this.Text = "Cascade Menu Activity";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem NewMenuItem;
        private ToolStripMenuItem OpenMenuItem;
        private ToolStripMenuItem SaveMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private Label StatusLabel;
        private ToolStripMenuItem FormatMenuItem;
        private ToolStripMenuItem FontColorMenuItem;
        private ToolStripMenuItem RedMenuItem;
        private ToolStripMenuItem GreenMenuItem;
        private ToolStripMenuItem BlueMenuItem;
    }
}