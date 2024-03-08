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
            MainMenuStrip = new MenuStrip();
            viewToolStripMenuItem = new ToolStripMenuItem();
            toggleDarkModeToolStripMenuItem = new ToolStripMenuItem();
            TextBox = new RichTextBox();
            MainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { viewToolStripMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(452, 24);
            MainMenuStrip.TabIndex = 0;
            MainMenuStrip.Text = "menuStrip1";
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
            toggleDarkModeToolStripMenuItem.Size = new Size(170, 22);
            toggleDarkModeToolStripMenuItem.Text = "Toggle Dark Mode";
            toggleDarkModeToolStripMenuItem.Click += toggleDarkModeToolStripMenuItem_Click;
            // 
            // TextBox
            // 
            TextBox.Location = new Point(48, 50);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(346, 202);
            TextBox.TabIndex = 1;
            TextBox.Text = "";
            // 
            // DarkMode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 312);
            Controls.Add(TextBox);
            Controls.Add(MainMenuStrip);
            Name = "DarkMode";
            Text = "DarkMode";
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem toggleDarkModeToolStripMenuItem;
        private RichTextBox TextBox;
    }
}