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
            txtItemName.Text = Update_ItemName;
            cboItemType.SelectedItem = Update_ItemType;
            txtItemID.Text = Update_ItemID;
            numericItemStock.Value = Convert.ToInt32(Update_ItemStock);
            txtItemPrice.Text = Update_ItemPrice;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update_ItemName = txtItemName.Text;
            Update_ItemType = cboItemType.SelectedItem.ToString();
            Update_ItemID = txtItemID.Text;
            Update_ItemStock = numericItemStock.Value.ToString();
            Update_ItemPrice = txtItemPrice.Text;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
