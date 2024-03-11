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
    public partial class FoodKiosk : Form
    {
        double pizzaPrice = 100, burgerPrice = 80, teaPrice = 50;

        private void TotalCostLabel_Click(object sender, EventArgs e)
        {

        }

        private void FiveRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TenRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TeaCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BurgerCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PizzaCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        public FoodKiosk()
        {
            InitializeComponent();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            double total = 0;
            if (PizzaCheckBox.Checked) { total += pizzaPrice; }
            if (BurgerCheckBox.Checked) { total += burgerPrice; }
            if (TeaCheckBox.Checked) { total += teaPrice; }

            if (FiveRadioButton.Checked) { total *= 0.95; }
            else if (TenRadioButton.Checked) { total *= 0.9; }

            TotalCostLabel.Text = "Total: " + "Php " + total.ToString("F");
        }
    }
}
