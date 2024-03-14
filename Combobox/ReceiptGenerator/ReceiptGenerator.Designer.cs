namespace CodeChum
{
    partial class ReceiptGenerator
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
            this.generateButton = new System.Windows.Forms.Button();
            this.defaultRadioButton = new System.Windows.Forms.RadioButton();
            this.specialRadioButton = new System.Windows.Forms.RadioButton();
            this.shirtCheckBox = new System.Windows.Forms.CheckBox();
            this.pantsCheckBox = new System.Windows.Forms.CheckBox();
            this.shoesCheckBox = new System.Windows.Forms.CheckBox();
            this.paymentMethodComboBox = new System.Windows.Forms.ComboBox();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(108, 173);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(112, 33);
            this.generateButton.TabIndex = 19;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // defaultRadioButton
            // 
            this.defaultRadioButton.AutoSize = true;
            this.defaultRadioButton.Location = new System.Drawing.Point(203, 40);
            this.defaultRadioButton.Name = "defaultRadioButton";
            this.defaultRadioButton.Size = new System.Drawing.Size(79, 24);
            this.defaultRadioButton.TabIndex = 18;
            this.defaultRadioButton.TabStop = true;
            this.defaultRadioButton.Text = "Default";
            this.defaultRadioButton.UseVisualStyleBackColor = true;
            // 
            // specialRadioButton
            // 
            this.specialRadioButton.AutoSize = true;
            this.specialRadioButton.Location = new System.Drawing.Point(203, 68);
            this.specialRadioButton.Name = "specialRadioButton";
            this.specialRadioButton.Size = new System.Drawing.Size(78, 24);
            this.specialRadioButton.TabIndex = 17;
            this.specialRadioButton.TabStop = true;
            this.specialRadioButton.Text = "Special";
            this.specialRadioButton.UseVisualStyleBackColor = true;
            // 
            // shirtCheckBox
            // 
            this.shirtCheckBox.AutoSize = true;
            this.shirtCheckBox.Location = new System.Drawing.Point(24, 97);
            this.shirtCheckBox.Name = "shirtCheckBox";
            this.shirtCheckBox.Size = new System.Drawing.Size(130, 24);
            this.shirtCheckBox.TabIndex = 16;
            this.shirtCheckBox.Text = "Shirt – Php 120";
            this.shirtCheckBox.UseVisualStyleBackColor = true;
            // 
            // pantsCheckBox
            // 
            this.pantsCheckBox.AutoSize = true;
            this.pantsCheckBox.Location = new System.Drawing.Point(24, 69);
            this.pantsCheckBox.Name = "pantsCheckBox";
            this.pantsCheckBox.Size = new System.Drawing.Size(134, 24);
            this.pantsCheckBox.TabIndex = 15;
            this.pantsCheckBox.Text = "Pants – Php 150";
            this.pantsCheckBox.UseVisualStyleBackColor = true;
            // 
            // shoesCheckBox
            // 
            this.shoesCheckBox.AutoSize = true;
            this.shoesCheckBox.Location = new System.Drawing.Point(24, 40);
            this.shoesCheckBox.Name = "shoesCheckBox";
            this.shoesCheckBox.Size = new System.Drawing.Size(139, 24);
            this.shoesCheckBox.TabIndex = 14;
            this.shoesCheckBox.Text = "Shoes – Php 200";
            this.shoesCheckBox.UseVisualStyleBackColor = true;
            // 
            // paymentMethodComboBox
            // 
            this.paymentMethodComboBox.FormattingEnabled = true;
            this.paymentMethodComboBox.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Debit Card"});
            this.paymentMethodComboBox.Location = new System.Drawing.Point(160, 128);
            this.paymentMethodComboBox.Name = "paymentMethodComboBox";
            this.paymentMethodComboBox.Size = new System.Drawing.Size(143, 28);
            this.paymentMethodComboBox.TabIndex = 21;
            // 
            // receiptLabel
            // 
            this.receiptLabel.Location = new System.Drawing.Point(24, 219);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(279, 86);
            this.receiptLabel.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Payment Method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(213, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Promos";
            // 
            // ReceiptGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 324);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.paymentMethodComboBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.defaultRadioButton);
            this.Controls.Add(this.specialRadioButton);
            this.Controls.Add(this.shirtCheckBox);
            this.Controls.Add(this.pantsCheckBox);
            this.Controls.Add(this.shoesCheckBox);
            this.Name = "ReceiptGenerator";
            this.Text = "Receipt Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button generateButton;
        private RadioButton defaultRadioButton;
        private RadioButton specialRadioButton;
        private CheckBox shirtCheckBox;
        private CheckBox pantsCheckBox;
        private CheckBox shoesCheckBox;
        private System.Windows.Forms.ComboBox paymentMethodComboBox;
        private Label receiptLabel;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}