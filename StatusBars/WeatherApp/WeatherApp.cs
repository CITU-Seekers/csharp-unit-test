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
    public partial class WeatherApp : Form
    {
        public WeatherApp()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            // Generate temperature based on a random value
            int tempIndex = rnd.Next(1, 101);

            // Determine weather condition based on temperature
            string weatherCondition;
            if (tempIndex >= 80)
            {
                weatherCondition = "Sunny";
            }
            else if (tempIndex >= 60)
            {
                weatherCondition = "Cloudy";
            }
            else if (tempIndex >= 40)
            {
                weatherCondition = "Rainy";
            }
            else
            {
                weatherCondition = "Snowy";
            }

            // Display the weather status
            weatherStatusLabel.Text = $"Temperature: {tempIndex}°F, Condition: {weatherCondition}";

        }
    }
}
