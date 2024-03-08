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
    public partial class TextDisplay : Form
    {
        public TextDisplay()
        {
            InitializeComponent();
        }

        private void DisplayTextButton_Click(object sender, EventArgs e)
        {
            Label.Text = TextBox.Text;
        }
    }
}
