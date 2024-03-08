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
            TextBox = new RichTextBox();
            btnMerge = new Button();
            lblFileNum = new Label();
            btnSave = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // TextBox
            // 
            TextBox.Location = new Point(32, 59);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(387, 237);
            TextBox.TabIndex = 1;
            TextBox.Text = "";
            // 
            // btnMerge
            // 
            btnMerge.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnMerge.Location = new Point(32, 317);
            btnMerge.Name = "btnMerge";
            btnMerge.Size = new Size(102, 35);
            btnMerge.TabIndex = 2;
            btnMerge.Text = "Merge Files";
            btnMerge.UseVisualStyleBackColor = true;
            btnMerge.Click += btnMerge_Click;
            // 
            // lblFileNum
            // 
            lblFileNum.AutoSize = true;
            lblFileNum.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblFileNum.Location = new Point(32, 29);
            lblFileNum.Name = "lblFileNum";
            lblFileNum.Size = new Size(97, 20);
            lblFileNum.TabIndex = 3;
            lblFileNum.Text = "Files Merged:";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(317, 317);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 35);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save File";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
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
            Controls.Add(btnSave);
            Controls.Add(lblFileNum);
            Controls.Add(btnMerge);
            Controls.Add(TextBox);
            Name = "TextFileMerger";
            Text = "TextFileMerger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox TextBox;
        private Button btnMerge;
        private Label lblFileNum;
        private Button btnSave;
        public OpenFileDialog openFileDialog1;
        public SaveFileDialog saveFileDialog1;
    }
}