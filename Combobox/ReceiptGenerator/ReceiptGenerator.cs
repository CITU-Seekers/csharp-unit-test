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
    public partial class ReceiptGenerator : Form
    {
        double shoesPrice = 200, pantsPrice = 150, shirtPrice = 120;
        public ReceiptGenerator()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            List<string> ItemsToBuy = new();
            double total = 0;

            if (ShoesCheckBox.Checked) 
            {
                ItemsToBuy.Add("Shoes");
                total += shoesPrice; 
            }
            if (PantsCheckBox.Checked)
            {
                ItemsToBuy.Add("Pants");
                total += pantsPrice;
            }
            if (ShirtCheckBox.Checked)
            {
                ItemsToBuy.Add("Shirt");
                total += shirtPrice;
            }

            if (DefaultRadioButton.Checked && total > 300) { total *= 0.95; }
            else if (SpecialRadioButton.Checked) { total *= 0.85; }

            string paymentMethod = (string)PaymentMethodComboBox.SelectedItem;

            string items = "";

            foreach (var item in ItemsToBuy)
            {
                if (item == ItemsToBuy.Last())
                {
                    items += item;
                }
                else
                {
                    items += item + ", ";
                }
            }

            string receiptText = "Welcome to Cody Store!\n" +
                "Items: " + items + "\n" +
                "Payment Method: " + paymentMethod + "\n" +
                "Total Cost: Php " + total.ToString("F");

            ReceiptLabel.Text = receiptText;
        }
    }
}
