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
    public partial class ComboBoxCalculator : Form
    {
        public ComboBoxCalculator()
        {
            InitializeComponent();
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            try
            {
                double number1 = Convert.ToDouble(TextNumber1.Text);
                double number2 = Convert.ToDouble(TextNumber2.Text);
                double result;

                string operation = (string)OperationsComboBox.SelectedItem;

                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        result = number1 / number2;
                        break;
                    default:
                        return;
                }

                ResultLabel.Text = result.ToString("F");
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
