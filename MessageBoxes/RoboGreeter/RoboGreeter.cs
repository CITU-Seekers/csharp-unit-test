using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CodeChum
{
    public partial class RoboGreeter : Form
    {
        public bool isMessageBoxClosed = false;
        public RoboGreeter()
        {
            InitializeComponent();
        }

        private void btnGreet_Click(object sender, EventArgs e)
        {
            string userName = GreeterName.Text.Trim();

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Hello there! It's always nice to know someone's name. Please enter your name before clicking 'Greet.'", "Friendly Reminder", MessageBoxButtons.OK);
                isMessageBoxClosed = true;
            }
            else
            {
                MessageBox.Show($"Hello, {userName}! Welcome to CodeVille!", "Greetings", MessageBoxButtons.OK);
                isMessageBoxClosed = true;
            }
        }

        private void btnFarewell_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye! Come back soon to CodeVille.", "Farewell", MessageBoxButtons.OK);
            isMessageBoxClosed = true;
        }
    }
}
