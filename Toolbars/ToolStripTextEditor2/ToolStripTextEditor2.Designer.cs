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
            this.EditorToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.FontComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.FontSizeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.FindTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.ReplaceAllTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.ReplaceAllButton = new System.Windows.Forms.ToolStripButton();
            this.OpenColorsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.MainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ColorToolStrip = new System.Windows.Forms.ToolStrip();
            this.BlackButton = new System.Windows.Forms.ToolStripButton();
            this.BlueButton = new System.Windows.Forms.ToolStripButton();
            this.GreenButton = new System.Windows.Forms.ToolStripButton();
            this.RedButton = new System.Windows.Forms.ToolStripButton();
            this.YellowButton = new System.Windows.Forms.ToolStripButton();
            this.EditorToolStrip.SuspendLayout();
            this.ColorToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditorToolStrip
            // 
            this.EditorToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.EditorToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.FontComboBox,
            this.toolStripLabel2,
            this.FontSizeComboBox,
            this.toolStripLabel3,
            this.FindTextBox,
            this.toolStripLabel4,
            this.ReplaceAllTextBox,
            this.ReplaceAllButton,
            this.OpenColorsToolStripButton});
            this.EditorToolStrip.Location = new System.Drawing.Point(0, 0);
            this.EditorToolStrip.Name = "EditorToolStrip";
            this.EditorToolStrip.Size = new System.Drawing.Size(921, 28);
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
            this.FontComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Arial",
            "Cascadia Code",
            "Segoe UI",
            "Tahoma",
            "Verdana"});
            this.FontComboBox.Items.AddRange(new object[] {
            "Arial",
            "Cascadia Code",
            "Segoe UI",
            "Tahoma",
            "Verdana"});
            this.FontComboBox.Name = "FontComboBox";
            this.FontComboBox.Size = new System.Drawing.Size(121, 28);
            this.FontComboBox.SelectedIndexChanged += new System.EventHandler(this.onComboBoxSelectionChange);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(72, 25);
            this.toolStripLabel2.Text = "Font Size:";
            // 
            // FontSizeComboBox
            // 
            this.FontSizeComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "8",
            "10",
            "12",
            "14",
            "16"});
            this.FontSizeComboBox.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16"});
            this.FontSizeComboBox.Name = "FontSizeComboBox";
            this.FontSizeComboBox.Size = new System.Drawing.Size(121, 28);
            this.FontSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.onComboBoxSelectionChange);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(40, 25);
            this.toolStripLabel3.Text = "Find:";
            // 
            // FindTextBox
            // 
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(100, 28);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(87, 25);
            this.toolStripLabel4.Text = "Replace All:";
            // 
            // ReplaceAllTextBox
            // 
            this.ReplaceAllTextBox.Name = "ReplaceAllTextBox";
            this.ReplaceAllTextBox.Size = new System.Drawing.Size(100, 28);
            // 
            // ReplaceAllButton
            // 
            this.ReplaceAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ReplaceAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReplaceAllButton.Name = "ReplaceAllButton";
            this.ReplaceAllButton.Size = new System.Drawing.Size(88, 25);
            this.ReplaceAllButton.Text = "Replace All";
            this.ReplaceAllButton.Click += new System.EventHandler(this.onEditorButtonsClick);
            // 
            // OpenColorsToolStripButton
            // 
            this.OpenColorsToolStripButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OpenColorsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenColorsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenColorsToolStripButton.Image")));
            this.OpenColorsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenColorsToolStripButton.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.OpenColorsToolStripButton.Name = "OpenColorsToolStripButton";
            this.OpenColorsToolStripButton.Size = new System.Drawing.Size(55, 25);
            this.OpenColorsToolStripButton.Text = "Colors";
            this.OpenColorsToolStripButton.Click += new System.EventHandler(this.onEditorButtonsClick);
            // 
            // MainRichTextBox
            // 
            this.MainRichTextBox.Location = new System.Drawing.Point(12, 42);
            this.MainRichTextBox.Name = "MainRichTextBox";
            this.MainRichTextBox.Size = new System.Drawing.Size(891, 277);
            this.MainRichTextBox.TabIndex = 1;
            this.MainRichTextBox.Text = "";
            // 
            // ColorToolStrip
            // 
            this.ColorToolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.ColorToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ColorToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BlackButton,
            this.BlueButton,
            this.GreenButton,
            this.RedButton,
            this.YellowButton});
            this.ColorToolStrip.Location = new System.Drawing.Point(881, 28);
            this.ColorToolStrip.Name = "ColorToolStrip";
            this.ColorToolStrip.Size = new System.Drawing.Size(40, 303);
            this.ColorToolStrip.TabIndex = 2;
            this.ColorToolStrip.Text = "toolStrip1";
            this.ColorToolStrip.Visible = false;
            // 
            // BlackButton
            // 
            this.BlackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BlackButton.Image = global::CodeChum.Properties.Resources.black;
            this.BlackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BlackButton.Name = "BlackButton";
            this.BlackButton.Size = new System.Drawing.Size(27, 24);
            this.BlackButton.Text = "toolStripButton1";
            this.BlackButton.ToolTipText = "Black";
            this.BlackButton.Click += new System.EventHandler(this.onColorButtonClick);
            // 
            // BlueButton
            // 
            this.BlueButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BlueButton.Image = global::CodeChum.Properties.Resources.blue;
            this.BlueButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BlueButton.Margin = new System.Windows.Forms.Padding(0, 5, 0, 2);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(27, 24);
            this.BlueButton.Text = "toolStripButton2";
            this.BlueButton.ToolTipText = "Blue";
            this.BlueButton.Click += new System.EventHandler(this.onColorButtonClick);
            // 
            // GreenButton
            // 
            this.GreenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GreenButton.Image = global::CodeChum.Properties.Resources.green;
            this.GreenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GreenButton.Margin = new System.Windows.Forms.Padding(0, 5, 0, 2);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(27, 24);
            this.GreenButton.Text = "toolStripButton3";
            this.GreenButton.ToolTipText = "Green";
            this.GreenButton.Click += new System.EventHandler(this.onColorButtonClick);
            // 
            // RedButton
            // 
            this.RedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RedButton.Image = global::CodeChum.Properties.Resources.red;
            this.RedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedButton.Margin = new System.Windows.Forms.Padding(0, 5, 0, 2);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(27, 24);
            this.RedButton.Text = "toolStripButton4";
            this.RedButton.ToolTipText = "Red";
            this.RedButton.Click += new System.EventHandler(this.onColorButtonClick);
            // 
            // YellowButton
            // 
            this.YellowButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.YellowButton.Image = global::CodeChum.Properties.Resources.yellow;
            this.YellowButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.YellowButton.Margin = new System.Windows.Forms.Padding(0, 5, 0, 2);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(27, 24);
            this.YellowButton.Text = "toolStripButton5";
            this.YellowButton.ToolTipText = "Yellow";
            this.YellowButton.Click += new System.EventHandler(this.onColorButtonClick);
            // 
            // ToolStripTextEditor2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 331);
            this.Controls.Add(this.ColorToolStrip);
            this.Controls.Add(this.MainRichTextBox);
            this.Controls.Add(this.EditorToolStrip);
            this.Name = "ToolStripTextEditor2";
            this.Text = "Text Editor";
            this.EditorToolStrip.ResumeLayout(false);
            this.EditorToolStrip.PerformLayout();
            this.ColorToolStrip.ResumeLayout(false);
            this.ColorToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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