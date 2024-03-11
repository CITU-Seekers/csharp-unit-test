using ToolStripTextEditor.Properties;

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
            EditorToolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            FontComboBox = new ToolStripComboBox();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripLabel();
            FontSizeComboBox = new ToolStripComboBox();
            toolStripSeparator2 = new ToolStripSeparator();
            UnderlineButton = new ToolStripButton();
            BoldButton = new ToolStripButton();
            ItalicButton = new ToolStripButton();
            MainRichTextBox = new RichTextBox();
            EditorToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // EditorToolStrip
            // 
            EditorToolStrip.ImageScalingSize = new Size(20, 20);
            EditorToolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, FontComboBox, toolStripSeparator1, toolStripLabel2, FontSizeComboBox, toolStripSeparator2, UnderlineButton, BoldButton, ItalicButton });
            EditorToolStrip.Location = new Point(0, 0);
            EditorToolStrip.Name = "EditorToolStrip";
            EditorToolStrip.Size = new Size(511, 27);
            EditorToolStrip.TabIndex = 0;
            EditorToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(34, 24);
            toolStripLabel1.Text = "Font:";
            // 
            // FontComboBox
            // 
            FontComboBox.Items.AddRange(new object[] { "Arial", "Cascadia Code", "Segoe UI", "Tahoma", "Verdana" });
            FontComboBox.Name = "FontComboBox";
            FontComboBox.Size = new Size(106, 27);
            FontComboBox.SelectedIndexChanged += fontPropertySelectedIndexChanged;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(57, 24);
            toolStripLabel2.Text = "Font Size:";
            // 
            // FontSizeComboBox
            // 
            FontSizeComboBox.Items.AddRange(new object[] { "8", "10", "12", "14", "16" });
            FontSizeComboBox.Name = "FontSizeComboBox";
            FontSizeComboBox.Size = new Size(106, 27);
            FontSizeComboBox.SelectedIndexChanged += fontPropertySelectedIndexChanged;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // UnderlineButton
            // 
            UnderlineButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            UnderlineButton.Image = Resources.underline;
            UnderlineButton.ImageTransparentColor = Color.Magenta;
            UnderlineButton.Name = "UnderlineButton";
            UnderlineButton.Size = new Size(24, 24);
            UnderlineButton.Text = "Underline";
            UnderlineButton.Click += buttonClick;
            // 
            // BoldButton
            // 
            BoldButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BoldButton.Image = Resources.bold;
            BoldButton.ImageTransparentColor = Color.Magenta;
            BoldButton.Name = "BoldButton";
            BoldButton.Size = new Size(23, 24);
            BoldButton.Text = "Bold";
            BoldButton.Click += buttonClick;
            // 
            // ItalicButton
            // 
            ItalicButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ItalicButton.Image = Resources.italic;
            ItalicButton.ImageTransparentColor = Color.Magenta;
            ItalicButton.Name = "ItalicButton";
            ItalicButton.Size = new Size(23, 24);
            ItalicButton.Text = "Italic";
            ItalicButton.Click += buttonClick;
            // 
            // MainRichTextBox
            // 
            MainRichTextBox.Location = new Point(27, 36);
            MainRichTextBox.Margin = new Padding(3, 2, 3, 2);
            MainRichTextBox.Name = "MainRichTextBox";
            MainRichTextBox.Size = new Size(460, 162);
            MainRichTextBox.TabIndex = 1;
            MainRichTextBox.Text = "";
            // 
            // ToolStripTextEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 219);
            Controls.Add(MainRichTextBox);
            Controls.Add(EditorToolStrip);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ToolStripTextEditor";
            Text = "ToolStrip Activity";
            EditorToolStrip.ResumeLayout(false);
            EditorToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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