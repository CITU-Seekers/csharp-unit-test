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
    public partial class MenuStripActivity : Form
    {
        public MenuStripActivity()
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
                // statusLabel.Text = "Closing app...";
                this.Close();
            }
        }

        private void fileMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
