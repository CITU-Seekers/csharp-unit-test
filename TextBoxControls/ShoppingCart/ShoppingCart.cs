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
    public partial class ShoppingCart : Form
    {
        public ShoppingCart()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string input = itemTextBox.Text;

            if (!string.IsNullOrEmpty(input))
            {
                decimal totalCost = CalculateTotal(input);
                totalPriceLabel.Text = totalCost.ToString();
            }
            else
            {
                totalPriceLabel.Text = "Please enter item prices.";
            }
        }

        private decimal CalculateTotal(string input)
        {
            // Split the input into an array of prices
            string[] delimiters = { ",", " ", "\r\n", "\n" };
            string[] priceStrings = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            // Convert each price to a decimal and calculate the total
            decimal totalCost = priceStrings.Sum(price => decimal.Parse(price.Trim()));

            return totalCost;
        }
    }
}
