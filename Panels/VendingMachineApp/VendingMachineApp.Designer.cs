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
            Panel1 = new Panel();
            TotalLabel = new Label();
            ToPanel2Button = new Button();
            label2 = new Label();
            QuantityUpDown = new NumericUpDown();
            BevRadioButton = new RadioButton();
            ItemList = new System.Windows.Forms.ListBox();
            FoodRadioButton = new RadioButton();
            Panel2 = new Panel();
            BackToPanel1Button = new Button();
            ToPanel3Button = new Button();
            CardRadioButton = new RadioButton();
            CashRadioButton = new RadioButton();
            label1 = new Label();
            Panel4 = new Panel();
            label5 = new Label();
            ExitButton = new Button();
            label7 = new Label();
            label = new Label();
            Panel3Card = new Panel();
            BackToPanel2Button2 = new Button();
            txtCVC = new TextBox();
            txtExpiryDate = new TextBox();
            ToPanel4Button2 = new Button();
            txtCardNum = new TextBox();
            label4 = new Label();
            Panel3Cash = new Panel();
            ErrorLabel = new Label();
            BackToPanel2Button1 = new Button();
            ToPanel4Button1 = new Button();
            CashTextBox = new TextBox();
            label3 = new Label();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityUpDown).BeginInit();
            Panel2.SuspendLayout();
            Panel4.SuspendLayout();
            Panel3Card.SuspendLayout();
            Panel3Cash.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Controls.Add(TotalLabel);
            Panel1.Controls.Add(ToPanel2Button);
            Panel1.Controls.Add(label2);
            Panel1.Controls.Add(QuantityUpDown);
            Panel1.Controls.Add(BevRadioButton);
            Panel1.Controls.Add(ItemList);
            Panel1.Controls.Add(FoodRadioButton);
            Panel1.Location = new Point(26, 12);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(368, 329);
            Panel1.TabIndex = 0;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TotalLabel.Location = new Point(140, 244);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(45, 19);
            TotalLabel.TabIndex = 8;
            TotalLabel.Text = "Total: ";
            // 
            // ToPanel2Button
            // 
            ToPanel2Button.Location = new Point(128, 291);
            ToPanel2Button.Name = "ToPanel2Button";
            ToPanel2Button.Size = new Size(75, 23);
            ToPanel2Button.TabIndex = 7;
            ToPanel2Button.Text = "Next";
            ToPanel2Button.UseVisualStyleBackColor = true;
            ToPanel2Button.Click += ToPanel2Button_Click;
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
            // QuantityUpDown
            // 
            QuantityUpDown.Location = new Point(209, 205);
            QuantityUpDown.Name = "QuantityUpDown";
            QuantityUpDown.Size = new Size(120, 23);
            QuantityUpDown.TabIndex = 3;
            QuantityUpDown.ValueChanged += QuantityUpDown_ValueChanged;
            // 
            // BevRadioButton
            // 
            BevRadioButton.AutoSize = true;
            BevRadioButton.Location = new Point(31, 119);
            BevRadioButton.Name = "BevRadioButton";
            BevRadioButton.Size = new Size(73, 19);
            BevRadioButton.TabIndex = 2;
            BevRadioButton.TabStop = true;
            BevRadioButton.Text = "Beverage";
            BevRadioButton.UseVisualStyleBackColor = true;
            BevRadioButton.CheckedChanged += BevRadioButton_CheckedChanged;
            // 
            // ItemList
            // 
            ItemList.FormattingEnabled = true;
            ItemList.ItemHeight = 15;
            ItemList.Location = new Point(138, 15);
            ItemList.Name = "ItemList";
            ItemList.Size = new Size(201, 184);
            ItemList.TabIndex = 1;
            ItemList.SelectedIndexChanged += ItemList_SelectedIndexChanged;
            // 
            // FoodRadioButton
            // 
            FoodRadioButton.AutoSize = true;
            FoodRadioButton.Location = new Point(31, 78);
            FoodRadioButton.Name = "FoodRadioButton";
            FoodRadioButton.Size = new Size(52, 19);
            FoodRadioButton.TabIndex = 0;
            FoodRadioButton.TabStop = true;
            FoodRadioButton.Text = "Food";
            FoodRadioButton.UseVisualStyleBackColor = true;
            FoodRadioButton.CheckedChanged += FoodRadioButton_CheckedChanged;
            // 
            // Panel2
            // 
            Panel2.Controls.Add(BackToPanel1Button);
            Panel2.Controls.Add(ToPanel3Button);
            Panel2.Controls.Add(CardRadioButton);
            Panel2.Controls.Add(CashRadioButton);
            Panel2.Controls.Add(label1);
            Panel2.Location = new Point(401, 13);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(262, 190);
            Panel2.TabIndex = 1;
            Panel2.Visible = false;
            // 
            // BackToPanel1Button
            // 
            BackToPanel1Button.Location = new Point(89, 160);
            BackToPanel1Button.Name = "BackToPanel1Button";
            BackToPanel1Button.Size = new Size(75, 23);
            BackToPanel1Button.TabIndex = 9;
            BackToPanel1Button.Text = "Back";
            BackToPanel1Button.UseVisualStyleBackColor = true;
            BackToPanel1Button.Click += BackToPanel1Button_Click;
            // 
            // ToPanel3Button
            // 
            ToPanel3Button.Location = new Point(89, 131);
            ToPanel3Button.Name = "ToPanel3Button";
            ToPanel3Button.Size = new Size(75, 23);
            ToPanel3Button.TabIndex = 8;
            ToPanel3Button.Text = "Next";
            ToPanel3Button.UseVisualStyleBackColor = true;
            ToPanel3Button.Click += ToPanel3Button_Click;
            // 
            // CardRadioButton
            // 
            CardRadioButton.AutoSize = true;
            CardRadioButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CardRadioButton.Location = new Point(72, 87);
            CardRadioButton.Name = "CardRadioButton";
            CardRadioButton.Size = new Size(135, 23);
            CardRadioButton.TabIndex = 4;
            CardRadioButton.TabStop = true;
            CardRadioButton.Text = "Credit/Debit Card";
            CardRadioButton.UseVisualStyleBackColor = true;
            // 
            // CashRadioButton
            // 
            CashRadioButton.AutoSize = true;
            CashRadioButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CashRadioButton.Location = new Point(72, 58);
            CashRadioButton.Name = "CashRadioButton";
            CashRadioButton.Size = new Size(57, 23);
            CashRadioButton.TabIndex = 3;
            CashRadioButton.TabStop = true;
            CashRadioButton.Text = "Cash";
            CashRadioButton.UseVisualStyleBackColor = true;
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
            // Panel4
            // 
            Panel4.Controls.Add(label5);
            Panel4.Controls.Add(ExitButton);
            Panel4.Controls.Add(label7);
            Panel4.Controls.Add(label);
            Panel4.Location = new Point(677, 208);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(270, 185);
            Panel4.TabIndex = 4;
            Panel4.Visible = false;
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
            // ExitButton
            // 
            ExitButton.Location = new Point(101, 149);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 12;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
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
            // Panel3Card
            // 
            Panel3Card.Controls.Add(BackToPanel2Button2);
            Panel3Card.Controls.Add(txtCVC);
            Panel3Card.Controls.Add(txtExpiryDate);
            Panel3Card.Controls.Add(ToPanel4Button2);
            Panel3Card.Controls.Add(txtCardNum);
            Panel3Card.Controls.Add(label4);
            Panel3Card.Location = new Point(677, 12);
            Panel3Card.Name = "Panel3Card";
            Panel3Card.Size = new Size(260, 190);
            Panel3Card.TabIndex = 3;
            Panel3Card.Visible = false;
            // 
            // BackToPanel2Button2
            // 
            BackToPanel2Button2.Location = new Point(96, 157);
            BackToPanel2Button2.Name = "BackToPanel2Button2";
            BackToPanel2Button2.Size = new Size(75, 23);
            BackToPanel2Button2.TabIndex = 11;
            BackToPanel2Button2.Text = "Back";
            BackToPanel2Button2.UseVisualStyleBackColor = true;
            BackToPanel2Button2.Click += BackToPanel2Button2_Click;
            // 
            // txtCVC
            // 
            txtCVC.Location = new Point(136, 78);
            txtCVC.Name = "txtCVC";
            txtCVC.PlaceholderText = "CVC";
            txtCVC.Size = new Size(88, 23);
            txtCVC.TabIndex = 11;
            // 
            // txtExpiryDate
            // 
            txtExpiryDate.Location = new Point(42, 78);
            txtExpiryDate.Name = "txtExpiryDate";
            txtExpiryDate.PlaceholderText = "Expiry Date";
            txtExpiryDate.Size = new Size(88, 23);
            txtExpiryDate.TabIndex = 10;
            // 
            // ToPanel4Button2
            // 
            ToPanel4Button2.Location = new Point(96, 131);
            ToPanel4Button2.Name = "ToPanel4Button2";
            ToPanel4Button2.Size = new Size(75, 23);
            ToPanel4Button2.TabIndex = 9;
            ToPanel4Button2.Text = "Next";
            ToPanel4Button2.UseVisualStyleBackColor = true;
            ToPanel4Button2.Click += ToPanel4Button2_Click;
            // 
            // txtCardNum
            // 
            txtCardNum.Location = new Point(42, 48);
            txtCardNum.Name = "txtCardNum";
            txtCardNum.PlaceholderText = "Card Number";
            txtCardNum.Size = new Size(184, 23);
            txtCardNum.TabIndex = 8;
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
            // Panel3Cash
            // 
            Panel3Cash.Controls.Add(ErrorLabel);
            Panel3Cash.Controls.Add(BackToPanel2Button1);
            Panel3Cash.Controls.Add(ToPanel4Button1);
            Panel3Cash.Controls.Add(CashTextBox);
            Panel3Cash.Controls.Add(label3);
            Panel3Cash.Location = new Point(403, 209);
            Panel3Cash.Name = "Panel3Cash";
            Panel3Cash.Size = new Size(260, 154);
            Panel3Cash.TabIndex = 2;
            Panel3Cash.Visible = false;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(59, 65);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(0, 12);
            ErrorLabel.TabIndex = 11;
            // 
            // BackToPanel2Button1
            // 
            BackToPanel2Button1.Location = new Point(87, 125);
            BackToPanel2Button1.Name = "BackToPanel2Button1";
            BackToPanel2Button1.Size = new Size(75, 23);
            BackToPanel2Button1.TabIndex = 10;
            BackToPanel2Button1.Text = "Back";
            BackToPanel2Button1.UseVisualStyleBackColor = true;
            BackToPanel2Button1.Click += BackToPanel2Button1_Click;
            // 
            // ToPanel4Button1
            // 
            ToPanel4Button1.Location = new Point(87, 96);
            ToPanel4Button1.Name = "ToPanel4Button1";
            ToPanel4Button1.Size = new Size(75, 23);
            ToPanel4Button1.TabIndex = 9;
            ToPanel4Button1.Text = "Next";
            ToPanel4Button1.UseVisualStyleBackColor = true;
            ToPanel4Button1.Click += ToPanel4Button1_Click;
            // 
            // CashTextBox
            // 
            CashTextBox.Location = new Point(59, 39);
            CashTextBox.Name = "CashTextBox";
            CashTextBox.PlaceholderText = "Enter Cash Amount";
            CashTextBox.Size = new Size(155, 23);
            CashTextBox.TabIndex = 8;
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
            ClientSize = new Size(401, 352);
            Controls.Add(Panel4);
            Controls.Add(Panel2);
            Controls.Add(Panel3Cash);
            Controls.Add(Panel1);
            Controls.Add(Panel3Card);
            Name = "VendingMachineApp";
            Text = "VendingMachineApp";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityUpDown).EndInit();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            Panel4.ResumeLayout(false);
            Panel4.PerformLayout();
            Panel3Card.ResumeLayout(false);
            Panel3Card.PerformLayout();
            Panel3Cash.ResumeLayout(false);
            Panel3Cash.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel1;
        private System.Windows.Forms.ListBox ItemList;
        private RadioButton FoodRadioButton;
        private NumericUpDown QuantityUpDown;
        private RadioButton BevRadioButton;
        private Button ToPanel2Button;
        private Panel Panel2;
        private Label label1;
        private RadioButton radioButton3;
        private RadioButton CardRadioButton;
        private RadioButton CashRadioButton;
        private Button ToPanel3Button;
        private Panel Panel3Cash;
        private Label label3;
        private TextBox CashTextBox;
        private Button ToPanel4Button1;
        private Panel Panel3Card;
        private Button ToPanel4Button2;
        private TextBox txtCardNum;
        private Label label4;
        private TextBox txtCVC;
        private TextBox txtExpiryDate;
        private Button BackToPanel1Button;
        private Button BackToPanel2Button1;
        private Button BackToPanel2Button2;
        private Panel Panel4;
        private Label label5;
        private Button ExitButton;
        private Label label7;
        private Label label;
        private Label TotalLabel;
        private Label label2;
        private Label ErrorLabel;
    }
}