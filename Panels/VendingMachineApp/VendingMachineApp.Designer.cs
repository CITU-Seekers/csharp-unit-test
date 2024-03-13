namespace CodeChum
{
    partial class VendingMachineApp
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
            panel1 = new Panel();
            totalLabel = new Label();
            toPanel2Button = new Button();
            label2 = new Label();
            quantityNumericUpDown = new NumericUpDown();
            beverageRadioButton = new RadioButton();
            itemListBox = new ListBox();
            foodRadioButton = new RadioButton();
            panel2 = new Panel();
            backToPanel1Button = new Button();
            toPanel3Button = new Button();
            cardRadioButton = new RadioButton();
            cashRadioButton = new RadioButton();
            label1 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            exitButton = new Button();
            label7 = new Label();
            label = new Label();
            cardPanel3 = new Panel();
            cardBackToPanel2Button = new Button();
            cvcTextBox = new TextBox();
            expiryDateTextBox = new TextBox();
            cardToPanel4Button = new Button();
            cardNumberTextBox = new TextBox();
            label4 = new Label();
            cashPanel3 = new Panel();
            errorLabel = new Label();
            cashBackToPanel2Button = new Button();
            cashToPanel4Button = new Button();
            cashTextBox = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            cardPanel3.SuspendLayout();
            cashPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(totalLabel);
            panel1.Controls.Add(toPanel2Button);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(quantityNumericUpDown);
            panel1.Controls.Add(beverageRadioButton);
            panel1.Controls.Add(itemListBox);
            panel1.Controls.Add(foodRadioButton);
            panel1.Location = new Point(26, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 329);
            panel1.TabIndex = 0;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            totalLabel.Location = new Point(140, 244);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(45, 19);
            totalLabel.TabIndex = 8;
            totalLabel.Text = "Total: ";
            // 
            // toPanel2Button
            // 
            toPanel2Button.Location = new Point(128, 291);
            toPanel2Button.Name = "toPanel2Button";
            toPanel2Button.Size = new Size(75, 23);
            toPanel2Button.TabIndex = 7;
            toPanel2Button.Text = "Next";
            toPanel2Button.UseVisualStyleBackColor = true;
            toPanel2Button.Click += ToPanel2Button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(140, 205);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 6;
            label2.Text = "Quantity";
            // 
            // quantityNumericUpDown
            // 
            quantityNumericUpDown.Location = new Point(209, 205);
            quantityNumericUpDown.Name = "quantityNumericUpDown";
            quantityNumericUpDown.Size = new Size(120, 23);
            quantityNumericUpDown.TabIndex = 3;
            quantityNumericUpDown.ValueChanged += QuantityUpDown_ValueChanged;
            // 
            // beverageRadioButton
            // 
            beverageRadioButton.AutoSize = true;
            beverageRadioButton.Location = new Point(31, 119);
            beverageRadioButton.Name = "beverageRadioButton";
            beverageRadioButton.Size = new Size(73, 19);
            beverageRadioButton.TabIndex = 2;
            beverageRadioButton.TabStop = true;
            beverageRadioButton.Text = "Beverage";
            beverageRadioButton.UseVisualStyleBackColor = true;
            beverageRadioButton.CheckedChanged += BevRadioButton_CheckedChanged;
            // 
            // itemListBox
            // 
            itemListBox.FormattingEnabled = true;
            itemListBox.ItemHeight = 15;
            itemListBox.Location = new Point(138, 15);
            itemListBox.Name = "itemListBox";
            itemListBox.Size = new Size(201, 184);
            itemListBox.TabIndex = 1;
            itemListBox.SelectedIndexChanged += ItemList_SelectedIndexChanged;
            // 
            // foodRadioButton
            // 
            foodRadioButton.AutoSize = true;
            foodRadioButton.Location = new Point(31, 78);
            foodRadioButton.Name = "foodRadioButton";
            foodRadioButton.Size = new Size(52, 19);
            foodRadioButton.TabIndex = 0;
            foodRadioButton.TabStop = true;
            foodRadioButton.Text = "Food";
            foodRadioButton.UseVisualStyleBackColor = true;
            foodRadioButton.CheckedChanged += FoodRadioButton_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(backToPanel1Button);
            panel2.Controls.Add(toPanel3Button);
            panel2.Controls.Add(cardRadioButton);
            panel2.Controls.Add(cashRadioButton);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(401, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(262, 190);
            panel2.TabIndex = 1;
            panel2.Visible = false;
            // 
            // backToPanel1Button
            // 
            backToPanel1Button.Location = new Point(89, 160);
            backToPanel1Button.Name = "backToPanel1Button";
            backToPanel1Button.Size = new Size(75, 23);
            backToPanel1Button.TabIndex = 9;
            backToPanel1Button.Text = "Back";
            backToPanel1Button.UseVisualStyleBackColor = true;
            backToPanel1Button.Click += BackToPanel1Button_Click;
            // 
            // toPanel3Button
            // 
            toPanel3Button.Location = new Point(89, 131);
            toPanel3Button.Name = "toPanel3Button";
            toPanel3Button.Size = new Size(75, 23);
            toPanel3Button.TabIndex = 8;
            toPanel3Button.Text = "Next";
            toPanel3Button.UseVisualStyleBackColor = true;
            toPanel3Button.Click += ToPanel3Button_Click;
            // 
            // cardRadioButton
            // 
            cardRadioButton.AutoSize = true;
            cardRadioButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cardRadioButton.Location = new Point(72, 87);
            cardRadioButton.Name = "cardRadioButton";
            cardRadioButton.Size = new Size(135, 23);
            cardRadioButton.TabIndex = 4;
            cardRadioButton.TabStop = true;
            cardRadioButton.Text = "Credit/Debit Card";
            cardRadioButton.UseVisualStyleBackColor = true;
            // 
            // cashRadioButton
            // 
            cashRadioButton.AutoSize = true;
            cashRadioButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cashRadioButton.Location = new Point(72, 58);
            cashRadioButton.Name = "cashRadioButton";
            cashRadioButton.Size = new Size(57, 23);
            cashRadioButton.TabIndex = 3;
            cashRadioButton.TabStop = true;
            cashRadioButton.Text = "Cash";
            cashRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 26);
            label1.Name = "label1";
            label1.Size = new Size(119, 19);
            label1.TabIndex = 0;
            label1.Text = "Mode of Payment";
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Controls.Add(exitButton);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label);
            panel4.Location = new Point(677, 208);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 185);
            panel4.TabIndex = 4;
            panel4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 37);
            label5.Name = "label5";
            label5.Size = new Size(179, 19);
            label5.TabIndex = 1;
            label5.Text = "Payment has been received.";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(101, 149);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 12;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += ExitButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(29, 97);
            label7.Name = "label7";
            label7.Size = new Size(196, 19);
            label7.TabIndex = 3;
            label7.Text = "Thank you for your patronage.";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(29, 68);
            label.Name = "label";
            label.Size = new Size(188, 19);
            label.TabIndex = 2;
            label.Text = "You may now get your order.";
            // 
            // cardPanel3
            // 
            cardPanel3.Controls.Add(cardBackToPanel2Button);
            cardPanel3.Controls.Add(cvcTextBox);
            cardPanel3.Controls.Add(expiryDateTextBox);
            cardPanel3.Controls.Add(cardToPanel4Button);
            cardPanel3.Controls.Add(cardNumberTextBox);
            cardPanel3.Controls.Add(label4);
            cardPanel3.Location = new Point(677, 12);
            cardPanel3.Name = "cardPanel3";
            cardPanel3.Size = new Size(260, 190);
            cardPanel3.TabIndex = 3;
            cardPanel3.Visible = false;
            // 
            // cardBackToPanel2Button2
            // 
            cardBackToPanel2Button.Location = new Point(96, 157);
            cardBackToPanel2Button.Name = "cardBackToPanel2Button";
            cardBackToPanel2Button.Size = new Size(75, 23);
            cardBackToPanel2Button.TabIndex = 11;
            cardBackToPanel2Button.Text = "Back";
            cardBackToPanel2Button.UseVisualStyleBackColor = true;
            cardBackToPanel2Button.Click += BackToPanel2Button2_Click;
            // 
            // cvcTextBox
            // 
            cvcTextBox.Location = new Point(136, 78);
            cvcTextBox.Name = "cvcTextBox";
            cvcTextBox.PlaceholderText = "CVC";
            cvcTextBox.Size = new Size(88, 23);
            cvcTextBox.TabIndex = 11;
            // 
            // expiryDateTextBox
            // 
            expiryDateTextBox.Location = new Point(42, 78);
            expiryDateTextBox.Name = "expiryDateTextBox";
            expiryDateTextBox.PlaceholderText = "Expiry Date";
            expiryDateTextBox.Size = new Size(88, 23);
            expiryDateTextBox.TabIndex = 10;
            // 
            // cardToPanel4Button
            // 
            cardToPanel4Button.Location = new Point(96, 131);
            cardToPanel4Button.Name = "cardToPanel4Button";
            cardToPanel4Button.Size = new Size(75, 23);
            cardToPanel4Button.TabIndex = 9;
            cardToPanel4Button.Text = "Next";
            cardToPanel4Button.UseVisualStyleBackColor = true;
            cardToPanel4Button.Click += ToPanel4Button2_Click;
            // 
            // cardNumberTextBox
            // 
            cardNumberTextBox.Location = new Point(42, 48);
            cardNumberTextBox.Name = "cardNumberTextBox";
            cardNumberTextBox.PlaceholderText = "Card Number";
            cardNumberTextBox.Size = new Size(184, 23);
            cardNumberTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 14);
            label4.Name = "label4";
            label4.Size = new Size(117, 19);
            label4.TabIndex = 7;
            label4.Text = "Credit/Debit Card";
            // 
            // cashPanel3
            // 
            cashPanel3.Controls.Add(errorLabel);
            cashPanel3.Controls.Add(cashBackToPanel2Button);
            cashPanel3.Controls.Add(cashToPanel4Button);
            cashPanel3.Controls.Add(cashTextBox);
            cashPanel3.Controls.Add(label3);
            cashPanel3.Location = new Point(403, 209);
            cashPanel3.Name = "cashPanel3";
            cashPanel3.Size = new Size(260, 154);
            cashPanel3.TabIndex = 2;
            cashPanel3.Visible = false;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(59, 65);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 12);
            errorLabel.TabIndex = 11;
            // 
            // cashBackToPanel2Button
            // 
            cashBackToPanel2Button.Location = new Point(87, 125);
            cashBackToPanel2Button.Name = "cashBackToPanel2Button";
            cashBackToPanel2Button.Size = new Size(75, 23);
            cashBackToPanel2Button.TabIndex = 10;
            cashBackToPanel2Button.Text = "Back";
            cashBackToPanel2Button.UseVisualStyleBackColor = true;
            cashBackToPanel2Button.Click += BackToPanel2Button1_Click;
            // 
            // cashToPanel4Button
            // 
            cashToPanel4Button.Location = new Point(87, 96);
            cashToPanel4Button.Name = "cashToPanel4Button";
            cashToPanel4Button.Size = new Size(75, 23);
            cashToPanel4Button.TabIndex = 9;
            cashToPanel4Button.Text = "Next";
            cashToPanel4Button.UseVisualStyleBackColor = true;
            cashToPanel4Button.Click += ToPanel4Button1_Click;
            // 
            // cashTextBox
            // 
            cashTextBox.Location = new Point(59, 39);
            cashTextBox.Name = "cashTextBox";
            cashTextBox.PlaceholderText = "Enter Cash Amount";
            cashTextBox.Size = new Size(155, 23);
            cashTextBox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 14);
            label3.Name = "label3";
            label3.Size = new Size(39, 19);
            label3.TabIndex = 7;
            label3.Text = "Cash";
            // 
            // VendingMachineApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 368);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(cashPanel3);
            Controls.Add(panel1);
            Controls.Add(cardPanel3);
            Name = "VendingMachineApp";
            Text = "VendingMachineApp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            cardPanel3.ResumeLayout(false);
            cardPanel3.PerformLayout();
            cashPanel3.ResumeLayout(false);
            cashPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private System.Windows.Forms.ListBox itemListBox;
        private RadioButton foodRadioButton;
        private NumericUpDown quantityNumericUpDown;
        private RadioButton beverageRadioButton;
        private Button toPanel2Button;
        private Panel panel2;
        private Label label1;
        private RadioButton radioButton3;
        private RadioButton cardRadioButton;
        private RadioButton cashRadioButton;
        private Button toPanel3Button;
        private Panel cashPanel3;
        private Label label3;
        private TextBox cashTextBox;
        private Button cashToPanel4Button;
        private Panel cardPanel3;
        private Button cardToPanel4Button;
        private TextBox cardNumberTextBox;
        private Label label4;
        private TextBox cvcTextBox;
        private TextBox expiryDateTextBox;
        private Button backToPanel1Button;
        private Button cashBackToPanel2Button;
        private Button cardBackToPanel2Button;
        private Panel panel4;
        private Label label5;
        private Button exitButton;
        private Label label7;
        private Label label;
        private Label totalLabel;
        private Label label2;
        private Label errorLabel;
    }
}