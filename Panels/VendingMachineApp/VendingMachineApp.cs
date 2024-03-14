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
            quantityNumericUpDown.ValueChanged += QuantityUpDown_ValueChanged;
            quantityNumericUpDown.Value = 1;
        }

        private void FoodRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Display the food options from the vending machine in the listbox
            if (foodRadioButton.Checked)
            {
                beverageRadioButton.Checked = false;

                itemListBox.Items.Clear();
                DisplayFoodItems();
            }
        }

        private void BevRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Display the beverage options from the vending machine in the listbox
            if (beverageRadioButton.Checked)
            {
                foodRadioButton.Checked = false;

                itemListBox.Items.Clear();
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
            itemListBox.Items.Add($"{itemName} - ${price:F2}");
        }

        private void QuantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            // Calculate the total cost based on the selected item's price and quantity
            int quantity = (int)quantityNumericUpDown.Value;
            totalPrice = selectedPrice * quantity;

            // Display the total cost in the TotalLabel
            totalLabel.Text = $"Total: ${totalPrice:F2}";
        }

        private void ItemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Extract the price from the selected item's text and update the selectedPrice variable
            string selectedItemText = itemListBox.SelectedItem?.ToString();
            if (selectedItemText != null && selectedItemText.Contains("$"))
            {
                selectedPrice = double.Parse(selectedItemText.Split('$')[1]);
            }
            else
            {
                selectedPrice = 0.0;
            }

            int quantity = (int)quantityNumericUpDown.Value;
            totalPrice = selectedPrice * quantity;

            // Display the total cost in the TotalLabel
            totalLabel.Text = $"Total: ${totalPrice:F2}";
        }

        private void ToPanel2Button_Click(object sender, EventArgs e)
        {
            // Set the location of Panel2 to match the location of Panel1
            panel2.Location = panel1.Location;

            // Make Panel2 visible and hide Panel1
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void ToPanel3Button_Click(object sender, EventArgs e)
        {
            if (cashRadioButton.Checked)
            {
                // Set the location of Panel3 to match the location of Panel1
                cashPanel3.Location = panel1.Location;

                // Make Panel3 visible and hide Panel1
                cashPanel3.Visible = true;
                panel2.Visible = false;
            }
            else if (cardRadioButton.Checked)
            {
                // Set the location of Panel3 to match the location of Panel2
                cardPanel3.Location = panel2.Location;

                // Make Panel3 visible and hide Panel2
                cardPanel3.Visible = true;
                panel2.Visible = false;
            }
        }

        private void BackToPanel1Button_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void ToPanel4Button1_Click(object sender, EventArgs e)
        {
            //Compare the totalPrice with CashTextBox.Text
            double cash = double.Parse(cashTextBox.Text);
            if (cash >= totalPrice)
            {
                // Set the location of Panel4 to match the location of Panel3
                panel4.Location = cashPanel3.Location;

                // Make Panel4 visible and hide Panel3
                panel4.Visible = true;
                cashPanel3.Visible = false;
            }
            else
            {
                errorLabel.Text = "Insufficient funds!";
            }
        }

        private void BackToPanel2Button1_Click(object sender, EventArgs e)
        {
            cashPanel3.Visible = false;
            panel2.Visible = true;
        }

        private void BackToPanel2Button2_Click(object sender, EventArgs e)
        {
            cardPanel3.Visible = false;
            panel2.Visible = true;
        }

        private void ToPanel4Button2_Click(object sender, EventArgs e)
        {
            panel4.Location = cardPanel3.Location;
            panel4.Visible = true;
            cardPanel3.Visible = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
