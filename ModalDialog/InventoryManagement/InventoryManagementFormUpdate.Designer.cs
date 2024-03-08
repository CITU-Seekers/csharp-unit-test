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
            btnCancel = new Button();
            btnUpdate = new Button();
            numericItemStock = new NumericUpDown();
            txtItemPrice = new TextBox();
            txtItemName = new TextBox();
            txtItemID = new TextBox();
            cboItemType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericItemStock).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(191, 137);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(57, 137);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // numericItemStock
            // 
            numericItemStock.Location = new Point(25, 91);
            numericItemStock.Name = "numericItemStock";
            numericItemStock.Size = new Size(120, 23);
            numericItemStock.TabIndex = 11;
            // 
            // txtItemPrice
            // 
            txtItemPrice.Location = new Point(164, 90);
            txtItemPrice.Name = "txtItemPrice";
            txtItemPrice.PlaceholderText = "Item Price";
            txtItemPrice.Size = new Size(139, 23);
            txtItemPrice.TabIndex = 10;
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(25, 61);
            txtItemName.Name = "txtItemName";
            txtItemName.PlaceholderText = "Item Name";
            txtItemName.Size = new Size(278, 23);
            txtItemName.TabIndex = 9;
            // 
            // txtItemID
            // 
            txtItemID.Location = new Point(164, 20);
            txtItemID.Name = "txtItemID";
            txtItemID.PlaceholderText = "Item ID";
            txtItemID.Size = new Size(139, 23);
            txtItemID.TabIndex = 8;
            // 
            // cboItemType
            // 
            cboItemType.FormattingEnabled = true;
            cboItemType.Items.AddRange(new object[] { "Food", "Beverage" });
            cboItemType.Location = new Point(25, 20);
            cboItemType.Name = "cboItemType";
            cboItemType.Size = new Size(121, 23);
            cboItemType.TabIndex = 7;
            // 
            // InventoryManagementFormUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 180);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(numericItemStock);
            Controls.Add(txtItemPrice);
            Controls.Add(txtItemName);
            Controls.Add(txtItemID);
            Controls.Add(cboItemType);
            Name = "InventoryManagementFormUpdate";
            Text = "InventoryManagementFormUpdate";
            ((System.ComponentModel.ISupportInitialize)numericItemStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnUpdate;
        private NumericUpDown numericItemStock;
        private TextBox txtItemPrice;
        private TextBox txtItemName;
        private TextBox txtItemID;
        private System.Windows.Forms.ComboBox cboItemType;
    }
}