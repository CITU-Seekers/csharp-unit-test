namespace CodeChum
{
    partial class NumberDisplay
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
            this.NumericControl = new System.Windows.Forms.NumericUpDown();
            this.IncrementTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericControl)).BeginInit();
            this.SuspendLayout();
            // 
            // NumericControl
            // 
            this.NumericControl.Location = new System.Drawing.Point(96, 51);
            this.NumericControl.Name = "NumericControl";
            this.NumericControl.Size = new System.Drawing.Size(143, 27);
            this.NumericControl.TabIndex = 0;
            // 
            // IncrementTextBox
            // 
            this.IncrementTextBox.Location = new System.Drawing.Point(169, 95);
            this.IncrementTextBox.Name = "IncrementTextBox";
            this.IncrementTextBox.Size = new System.Drawing.Size(58, 27);
            this.IncrementTextBox.TabIndex = 1;
            this.IncrementTextBox.Text = "1";
            this.IncrementTextBox.TextChanged += new System.EventHandler(this.IncrementTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(96, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Interval";
            // 
            // NumberDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IncrementTextBox);
            this.Controls.Add(this.NumericControl);
            this.Name = "NumberDisplay";
            this.Text = "Number Display";
            ((System.ComponentModel.ISupportInitialize)(this.NumericControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumericControl;
        private TextBox IncrementTextBox;
        private Label label1;
    }
}