namespace CodeChum
{
    partial class InventoryManagementForm
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
            itemTypeComboBox = new System.Windows.Forms.ComboBox();
            itemIDTextBox = new TextBox();
            itemNameTextBox = new TextBox();
            itemPriceTextBox = new TextBox();
            itemStockNumericUpDown = new NumericUpDown();
            addButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)itemStockNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // cboItemType
            // 
            itemTypeComboBox.FormattingEnabled = true;
            itemTypeComboBox.Items.AddRange(new object[] { "Food", "Beverage" });
            itemTypeComboBox.Location = new Point(33, 27);
            itemTypeComboBox.Name = "itemTypeComboBox";
            itemTypeComboBox.Size = new Size(121, 23);
            itemTypeComboBox.TabIndex = 0;
            // 
            // txtItemID
            // 
            itemIDTextBox.Location = new Point(172, 27);
            itemIDTextBox.Name = "itemIDTextBox";
            itemIDTextBox.PlaceholderText = "Item ID";
            itemIDTextBox.Size = new Size(139, 23);
            itemIDTextBox.TabIndex = 1;
            // 
            // txtItemName
            // 
            itemNameTextBox.Location = new Point(33, 68);
            itemNameTextBox.Name = "itemNameTextBox";
            itemNameTextBox.PlaceholderText = "Item Name";
            itemNameTextBox.Size = new Size(278, 23);
            itemNameTextBox.TabIndex = 2;
            // 
            // txtItemPrice
            // 
            itemPriceTextBox.Location = new Point(172, 97);
            itemPriceTextBox.Name = "itemPriceTextBox";
            itemPriceTextBox.PlaceholderText = "Item Price";
            itemPriceTextBox.Size = new Size(139, 23);
            itemPriceTextBox.TabIndex = 3;
            // 
            // numericItemStock
            // 
            itemStockNumericUpDown.Location = new Point(33, 98);
            itemStockNumericUpDown.Name = "itemStockNumericUpDown";
            itemStockNumericUpDown.Size = new Size(120, 23);
            itemStockNumericUpDown.TabIndex = 4;
            // 
            // btnAdd
            // 
            addButton.Location = new Point(65, 144);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            cancelButton.Location = new Point(199, 144);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += btnCancel_Click;
            // 
            // InventoryManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 179);
            Controls.Add(cancelButton);
            Controls.Add(addButton);
            Controls.Add(itemStockNumericUpDown);
            Controls.Add(itemPriceTextBox);
            Controls.Add(itemNameTextBox);
            Controls.Add(itemIDTextBox);
            Controls.Add(itemTypeComboBox);
            Name = "InventoryManagementForm";
            Text = "InventoryManagementForm";
            ((System.ComponentModel.ISupportInitialize)itemStockNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox itemTypeComboBox;
        private TextBox itemIDTextBox;
        private TextBox itemNameTextBox;
        private TextBox itemPriceTextBox;
        private NumericUpDown itemStockNumericUpDown;
        private Button addButton;
        private Button cancelButton;
    }
}