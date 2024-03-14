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
    public partial class PizzaPlanner : Form
    {
        // Constants for topping prices
        const double PepperoniPrice = 100;
        const double MushroomPrice = 50;
        const double OnionPrice = 50;
        const double BaconPrice = 75;
        const double ExtraCheesePrice = 25;

        // Constants for crust type prices
        const double ThinCrustPrice = 100;
        const double HandTossedPrice = 200;
        const double DeepDishPrice = 150;

        public PizzaPlanner()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            double totalPrice = 0;

            // Calculate total cost based on selected toppings
            if (pepperoniCheckBox.Checked)
            {
                totalPrice += PepperoniPrice;
            }
            if (mushroomCheckBox.Checked)
            {
                totalPrice += MushroomPrice;
            }
            if (onionCheckBox.Checked)
            {
                totalPrice += OnionPrice;
            }
            if (baconCheckBox.Checked)
            {
                totalPrice += BaconPrice;
            }
            if (extraCheeseCheckBox.Checked)
            {
                totalPrice += ExtraCheesePrice;
            }

            // Calculate total cost based on selected crust type
            if (thinCrustRadioButton.Checked)
            {
                totalPrice += ThinCrustPrice;
            }
            else if (handTossedRadioButton.Checked)
            {
                totalPrice += HandTossedPrice;
            }
            else if (deepDishRadioButton.Checked)
            {
                totalPrice += DeepDishPrice;
            }

            int pizzaNum = int.Parse(this.pizzaTextBox.Text);

            totalPrice *= pizzaNum;

            // Display the total cost in a label or perform further actions
            totalLabel.Text = $"Total Cost: {totalPrice:C}";
        }
    }
}
