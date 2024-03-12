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
    public partial class CascadeMenuActivity : Form
    {
        public CascadeMenuActivity()
        {
            InitializeComponent();
        }

        private void displayText(Object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            if (menuItem.Text.Equals("New"))
            {
                statusLabel.Text = "Creating new file...";
            }
            else if (menuItem.Text.Equals("Open"))
            {
                statusLabel.Text = "Opening file...";
            }
            else if (menuItem.Text.Equals("Save"))
            {
                statusLabel.Text = "Saving file...";
            }
            else if (menuItem.Text.Equals("Exit"))
            {
                this.Close();
            }
        }

        private void changeColor(Object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            if (menuItem.Text.Equals("Red"))
            {
                statusLabel.ForeColor = Color.Red;
            }
            else if (menuItem.Text.Equals("Green"))
            {
                statusLabel.ForeColor = Color.Green;
            }
            else if (menuItem.Text.Equals("Blue"))
            {
                statusLabel.ForeColor = Color.Blue;
            }
        }

        private void formatMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
