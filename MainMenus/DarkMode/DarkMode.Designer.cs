namespace CodeChum
{
    partial class DarkMode
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
            viewToolStripMenuItem = new ToolStripMenuItem();
            toggleDarkModeToolStripMenuItem = new ToolStripMenuItem();
            richTextBox = new RichTextBox();
            mainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(452, 24);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toggleDarkModeToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // toggleDarkModeToolStripMenuItem
            // 
            toggleDarkModeToolStripMenuItem.Name = "toggleDarkModeToolStripMenuItem";
            toggleDarkModeToolStripMenuItem.Size = new Size(180, 22);
            toggleDarkModeToolStripMenuItem.Text = "Toggle Dark Mode";
            toggleDarkModeToolStripMenuItem.Click += toggleDarkModeToolStripMenuItem_Click;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(48, 50);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(346, 202);
            richTextBox.TabIndex = 1;
            richTextBox.Text = "";
            // 
            // DarkMode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 312);
            Controls.Add(richTextBox);
            Controls.Add(mainMenuStrip);
            Name = "DarkMode";
            Text = "DarkMode";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem toggleDarkModeToolStripMenuItem;
        private RichTextBox richTextBox;
    }
}