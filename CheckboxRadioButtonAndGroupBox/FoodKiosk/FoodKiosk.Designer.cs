namespace CodeChum
{
    partial class FoodKiosk
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
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.fiveRadioButton = new System.Windows.Forms.RadioButton();
            this.tenRadioButton = new System.Windows.Forms.RadioButton();
            this.teaCheckBox = new System.Windows.Forms.CheckBox();
            this.burgerCheckBox = new System.Windows.Forms.CheckBox();
            this.pizzaCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noneRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(158, 165);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(49, 20);
            this.totalCostLabel.TabIndex = 13;
            this.totalCostLabel.Text = "Total: ";
            this.totalCostLabel.Click += new System.EventHandler(this.TotalCostLabel_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(29, 163);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(100, 25);
            this.orderButton.TabIndex = 12;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // fiveRadioButton
            // 
            this.fiveRadioButton.AutoSize = true;
            this.fiveRadioButton.Location = new System.Drawing.Point(182, 80);
            this.fiveRadioButton.Name = "fiveRadioButton";
            this.fiveRadioButton.Size = new System.Drawing.Size(112, 24);
            this.fiveRadioButton.TabIndex = 11;
            this.fiveRadioButton.TabStop = true;
            this.fiveRadioButton.Text = "5% Discount";
            this.fiveRadioButton.UseVisualStyleBackColor = true;
            this.fiveRadioButton.CheckedChanged += new System.EventHandler(this.FiveRadioButton_CheckedChanged);
            // 
            // tenRadioButton
            // 
            this.tenRadioButton.AutoSize = true;
            this.tenRadioButton.Location = new System.Drawing.Point(182, 109);
            this.tenRadioButton.Name = "tenRadioButton";
            this.tenRadioButton.Size = new System.Drawing.Size(120, 24);
            this.tenRadioButton.TabIndex = 10;
            this.tenRadioButton.TabStop = true;
            this.tenRadioButton.Text = "10% Discount";
            this.tenRadioButton.UseVisualStyleBackColor = true;
            this.tenRadioButton.CheckedChanged += new System.EventHandler(this.TenRadioButton_CheckedChanged);
            // 
            // teaCheckBox
            // 
            this.teaCheckBox.AutoSize = true;
            this.teaCheckBox.Location = new System.Drawing.Point(27, 110);
            this.teaCheckBox.Name = "teaCheckBox";
            this.teaCheckBox.Size = new System.Drawing.Size(115, 24);
            this.teaCheckBox.TabIndex = 9;
            this.teaCheckBox.Text = "Tea – Php 50";
            this.teaCheckBox.UseVisualStyleBackColor = true;
            this.teaCheckBox.CheckedChanged += new System.EventHandler(this.TeaCheckBox_CheckedChanged);
            // 
            // burgerCheckBox
            // 
            this.burgerCheckBox.AutoSize = true;
            this.burgerCheckBox.Location = new System.Drawing.Point(27, 81);
            this.burgerCheckBox.Name = "burgerCheckBox";
            this.burgerCheckBox.Size = new System.Drawing.Size(136, 24);
            this.burgerCheckBox.TabIndex = 8;
            this.burgerCheckBox.Text = "Burger – Php 80";
            this.burgerCheckBox.UseVisualStyleBackColor = true;
            this.burgerCheckBox.CheckedChanged += new System.EventHandler(this.BurgerCheckBox_CheckedChanged);
            // 
            // pizzaCheckBox
            // 
            this.pizzaCheckBox.AutoSize = true;
            this.pizzaCheckBox.Location = new System.Drawing.Point(27, 52);
            this.pizzaCheckBox.Name = "pizzaCheckBox";
            this.pizzaCheckBox.Size = new System.Drawing.Size(134, 24);
            this.pizzaCheckBox.TabIndex = 7;
            this.pizzaCheckBox.Text = "Pizza – Php 100";
            this.pizzaCheckBox.UseVisualStyleBackColor = true;
            this.pizzaCheckBox.CheckedChanged += new System.EventHandler(this.PizzaCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Food";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(182, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Discounts";
            // 
            // noneRadioButton
            // 
            this.noneRadioButton.AutoSize = true;
            this.noneRadioButton.Location = new System.Drawing.Point(182, 50);
            this.noneRadioButton.Name = "noneRadioButton";
            this.noneRadioButton.Size = new System.Drawing.Size(66, 24);
            this.noneRadioButton.TabIndex = 16;
            this.noneRadioButton.TabStop = true;
            this.noneRadioButton.Text = "None";
            this.noneRadioButton.UseVisualStyleBackColor = true;
            // 
            // FoodKiosk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 233);
            this.Controls.Add(this.noneRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.fiveRadioButton);
            this.Controls.Add(this.tenRadioButton);
            this.Controls.Add(this.teaCheckBox);
            this.Controls.Add(this.burgerCheckBox);
            this.Controls.Add(this.pizzaCheckBox);
            this.Name = "FoodKiosk";
            this.Text = "FoodKiosk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label totalCostLabel;
        private Button orderButton;
        private RadioButton fiveRadioButton;
        private RadioButton tenRadioButton;
        private CheckBox teaCheckBox;
        private CheckBox burgerCheckBox;
        private CheckBox pizzaCheckBox;
        private Label label1;
        private Label label2;
        private RadioButton noneRadioButton;
    }
}