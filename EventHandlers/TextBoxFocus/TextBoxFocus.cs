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
    public partial class TextBoxFocus : Form
    {
        public TextBoxFocus()
        {
            InitializeComponent();
        }

        private void FirstTextBox_Enter(object sender, EventArgs e)
        {
            messageLabel.Text = "FirstTextBox is in focus.";
        }

        private void SecondTextBox_Enter(object sender, EventArgs e)
        {
            messageLabel.Text = "SecondTextBox is in focus.";
        }

        private void ThirdTextBox_Enter(object sender, EventArgs e)
        {
            messageLabel.Text = "ThirdTextBox is in focus.";
        }

        private void FocusOnTextBox(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Name.Equals("firstTextBoxFocusButton"))
            {
                firstTextBox.Focus();
            }
            else if (btn.Name.Equals("secondTextBoxFocusButton"))
            {
                secondTextBox.Focus();
            }
            else if (btn.Name.Equals("thirdTextBoxFocusButton"))
            {
                thirdTextBox.Focus();
            }
        }
    }
}
