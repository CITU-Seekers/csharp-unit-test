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
    public partial class MyFavoritePlaylist : Form
    {
        public MyFavoritePlaylist()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (musicTextBox.Text.Length != 0)
            {
                regularListBox.Items.Add(musicTextBox.Text);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (regularListBox.SelectedIndex != -1)
            {
                favoritesListBox.Items.Remove(regularListBox.Items[regularListBox.SelectedIndex]);
                regularListBox.Items.RemoveAt(regularListBox.SelectedIndex);
            }
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            if (regularListBox.SelectedIndex != -1)
            {
                favoritesListBox.Items.Add(regularListBox.Items[regularListBox.SelectedIndex]);
            }
        }
    }
}
