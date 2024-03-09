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
            if (MusicTextBox.Text.Length != 0)
            {
                RegularListBox.Items.Add(MusicTextBox.Text);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (RegularListBox.SelectedIndex != -1)
            {
                FavoritesListBox.Items.Remove(RegularListBox.Items[RegularListBox.SelectedIndex]);
                RegularListBox.Items.RemoveAt(RegularListBox.SelectedIndex);
            }
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            if (RegularListBox.SelectedIndex != -1)
            {
                FavoritesListBox.Items.Add(RegularListBox.Items[RegularListBox.SelectedIndex]);
            }
        }
    }
}
