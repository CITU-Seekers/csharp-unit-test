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
            string author = AuthorTextBox.Text;
            string title = TitleTextBox.Text;
            string isbn = IsbnTextBox.Text;
            DateTime date = DatePublishedDateTimePicker.Value;

            string[] row = { isbn, title, author, date.ToString() };
            BookListView.Items.Add(new ListViewItem(row));
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in BookListView.SelectedItems)
            {
                BookListView.Items.Remove(item);
            }
        }
    }
}
