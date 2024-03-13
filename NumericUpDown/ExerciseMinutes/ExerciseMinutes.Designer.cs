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
            totalLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cyclingNumericUpDown = new NumericUpDown();
            runningNumericUpDown = new NumericUpDown();
            walkingNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)cyclingNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)runningNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)walkingNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // lblTotal
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(133, 170);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(0, 15);
            totalLabel.TabIndex = 13;
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
            // cyclingNumericUpDown
            // 
            cyclingNumericUpDown.Location = new Point(171, 121);
            cyclingNumericUpDown.Name = "cyclingNumericUpDown";
            cyclingNumericUpDown.Size = new Size(120, 23);
            cyclingNumericUpDown.TabIndex = 9;
            // 
            // runningNumericUpDown
            // 
            runningNumericUpDown.Location = new Point(171, 79);
            runningNumericUpDown.Name = "runningNumericUpDown";
            runningNumericUpDown.Size = new Size(120, 23);
            runningNumericUpDown.TabIndex = 8;
            // 
            // walkingNumericUpDown
            // 
            walkingNumericUpDown.Location = new Point(171, 37);
            walkingNumericUpDown.Name = "walkingNumericUpDown";
            walkingNumericUpDown.Size = new Size(120, 23);
            walkingNumericUpDown.TabIndex = 7;
            // 
            // ExerciseMinutes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 247);
            Controls.Add(totalLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cyclingNumericUpDown);
            Controls.Add(runningNumericUpDown);
            Controls.Add(walkingNumericUpDown);
            Name = "ExerciseMinutes";
            Text = "ExerciseMinutes";
            ((System.ComponentModel.ISupportInitialize)cyclingNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)runningNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)walkingNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label totalLabel;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown cyclingNumericUpDown;
        private NumericUpDown runningNumericUpDown;
        private NumericUpDown walkingNumericUpDown;
    }
}