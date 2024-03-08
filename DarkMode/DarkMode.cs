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
    public partial class DarkMode : Form
    {
        public DarkMode()
        {
            InitializeComponent();
            this.BackColor = Color.White;
        }

        private void toggleDarkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Toggle dark mode
            if (this.BackColor == Color.White)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
                TextBox.BackColor = Color.Gray;
                TextBox.ForeColor = Color.White;
                MainMenuStrip.BackColor = Color.Gray;
                MainMenuStrip.ForeColor = Color.White;

            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                TextBox.BackColor = Color.White;
                TextBox.ForeColor = Color.Black;
                MainMenuStrip.BackColor = Color.White;
                MainMenuStrip.ForeColor = Color.Black;
            }
        }
    }
}
