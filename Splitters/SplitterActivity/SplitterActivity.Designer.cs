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
            this.MainSplitter = new System.Windows.Forms.Splitter();
            this.NormalTextBox = new System.Windows.Forms.TextBox();
            this.CapitalizedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainSplitter
            // 
            this.MainSplitter.Location = new System.Drawing.Point(0, 0);
            this.MainSplitter.Name = "MainSplitter";
            this.MainSplitter.Size = new System.Drawing.Size(325, 259);
            this.MainSplitter.TabIndex = 1;
            this.MainSplitter.TabStop = false;
            // 
            // NormalTextBox
            // 
            this.NormalTextBox.Location = new System.Drawing.Point(11, 45);
            this.NormalTextBox.Multiline = true;
            this.NormalTextBox.Name = "NormalTextBox";
            this.NormalTextBox.Size = new System.Drawing.Size(297, 204);
            this.NormalTextBox.TabIndex = 2;
            this.NormalTextBox.TextChanged += new System.EventHandler(this.EditableTextBox_TextChanged);
            // 
            // CapitalizedTextBox
            // 
            this.CapitalizedTextBox.Enabled = false;
            this.CapitalizedTextBox.Location = new System.Drawing.Point(340, 45);
            this.CapitalizedTextBox.Multiline = true;
            this.CapitalizedTextBox.Name = "CapitalizedTextBox";
            this.CapitalizedTextBox.Size = new System.Drawing.Size(297, 204);
            this.CapitalizedTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(108, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Normal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(439, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Capitalized";
            // 
            // SplitterActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 259);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CapitalizedTextBox);
            this.Controls.Add(this.NormalTextBox);
            this.Controls.Add(this.MainSplitter);
            this.Name = "SplitterActivity";
            this.Text = "SplitterActivity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Splitter MainSplitter;
        private TextBox NormalTextBox;
        private TextBox CapitalizedTextBox;
        private Label label1;
        private Label label2;
    }
}