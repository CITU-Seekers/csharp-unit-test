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
    public partial class InventoryManagementForm : Form
    {
        public string Add_ItemName { get; set; }
        public string Add_ItemType { get; set; }
        public string Add_ItemID { get; set; }
        public string Add_ItemStock { get; set; }
        public string Add_ItemPrice { get; set; }

        public InventoryManagementForm()
        {
            InitializeComponent();
            ResetProperties();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_ItemType = itemTypeComboBox.SelectedItem.ToString();
            Add_ItemID = itemIDTextBox.Text;
            Add_ItemName = itemNameTextBox.Text;
            Add_ItemStock = itemStockNumericUpDown.Value.ToString();
            Add_ItemPrice = itemPriceTextBox.Text;

            this.DialogResult = DialogResult.OK; // Set DialogResult to OK before closing
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ResetProperties()
        {
            //Reset all components to empty
            itemTypeComboBox.SelectedIndex = -1;
            itemIDTextBox.Text = "";
            itemNameTextBox.Text = "";
            itemStockNumericUpDown.Value = 0;
            itemPriceTextBox.Text = "";
        }
    }
}
