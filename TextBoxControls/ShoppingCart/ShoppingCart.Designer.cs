namespace CodeChum
{
    partial class ShoppingCart
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
            label1 = new Label();
            textBox1 = new TextBox();
            btnCalculate = new Button();
            TotalPrice = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 50);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Item prices:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 68);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 277);
            textBox1.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(133, 361);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(119, 29);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSize = true;
            TotalPrice.BorderStyle = BorderStyle.Fixed3D;
            TotalPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TotalPrice.Location = new Point(114, 433);
            TotalPrice.MinimumSize = new Size(173, 24);
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Size = new Size(173, 24);
            TotalPrice.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 409);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 6;
            label2.Text = "Total:";
            // 
            // ShoppingCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 499);
            Controls.Add(label2);
            Controls.Add(TotalPrice);
            Controls.Add(btnCalculate);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ShoppingCart";
            Text = "ShoppingCart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnCalculate;
        private Label TotalPrice;
        private Label label2;
    }
}