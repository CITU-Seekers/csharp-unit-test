namespace CodeChum
{
    partial class InventoryManagementApp
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
            ItemList = new ListView();
            ItemType = new ColumnHeader();
            ItemID = new ColumnHeader();
            ItemName = new ColumnHeader();
            ItemStock = new ColumnHeader();
            ItemPrice = new ColumnHeader();
            btnAddItem = new Button();
            btnUpdateItem = new Button();
            btnDeleteItem = new Button();
            SuspendLayout();
            // 
            // ItemList
            // 
            ItemList.Columns.AddRange(new ColumnHeader[] { ItemType, ItemID, ItemName, ItemStock, ItemPrice });
            ItemList.Location = new Point(34, 24);
            ItemList.Name = "ItemList";
            ItemList.Size = new Size(472, 190);
            ItemList.TabIndex = 0;
            ItemList.UseCompatibleStateImageBehavior = false;
            ItemList.View = View.Details;
            // 
            // ItemType
            // 
            ItemType.Text = "Type";
            ItemType.Width = 100;
            // 
            // ItemID
            // 
            ItemID.Text = "ID";
            ItemID.Width = 80;
            // 
            // ItemName
            // 
            ItemName.Text = "Name";
            ItemName.Width = 150;
            // 
            // ItemStock
            // 
            ItemStock.Text = "Stock";
            // 
            // ItemPrice
            // 
            ItemPrice.Text = "Price";
            ItemPrice.Width = 80;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(51, 229);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(85, 28);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnUpdateItem
            // 
            btnUpdateItem.Location = new Point(224, 229);
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.Size = new Size(85, 28);
            btnUpdateItem.TabIndex = 2;
            btnUpdateItem.Text = "Update Item";
            btnUpdateItem.UseVisualStyleBackColor = true;
            btnUpdateItem.Click += btnUpdateItem_Click;
            // 
            // btnDeleteItem
            // 
            btnDeleteItem.Location = new Point(406, 229);
            btnDeleteItem.Name = "btnDeleteItem";
            btnDeleteItem.Size = new Size(85, 28);
            btnDeleteItem.TabIndex = 3;
            btnDeleteItem.Text = "Delete Item";
            btnDeleteItem.UseVisualStyleBackColor = true;
            btnDeleteItem.Click += btnDeleteItem_Click;
            // 
            // InventoryManagementApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 296);
            Controls.Add(btnDeleteItem);
            Controls.Add(btnUpdateItem);
            Controls.Add(btnAddItem);
            Controls.Add(ItemList);
            Name = "InventoryManagementApp";
            Text = "InventoryManagementApp";
            ResumeLayout(false);
        }

        #endregion

        private ListView ItemList;
        private Button btnAddItem;
        private Button btnUpdateItem;
        private Button btnDeleteItem;
        private ColumnHeader ItemType;
        private ColumnHeader ItemID;
        private ColumnHeader ItemName;
        private ColumnHeader ItemStock;
        private ColumnHeader ItemPrice;
    }
}