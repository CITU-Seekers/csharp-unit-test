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
    public partial class TextRepeater : Form
    {
        public TextRepeater()
        {
            InitializeComponent();
        }

        private void DisplayTextButton_Click(object sender, EventArgs e)
        {
            string textToRepeat = inputTextBox.Text;
            int count = Convert.ToInt32(numberTextBox.Text);
            string output = "";

            for (int i = 0; i < count; i++)
            {
                if (i == count - 1)
                {
                    output += textToRepeat;
                }
                else
                {
                    output += textToRepeat + " ";
                }
            }

            resultTextBox.Text = output;
        }
    }
}
