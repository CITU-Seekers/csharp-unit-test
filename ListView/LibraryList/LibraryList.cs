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
    public partial class LibraryList : Form
    {
        public LibraryList()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string author = authorTextBox.Text;
            string title = titleTextBox.Text;
            string isbn = isbnTextBox.Text;
            DateTime date = datePublishedDateTimePicker.Value;

            string[] row = { isbn, title, author, date.ToString() };
            bookListView.Items.Add(new ListViewItem(row));
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in bookListView.SelectedItems)
            {
                bookListView.Items.Remove(item);
            }
        }
    }
}
