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
            if (!musicTextBox.Text.Equals(""))
            {
                musicListBox.Items.Add(musicTextBox.Text);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            musicListBox.Items.RemoveAt(musicListBox.SelectedIndex);
        }
    }
}
