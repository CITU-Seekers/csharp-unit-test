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
            string[] row = { nameTextBox.Text, emailTextBox.Text, phoneNumberTextBox.Text, telecomComboBox.SelectedItem.ToString() };

            contactListView.Items.Add(new ListViewItem(row));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if there is a selected item
            if (contactListView.SelectedItems.Count > 0)
            {
                // Update the selected item
                contactListView.SelectedItems[0].SubItems[0].Text = nameTextBox.Text;
                contactListView.SelectedItems[0].SubItems[1].Text = emailTextBox.Text;
                contactListView.SelectedItems[0].SubItems[2].Text = phoneNumberTextBox.Text;
                contactListView.SelectedItems[0].SubItems[3].Text = telecomComboBox.SelectedItem.ToString();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in contactListView.SelectedItems)
            {
                contactListView.Items.Remove(item);
            }
        }
    }
}
