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
            ExtraCheeseCheckBox = new CheckBox();
            BaconCheckBox = new CheckBox();
            OnionCheckBox = new CheckBox();
            MushroomCheckBox = new CheckBox();
            PepperoniCheckBox = new CheckBox();
            groupBox2 = new GroupBox();
            DeepDishRadioButton = new RadioButton();
            HandTossedRadioButton = new RadioButton();
            ThinCrustRadioButton = new RadioButton();
            btnOrder = new Button();
            lblTotal = new Label();
            PizzaNum = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ExtraCheeseCheckBox);
            groupBox1.Controls.Add(BaconCheckBox);
            groupBox1.Controls.Add(OnionCheckBox);
            groupBox1.Controls.Add(MushroomCheckBox);
            groupBox1.Controls.Add(PepperoniCheckBox);
            groupBox1.Location = new Point(126, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(211, 201);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Toppings";
            // 
            // ExtraCheeseCheckBox
            // 
            ExtraCheeseCheckBox.AutoSize = true;
            ExtraCheeseCheckBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ExtraCheeseCheckBox.Location = new Point(49, 153);
            ExtraCheeseCheckBox.Name = "ExtraCheeseCheckBox";
            ExtraCheeseCheckBox.Size = new Size(106, 23);
            ExtraCheeseCheckBox.TabIndex = 4;
            ExtraCheeseCheckBox.Text = "Extra Cheese";
            ExtraCheeseCheckBox.UseVisualStyleBackColor = true;
            // 
            // BaconCheckBox
            // 
            BaconCheckBox.AutoSize = true;
            BaconCheckBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BaconCheckBox.Location = new Point(49, 124);
            BaconCheckBox.Name = "BaconCheckBox";
            BaconCheckBox.Size = new Size(65, 23);
            BaconCheckBox.TabIndex = 3;
            BaconCheckBox.Text = "Bacon";
            BaconCheckBox.UseVisualStyleBackColor = true;
            // 
            // OnionCheckBox
            // 
            OnionCheckBox.AutoSize = true;
            OnionCheckBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            OnionCheckBox.Location = new Point(49, 95);
            OnionCheckBox.Name = "OnionCheckBox";
            OnionCheckBox.Size = new Size(72, 23);
            OnionCheckBox.TabIndex = 2;
            OnionCheckBox.Text = "Onions";
            OnionCheckBox.UseVisualStyleBackColor = true;
            // 
            // MushroomCheckBox
            // 
            MushroomCheckBox.AutoSize = true;
            MushroomCheckBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MushroomCheckBox.Location = new Point(49, 66);
            MushroomCheckBox.Name = "MushroomCheckBox";
            MushroomCheckBox.Size = new Size(102, 23);
            MushroomCheckBox.TabIndex = 1;
            MushroomCheckBox.Text = "Mushrooms";
            MushroomCheckBox.UseVisualStyleBackColor = true;
            // 
            // PepperoniCheckBox
            // 
            PepperoniCheckBox.AutoSize = true;
            PepperoniCheckBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PepperoniCheckBox.Location = new Point(49, 37);
            PepperoniCheckBox.Name = "PepperoniCheckBox";
            PepperoniCheckBox.Size = new Size(89, 23);
            PepperoniCheckBox.TabIndex = 0;
            PepperoniCheckBox.Text = "Pepperoni";
            PepperoniCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DeepDishRadioButton);
            groupBox2.Controls.Add(HandTossedRadioButton);
            groupBox2.Controls.Add(ThinCrustRadioButton);
            groupBox2.Location = new Point(423, 68);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(211, 201);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Crust Types";
            // 
            // DeepDishRadioButton
            // 
            DeepDishRadioButton.AutoSize = true;
            DeepDishRadioButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DeepDishRadioButton.Location = new Point(57, 107);
            DeepDishRadioButton.Name = "DeepDishRadioButton";
            DeepDishRadioButton.Size = new Size(90, 23);
            DeepDishRadioButton.TabIndex = 2;
            DeepDishRadioButton.TabStop = true;
            DeepDishRadioButton.Text = "Deep Dish";
            DeepDishRadioButton.UseVisualStyleBackColor = true;
            // 
            // HandTossedRadioButton
            // 
            HandTossedRadioButton.AutoSize = true;
            HandTossedRadioButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            HandTossedRadioButton.Location = new Point(57, 78);
            HandTossedRadioButton.Name = "HandTossedRadioButton";
            HandTossedRadioButton.Size = new Size(107, 23);
            HandTossedRadioButton.TabIndex = 1;
            HandTossedRadioButton.TabStop = true;
            HandTossedRadioButton.Text = "Hand-Tossed";
            HandTossedRadioButton.UseVisualStyleBackColor = true;
            // 
            // ThinCrustRadioButton
            // 
            ThinCrustRadioButton.AutoSize = true;
            ThinCrustRadioButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ThinCrustRadioButton.Location = new Point(57, 49);
            ThinCrustRadioButton.Name = "ThinCrustRadioButton";
            ThinCrustRadioButton.Size = new Size(90, 23);
            ThinCrustRadioButton.TabIndex = 0;
            ThinCrustRadioButton.TabStop = true;
            ThinCrustRadioButton.Text = "Thin Crust";
            ThinCrustRadioButton.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrder.Location = new Point(314, 336);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(104, 35);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(292, 398);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(82, 20);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total Cost: ";
            // 
            // PizzaNum
            // 
            PizzaNum.Location = new Point(363, 290);
            PizzaNum.Name = "PizzaNum";
            PizzaNum.Size = new Size(100, 23);
            PizzaNum.TabIndex = 4;
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
            Controls.Add(PizzaNum);
            Controls.Add(lblTotal);
            Controls.Add(btnOrder);
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
        private CheckBox PepperoniCheckBox;
        private GroupBox groupBox2;
        private CheckBox ExtraCheeseCheckBox;
        private CheckBox BaconCheckBox;
        private CheckBox OnionCheckBox;
        private CheckBox MushroomCheckBox;
        private RadioButton DeepDishRadioButton;
        private RadioButton HandTossedRadioButton;
        private RadioButton ThinCrustRadioButton;
        private Button btnOrder;
        private Label lblTotal;
        private TextBox PizzaNum;
        private Label label1;
    }
}