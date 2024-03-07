namespace CodeChum
{
    partial class ExerciseMinutes
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
            lblTotal = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericUpDownCycling = new NumericUpDown();
            numericUpDownRunning = new NumericUpDown();
            numericUpDownWalking = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCycling).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRunning).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWalking).BeginInit();
            SuspendLayout();
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(133, 170);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 124);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 12;
            label3.Text = "Cycling";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(55, 82);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 11;
            label2.Text = "Running";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 40);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 10;
            label1.Text = "Walking";
            // 
            // numericUpDownCycling
            // 
            numericUpDownCycling.Location = new Point(171, 121);
            numericUpDownCycling.Name = "numericUpDownCycling";
            numericUpDownCycling.Size = new Size(120, 23);
            numericUpDownCycling.TabIndex = 9;
            // 
            // numericUpDownRunning
            // 
            numericUpDownRunning.Location = new Point(171, 79);
            numericUpDownRunning.Name = "numericUpDownRunning";
            numericUpDownRunning.Size = new Size(120, 23);
            numericUpDownRunning.TabIndex = 8;
            // 
            // numericUpDownWalking
            // 
            numericUpDownWalking.Location = new Point(171, 37);
            numericUpDownWalking.Name = "numericUpDownWalking";
            numericUpDownWalking.Size = new Size(120, 23);
            numericUpDownWalking.TabIndex = 7;
            // 
            // ExerciseMinutes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 247);
            Controls.Add(lblTotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownCycling);
            Controls.Add(numericUpDownRunning);
            Controls.Add(numericUpDownWalking);
            Name = "ExerciseMinutes";
            Text = "ExerciseMinutes";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCycling).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRunning).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWalking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotal;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDownCycling;
        private NumericUpDown numericUpDownRunning;
        private NumericUpDown numericUpDownWalking;
    }
}