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
            numericUpDownZoo = new NumericUpDown();
            numericUpDownRollerCoaster = new NumericUpDown();
            numericUpDownWaterSlide = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblTotal = new Label();
            btnCalculate = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownZoo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRollerCoaster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWaterSlide).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownZoo
            // 
            numericUpDownZoo.Location = new Point(169, 44);
            numericUpDownZoo.Name = "numericUpDownZoo";
            numericUpDownZoo.Size = new Size(120, 23);
            numericUpDownZoo.TabIndex = 0;
            // 
            // numericUpDownRollerCoaster
            // 
            numericUpDownRollerCoaster.Location = new Point(169, 86);
            numericUpDownRollerCoaster.Name = "numericUpDownRollerCoaster";
            numericUpDownRollerCoaster.Size = new Size(120, 23);
            numericUpDownRollerCoaster.TabIndex = 1;
            // 
            // numericUpDownWaterSlide
            // 
            numericUpDownWaterSlide.Location = new Point(169, 128);
            numericUpDownWaterSlide.Name = "numericUpDownWaterSlide";
            numericUpDownWaterSlide.Size = new Size(120, 23);
            numericUpDownWaterSlide.TabIndex = 2;
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
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(169, 209);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 6;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(183, 167);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // TicketCounter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 280);
            Controls.Add(btnCalculate);
            Controls.Add(lblTotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownWaterSlide);
            Controls.Add(numericUpDownRollerCoaster);
            Controls.Add(numericUpDownZoo);
            Name = "TicketCounter";
            Text = "TicketCounter";
            ((System.ComponentModel.ISupportInitialize)numericUpDownZoo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRollerCoaster).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWaterSlide).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownZoo;
        private NumericUpDown numericUpDownRollerCoaster;
        private NumericUpDown numericUpDownWaterSlide;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblTotal;
        private Button btnCalculate;
    }
}