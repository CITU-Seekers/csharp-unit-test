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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frequentCharLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(31, 32);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(441, 27);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
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
            // frequentCharLabel
            // 
            this.frequentCharLabel.AutoSize = true;
            this.frequentCharLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.frequentCharLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.frequentCharLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.frequentCharLabel.Location = new System.Drawing.Point(329, 80);
            this.frequentCharLabel.MaximumSize = new System.Drawing.Size(50, 0);
            this.frequentCharLabel.MinimumSize = new System.Drawing.Size(50, 0);
            this.frequentCharLabel.Name = "frequentCharLabel";
            this.frequentCharLabel.Size = new System.Drawing.Size(50, 27);
            this.frequentCharLabel.TabIndex = 2;
            // 
            // MostFrequentCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 132);
            this.Controls.Add(this.frequentCharLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBox);
            this.Name = "MostFrequentCharacter";
            this.Text = "Most Frequent Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inputTextBox;
        private Label label1;
        private Label frequentCharLabel;
    }
}