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
    public partial class MusicList : Form
    {
        public MusicList()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!MusicTextBox.Text.Equals(""))
            {
                MusicListBox.Items.Add(MusicTextBox.Text);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            MusicListBox.Items.RemoveAt(MusicListBox.SelectedIndex);
        }
    }
}
