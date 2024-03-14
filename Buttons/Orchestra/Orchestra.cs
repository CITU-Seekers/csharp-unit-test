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
    public partial class Orchestra : Form
    {
        public Orchestra()
        {
            InitializeComponent();
            messageLabel.Text = "Welcome to the orchestra!";
        }

        private void btnViolins_Click(object sender, EventArgs e)
        {
            celloButton.BackColor = Color.White;
            drumButton.BackColor = Color.White;
            trumpetButton.BackColor = Color.White;

            violinButton.BackColor = Color.Yellow;
            messageLabel.Text = "Violins are playing!";
        }

        private void btnCellos_Click(object sender, EventArgs e)
        {
            violinButton.BackColor = Color.White;
            drumButton.BackColor = Color.White;
            trumpetButton.BackColor = Color.White;

            celloButton.BackColor = Color.Yellow;
            messageLabel.Text = "Cellos are playing!";
        }

        private void btnTrumpets_Click(object sender, EventArgs e)
        {
            violinButton.BackColor = Color.White;
            drumButton.BackColor = Color.White;
            celloButton.BackColor = Color.White;

            trumpetButton.BackColor = Color.Yellow;
            messageLabel.Text = "Trumpets are playing!";
        }

        private void btnDrums_Click(object sender, EventArgs e)
        {
            violinButton.BackColor = Color.White;
            celloButton.BackColor = Color.White;
            trumpetButton.BackColor = Color.White;

            drumButton.BackColor = Color.Yellow;
            messageLabel.Text = "Drums are playing!";
        }
    }
}
