namespace CodeChum
{
    partial class PizzaPlanner
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
            groupBox1 = new GroupBox();
            extraCheeseCheckBox = new CheckBox();
            baconCheckBox = new CheckBox();
            onionCheckBox = new CheckBox();
            mushroomCheckBox = new CheckBox();
            pepperoniCheckBox = new CheckBox();
            groupBox2 = new GroupBox();
            deepDishRadioButton = new RadioButton();
            handTossedRadioButton = new RadioButton();
            thinCrustRadioButton = new RadioButton();
            orderButton = new Button();
            totalLabel = new Label();
            pizzaTextBox = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(extraCheeseCheckBox);
            groupBox1.Controls.Add(baconCheckBox);
            groupBox1.Controls.Add(onionCheckBox);
            groupBox1.Controls.Add(mushroomCheckBox);
            groupBox1.Controls.Add(pepperoniCheckBox);
            groupBox1.Location = new Point(126, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(211, 201);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Toppings";
            // 
            // extraCheeseCheckBox
            // 
            extraCheeseCheckBox.AutoSize = true;
            extraCheeseCheckBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            extraCheeseCheckBox.Location = new Point(49, 153);
            extraCheeseCheckBox.Name = "extraCheeseCheckBox";
            extraCheeseCheckBox.Size = new Size(106, 23);
            extraCheeseCheckBox.TabIndex = 4;
            extraCheeseCheckBox.Text = "Extra Cheese";
            extraCheeseCheckBox.UseVisualStyleBackColor = true;
            // 
            // baconCheckBox
            // 
            baconCheckBox.AutoSize = true;
            baconCheckBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            baconCheckBox.Location = new Point(49, 124);
            baconCheckBox.Name = "baconCheckBox";
            baconCheckBox.Size = new Size(65, 23);
            baconCheckBox.TabIndex = 3;
            baconCheckBox.Text = "Bacon";
            baconCheckBox.UseVisualStyleBackColor = true;
            // 
            // onionCheckBox
            // 
            onionCheckBox.AutoSize = true;
            onionCheckBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            onionCheckBox.Location = new Point(49, 95);
            onionCheckBox.Name = "onionCheckBox";
            onionCheckBox.Size = new Size(72, 23);
            onionCheckBox.TabIndex = 2;
            onionCheckBox.Text = "Onions";
            onionCheckBox.UseVisualStyleBackColor = true;
            // 
            // mushroomCheckBox
            // 
            mushroomCheckBox.AutoSize = true;
            mushroomCheckBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            mushroomCheckBox.Location = new Point(49, 66);
            mushroomCheckBox.Name = "mushroomCheckBox";
            mushroomCheckBox.Size = new Size(102, 23);
            mushroomCheckBox.TabIndex = 1;
            mushroomCheckBox.Text = "Mushrooms";
            mushroomCheckBox.UseVisualStyleBackColor = true;
            // 
            // pepperoniCheckBox
            // 
            pepperoniCheckBox.AutoSize = true;
            pepperoniCheckBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            pepperoniCheckBox.Location = new Point(49, 37);
            pepperoniCheckBox.Name = "pepperoniCheckBox";
            pepperoniCheckBox.Size = new Size(89, 23);
            pepperoniCheckBox.TabIndex = 0;
            pepperoniCheckBox.Text = "Pepperoni";
            pepperoniCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(deepDishRadioButton);
            groupBox2.Controls.Add(handTossedRadioButton);
            groupBox2.Controls.Add(thinCrustRadioButton);
            groupBox2.Location = new Point(423, 68);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(211, 201);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Crust Types";
            // 
            // deepDishRadioButton
            // 
            deepDishRadioButton.AutoSize = true;
            deepDishRadioButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            deepDishRadioButton.Location = new Point(57, 107);
            deepDishRadioButton.Name = "deepDishRadioButton";
            deepDishRadioButton.Size = new Size(90, 23);
            deepDishRadioButton.TabIndex = 2;
            deepDishRadioButton.TabStop = true;
            deepDishRadioButton.Text = "Deep Dish";
            deepDishRadioButton.UseVisualStyleBackColor = true;
            // 
            // handTossedRadioButton
            // 
            handTossedRadioButton.AutoSize = true;
            handTossedRadioButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            handTossedRadioButton.Location = new Point(57, 78);
            handTossedRadioButton.Name = "handTossedRadioButton";
            handTossedRadioButton.Size = new Size(107, 23);
            handTossedRadioButton.TabIndex = 1;
            handTossedRadioButton.TabStop = true;
            handTossedRadioButton.Text = "Hand-Tossed";
            handTossedRadioButton.UseVisualStyleBackColor = true;
            // 
            // thinCrustRadioButton
            // 
            thinCrustRadioButton.AutoSize = true;
            thinCrustRadioButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            thinCrustRadioButton.Location = new Point(57, 49);
            thinCrustRadioButton.Name = "thinCrustRadioButton";
            thinCrustRadioButton.Size = new Size(90, 23);
            thinCrustRadioButton.TabIndex = 0;
            thinCrustRadioButton.TabStop = true;
            thinCrustRadioButton.Text = "Thin Crust";
            thinCrustRadioButton.UseVisualStyleBackColor = true;
            // 
            // orderButton
            // 
            orderButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            orderButton.Location = new Point(314, 336);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(104, 35);
            orderButton.TabIndex = 2;
            orderButton.Text = "Order";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += btnOrder_Click;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            totalLabel.Location = new Point(292, 398);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(82, 20);
            totalLabel.TabIndex = 3;
            totalLabel.Text = "Total Cost: ";
            // 
            // pizzaTextBox
            // 
            pizzaTextBox.Location = new Point(363, 290);
            pizzaTextBox.Name = "pizzaTextBox";
            pizzaTextBox.Size = new Size(100, 23);
            pizzaTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(239, 294);
            label1.Name = "label1";
            label1.Size = new Size(118, 19);
            label1.TabIndex = 5;
            label1.Text = "Number of Pizzas:";
            // 
            // PizzaPlanner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 534);
            Controls.Add(label1);
            Controls.Add(pizzaTextBox);
            Controls.Add(totalLabel);
            Controls.Add(orderButton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "PizzaPlanner";
            Text = "PizzaPlanner";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox pepperoniCheckBox;
        private GroupBox groupBox2;
        private CheckBox extraCheeseCheckBox;
        private CheckBox baconCheckBox;
        private CheckBox onionCheckBox;
        private CheckBox mushroomCheckBox;
        private RadioButton deepDishRadioButton;
        private RadioButton handTossedRadioButton;
        private RadioButton thinCrustRadioButton;
        private Button orderButton;
        private Label totalLabel;
        private TextBox pizzaTextBox;
        private Label label1;
    }
}