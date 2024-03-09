namespace CodeChum
{
    partial class TextEditor
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
            this.MainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.EditorStatusStrip = new System.Windows.Forms.StatusStrip();
            this.CaretPositionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TextLengthProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.ToStartButton = new System.Windows.Forms.Button();
            this.ToEndButton = new System.Windows.Forms.Button();
            this.EditorStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainRichTextBox
            // 
            this.MainRichTextBox.Location = new System.Drawing.Point(31, 40);
            this.MainRichTextBox.MaxLength = 200;
            this.MainRichTextBox.Name = "MainRichTextBox";
            this.MainRichTextBox.Size = new System.Drawing.Size(654, 216);
            this.MainRichTextBox.TabIndex = 0;
            this.MainRichTextBox.Text = "";
            this.MainRichTextBox.SelectionChanged += new System.EventHandler(this.MainRichTextBox_SelectionChanged);
            this.MainRichTextBox.TextChanged += new System.EventHandler(this.MainRichTextBox_TextChanged);
            // 
            // EditorStatusStrip
            // 
            this.EditorStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.EditorStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CaretPositionStatusLabel,
            this.TextLengthProgressBar});
            this.EditorStatusStrip.Location = new System.Drawing.Point(0, 306);
            this.EditorStatusStrip.Name = "EditorStatusStrip";
            this.EditorStatusStrip.Size = new System.Drawing.Size(720, 26);
            this.EditorStatusStrip.TabIndex = 1;
            // 
            // CaretPositionStatusLabel
            // 
            this.CaretPositionStatusLabel.Name = "CaretPositionStatusLabel";
            this.CaretPositionStatusLabel.Size = new System.Drawing.Size(83, 20);
            this.CaretPositionStatusLabel.Text = "Ln: 1, Col: 1";
            // 
            // TextLengthProgressBar
            // 
            this.TextLengthProgressBar.Maximum = 200;
            this.TextLengthProgressBar.Name = "TextLengthProgressBar";
            this.TextLengthProgressBar.Size = new System.Drawing.Size(100, 18);
            // 
            // ToStartButton
            // 
            this.ToStartButton.Location = new System.Drawing.Point(211, 262);
            this.ToStartButton.Name = "ToStartButton";
            this.ToStartButton.Size = new System.Drawing.Size(108, 29);
            this.ToStartButton.TabIndex = 2;
            this.ToStartButton.Text = "To Start";
            this.ToStartButton.UseVisualStyleBackColor = true;
            this.ToStartButton.Click += new System.EventHandler(this.ToStartButton_Click);
            // 
            // ToEndButton
            // 
            this.ToEndButton.Location = new System.Drawing.Point(384, 262);
            this.ToEndButton.Name = "ToEndButton";
            this.ToEndButton.Size = new System.Drawing.Size(108, 29);
            this.ToEndButton.TabIndex = 3;
            this.ToEndButton.Text = "To End";
            this.ToEndButton.UseVisualStyleBackColor = true;
            this.ToEndButton.Click += new System.EventHandler(this.ToEndButton_Click);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 332);
            this.Controls.Add(this.ToEndButton);
            this.Controls.Add(this.ToStartButton);
            this.Controls.Add(this.EditorStatusStrip);
            this.Controls.Add(this.MainRichTextBox);
            this.Name = "TextEditor";
            this.Text = "Text Editor";
            this.EditorStatusStrip.ResumeLayout(false);
            this.EditorStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox MainRichTextBox;
        private System.Windows.Forms.StatusStrip EditorStatusStrip;
        private ToolStripStatusLabel CaretPositionStatusLabel;
        private FontDialog fontDialog1;
        private Button ToStartButton;
        private Button ToEndButton;
        private ToolStripProgressBar TextLengthProgressBar;
    }
}