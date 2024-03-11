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
    public partial class TemperatureConverter : Form
    {
        public TemperatureConverter()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal celsiusTemperature))
            {
                // Convert Celsius to Fahrenheit using the formula
                decimal fahrenheitTemperature = (celsiusTemperature * 9 / 5) + 32;

                // Display the result
                lblFahrenheit.Text = $"{fahrenheitTemperature:F2} °F";
            }
            else
            {
                // Display an error message for invalid input
                lblFahrenheit.Text = "Invalid input. Please enter a valid temperature in Celsius.";
            }
        }
    }
}
