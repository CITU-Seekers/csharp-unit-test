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
    public partial class NumberDisplay : Form
    {
        public NumberDisplay()
        {
            InitializeComponent();
        }

        private void IncrementTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                intervalNumericUpDown.Increment = Convert.ToInt32(incrementTextBox.Text);
            }
            catch (Exception ex)
            {
                intervalNumericUpDown.Increment = 1;
            }

        }

        private void NumericControl_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
