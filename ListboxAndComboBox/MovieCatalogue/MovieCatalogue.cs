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
    public partial class MovieCatalogue : Form
    {
        public MovieCatalogue()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = movieNameTextBox.Text;

            int selectedIndex = genreComboBox.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:
                    comedyListBox.Items.Add(name);
                    break;
                case 1:
                    horrorListBox.Items.Add(name);
                    break;
                case 2:
                    actionListBox.Items.Add(name);
                    break;
                default:
                    break;
            }
        }
    }
}
