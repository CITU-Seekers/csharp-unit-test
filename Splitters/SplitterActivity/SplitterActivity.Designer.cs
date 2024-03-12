namespace CodeChum
{
    partial class SplitterActivity
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
            mainSplitter = new Splitter();
            normalTextBox = new TextBox();
            capitalizedTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // mainSplitter
            // 
            mainSplitter.Location = new Point(0, 0);
            mainSplitter.Margin = new Padding(3, 2, 3, 2);
            mainSplitter.Name = "mainSplitter";
            mainSplitter.Size = new Size(284, 194);
            mainSplitter.TabIndex = 1;
            mainSplitter.TabStop = false;
            // 
            // normalTextBox
            // 
            normalTextBox.Location = new Point(10, 34);
            normalTextBox.Margin = new Padding(3, 2, 3, 2);
            normalTextBox.Multiline = true;
            normalTextBox.Name = "normalTextBox";
            normalTextBox.Size = new Size(260, 154);
            normalTextBox.TabIndex = 2;
            normalTextBox.TextChanged += EditableTextBox_TextChanged;
            // 
            // capitalizedTextBox
            // 
            capitalizedTextBox.Enabled = false;
            capitalizedTextBox.Location = new Point(298, 34);
            capitalizedTextBox.Margin = new Padding(3, 2, 3, 2);
            capitalizedTextBox.Multiline = true;
            capitalizedTextBox.Name = "capitalizedTextBox";
            capitalizedTextBox.Size = new Size(260, 154);
            capitalizedTextBox.TabIndex = 3;
            capitalizedTextBox.TextChanged += CapitalizedTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(94, 13);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 4;
            label1.Text = "Normal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(384, 13);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 5;
            label2.Text = "Capitalized";
            // 
            // SplitterActivity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 194);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(capitalizedTextBox);
            Controls.Add(normalTextBox);
            Controls.Add(mainSplitter);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SplitterActivity";
            Text = "SplitterActivity";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Splitter mainSplitter;
        private TextBox normalTextBox;
        private TextBox capitalizedTextBox;
        private Label label1;
        private Label label2;
    }
}