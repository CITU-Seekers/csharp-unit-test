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
            editorToolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            fontComboBox = new ToolStripComboBox();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripLabel();
            fontSizeComboBox = new ToolStripComboBox();
            toolStripSeparator2 = new ToolStripSeparator();
            underlineButton = new ToolStripButton();
            boldButton = new ToolStripButton();
            italicButton = new ToolStripButton();
            mainRichTextBox = new RichTextBox();
            editorToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // editorToolStrip
            // 
            editorToolStrip.ImageScalingSize = new Size(20, 20);
            editorToolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, fontComboBox, toolStripSeparator1, toolStripLabel2, fontSizeComboBox, toolStripSeparator2, underlineButton, boldButton, italicButton });
            editorToolStrip.Location = new Point(0, 0);
            editorToolStrip.Name = "editorToolStrip";
            editorToolStrip.Size = new Size(511, 27);
            editorToolStrip.TabIndex = 0;
            editorToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(34, 24);
            toolStripLabel1.Text = "Font:";
            // 
            // fontComboBox
            // 
            fontComboBox.Items.AddRange(new object[] { "Arial", "Cascadia Code", "Segoe UI", "Tahoma", "Verdana" });
            fontComboBox.Name = "fontComboBox";
            fontComboBox.Size = new Size(106, 27);
            fontComboBox.SelectedIndexChanged += fontPropertySelectedIndexChanged;
            fontComboBox.Click += FontComboBox_Click;
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
            // fontSizeComboBox
            // 
            fontSizeComboBox.Items.AddRange(new object[] { "8", "10", "12", "14", "16" });
            fontSizeComboBox.Name = "fontSizeComboBox";
            fontSizeComboBox.Size = new Size(106, 27);
            fontSizeComboBox.SelectedIndexChanged += fontPropertySelectedIndexChanged;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // underlineButton
            // 
            underlineButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            underlineButton.Image = Resources.underline;
            underlineButton.ImageTransparentColor = Color.Magenta;
            underlineButton.Name = "underlineButton";
            underlineButton.Size = new Size(24, 24);
            underlineButton.Text = "Underline";
            underlineButton.Click += buttonClick;
            // 
            // boldButton
            // 
            boldButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            boldButton.Image = Resources.bold;
            boldButton.ImageTransparentColor = Color.Magenta;
            boldButton.Name = "boldButton";
            boldButton.Size = new Size(24, 24);
            boldButton.Text = "Bold";
            boldButton.Click += buttonClick;
            // 
            // italicButton
            // 
            italicButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            italicButton.Image = Resources.italic;
            italicButton.ImageTransparentColor = Color.Magenta;
            italicButton.Name = "italicButton";
            italicButton.Size = new Size(24, 24);
            italicButton.Text = "Italic";
            italicButton.Click += buttonClick;
            // 
            // mainRichTextBox
            // 
            mainRichTextBox.Location = new Point(27, 36);
            mainRichTextBox.Margin = new Padding(3, 2, 3, 2);
            mainRichTextBox.Name = "mainRichTextBox";
            mainRichTextBox.Size = new Size(460, 162);
            mainRichTextBox.TabIndex = 1;
            mainRichTextBox.Text = "";
            // 
            // ToolStripTextEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 219);
            Controls.Add(mainRichTextBox);
            Controls.Add(editorToolStrip);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ToolStripTextEditor";
            Text = "ToolStrip Activity";
            editorToolStrip.ResumeLayout(false);
            editorToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip editorToolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox fontComboBox;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripComboBox fontSizeComboBox;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton underlineButton;
        private ToolStripButton boldButton;
        private ToolStripButton italicButton;
        private RichTextBox mainRichTextBox;
    }
}