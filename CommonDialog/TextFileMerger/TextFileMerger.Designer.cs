namespace CodeChum
{
    partial class TextFileMerger
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
            resultRichTextBox = new RichTextBox();
            mergeButton = new Button();
            fileMergedCounterLabel = new Label();
            saveButton = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // resultRichTextBox
            // 
            resultRichTextBox.Location = new Point(32, 59);
            resultRichTextBox.Name = "resultRichTextBox";
            resultRichTextBox.Size = new Size(387, 237);
            resultRichTextBox.TabIndex = 1;
            resultRichTextBox.Text = "";
            // 
            // mergeButton
            // 
            mergeButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            mergeButton.Location = new Point(32, 317);
            mergeButton.Name = "mergeButton";
            mergeButton.Size = new Size(102, 35);
            mergeButton.TabIndex = 2;
            mergeButton.Text = "Merge Files";
            mergeButton.UseVisualStyleBackColor = true;
            mergeButton.Click += btnMerge_Click;
            // 
            // fileMergedCounterLabel
            // 
            fileMergedCounterLabel.AutoSize = true;
            fileMergedCounterLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            fileMergedCounterLabel.Location = new Point(32, 29);
            fileMergedCounterLabel.Name = "fileMergedCounterLabel";
            fileMergedCounterLabel.Size = new Size(97, 20);
            fileMergedCounterLabel.TabIndex = 3;
            fileMergedCounterLabel.Text = "Files Merged:";
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(317, 317);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(102, 35);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save File";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += btnSave_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // TextFileMerger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 399);
            Controls.Add(saveButton);
            Controls.Add(fileMergedCounterLabel);
            Controls.Add(mergeButton);
            Controls.Add(resultRichTextBox);
            Name = "TextFileMerger";
            Text = "TextFileMerger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox resultRichTextBox;
        private Button mergeButton;
        private Label fileMergedCounterLabel;
        private Button saveButton;
        public OpenFileDialog openFileDialog1;
        public SaveFileDialog saveFileDialog1;
    }
}