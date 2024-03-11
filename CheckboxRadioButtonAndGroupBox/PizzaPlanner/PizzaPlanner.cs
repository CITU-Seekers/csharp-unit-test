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
            if (PepperoniCheckBox.Checked)
            {
                totalPrice += PepperoniPrice;
            }
            if (MushroomCheckBox.Checked)
            {
                totalPrice += MushroomPrice;
            }
            if (OnionCheckBox.Checked)
            {
                totalPrice += OnionPrice;
            }
            if (BaconCheckBox.Checked)
            {
                totalPrice += BaconPrice;
            }
            if (ExtraCheeseCheckBox.Checked)
            {
                totalPrice += ExtraCheesePrice;
            }

            // Calculate total cost based on selected crust type
            if (ThinCrustRadioButton.Checked)
            {
                totalPrice += ThinCrustPrice;
            }
            else if (HandTossedRadioButton.Checked)
            {
                totalPrice += HandTossedPrice;
            }
            else if (DeepDishRadioButton.Checked)
            {
                totalPrice += DeepDishPrice;
            }

            int pizzaNum = int.Parse(PizzaNum.Text);

            totalPrice *= pizzaNum;

            // Display the total cost in a label or perform further actions
            lblTotal.Text = $"Total Cost: {totalPrice:C}";
        }
    }
}
