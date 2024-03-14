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
            intervalNumericUpDown = new NumericUpDown();
            incrementTextBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)intervalNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // intervalNumericUpDown
            // 
            intervalNumericUpDown.Location = new Point(84, 38);
            intervalNumericUpDown.Margin = new Padding(3, 2, 3, 2);
            intervalNumericUpDown.Name = "intervalNumericUpDown";
            intervalNumericUpDown.Size = new Size(125, 23);
            intervalNumericUpDown.TabIndex = 0;
            intervalNumericUpDown.ValueChanged += NumericControl_ValueChanged;
            // 
            // incrementTextBox
            // 
            incrementTextBox.Location = new Point(148, 71);
            incrementTextBox.Margin = new Padding(3, 2, 3, 2);
            incrementTextBox.Name = "incrementTextBox";
            incrementTextBox.Size = new Size(51, 23);
            incrementTextBox.TabIndex = 1;
            incrementTextBox.Text = "1";
            incrementTextBox.TextChanged += IncrementTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(84, 74);
            label1.Name = "label1";
            label1.Size = new Size(55, 19);
            label1.TabIndex = 2;
            label1.Text = "Interval";
            // 
            // NumberDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 134);
            Controls.Add(label1);
            Controls.Add(incrementTextBox);
            Controls.Add(intervalNumericUpDown);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NumberDisplay";
            Text = "Number Display";
            ((System.ComponentModel.ISupportInitialize)intervalNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown intervalNumericUpDown;
        private TextBox incrementTextBox;
        private Label label1;
    }
}