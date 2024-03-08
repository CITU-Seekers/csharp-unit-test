namespace CodeChum
{
    partial class MostFrequentCharacter
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FrequentCharLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(31, 32);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(441, 27);
            this.TextBox.TabIndex = 0;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(72, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "The most frequent character is";
            // 
            // FrequentCharLabel
            // 
            this.FrequentCharLabel.AutoSize = true;
            this.FrequentCharLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FrequentCharLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FrequentCharLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FrequentCharLabel.Location = new System.Drawing.Point(329, 80);
            this.FrequentCharLabel.MaximumSize = new System.Drawing.Size(50, 0);
            this.FrequentCharLabel.MinimumSize = new System.Drawing.Size(50, 0);
            this.FrequentCharLabel.Name = "FrequentCharLabel";
            this.FrequentCharLabel.Size = new System.Drawing.Size(50, 27);
            this.FrequentCharLabel.TabIndex = 2;
            // 
            // MostFrequentCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 132);
            this.Controls.Add(this.FrequentCharLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox);
            this.Name = "MostFrequentCharacter";
            this.Text = "Most Frequent Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBox;
        private Label label1;
        private Label FrequentCharLabel;
    }
}