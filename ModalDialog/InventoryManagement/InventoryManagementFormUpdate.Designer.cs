namespace CodeChum
{
    partial class InventoryManagementFormUpdate
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
            cancelButton = new Button();
            updateButton = new Button();
            itemStockNumericUpDown = new NumericUpDown();
            itemPriceTextBox = new TextBox();
            itemNameTextBox = new TextBox();
            itemIDTextBox = new TextBox();
            itemTypeComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)itemStockNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(191, 137);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += btnCancel_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(57, 137);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 12;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += btnUpdate_Click;
            // 
            // itemStockNumericUpDown
            // 
            itemStockNumericUpDown.Location = new Point(25, 91);
            itemStockNumericUpDown.Name = "itemStockNumericUpDown";
            itemStockNumericUpDown.Size = new Size(120, 23);
            itemStockNumericUpDown.TabIndex = 11;
            // 
            // priceTextBox
            // 
            itemPriceTextBox.Location = new Point(164, 90);
            itemPriceTextBox.Name = "itemPriceTextBox";
            itemPriceTextBox.PlaceholderText = "Item Price";
            itemPriceTextBox.Size = new Size(139, 23);
            itemPriceTextBox.TabIndex = 10;
            // 
            // itemNameTextBox
            // 
            itemNameTextBox.Location = new Point(25, 61);
            itemNameTextBox.Name = "itemNameTextBox";
            itemNameTextBox.PlaceholderText = "Item Name";
            itemNameTextBox.Size = new Size(278, 23);
            itemNameTextBox.TabIndex = 9;
            // 
            // itemIDTextBox
            // 
            itemIDTextBox.Location = new Point(164, 20);
            itemIDTextBox.Name = "itemIDTextBox";
            itemIDTextBox.PlaceholderText = "Item ID";
            itemIDTextBox.Size = new Size(139, 23);
            itemIDTextBox.TabIndex = 8;
            // 
            // itemTypeComboBox
            // 
            itemTypeComboBox.FormattingEnabled = true;
            itemTypeComboBox.Items.AddRange(new object[] { "Food", "Beverage" });
            itemTypeComboBox.Location = new Point(25, 20);
            itemTypeComboBox.Name = "itemTypeComboBox";
            itemTypeComboBox.Size = new Size(121, 23);
            itemTypeComboBox.TabIndex = 7;
            // 
            // InventoryManagementFormUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 180);
            Controls.Add(cancelButton);
            Controls.Add(updateButton);
            Controls.Add(itemStockNumericUpDown);
            Controls.Add(itemPriceTextBox);
            Controls.Add(itemNameTextBox);
            Controls.Add(itemIDTextBox);
            Controls.Add(itemTypeComboBox);
            Name = "InventoryManagementFormUpdate";
            Text = "InventoryManagementFormUpdate";
            ((System.ComponentModel.ISupportInitialize)itemStockNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button updateButton;
        private NumericUpDown itemStockNumericUpDown;
        private TextBox itemNameTextBox;
        private TextBox itemIDTextBox;
        private System.Windows.Forms.ComboBox itemTypeComboBox;
        private TextBox itemPriceTextBox;
    }
}