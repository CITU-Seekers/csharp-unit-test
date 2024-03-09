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
                StatusLabel.Text = "Creating new file...";
            }
            else if (menuItem.Text.Equals("Open"))
            {
                StatusLabel.Text = "Opening file...";
            }
            else if (menuItem.Text.Equals("Save"))
            {
                StatusLabel.Text = "Saving file...";
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
                StatusLabel.ForeColor = Color.Red;
            }
            else if (menuItem.Text.Equals("Green"))
            {
                StatusLabel.ForeColor = Color.Green;
            }
            else if (menuItem.Text.Equals("Blue"))
            {
                StatusLabel.ForeColor = Color.Blue;
            }
        }
    }
}
