namespace CodeChum
{
    partial class ToolStripTextEditor
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
            this.EditorToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.FontComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.FontSizeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.UnderlineButton = new System.Windows.Forms.ToolStripButton();
            this.BoldButton = new System.Windows.Forms.ToolStripButton();
            this.ItalicButton = new System.Windows.Forms.ToolStripButton();
            this.MainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.EditorToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditorToolStrip
            // 
            this.EditorToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.EditorToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.FontComboBox,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.FontSizeComboBox,
            this.toolStripSeparator2,
            this.UnderlineButton,
            this.BoldButton,
            this.ItalicButton});
            this.EditorToolStrip.Location = new System.Drawing.Point(0, 0);
            this.EditorToolStrip.Name = "EditorToolStrip";
            this.EditorToolStrip.Size = new System.Drawing.Size(584, 28);
            this.EditorToolStrip.TabIndex = 0;
            this.EditorToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(41, 25);
            this.toolStripLabel1.Text = "Font:";
            // 
            // FontComboBox
            // 
            this.FontComboBox.Items.AddRange(new object[] {
            "Arial",
            "Cascadia Code",
            "Segoe UI",
            "Tahoma",
            "Verdana"});
            this.FontComboBox.Name = "FontComboBox";
            this.FontComboBox.Size = new System.Drawing.Size(121, 28);
            this.FontComboBox.SelectedIndexChanged += new System.EventHandler(this.fontPropertySelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(72, 25);
            this.toolStripLabel2.Text = "Font Size:";
            // 
            // FontSizeComboBox
            // 
            this.FontSizeComboBox.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16"});
            this.FontSizeComboBox.Name = "FontSizeComboBox";
            this.FontSizeComboBox.Size = new System.Drawing.Size(121, 28);
            this.FontSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.fontPropertySelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // UnderlineButton
            // 
            this.UnderlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnderlineButton.Image = global::CodeChum.Properties.Resources.underline;
            this.UnderlineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderlineButton.Name = "UnderlineButton";
            this.UnderlineButton.Size = new System.Drawing.Size(29, 25);
            this.UnderlineButton.Text = "Underline";
            this.UnderlineButton.Click += new System.EventHandler(this.buttonClick);
            // 
            // BoldButton
            // 
            this.BoldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoldButton.Image = global::CodeChum.Properties.Resources.bold;
            this.BoldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldButton.Name = "BoldButton";
            this.BoldButton.Size = new System.Drawing.Size(29, 25);
            this.BoldButton.Text = "Bold";
            this.BoldButton.Click += new System.EventHandler(this.buttonClick);
            // 
            // ItalicButton
            // 
            this.ItalicButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItalicButton.Image = global::CodeChum.Properties.Resources.italic;
            this.ItalicButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicButton.Name = "ItalicButton";
            this.ItalicButton.Size = new System.Drawing.Size(29, 25);
            this.ItalicButton.Text = "Italic";
            this.ItalicButton.Click += new System.EventHandler(this.buttonClick);
            // 
            // MainRichTextBox
            // 
            this.MainRichTextBox.Location = new System.Drawing.Point(31, 48);
            this.MainRichTextBox.Name = "MainRichTextBox";
            this.MainRichTextBox.Size = new System.Drawing.Size(525, 214);
            this.MainRichTextBox.TabIndex = 1;
            this.MainRichTextBox.Text = "";
            // 
            // ToolStripActivity1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 292);
            this.Controls.Add(this.MainRichTextBox);
            this.Controls.Add(this.EditorToolStrip);
            this.Name = "ToolStripActivity1";
            this.Text = "ToolStrip Activity";
            this.EditorToolStrip.ResumeLayout(false);
            this.EditorToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip EditorToolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox FontComboBox;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripComboBox FontSizeComboBox;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton UnderlineButton;
        private ToolStripButton BoldButton;
        private ToolStripButton ItalicButton;
        private RichTextBox MainRichTextBox;
    }
}