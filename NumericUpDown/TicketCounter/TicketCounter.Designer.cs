namespace CodeChum
{
    partial class TicketCounter
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
            zooNumericUpDown = new NumericUpDown();
            rollerCoasterNumericUpDown = new NumericUpDown();
            waterSlideNumericUpDown = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            totalLabel = new Label();
            calculateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)zooNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rollerCoasterNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)waterSlideNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // zooNumericUpDown
            // 
            zooNumericUpDown.Location = new Point(169, 44);
            zooNumericUpDown.Name = "zooNumericUpDown";
            zooNumericUpDown.Size = new Size(120, 23);
            zooNumericUpDown.TabIndex = 0;
            // 
            // rollerCoasterNumericUpDown
            // 
            rollerCoasterNumericUpDown.Location = new Point(169, 86);
            rollerCoasterNumericUpDown.Name = "rollerCoasterNumericUpDown";
            rollerCoasterNumericUpDown.Size = new Size(120, 23);
            rollerCoasterNumericUpDown.TabIndex = 1;
            // 
            // waterSlideNumericUpDown
            // 
            waterSlideNumericUpDown.Location = new Point(169, 128);
            waterSlideNumericUpDown.Name = "waterSlideNumericUpDown";
            waterSlideNumericUpDown.Size = new Size(120, 23);
            waterSlideNumericUpDown.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(53, 47);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 3;
            label1.Text = "Zoo Tickets";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(53, 89);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 4;
            label2.Text = "RollerCoaster";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(53, 131);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 5;
            label3.Text = "WaterSlide";
            // 
            // lblTotal
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(169, 209);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(0, 15);
            totalLabel.TabIndex = 6;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(183, 167);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 7;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += btnCalculate_Click;
            // 
            // TicketCounter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 280);
            Controls.Add(calculateButton);
            Controls.Add(totalLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(waterSlideNumericUpDown);
            Controls.Add(rollerCoasterNumericUpDown);
            Controls.Add(zooNumericUpDown);
            Name = "TicketCounter";
            Text = "TicketCounter";
            ((System.ComponentModel.ISupportInitialize)zooNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)rollerCoasterNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)waterSlideNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown zooNumericUpDown;
        private NumericUpDown rollerCoasterNumericUpDown;
        private NumericUpDown waterSlideNumericUpDown;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label totalLabel;
        private Button calculateButton;
    }
}