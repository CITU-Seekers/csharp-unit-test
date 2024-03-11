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
    public partial class PotionBrewingRevamp : Form
    {
        public PotionBrewingRevamp()
        {
            InitializeComponent();
            InitializeTrackBars();
        }

        private void InitializeTrackBars()
        {
            //Min and Max values for each trackbar
            potencyTrackBar.Minimum = 0;
            potencyTrackBar.Maximum = 100;
            durationTrackBar.Minimum = 0;
            durationTrackBar.Maximum = 100;
            intensityTrackBar.Minimum = 0;
            intensityTrackBar.Maximum = 100;

            // Attach event handlers
            potencyTrackBar.Scroll += UpdatePotionSettings;
            durationTrackBar.Scroll += UpdatePotionSettings;
            intensityTrackBar.Scroll += UpdatePotionSettings;

            // Display initial potion settings
            UpdatePotionSettings(null, null);
        }

        private void UpdatePotionSettings(object sender, EventArgs e)
        {
            // Update labels or visuals based on TrackBar values
            int potency = potencyTrackBar.Value;
            int duration = durationTrackBar.Value;
            int intensity = intensityTrackBar.Value;

            PotencyLevel.Text = $"Potency: {potency}%";
            Duration.Text = $"Duration: {duration} seconds";
            IntensityLevel.Text = $"Intensity: {intensity}%";

            // You can add additional logic to update visuals based on the potion settings
            UpdateVisuals(potencyTrackBar, potency);
            UpdateVisuals(durationTrackBar, duration);
            UpdateVisuals(intensityTrackBar, intensity);
        }

        private void UpdateVisuals(TrackBar trackBar, int value)
        {
            // Implement your logic to update visuals here
            // For example, change colors, display animations, etc.

            // Change the color if the level is 80-100%
            if (value >= 80 && value <= 100)
            {
                trackBar.BackColor = Color.Red;
            }
            else
            {
                // Reset to the default color
                trackBar.BackColor = SystemColors.Control;
            }
        }
    }
}
