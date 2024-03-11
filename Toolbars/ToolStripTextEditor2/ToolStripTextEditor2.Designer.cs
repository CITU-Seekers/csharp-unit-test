using ToolStripTextEditor2.Properties;

namespace CodeChum
{
    partial class ToolStripTextEditor2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolStripTextEditor2));
            EditorToolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            FontComboBox = new ToolStripComboBox();
            toolStripLabel2 = new ToolStripLabel();
            FontSizeComboBox = new ToolStripComboBox();
            toolStripLabel3 = new ToolStripLabel();
            FindTextBox = new ToolStripTextBox();
            toolStripLabel4 = new ToolStripLabel();
            ReplaceAllTextBox = new ToolStripTextBox();
            ReplaceAllButton = new ToolStripButton();
            OpenColorsToolStripButton = new ToolStripButton();
            MainRichTextBox = new RichTextBox();
            ColorToolStrip = new ToolStrip();
            BlackButton = new ToolStripButton();
            BlueButton = new ToolStripButton();
            GreenButton = new ToolStripButton();
            RedButton = new ToolStripButton();
            YellowButton = new ToolStripButton();
            EditorToolStrip.SuspendLayout();
            ColorToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // EditorToolStrip
            // 
            EditorToolStrip.ImageScalingSize = new Size(20, 20);
            EditorToolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, FontComboBox, toolStripLabel2, FontSizeComboBox, toolStripLabel3, FindTextBox, toolStripLabel4, ReplaceAllTextBox, ReplaceAllButton, OpenColorsToolStripButton });
            EditorToolStrip.Location = new Point(0, 0);
            EditorToolStrip.Name = "EditorToolStrip";
            EditorToolStrip.Size = new Size(806, 25);
            EditorToolStrip.TabIndex = 0;
            EditorToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(34, 22);
            toolStripLabel1.Text = "Font:";
            // 
            // FontComboBox
            // 
            FontComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Arial", "Cascadia Code", "Segoe UI", "Tahoma", "Verdana" });
            FontComboBox.Items.AddRange(new object[] { "Arial", "Cascadia Code", "Segoe UI", "Tahoma", "Verdana" });
            FontComboBox.Name = "FontComboBox";
            FontComboBox.Size = new Size(106, 25);
            FontComboBox.SelectedIndexChanged += onComboBoxSelectionChange;
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(57, 22);
            toolStripLabel2.Text = "Font Size:";
            // 
            // FontSizeComboBox
            // 
            FontSizeComboBox.AutoCompleteCustomSource.AddRange(new string[] { "8", "10", "12", "14", "16" });
            FontSizeComboBox.Items.AddRange(new object[] { "8", "10", "12", "14", "16" });
            FontSizeComboBox.Name = "FontSizeComboBox";
            FontSizeComboBox.Size = new Size(106, 25);
            FontSizeComboBox.SelectedIndexChanged += onComboBoxSelectionChange;
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(33, 22);
            toolStripLabel3.Text = "Find:";
            // 
            // FindTextBox
            // 
            FindTextBox.Name = "FindTextBox";
            FindTextBox.Size = new Size(88, 25);
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(68, 22);
            toolStripLabel4.Text = "Replace All:";
            // 
            // ReplaceAllTextBox
            // 
            ReplaceAllTextBox.Name = "ReplaceAllTextBox";
            ReplaceAllTextBox.Size = new Size(88, 25);
            // 
            // ReplaceAllButton
            // 
            ReplaceAllButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ReplaceAllButton.ImageTransparentColor = Color.Magenta;
            ReplaceAllButton.Name = "ReplaceAllButton";
            ReplaceAllButton.Size = new Size(69, 22);
            ReplaceAllButton.Text = "Replace All";
            ReplaceAllButton.Click += onEditorButtonsClick;
            // 
            // OpenColorsToolStripButton
            // 
            OpenColorsToolStripButton.BackColor = SystemColors.ButtonHighlight;
            OpenColorsToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            OpenColorsToolStripButton.Image = (Image)resources.GetObject("OpenColorsToolStripButton.Image");
            OpenColorsToolStripButton.ImageTransparentColor = Color.Magenta;
            OpenColorsToolStripButton.Margin = new Padding(50, 1, 0, 2);
            OpenColorsToolStripButton.Name = "OpenColorsToolStripButton";
            OpenColorsToolStripButton.Size = new Size(45, 22);
            OpenColorsToolStripButton.Text = "Colors";
            OpenColorsToolStripButton.Click += onEditorButtonsClick;
            // 
            // MainRichTextBox
            // 
            MainRichTextBox.Location = new Point(10, 32);
            MainRichTextBox.Margin = new Padding(3, 2, 3, 2);
            MainRichTextBox.Name = "MainRichTextBox";
            MainRichTextBox.Size = new Size(780, 209);
            MainRichTextBox.TabIndex = 1;
            MainRichTextBox.Text = "";
            // 
            // ColorToolStrip
            // 
            ColorToolStrip.Dock = DockStyle.Right;
            ColorToolStrip.ImageScalingSize = new Size(20, 20);
            ColorToolStrip.Items.AddRange(new ToolStripItem[] { BlackButton, BlueButton, GreenButton, RedButton, YellowButton });
            ColorToolStrip.Location = new Point(771, 21);
            ColorToolStrip.Name = "ColorToolStrip";
            ColorToolStrip.Size = new Size(35, 227);
            ColorToolStrip.TabIndex = 2;
            ColorToolStrip.Text = "toolStrip1";
            ColorToolStrip.Visible = false;
            // 
            // BlackButton
            // 
            BlackButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BlackButton.Image = Resources.black;
            BlackButton.ImageTransparentColor = Color.Magenta;
            BlackButton.Name = "BlackButton";
            BlackButton.Size = new Size(21, 4);
            BlackButton.Text = "toolStripButton1";
            BlackButton.ToolTipText = "Black";
            BlackButton.Click += onColorButtonClick;
            // 
            // BlueButton
            // 
            BlueButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BlueButton.Image = Resources.blue;
            BlueButton.ImageTransparentColor = Color.Magenta;
            BlueButton.Margin = new Padding(0, 5, 0, 2);
            BlueButton.Name = "BlueButton";
            BlueButton.Size = new Size(21, 4);
            BlueButton.Text = "toolStripButton2";
            BlueButton.ToolTipText = "Blue";
            BlueButton.Click += onColorButtonClick;
            // 
            // GreenButton
            // 
            GreenButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            GreenButton.Image = Resources.green;
            GreenButton.ImageTransparentColor = Color.Magenta;
            GreenButton.Margin = new Padding(0, 5, 0, 2);
            GreenButton.Name = "GreenButton";
            GreenButton.Size = new Size(21, 4);
            GreenButton.Text = "toolStripButton3";
            GreenButton.ToolTipText = "Green";
            GreenButton.Click += onColorButtonClick;
            // 
            // RedButton
            // 
            RedButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            RedButton.Image = Resources.red;
            RedButton.ImageTransparentColor = Color.Magenta;
            RedButton.Margin = new Padding(0, 5, 0, 2);
            RedButton.Name = "RedButton";
            RedButton.Size = new Size(21, 4);
            RedButton.Text = "toolStripButton4";
            RedButton.ToolTipText = "Red";
            RedButton.Click += onColorButtonClick;
            // 
            // YellowButton
            // 
            YellowButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            YellowButton.Image = Resources.yellow;
            YellowButton.ImageTransparentColor = Color.Magenta;
            YellowButton.Margin = new Padding(0, 5, 0, 2);
            YellowButton.Name = "YellowButton";
            YellowButton.Size = new Size(21, 4);
            YellowButton.Text = "toolStripButton5";
            YellowButton.ToolTipText = "Yellow";
            YellowButton.Click += onColorButtonClick;
            // 
            // ToolStripTextEditor2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 248);
            Controls.Add(ColorToolStrip);
            Controls.Add(MainRichTextBox);
            Controls.Add(EditorToolStrip);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ToolStripTextEditor2";
            Text = "Text Editor";
            EditorToolStrip.ResumeLayout(false);
            EditorToolStrip.PerformLayout();
            ColorToolStrip.ResumeLayout(false);
            ColorToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip EditorToolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox FontComboBox;
        private ToolStripLabel toolStripLabel2;
        private ToolStripComboBox FontSizeComboBox;
        private ToolStripLabel toolStripLabel3;
        private ToolStripTextBox FindTextBox;
        private ToolStripLabel toolStripLabel4;
        private ToolStripTextBox ReplaceAllTextBox;
        private ToolStripButton ReplaceAllButton;
        private RichTextBox MainRichTextBox;
        private ToolStripButton OpenColorsToolStripButton;
        private ToolStrip ColorToolStrip;
        private ToolStripButton BlackButton;
        private ToolStripButton BlueButton;
        private ToolStripButton GreenButton;
        private ToolStripButton RedButton;
        private ToolStripButton YellowButton;
    }
}