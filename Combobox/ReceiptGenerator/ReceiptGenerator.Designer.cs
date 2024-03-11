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
            this.GenerateButton = new System.Windows.Forms.Button();
            this.DefaultRadioButton = new System.Windows.Forms.RadioButton();
            this.SpecialRadioButton = new System.Windows.Forms.RadioButton();
            this.ShirtCheckBox = new System.Windows.Forms.CheckBox();
            this.PantsCheckBox = new System.Windows.Forms.CheckBox();
            this.ShoesCheckBox = new System.Windows.Forms.CheckBox();
            this.PaymentMethodComboBox = new System.Windows.Forms.ComboBox();
            this.ReceiptLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(108, 173);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(112, 33);
            this.GenerateButton.TabIndex = 19;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // DefaultRadioButton
            // 
            this.DefaultRadioButton.AutoSize = true;
            this.DefaultRadioButton.Location = new System.Drawing.Point(203, 40);
            this.DefaultRadioButton.Name = "DefaultRadioButton";
            this.DefaultRadioButton.Size = new System.Drawing.Size(79, 24);
            this.DefaultRadioButton.TabIndex = 18;
            this.DefaultRadioButton.TabStop = true;
            this.DefaultRadioButton.Text = "Default";
            this.DefaultRadioButton.UseVisualStyleBackColor = true;
            // 
            // SpecialRadioButton
            // 
            this.SpecialRadioButton.AutoSize = true;
            this.SpecialRadioButton.Location = new System.Drawing.Point(203, 68);
            this.SpecialRadioButton.Name = "SpecialRadioButton";
            this.SpecialRadioButton.Size = new System.Drawing.Size(78, 24);
            this.SpecialRadioButton.TabIndex = 17;
            this.SpecialRadioButton.TabStop = true;
            this.SpecialRadioButton.Text = "Special";
            this.SpecialRadioButton.UseVisualStyleBackColor = true;
            // 
            // ShirtCheckBox
            // 
            this.ShirtCheckBox.AutoSize = true;
            this.ShirtCheckBox.Location = new System.Drawing.Point(24, 97);
            this.ShirtCheckBox.Name = "ShirtCheckBox";
            this.ShirtCheckBox.Size = new System.Drawing.Size(130, 24);
            this.ShirtCheckBox.TabIndex = 16;
            this.ShirtCheckBox.Text = "Shirt – Php 120";
            this.ShirtCheckBox.UseVisualStyleBackColor = true;
            // 
            // PantsCheckBox
            // 
            this.PantsCheckBox.AutoSize = true;
            this.PantsCheckBox.Location = new System.Drawing.Point(24, 69);
            this.PantsCheckBox.Name = "PantsCheckBox";
            this.PantsCheckBox.Size = new System.Drawing.Size(134, 24);
            this.PantsCheckBox.TabIndex = 15;
            this.PantsCheckBox.Text = "Pants – Php 150";
            this.PantsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShoesCheckBox
            // 
            this.ShoesCheckBox.AutoSize = true;
            this.ShoesCheckBox.Location = new System.Drawing.Point(24, 40);
            this.ShoesCheckBox.Name = "ShoesCheckBox";
            this.ShoesCheckBox.Size = new System.Drawing.Size(139, 24);
            this.ShoesCheckBox.TabIndex = 14;
            this.ShoesCheckBox.Text = "Shoes – Php 200";
            this.ShoesCheckBox.UseVisualStyleBackColor = true;
            // 
            // PaymentMethodComboBox
            // 
            this.PaymentMethodComboBox.FormattingEnabled = true;
            this.PaymentMethodComboBox.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Debit Card"});
            this.PaymentMethodComboBox.Location = new System.Drawing.Point(160, 128);
            this.PaymentMethodComboBox.Name = "PaymentMethodComboBox";
            this.PaymentMethodComboBox.Size = new System.Drawing.Size(143, 28);
            this.PaymentMethodComboBox.TabIndex = 21;
            // 
            // ReceiptLabel
            // 
            this.ReceiptLabel.Location = new System.Drawing.Point(24, 219);
            this.ReceiptLabel.Name = "ReceiptLabel";
            this.ReceiptLabel.Size = new System.Drawing.Size(279, 86);
            this.ReceiptLabel.TabIndex = 22;
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
            this.Controls.Add(this.ReceiptLabel);
            this.Controls.Add(this.PaymentMethodComboBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.DefaultRadioButton);
            this.Controls.Add(this.SpecialRadioButton);
            this.Controls.Add(this.ShirtCheckBox);
            this.Controls.Add(this.PantsCheckBox);
            this.Controls.Add(this.ShoesCheckBox);
            this.Name = "ReceiptGenerator";
            this.Text = "Receipt Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button GenerateButton;
        private RadioButton DefaultRadioButton;
        private RadioButton SpecialRadioButton;
        private CheckBox ShirtCheckBox;
        private CheckBox PantsCheckBox;
        private CheckBox ShoesCheckBox;
        private System.Windows.Forms.ComboBox PaymentMethodComboBox;
        private Label ReceiptLabel;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}