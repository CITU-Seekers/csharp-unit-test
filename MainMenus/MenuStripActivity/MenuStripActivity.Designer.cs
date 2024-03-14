namespace CodeChum
{
    partial class MenuStripActivity
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
            mainMenuStrip = new MenuStrip();
            fileMenuItem = new ToolStripMenuItem();
            newMenuItem = new ToolStripMenuItem();
            openMenuItem = new ToolStripMenuItem();
            saveMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            statusLabel = new Label();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.ImageScalingSize = new Size(20, 20);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { fileMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Padding = new Padding(5, 2, 0, 2);
            mainMenuStrip.Size = new Size(474, 24);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            fileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newMenuItem, openMenuItem, saveMenuItem, exitMenuItem });
            fileMenuItem.Name = "fileMenuItem";
            fileMenuItem.Size = new Size(37, 20);
            fileMenuItem.Text = "File";
            fileMenuItem.Click += fileMenuItem_Click;
            // 
            // newMenuItem
            // 
            newMenuItem.Name = "newMenuItem";
            newMenuItem.Size = new Size(180, 22);
            newMenuItem.Text = "New";
            newMenuItem.Click += displayText;
            // 
            // openMenuItem
            // 
            openMenuItem.Name = "openMenuItem";
            openMenuItem.Size = new Size(180, 22);
            openMenuItem.Text = "Open";
            openMenuItem.Click += displayText;
            // 
            // saveMenuItem
            // 
            saveMenuItem.Name = "saveMenuItem";
            saveMenuItem.Size = new Size(180, 22);
            saveMenuItem.Text = "Save";
            saveMenuItem.Click += displayText;
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(180, 22);
            exitMenuItem.Text = "Exit";
            exitMenuItem.Click += displayText;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            statusLabel.Location = new Point(143, 65);
            statusLabel.MaximumSize = new Size(88, 75);
            statusLabel.MinimumSize = new Size(175, 38);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(175, 38);
            statusLabel.TabIndex = 1;
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MenuStripActivity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 176);
            Controls.Add(statusLabel);
            Controls.Add(mainMenuStrip);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuStripActivity";
            Text = "Menu Strip Activity";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem fileMenuItem;
        private ToolStripMenuItem newMenuItem;
        private ToolStripMenuItem openMenuItem;
        private ToolStripMenuItem saveMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private Label statusLabel;
    }
}