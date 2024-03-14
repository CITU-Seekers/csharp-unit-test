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

        public void ToggleDarkMode()
        {
            //Toggle dark mode
            if (this.BackColor == Color.White)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
                richTextBox.BackColor = Color.Gray;
                richTextBox.ForeColor = Color.White;
                mainMenuStrip.BackColor = Color.Gray;
                mainMenuStrip.ForeColor = Color.White;

            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                richTextBox.BackColor = Color.White;
                richTextBox.ForeColor = Color.Black;
                mainMenuStrip.BackColor = Color.White;
                mainMenuStrip.ForeColor = Color.Black;
            }
        }

        private void toggleDarkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleDarkMode();
        }
    }
}
