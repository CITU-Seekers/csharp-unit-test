namespace CodeChum
{
    partial class SimpleWordApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleWordApp));
            WordToolStrip = new ToolStrip();
            NewButton = new ToolStripButton();
            SaveButton = new ToolStripButton();
            PrintButton = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            FontComboBox = new ToolStripComboBox();
            toolStripLabel2 = new ToolStripLabel();
            FontSizeTextBox = new ToolStripTextBox();
            ColorComboBox = new ToolStripComboBox();
            toolStripLabel3 = new ToolStripLabel();
            StatusStrip = new StatusStrip();
            StatusLabel = new ToolStripStatusLabel();
            MainRichTextBox = new RichTextBox();
            WordToolStrip.SuspendLayout();
            StatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // WordToolStrip
            // 
            WordToolStrip.Items.AddRange(new ToolStripItem[] { NewButton, SaveButton, PrintButton, toolStripLabel1, FontComboBox, toolStripLabel2, FontSizeTextBox, ColorComboBox, toolStripLabel3 });
            WordToolStrip.Location = new Point(0, 0);
            WordToolStrip.Name = "WordToolStrip";
            WordToolStrip.Size = new Size(800, 25);
            WordToolStrip.TabIndex = 0;
            WordToolStrip.Text = "toolStrip1";
            // 
            // NewButton
            // 
            NewButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            NewButton.Image = (Image)resources.GetObject("NewButton.Image");
            NewButton.ImageTransparentColor = Color.Magenta;
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(35, 22);
            NewButton.Text = "New";
            NewButton.Click += NewButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            SaveButton.Image = (Image)resources.GetObject("SaveButton.Image");
            SaveButton.ImageTransparentColor = Color.Magenta;
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(35, 22);
            SaveButton.Text = "Save";
            SaveButton.Click += SaveButton_Click;
            // 
            // PrintButton
            // 
            PrintButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            PrintButton.Image = (Image)resources.GetObject("PrintButton.Image");
            PrintButton.ImageTransparentColor = Color.Magenta;
            PrintButton.Name = "PrintButton";
            PrintButton.Size = new Size(36, 22);
            PrintButton.Text = "Print";
            PrintButton.Click += PrintButton_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(31, 22);
            toolStripLabel1.Text = "Font";
            // 
            // FontComboBox
            // 
            FontComboBox.Items.AddRange(new object[] { "Arial", "Times New Roman", "Cascadia Code", "Segoe UI", "Tahoma", "Verdana" });
            FontComboBox.Name = "FontComboBox";
            FontComboBox.Size = new Size(121, 25);
            FontComboBox.SelectedIndexChanged += FontComboBox_SelectedIndexChanged;
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(54, 22);
            toolStripLabel2.Text = "Font Size";
            // 
            // FontSizeTextBox
            // 
            FontSizeTextBox.Name = "FontSizeTextBox";
            FontSizeTextBox.Size = new Size(100, 25);
            FontSizeTextBox.TextChanged += FontSizeTextBox_TextChanged;
            // 
            // ColorComboBox
            // 
            ColorComboBox.Alignment = ToolStripItemAlignment.Right;
            ColorComboBox.Items.AddRange(new object[] { "Black", "Red", "Green", "Blue ", "Orange" });
            ColorComboBox.Name = "ColorComboBox";
            ColorComboBox.Size = new Size(75, 25);
            ColorComboBox.SelectedIndexChanged += ColorComboBox_SelectedIndexChanged;
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(36, 22);
            toolStripLabel3.Text = "Color";
            // 
            // StatusStrip
            // 
            StatusStrip.Items.AddRange(new ToolStripItem[] { StatusLabel });
            StatusStrip.Location = new Point(0, 428);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(800, 22);
            StatusStrip.TabIndex = 1;
            StatusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(0, 17);
            // 
            // MainRichTextBox
            // 
            MainRichTextBox.Location = new Point(63, 46);
            MainRichTextBox.Name = "MainRichTextBox";
            MainRichTextBox.Size = new Size(638, 342);
            MainRichTextBox.TabIndex = 2;
            MainRichTextBox.Text = "";
            MainRichTextBox.TextChanged += MainRichTextBox_TextChanged;
            // 
            // SimpleWordApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainRichTextBox);
            Controls.Add(StatusStrip);
            Controls.Add(WordToolStrip);
            Name = "SimpleWordApp";
            Text = "SimpleWordApp";
            WordToolStrip.ResumeLayout(false);
            WordToolStrip.PerformLayout();
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip WordToolStrip;
        private StatusStrip StatusStrip;
        private ToolStripStatusLabel StatusLabel;
        private ToolStripButton NewButton;
        private ToolStripButton SaveButton;
        private ToolStripButton PrintButton;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox FontComboBox;
        private ToolStripLabel toolStripLabel2;
        private ToolStripTextBox FontSizeTextBox;
        private ToolStripComboBox ColorComboBox;
        private ToolStripLabel toolStripLabel3;
        private RichTextBox MainRichTextBox;
    }
}