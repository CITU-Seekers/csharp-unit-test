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
    public partial class DestinationDecoder : Form
    {
        public DestinationDecoder()
        {
            InitializeComponent();
        }

        private void btnReveal_Click(object sender, EventArgs e)
        {
            //pick a destination based on the user's selection
            switch (traitComboBox.SelectedIndex)
            {
                case 0:
                    destinationLabel.Text = "Machu Picchu, Peru";
                    break;
                case 1:
                    destinationLabel.Text = "The Great Barrier Reef, Australia";
                    break;
                case 2:
                    destinationLabel.Text = "The Maldives";
                    break;
                case 3:
                    destinationLabel.Text = "Rome, Italy";
                    break;
                case 4:
                    destinationLabel.Text = "Tokyo, Japan";
                    break;
                case 5:
                    destinationLabel.Text = "Amazon Rainforest, Brazil";
                    break;
                default:
                    destinationLabel.Text = "Destination";
                    break;
            }
        }
    }
}
