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
            Add_ItemType = cboItemType.SelectedItem.ToString();
            Add_ItemID = txtItemID.Text;
            Add_ItemName = txtItemName.Text;
            Add_ItemStock = numericItemStock.Value.ToString();
            Add_ItemPrice = txtItemPrice.Text;

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
            cboItemType.SelectedIndex = -1;
            txtItemID.Text = "";
            txtItemName.Text = "";
            numericItemStock.Value = 0;
            txtItemPrice.Text = "";
        }
    }
}
