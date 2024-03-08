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
            lblMessage.Text = "Welcome to the orchestra!";
        }

        private void btnViolins_Click(object sender, EventArgs e)
        {
            btnCellos.BackColor = Color.White;
            btnDrums.BackColor = Color.White;
            btnTrumpets.BackColor = Color.White;

            btnViolins.BackColor = Color.Yellow;
            lblMessage.Text = "Violins are playing!";
        }

        private void btnCellos_Click(object sender, EventArgs e)
        {
            btnViolins.BackColor = Color.White;
            btnDrums.BackColor = Color.White;
            btnTrumpets.BackColor = Color.White;

            btnCellos.BackColor = Color.Yellow;
            lblMessage.Text = "Cellos are playing!";
        }

        private void btnTrumpets_Click(object sender, EventArgs e)
        {
            btnViolins.BackColor = Color.White;
            btnDrums.BackColor = Color.White;
            btnCellos.BackColor = Color.White;

            btnTrumpets.BackColor = Color.Yellow;
            lblMessage.Text = "Trumpets are playing!";
        }

        private void btnDrums_Click(object sender, EventArgs e)
        {
            btnViolins.BackColor = Color.White;
            btnCellos.BackColor = Color.White;
            btnTrumpets.BackColor = Color.White;

            btnDrums.BackColor = Color.Yellow;
            lblMessage.Text = "Drums are playing!";
        }
    }
}
