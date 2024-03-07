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
            string name = MovieName.Text;

            int selectedIndex = cboGenre.SelectedIndex;

            switch (selectedIndex)
            {
                case 0:
                    ComedyList.Items.Add(name);
                    break;
                case 1:
                    HorrorList.Items.Add(name);
                    break;
                case 2:
                    ActionList.Items.Add(name);
                    break;
                default:
                    break;
            }
        }
    }
}
