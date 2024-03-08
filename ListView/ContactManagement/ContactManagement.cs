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
    public partial class ContactManagement : Form
    {
        public ContactManagement()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] row = { ContactName.Text, ContactEmail.Text, ContactNum.Text, cboTelecom.SelectedItem.ToString() };

            ContactList.Items.Add(new ListViewItem(row));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if there is a selected item
            if (ContactList.SelectedItems.Count > 0)
            {
                // Update the selected item
                ContactList.SelectedItems[0].SubItems[0].Text = ContactName.Text;
                ContactList.SelectedItems[0].SubItems[1].Text = ContactEmail.Text;
                ContactList.SelectedItems[0].SubItems[2].Text = ContactNum.Text;
                ContactList.SelectedItems[0].SubItems[3].Text = cboTelecom.SelectedItem.ToString();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ContactList.SelectedItems)
            {
                ContactList.Items.Remove(item);
            }
        }
    }
}
