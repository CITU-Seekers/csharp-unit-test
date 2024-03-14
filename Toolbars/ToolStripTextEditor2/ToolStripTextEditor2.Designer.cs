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
            editorToolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            fontComboBox = new ToolStripComboBox();
            toolStripLabel2 = new ToolStripLabel();
            fontSizeComboBox = new ToolStripComboBox();
            toolStripLabel3 = new ToolStripLabel();
            findTextBox = new ToolStripTextBox();
            toolStripLabel4 = new ToolStripLabel();
            replaceAllTextBox = new ToolStripTextBox();
            replaceAllButton = new ToolStripButton();
            openColorsToolStripButton = new ToolStripButton();
            mainRichTextBox = new RichTextBox();
            colorToolStrip = new ToolStrip();
            blackButton = new ToolStripButton();
            blueButton = new ToolStripButton();
            greenButton = new ToolStripButton();
            redButton = new ToolStripButton();
            yellowButton = new ToolStripButton();
            editorToolStrip.SuspendLayout();
            colorToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // editorToolStrip
            // 
            editorToolStrip.ImageScalingSize = new Size(20, 20);
            editorToolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, fontComboBox, toolStripLabel2, fontSizeComboBox, toolStripLabel3, findTextBox, toolStripLabel4, replaceAllTextBox, replaceAllButton, openColorsToolStripButton });
            editorToolStrip.Location = new Point(0, 0);
            editorToolStrip.Name = "editorToolStrip";
            editorToolStrip.Size = new Size(806, 25);
            editorToolStrip.TabIndex = 0;
            editorToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(34, 22);
            toolStripLabel1.Text = "Font:";
            // 
            // fontComboBox
            // 
            fontComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Arial", "Cascadia Code", "Segoe UI", "Tahoma", "Verdana" });
            fontComboBox.Items.AddRange(new object[] { "Arial", "Cascadia Code", "Segoe UI", "Tahoma", "Verdana" });
            fontComboBox.Name = "fontComboBox";
            fontComboBox.Size = new Size(106, 25);
            fontComboBox.SelectedIndexChanged += onComboBoxSelectionChange;
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(57, 22);
            toolStripLabel2.Text = "Font Size:";
            toolStripLabel2.Click += toolStripLabel2_Click;
            // 
            // fontSizeComboBox
            // 
            fontSizeComboBox.AutoCompleteCustomSource.AddRange(new string[] { "8", "10", "12", "14", "16" });
            fontSizeComboBox.Items.AddRange(new object[] { "8", "10", "12", "14", "16" });
            fontSizeComboBox.Name = "fontSizeComboBox";
            fontSizeComboBox.Size = new Size(106, 25);
            fontSizeComboBox.SelectedIndexChanged += onComboBoxSelectionChange;
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(33, 22);
            toolStripLabel3.Text = "Find:";
            // 
            // findTextBox
            // 
            findTextBox.Name = "findTextBox";
            findTextBox.Size = new Size(88, 25);
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(68, 22);
            toolStripLabel4.Text = "Replace All:";
            // 
            // replaceAllTextBox
            // 
            replaceAllTextBox.Name = "replaceAllTextBox";
            replaceAllTextBox.Size = new Size(88, 25);
            // 
            // replaceAllButton
            // 
            replaceAllButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            replaceAllButton.ImageTransparentColor = Color.Magenta;
            replaceAllButton.Name = "replaceAllButton";
            replaceAllButton.Size = new Size(69, 22);
            replaceAllButton.Text = "Replace All";
            replaceAllButton.Click += onEditorButtonsClick;
            // 
            // openColorsToolStripButton
            // 
            openColorsToolStripButton.BackColor = SystemColors.ButtonHighlight;
            openColorsToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            openColorsToolStripButton.Image = (Image)resources.GetObject("openColorsToolStripButton.Image");
            openColorsToolStripButton.ImageTransparentColor = Color.Magenta;
            openColorsToolStripButton.Margin = new Padding(50, 1, 0, 2);
            openColorsToolStripButton.Name = "openColorsToolStripButton";
            openColorsToolStripButton.Size = new Size(45, 22);
            openColorsToolStripButton.Text = "Colors";
            openColorsToolStripButton.Click += onEditorButtonsClick;
            // 
            // mainRichTextBox
            // 
            mainRichTextBox.Location = new Point(10, 32);
            mainRichTextBox.Margin = new Padding(3, 2, 3, 2);
            mainRichTextBox.Name = "mainRichTextBox";
            mainRichTextBox.Size = new Size(780, 209);
            mainRichTextBox.TabIndex = 1;
            mainRichTextBox.Text = "";
            // 
            // colorToolStrip
            // 
            colorToolStrip.Dock = DockStyle.Right;
            colorToolStrip.ImageScalingSize = new Size(20, 20);
            colorToolStrip.Items.AddRange(new ToolStripItem[] { blackButton, blueButton, greenButton, redButton, yellowButton });
            colorToolStrip.Location = new Point(771, 21);
            colorToolStrip.Name = "colorToolStrip";
            colorToolStrip.Size = new Size(35, 227);
            colorToolStrip.TabIndex = 2;
            colorToolStrip.Text = "toolStrip1";
            colorToolStrip.Visible = false;
            // 
            // blackButton
            // 
            blackButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            blackButton.Image = Resources.black;
            blackButton.ImageTransparentColor = Color.Magenta;
            blackButton.Name = "blackButton";
            blackButton.Size = new Size(22, 24);
            blackButton.Text = "toolStripButton1";
            blackButton.ToolTipText = "Black";
            blackButton.Click += onColorButtonClick;
            // 
            // blueButton
            // 
            blueButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            blueButton.Image = Resources.blue;
            blueButton.ImageTransparentColor = Color.Magenta;
            blueButton.Margin = new Padding(0, 5, 0, 2);
            blueButton.Name = "blueButton";
            blueButton.Size = new Size(22, 24);
            blueButton.Text = "toolStripButton2";
            blueButton.ToolTipText = "Blue";
            blueButton.Click += onColorButtonClick;
            // 
            // greenButton
            // 
            greenButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            greenButton.Image = Resources.green;
            greenButton.ImageTransparentColor = Color.Magenta;
            greenButton.Margin = new Padding(0, 5, 0, 2);
            greenButton.Name = "greenButton";
            greenButton.Size = new Size(22, 24);
            greenButton.Text = "toolStripButton3";
            greenButton.ToolTipText = "Green";
            greenButton.Click += onColorButtonClick;
            // 
            // redButton
            // 
            redButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            redButton.Image = Resources.red;
            redButton.ImageTransparentColor = Color.Magenta;
            redButton.Margin = new Padding(0, 5, 0, 2);
            redButton.Name = "redButton";
            redButton.Size = new Size(22, 24);
            redButton.Text = "toolStripButton4";
            redButton.ToolTipText = "Red";
            redButton.Click += onColorButtonClick;
            // 
            // yellowButton
            // 
            yellowButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            yellowButton.Image = Resources.yellow;
            yellowButton.ImageTransparentColor = Color.Magenta;
            yellowButton.Margin = new Padding(0, 5, 0, 2);
            yellowButton.Name = "yellowButton";
            yellowButton.Size = new Size(22, 24);
            yellowButton.Text = "toolStripButton5";
            yellowButton.ToolTipText = "Yellow";
            yellowButton.Click += onColorButtonClick;
            // 
            // ToolStripTextEditor2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 248);
            Controls.Add(colorToolStrip);
            Controls.Add(mainRichTextBox);
            Controls.Add(editorToolStrip);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ToolStripTextEditor2";
            Text = "Text Editor";
            editorToolStrip.ResumeLayout(false);
            editorToolStrip.PerformLayout();
            colorToolStrip.ResumeLayout(false);
            colorToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip editorToolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox fontComboBox;
        private ToolStripLabel toolStripLabel2;
        private ToolStripComboBox fontSizeComboBox;
        private ToolStripLabel toolStripLabel3;
        private ToolStripTextBox findTextBox;
        private ToolStripLabel toolStripLabel4;
        private ToolStripTextBox replaceAllTextBox;
        private ToolStripButton replaceAllButton;
        private RichTextBox mainRichTextBox;
        private ToolStripButton openColorsToolStripButton;
        private ToolStrip colorToolStrip;
        private ToolStripButton blackButton;
        private ToolStripButton blueButton;
        private ToolStripButton greenButton;
        private ToolStripButton redButton;
        private ToolStripButton yellowButton;
    }
}