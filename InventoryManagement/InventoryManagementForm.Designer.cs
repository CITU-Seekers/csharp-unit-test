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
            cboItemType = new System.Windows.Forms.ComboBox();
            txtItemID = new TextBox();
            txtItemName = new TextBox();
            txtItemPrice = new TextBox();
            numericItemStock = new NumericUpDown();
            btnAdd = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericItemStock).BeginInit();
            SuspendLayout();
            // 
            // cboItemType
            // 
            cboItemType.FormattingEnabled = true;
            cboItemType.Items.AddRange(new object[] { "Food", "Beverage" });
            cboItemType.Location = new Point(33, 27);
            cboItemType.Name = "cboItemType";
            cboItemType.Size = new Size(121, 23);
            cboItemType.TabIndex = 0;
            // 
            // txtItemID
            // 
            txtItemID.Location = new Point(172, 27);
            txtItemID.Name = "txtItemID";
            txtItemID.PlaceholderText = "Item ID";
            txtItemID.Size = new Size(139, 23);
            txtItemID.TabIndex = 1;
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(33, 68);
            txtItemName.Name = "txtItemName";
            txtItemName.PlaceholderText = "Item Name";
            txtItemName.Size = new Size(278, 23);
            txtItemName.TabIndex = 2;
            // 
            // txtItemPrice
            // 
            txtItemPrice.Location = new Point(172, 97);
            txtItemPrice.Name = "txtItemPrice";
            txtItemPrice.PlaceholderText = "Item Price";
            txtItemPrice.Size = new Size(139, 23);
            txtItemPrice.TabIndex = 3;
            // 
            // numericItemStock
            // 
            numericItemStock.Location = new Point(33, 98);
            numericItemStock.Name = "numericItemStock";
            numericItemStock.Size = new Size(120, 23);
            numericItemStock.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(65, 144);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(199, 144);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // InventoryManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 179);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(numericItemStock);
            Controls.Add(txtItemPrice);
            Controls.Add(txtItemName);
            Controls.Add(txtItemID);
            Controls.Add(cboItemType);
            Name = "InventoryManagementForm";
            Text = "InventoryManagementForm";
            ((System.ComponentModel.ISupportInitialize)numericItemStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cboItemType;
        private TextBox txtItemID;
        private TextBox txtItemName;
        private TextBox txtItemPrice;
        private NumericUpDown numericItemStock;
        private Button btnAdd;
        private Button btnCancel;
    }
}