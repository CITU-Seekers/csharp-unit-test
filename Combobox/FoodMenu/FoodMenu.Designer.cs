namespace CodeChum
{
    partial class FoodMenu
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
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            addButton = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            orderSummaryLabel = new Label();
            errorLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Food", "Drinks" });
            comboBox1.Location = new Point(101, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(159, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(330, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 200);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(47, 107);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(14, 13);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(47, 77);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(14, 13);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(47, 47);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(14, 13);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.Location = new Point(386, 304);
            addButton.Name = "addButton";
            addButton.Size = new Size(93, 34);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(164, 356);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 3;
            label1.Text = "Order Summary:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(346, 267);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 5;
            label2.Text = "Quantity";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(415, 266);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // labelOrderSummary
            // 
            orderSummaryLabel.AutoSize = true;
            orderSummaryLabel.Location = new Point(266, 386);
            orderSummaryLabel.Name = "orderSummaryLabel";
            orderSummaryLabel.Size = new Size(0, 15);
            orderSummaryLabel.TabIndex = 7;
            // 
            // labelError
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(266, 468);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 15);
            errorLabel.TabIndex = 8;
            // 
            // FoodMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 543);
            Controls.Add(errorLabel);
            Controls.Add(orderSummaryLabel);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addButton);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Name = "FoodMenu";
            Text = "FoodMenu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private GroupBox groupBox1;
        private Button addButton;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private Label orderSummaryLabel;
        private Label errorLabel;
    }
}