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
                // StatusLabel.Text = "Closing app...";
                this.Close();
            }
        }
    }
}
