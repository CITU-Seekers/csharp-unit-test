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
    public partial class VendingMachineApp : Form
    {
        private double selectedPrice = 0.0;
        private double totalPrice = 0.0;
        public VendingMachineApp()
        {
            InitializeComponent();
            QuantityUpDown.ValueChanged += QuantityUpDown_ValueChanged;
            QuantityUpDown.Value = 1;
        }

        private void FoodRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Display the food options from the vending machine in the listbox
            if (FoodRadioButton.Checked)
            {
                BevRadioButton.Checked = false;

                ItemList.Items.Clear();
                DisplayFoodItems();
            }
        }

        private void BevRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Display the beverage options from the vending machine in the listbox
            if (BevRadioButton.Checked)
            {
                FoodRadioButton.Checked = false;

                ItemList.Items.Clear();
                DisplayBeverageItems();
            }
        }

        private void DisplayFoodItems()
        {
            // Food items with prices
            AddItemWithPrice("Potato Chips", 1.50);
            AddItemWithPrice("Tortilla Chips", 1.25);
            AddItemWithPrice("Pretzels", 1.00);
            AddItemWithPrice("Snickers", 1.75);
            AddItemWithPrice("M&Ms", 1.50);
            AddItemWithPrice("KitKat", 1.50);
        }

        private void DisplayBeverageItems()
        {
            // Beverage items with prices
            AddItemWithPrice("Coke", 1.25);
            AddItemWithPrice("Sprite", 1.25);
            AddItemWithPrice("Dr. Pepper", 1.50);
            AddItemWithPrice("Water", 1.00);
            AddItemWithPrice("Orange Juice", 2.00);
            AddItemWithPrice("Apple Juice", 2.00);
        }

        private void AddItemWithPrice(string itemName, double price)
        {
            ItemList.Items.Add($"{itemName} - ${price:F2}");
        }

        private void QuantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            // Calculate the total cost based on the selected item's price and quantity
            int quantity = (int)QuantityUpDown.Value;
            totalPrice = selectedPrice * quantity;

            // Display the total cost in the TotalLabel
            TotalLabel.Text = $"Total: ${totalPrice:F2}";
        }

        private void ItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Extract the price from the selected item's text and update the selectedPrice variable
            string selectedItemText = ItemList.SelectedItem?.ToString();
            if (selectedItemText != null && selectedItemText.Contains("$"))
            {
                selectedPrice = double.Parse(selectedItemText.Split('$')[1]);
            }
            else
            {
                selectedPrice = 0.0;
            }

            int quantity = (int)QuantityUpDown.Value;
            totalPrice = selectedPrice * quantity;

            // Display the total cost in the TotalLabel
            TotalLabel.Text = $"Total: ${totalPrice:F2}";
        }

        private void ToPanel2Button_Click(object sender, EventArgs e)
        {
            // Set the location of Panel2 to match the location of Panel1
            Panel2.Location = Panel1.Location;

            // Make Panel2 visible and hide Panel1
            Panel2.Visible = true;
            Panel1.Visible = false;
        }

        private void ToPanel3Button_Click(object sender, EventArgs e)
        {
            if (CashRadioButton.Checked)
            {
                // Set the location of Panel3 to match the location of Panel1
                Panel3Cash.Location = Panel1.Location;

                // Make Panel3 visible and hide Panel1
                Panel3Cash.Visible = true;
                Panel2.Visible = false;
            }
            else if (CardRadioButton.Checked)
            {
                // Set the location of Panel3 to match the location of Panel2
                Panel3Card.Location = Panel2.Location;

                // Make Panel3 visible and hide Panel2
                Panel3Card.Visible = true;
                Panel2.Visible = false;
            }
        }

        private void BackToPanel1Button_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel1.Visible = true;
        }

        private void ToPanel4Button1_Click(object sender, EventArgs e)
        {
            //Compare the totalPrice with CashTextBox.Text
            double cash = double.Parse(CashTextBox.Text);
            if (cash >= totalPrice)
            {
                // Set the location of Panel4 to match the location of Panel3
                Panel4.Location = Panel3Cash.Location;

                // Make Panel4 visible and hide Panel3
                Panel4.Visible = true;
                Panel3Cash.Visible = false;
            }
            else
            {
                ErrorLabel.Text = "Insufficient funds!";
            }
        }

        private void BackToPanel2Button1_Click(object sender, EventArgs e)
        {
            Panel3Cash.Visible = false;
            Panel2.Visible = true;
        }

        private void BackToPanel2Button2_Click(object sender, EventArgs e)
        {
            Panel3Card.Visible = false;
            Panel2.Visible = true;
        }

        private void ToPanel4Button2_Click(object sender, EventArgs e)
        {
            Panel4.Location = Panel3Card.Location;
            Panel4.Visible = true;
            Panel3Card.Visible = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
