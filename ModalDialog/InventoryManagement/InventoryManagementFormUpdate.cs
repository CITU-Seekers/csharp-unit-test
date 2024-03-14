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
    public partial class InventoryManagementFormUpdate : Form
    {
        public string Update_ItemName { get; set; }
        public string Update_ItemType { get; set; }
        public string Update_ItemID { get; set; }
        public string Update_ItemStock { get; set; }
        public string Update_ItemPrice { get; set; }
        public InventoryManagementFormUpdate()
        {
            InitializeComponent();
            InitializeValues();
        }

        public void InitializeValues()
        {
            itemNameTextBox.Text = Update_ItemName;
            itemTypeComboBox.SelectedItem = Update_ItemType;
            itemIDTextBox.Text = Update_ItemID;
            itemStockNumericUpDown.Value = Convert.ToInt32(Update_ItemStock);
            itemPriceTextBox.Text = Update_ItemPrice;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update_ItemName = itemNameTextBox.Text;
            Update_ItemType = itemTypeComboBox.SelectedItem.ToString();
            Update_ItemID = itemIDTextBox.Text;
            Update_ItemStock = itemStockNumericUpDown.Value.ToString();
            Update_ItemPrice = itemPriceTextBox.Text;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
