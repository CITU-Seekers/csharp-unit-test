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
            itemsListView = new ListView();
            ItemType = new ColumnHeader();
            ItemID = new ColumnHeader();
            ItemName = new ColumnHeader();
            ItemStock = new ColumnHeader();
            ItemPrice = new ColumnHeader();
            addItemButton = new Button();
            updateItemButton = new Button();
            deleteItemButton = new Button();
            SuspendLayout();
            // 
            // ItemList
            // 
            itemsListView.Columns.AddRange(new ColumnHeader[] { ItemType, ItemID, ItemName, ItemStock, ItemPrice });
            itemsListView.Location = new Point(34, 24);
            itemsListView.Name = "itemsListView";
            itemsListView.Size = new Size(472, 190);
            itemsListView.TabIndex = 0;
            itemsListView.UseCompatibleStateImageBehavior = false;
            itemsListView.View = View.Details;
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
            addItemButton.Location = new Point(51, 229);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(85, 28);
            addItemButton.TabIndex = 1;
            addItemButton.Text = "Add Item";
            addItemButton.UseVisualStyleBackColor = true;
            addItemButton.Click += btnAddItem_Click;
            // 
            // btnUpdateItem
            // 
            updateItemButton.Location = new Point(224, 229);
            updateItemButton.Name = "updateItemButton";
            updateItemButton.Size = new Size(85, 28);
            updateItemButton.TabIndex = 2;
            updateItemButton.Text = "Update Item";
            updateItemButton.UseVisualStyleBackColor = true;
            updateItemButton.Click += btnUpdateItem_Click;
            // 
            // btnDeleteItem
            // 
            deleteItemButton.Location = new Point(406, 229);
            deleteItemButton.Name = "deleteItemButton";
            deleteItemButton.Size = new Size(85, 28);
            deleteItemButton.TabIndex = 3;
            deleteItemButton.Text = "Delete Item";
            deleteItemButton.UseVisualStyleBackColor = true;
            deleteItemButton.Click += btnDeleteItem_Click;
            // 
            // InventoryManagementApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 296);
            Controls.Add(deleteItemButton);
            Controls.Add(updateItemButton);
            Controls.Add(addItemButton);
            Controls.Add(itemsListView);
            Name = "InventoryManagementApp";
            Text = "InventoryManagementApp";
            ResumeLayout(false);
        }

        #endregion

        private ListView itemsListView;
        private Button addItemButton;
        private Button updateItemButton;
        private Button deleteItemButton;
        private ColumnHeader ItemType;
        private ColumnHeader ItemID;
        private ColumnHeader ItemName;
        private ColumnHeader ItemStock;
        private ColumnHeader ItemPrice;
    }
}