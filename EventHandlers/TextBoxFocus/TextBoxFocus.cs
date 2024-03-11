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
            MessageLabel.Text = "FirstTextBox is in focus.";
        }

        private void SecondTextBox_Enter(object sender, EventArgs e)
        {
            MessageLabel.Text = "SecondTextBox is in focus.";
        }

        private void ThirdTextBox_Enter(object sender, EventArgs e)
        {
            MessageLabel.Text = "ThirdTextBox is in focus.";
        }

        private void FocusOnTextBox(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Name.Equals("FirstTextBoxFocusButton"))
            {
                FirstTextBox.Focus();
            } else if (btn.Name.Equals("SecondTextBoxFocusButton"))
            {
                SecondTextBox.Focus(); 
            } else if (btn.Name.Equals("ThirdTextBoxFocusButton"))
            {
                ThirdTextBox.Focus();
            }
        }
    }
}
