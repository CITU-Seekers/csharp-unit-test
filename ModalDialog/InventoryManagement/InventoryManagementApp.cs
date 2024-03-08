using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChum
{
    public partial class InventoryManagementApp : Form
    {
        public InventoryManagementForm addForm;
        public InventoryManagementFormUpdate updateForm;
        public InventoryManagementApp()
        {
            InitializeComponent();
            addForm = new InventoryManagementForm();
            updateForm = new InventoryManagementFormUpdate();
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if (ItemList.SelectedItems.Count > 0)
            {
                // Retrieve selected item details
                string selectedItemType = ItemList.SelectedItems[0].SubItems[0].Text;
                string selectedItemID = ItemList.SelectedItems[0].SubItems[1].Text;
                string selectedItemName = ItemList.SelectedItems[0].SubItems[2].Text;
                string selectedItemStock = ItemList.SelectedItems[0].SubItems[3].Text;
                string selectedItemPrice = ItemList.SelectedItems[0].SubItems[4].Text;

                //InventoryManagementFormUpdate updateForm = new InventoryManagementFormUpdate();

                // Set the selected item details in the update form
                updateForm.Update_ItemType = selectedItemType;
                updateForm.Update_ItemID = selectedItemID;
                updateForm.Update_ItemName = selectedItemName;
                updateForm.Update_ItemStock = selectedItemStock;
                updateForm.Update_ItemPrice = selectedItemPrice;

                // Set initial values just before showing the update form
                updateForm.InitializeValues();

                // Show the update form
                updateForm.ShowDialog();

                // Update the ItemList with the modified details
                ItemList.SelectedItems[0].SubItems[0].Text = updateForm.Update_ItemType;
                ItemList.SelectedItems[0].SubItems[1].Text = updateForm.Update_ItemID;
                ItemList.SelectedItems[0].SubItems[2].Text = updateForm.Update_ItemName;
                ItemList.SelectedItems[0].SubItems[3].Text = updateForm.Update_ItemStock;
                ItemList.SelectedItems[0].SubItems[4].Text = updateForm.Update_ItemPrice;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            addForm.ResetProperties();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                string[] item = { addForm.Add_ItemType, addForm.Add_ItemID, addForm.Add_ItemName, addForm.Add_ItemStock, addForm.Add_ItemPrice };
                ItemList.Items.Add(new ListViewItem(item));
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ItemList.SelectedItems)
            {
                ItemList.Items.Remove(item);
            }
        }
    }
}
