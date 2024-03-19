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
    public partial class BookLibrary : Form
    {
        //Create a dictionary for Title and Full Publication Date
        Dictionary<string, string> BookPubDate = new Dictionary<string, string>();
        public BookLibrary()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Get the full publication date from the date time picker and add it to the dictionary
            BookPubDate.Add(titleTextBox.Text, publishedDateDateTimePicker.Value.ToLongDateString());

            //Get the details from the textboxes and add to the list view
            string[] row = { titleTextBox.Text, authorTextBox.Text, genreTextBox.Text, publishedDateDateTimePicker.Value.Year.ToString(), statusComboBox.SelectedItem.ToString() };

            //Get the only the year from the date time picker
            bookListView.Items.Add(new ListViewItem(row));
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (bookListView.SelectedItems.Count > 0)
            {
                bookListView.SelectedItems[0].SubItems[0].Text = titleTextBox.Text;
                bookListView.SelectedItems[0].SubItems[1].Text = authorTextBox.Text;
                bookListView.SelectedItems[0].SubItems[2].Text = genreTextBox.Text;
                bookListView.SelectedItems[0].SubItems[3].Text = publishedDateDateTimePicker.Value.Year.ToString();
                bookListView.SelectedItems[0].SubItems[4].Text = statusComboBox.SelectedItem.ToString();

                // Update the selected item in the BookPubDate dictionary
                string title = bookListView.SelectedItems[0].SubItems[0].Text;
                if (BookPubDate.ContainsKey(title))
                {
                    BookPubDate[title] = publishedDateDateTimePicker.Value.ToLongDateString();
                }
                else
                {
                    BookPubDate.Add(titleTextBox.Text, publishedDateDateTimePicker.Value.ToLongDateString());
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //Delete the selected item
            foreach (ListViewItem item in bookListView.SelectedItems)
            {
                bookListView.Items.Remove(item);
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            //Get the details from the selected item and create a new tab to display the details in labels
            if (bookListView.SelectedItems.Count > 0)
            {
                //Create a new tab
                TabPage newTab = new TabPage();

                //Create a new label
                Label lblTitle = new Label();
                Label lblAuthor = new Label();
                Label lblGenre = new Label();
                Label lblPubDate = new Label();
                Label lblStatus = new Label();

                Button exitButton = new Button();

                //Set the text of the labels
                lblTitle.Text = "Title: " + bookListView.SelectedItems[0].SubItems[0].Text;
                lblAuthor.Text = "Author: " + bookListView.SelectedItems[0].SubItems[1].Text;
                lblGenre.Text = "Genre: " + bookListView.SelectedItems[0].SubItems[2].Text;
                //Get the full publication date from the dictionary
                lblPubDate.Text = "Publication Date: " + BookPubDate[bookListView.SelectedItems[0].SubItems[0].Text].ToString();
                lblStatus.Text = "Status: " + bookListView.SelectedItems[0].SubItems[4].Text;

                exitButton.Text = "Exit";

                //Set the location of controls
                lblTitle.Location = new Point(64, 42);
                lblAuthor.Location = new Point(64, 62);
                lblGenre.Location = new Point(64, 82);
                lblPubDate.Location = new Point(64, 102);
                lblStatus.Location = new Point(64, 122);
                exitButton.Location = new Point(64, 200);

                //Set label sizes
                lblTitle.Size = new Size(500, 20);
                lblAuthor.Size = new Size(500, 20);
                lblGenre.Size = new Size(500, 20);
                lblPubDate.Size = new Size(500, 20);
                lblStatus.Size = new Size(500, 20);

                //Set font size of the labels
                lblTitle.Font = new Font("Arial", 12);
                lblAuthor.Font = new Font("Arial", 12);
                lblGenre.Font = new Font("Arial", 12);
                lblPubDate.Font = new Font("Arial", 12);
                lblStatus.Font = new Font("Arial", 12);

                //Set the control names
                lblTitle.Name = "titleLabel";
                lblAuthor.Name = "authorLabel";
                lblGenre.Name = "genreLabel";
                lblPubDate.Name = "pubDateLabel";
                lblStatus.Name = "statusLabel";
                exitButton.Name = "exitButtonLabel";

                exitButton.Click += (s, args) => mainTabControl.TabPages.Remove(newTab);

                //Add the labels to the panel
                newTab.Controls.Add(lblTitle);
                newTab.Controls.Add(lblAuthor);
                newTab.Controls.Add(lblGenre);
                newTab.Controls.Add(lblPubDate);
                newTab.Controls.Add(lblStatus);
                newTab.Controls.Add(exitButton);


                //Set the text of the tab
                newTab.Text = bookListView.SelectedItems[0].SubItems[0].Text;

                //Add the tab to the tab control
                mainTabControl.TabPages.Add(newTab);
            }
        }
    }
}
