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
            wordToolStrip = new ToolStrip();
            newToolStripButton = new ToolStripButton();
            saveToolStripButton = new ToolStripButton();
            printToolStripButton = new ToolStripButton();
            fontToolStripButton = new ToolStripLabel();
            fontToolStripComboBox = new ToolStripComboBox();
            fontToolStripLabel = new ToolStripLabel();
            fontSizeToolStripTextBox = new ToolStripTextBox();
            colorToolStripComboBox = new ToolStripComboBox();
            toolStripLabel3 = new ToolStripLabel();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            mainRichTextBox = new RichTextBox();
            wordToolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // WordToolStrip
            // 
            wordToolStrip.Items.AddRange(new ToolStripItem[] { newToolStripButton, saveToolStripButton, printToolStripButton, fontToolStripButton, fontToolStripComboBox, fontToolStripLabel, fontSizeToolStripTextBox, colorToolStripComboBox, toolStripLabel3 });
            wordToolStrip.Location = new Point(0, 0);
            wordToolStrip.Name = "wordToolStrip";
            wordToolStrip.Size = new Size(800, 25);
            wordToolStrip.TabIndex = 0;
            wordToolStrip.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            newToolStripButton.Image = (Image)resources.GetObject("newToolStripButton.Image");
            newToolStripButton.ImageTransparentColor = Color.Magenta;
            newToolStripButton.Name = "newToolStripButton";
            newToolStripButton.Size = new Size(35, 22);
            newToolStripButton.Text = "New";
            newToolStripButton.Click += NewButton_Click;
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            saveToolStripButton.Image = (Image)resources.GetObject("saveToolStripButton.Image");
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size(35, 22);
            saveToolStripButton.Text = "Save";
            saveToolStripButton.Click += SaveButton_Click;
            // 
            // printToolStripButton
            // 
            printToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            printToolStripButton.Image = (Image)resources.GetObject("printToolStripButton.Image");
            printToolStripButton.ImageTransparentColor = Color.Magenta;
            printToolStripButton.Name = "printToolStripButton";
            printToolStripButton.Size = new Size(36, 22);
            printToolStripButton.Text = "Print";
            printToolStripButton.Click += PrintButton_Click;
            // 
            // fontToolStripButton
            // 
            fontToolStripButton.Name = "fontToolStripButton";
            fontToolStripButton.Size = new Size(31, 22);
            fontToolStripButton.Text = "Font";
            // 
            // fontToolStripComboBox
            // 
            fontToolStripComboBox.Items.AddRange(new object[] { "Arial", "Times New Roman", "Cascadia Code", "Segoe UI", "Tahoma", "Verdana" });
            fontToolStripComboBox.Name = "fontToolStripComboBox";
            fontToolStripComboBox.Size = new Size(121, 25);
            fontToolStripComboBox.SelectedIndexChanged += FontComboBox_SelectedIndexChanged;
            // 
            // fontToolStripLabel
            // 
            fontToolStripLabel.Name = "fontToolStripLabel";
            fontToolStripLabel.Size = new Size(54, 22);
            fontToolStripLabel.Text = "Font Size";
            // 
            // fontSizeToolStripTextBox
            // 
            fontSizeToolStripTextBox.Name = "fontSizeToolStripTextBox";
            fontSizeToolStripTextBox.Size = new Size(100, 25);
            fontSizeToolStripTextBox.TextChanged += FontSizeTextBox_TextChanged;
            // 
            // ColorComboBox
            // 
            colorToolStripComboBox.Alignment = ToolStripItemAlignment.Right;
            colorToolStripComboBox.Items.AddRange(new object[] { "Black", "Red", "Green", "Blue ", "Orange" });
            colorToolStripComboBox.Name = "colorToolStripComboBox";
            colorToolStripComboBox.Size = new Size(75, 25);
            colorToolStripComboBox.SelectedIndexChanged += ColorComboBox_SelectedIndexChanged;
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
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 428);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 22);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(0, 17);
            // 
            // mainRichTextBox
            // 
            mainRichTextBox.Location = new Point(63, 46);
            mainRichTextBox.Name = "mainRichTextBox";
            mainRichTextBox.Size = new Size(638, 342);
            mainRichTextBox.TabIndex = 2;
            mainRichTextBox.Text = "";
            mainRichTextBox.TextChanged += MainRichTextBox_TextChanged;
            // 
            // SimpleWordApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainRichTextBox);
            Controls.Add(statusStrip);
            Controls.Add(wordToolStrip);
            Name = "SimpleWordApp";
            Text = "SimpleWordApp";
            wordToolStrip.ResumeLayout(false);
            wordToolStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip wordToolStrip;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripButton newToolStripButton;
        private ToolStripButton saveToolStripButton;
        private ToolStripButton printToolStripButton;
        private ToolStripLabel fontToolStripButton;
        private ToolStripComboBox fontToolStripComboBox;
        private ToolStripLabel fontToolStripLabel;
        private ToolStripTextBox fontSizeToolStripTextBox;
        private ToolStripComboBox colorToolStripComboBox;
        private ToolStripLabel toolStripLabel3;
        private RichTextBox mainRichTextBox;
    }
}