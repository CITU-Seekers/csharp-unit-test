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
            this.mainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.editorStatusStrip = new System.Windows.Forms.StatusStrip();
            this.caretPositionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.textLengthProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.toStartButton = new System.Windows.Forms.Button();
            this.toEndButton = new System.Windows.Forms.Button();
            this.editorStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainRichTextBox
            // 
            this.mainRichTextBox.Location = new System.Drawing.Point(31, 40);
            this.mainRichTextBox.MaxLength = 200;
            this.mainRichTextBox.Name = "mainRichTextBox";
            this.mainRichTextBox.Size = new System.Drawing.Size(654, 216);
            this.mainRichTextBox.TabIndex = 0;
            this.mainRichTextBox.Text = "";
            this.mainRichTextBox.SelectionChanged += new System.EventHandler(this.MainRichTextBox_SelectionChanged);
            this.mainRichTextBox.TextChanged += new System.EventHandler(this.MainRichTextBox_TextChanged);
            // 
            // editorStatusStrip
            // 
            this.editorStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.editorStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caretPositionStatusLabel,
            this.textLengthProgressBar});
            this.editorStatusStrip.Location = new System.Drawing.Point(0, 306);
            this.editorStatusStrip.Name = "editorStatusStrip";
            this.editorStatusStrip.Size = new System.Drawing.Size(720, 26);
            this.editorStatusStrip.TabIndex = 1;
            // 
            // caretPositionStatusLabel
            // 
            this.caretPositionStatusLabel.Name = "caretPositionStatusLabel";
            this.caretPositionStatusLabel.Size = new System.Drawing.Size(83, 20);
            this.caretPositionStatusLabel.Text = "Ln: 1, Col: 1";
            // 
            // textLengthProgressBar
            // 
            this.textLengthProgressBar.Maximum = 200;
            this.textLengthProgressBar.Name = "textLengthProgressBar";
            this.textLengthProgressBar.Size = new System.Drawing.Size(100, 18);
            // 
            // toStartButton
            // 
            this.toStartButton.Location = new System.Drawing.Point(211, 262);
            this.toStartButton.Name = "toStartButton";
            this.toStartButton.Size = new System.Drawing.Size(108, 29);
            this.toStartButton.TabIndex = 2;
            this.toStartButton.Text = "To Start";
            this.toStartButton.UseVisualStyleBackColor = true;
            this.toStartButton.Click += new System.EventHandler(this.ToStartButton_Click);
            // 
            // toEndButton
            // 
            this.toEndButton.Location = new System.Drawing.Point(384, 262);
            this.toEndButton.Name = "toEndButton";
            this.toEndButton.Size = new System.Drawing.Size(108, 29);
            this.toEndButton.TabIndex = 3;
            this.toEndButton.Text = "To End";
            this.toEndButton.UseVisualStyleBackColor = true;
            this.toEndButton.Click += new System.EventHandler(this.ToEndButton_Click);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 332);
            this.Controls.Add(this.toEndButton);
            this.Controls.Add(this.toStartButton);
            this.Controls.Add(this.editorStatusStrip);
            this.Controls.Add(this.mainRichTextBox);
            this.Name = "TextEditor";
            this.Text = "Text Editor";
            this.editorStatusStrip.ResumeLayout(false);
            this.editorStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox mainRichTextBox;
        private System.Windows.Forms.StatusStrip editorStatusStrip;
        private ToolStripStatusLabel caretPositionStatusLabel;
        private FontDialog fontDialog1;
        private Button toStartButton;
        private Button toEndButton;
        private ToolStripProgressBar textLengthProgressBar;
    }
}