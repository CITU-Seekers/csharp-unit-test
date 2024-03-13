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
    public partial class FoodMenu : Form
    {
        public FoodMenu()
        {
            InitializeComponent();
            orderSummaryLabel.Font = new Font("Segoe UI", 11);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Change the checkboxes based on the selection
            if (comboBox1.SelectedIndex == 0)
            {
                radioButton1.Text = "Burger";
                radioButton2.Text = "Salad";
                radioButton3.Text = "Pizza";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                radioButton1.Text = "Soda";
                radioButton2.Text = "Juice";
                radioButton3.Text = "Water";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add the selected item and its quantity to the label

            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {
                string selectedItem = GetSelectedRadioButtonText();
                int quantity;

                if (int.TryParse(textBox1.Text, out quantity) && quantity > 0)
                {
                    errorLabel.Text = string.Empty;
                    string itemDescription = $"{selectedItem} x {quantity}";

                    if (string.IsNullOrEmpty(orderSummaryLabel.Text))
                    {
                        orderSummaryLabel.Text = itemDescription;
                    }
                    else
                    {
                        // Append the new item to the existing label text
                        orderSummaryLabel.Text += Environment.NewLine + itemDescription;
                    }
                }
                else
                {
                    errorLabel.Text = "Please enter a valid quantity (a positive integer)";
                }
            }
            else
            {
                errorLabel.Text = "Please select an item using the radio buttons.";
            }
        }

        private string GetSelectedRadioButtonText()
        {
            if (radioButton1.Checked) return radioButton1.Text;
            if (radioButton2.Checked) return radioButton2.Text;
            if (radioButton3.Checked) return radioButton3.Text;

            return string.Empty;
        }
    }
}
