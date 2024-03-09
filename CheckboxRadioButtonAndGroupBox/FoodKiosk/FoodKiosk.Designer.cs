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
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.OrderButton = new System.Windows.Forms.Button();
            this.FiveRadioButton = new System.Windows.Forms.RadioButton();
            this.TenRadioButton = new System.Windows.Forms.RadioButton();
            this.TeaCheckBox = new System.Windows.Forms.CheckBox();
            this.BurgerCheckBox = new System.Windows.Forms.CheckBox();
            this.PizzaCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NoneRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Location = new System.Drawing.Point(158, 165);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(49, 20);
            this.TotalCostLabel.TabIndex = 13;
            this.TotalCostLabel.Text = "Total: ";
            this.TotalCostLabel.Click += new System.EventHandler(this.TotalCostLabel_Click);
            // 
            // OrderButton
            // 
            this.OrderButton.Location = new System.Drawing.Point(29, 163);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(100, 25);
            this.OrderButton.TabIndex = 12;
            this.OrderButton.Text = "Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // FiveRadioButton
            // 
            this.FiveRadioButton.AutoSize = true;
            this.FiveRadioButton.Location = new System.Drawing.Point(182, 80);
            this.FiveRadioButton.Name = "FiveRadioButton";
            this.FiveRadioButton.Size = new System.Drawing.Size(112, 24);
            this.FiveRadioButton.TabIndex = 11;
            this.FiveRadioButton.TabStop = true;
            this.FiveRadioButton.Text = "5% Discount";
            this.FiveRadioButton.UseVisualStyleBackColor = true;
            this.FiveRadioButton.CheckedChanged += new System.EventHandler(this.FiveRadioButton_CheckedChanged);
            // 
            // TenRadioButton
            // 
            this.TenRadioButton.AutoSize = true;
            this.TenRadioButton.Location = new System.Drawing.Point(182, 109);
            this.TenRadioButton.Name = "TenRadioButton";
            this.TenRadioButton.Size = new System.Drawing.Size(120, 24);
            this.TenRadioButton.TabIndex = 10;
            this.TenRadioButton.TabStop = true;
            this.TenRadioButton.Text = "10% Discount";
            this.TenRadioButton.UseVisualStyleBackColor = true;
            this.TenRadioButton.CheckedChanged += new System.EventHandler(this.TenRadioButton_CheckedChanged);
            // 
            // TeaCheckBox
            // 
            this.TeaCheckBox.AutoSize = true;
            this.TeaCheckBox.Location = new System.Drawing.Point(27, 110);
            this.TeaCheckBox.Name = "TeaCheckBox";
            this.TeaCheckBox.Size = new System.Drawing.Size(115, 24);
            this.TeaCheckBox.TabIndex = 9;
            this.TeaCheckBox.Text = "Tea – Php 50";
            this.TeaCheckBox.UseVisualStyleBackColor = true;
            this.TeaCheckBox.CheckedChanged += new System.EventHandler(this.TeaCheckBox_CheckedChanged);
            // 
            // BurgerCheckBox
            // 
            this.BurgerCheckBox.AutoSize = true;
            this.BurgerCheckBox.Location = new System.Drawing.Point(27, 81);
            this.BurgerCheckBox.Name = "BurgerCheckBox";
            this.BurgerCheckBox.Size = new System.Drawing.Size(136, 24);
            this.BurgerCheckBox.TabIndex = 8;
            this.BurgerCheckBox.Text = "Burger – Php 80";
            this.BurgerCheckBox.UseVisualStyleBackColor = true;
            this.BurgerCheckBox.CheckedChanged += new System.EventHandler(this.BurgerCheckBox_CheckedChanged);
            // 
            // PizzaCheckBox
            // 
            this.PizzaCheckBox.AutoSize = true;
            this.PizzaCheckBox.Location = new System.Drawing.Point(27, 52);
            this.PizzaCheckBox.Name = "PizzaCheckBox";
            this.PizzaCheckBox.Size = new System.Drawing.Size(134, 24);
            this.PizzaCheckBox.TabIndex = 7;
            this.PizzaCheckBox.Text = "Pizza – Php 100";
            this.PizzaCheckBox.UseVisualStyleBackColor = true;
            this.PizzaCheckBox.CheckedChanged += new System.EventHandler(this.PizzaCheckBox_CheckedChanged);
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
            // NoneRadioButton
            // 
            this.NoneRadioButton.AutoSize = true;
            this.NoneRadioButton.Location = new System.Drawing.Point(182, 50);
            this.NoneRadioButton.Name = "NoneRadioButton";
            this.NoneRadioButton.Size = new System.Drawing.Size(66, 24);
            this.NoneRadioButton.TabIndex = 16;
            this.NoneRadioButton.TabStop = true;
            this.NoneRadioButton.Text = "None";
            this.NoneRadioButton.UseVisualStyleBackColor = true;
            // 
            // FoodKiosk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 233);
            this.Controls.Add(this.NoneRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.FiveRadioButton);
            this.Controls.Add(this.TenRadioButton);
            this.Controls.Add(this.TeaCheckBox);
            this.Controls.Add(this.BurgerCheckBox);
            this.Controls.Add(this.PizzaCheckBox);
            this.Name = "FoodKiosk";
            this.Text = "FoodKiosk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TotalCostLabel;
        private Button OrderButton;
        private RadioButton FiveRadioButton;
        private RadioButton TenRadioButton;
        private CheckBox TeaCheckBox;
        private CheckBox BurgerCheckBox;
        private CheckBox PizzaCheckBox;
        private Label label1;
        private Label label2;
        private RadioButton NoneRadioButton;
    }
}