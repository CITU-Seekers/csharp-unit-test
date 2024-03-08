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
    public partial class Brightness : Form
    {
        public Brightness()
        {
            InitializeComponent();
            BrightnessTrackBar.Minimum = 0;
            BrightnessTrackBar.Maximum = 100;
            lblBrightness.Text = $"Brightness Level: 0%";
        }

        private void BrightnessTrackBar_Scroll(object sender, EventArgs e)
        {
            SetLabelColor();
        }

        private void SetLabelColor()
        {
            int trackBarValue = BrightnessTrackBar.Value; // Get trackbar value (0-100)

            // Calculate transparency level based on trackbar value and desired mapping
            int transparencyLevel = (int)((trackBarValue / 100.0) * 255);

            // Set the label's background color with adjusted transparency
            lblColor.BackColor = Color.FromArgb(transparencyLevel, 255, 0, 0);

            // Calculate and display percentage (0-100) based on actual transparency level
            int percentage = (int)((transparencyLevel / 255.0) * 100);
            lblBrightness.Text = $"Brightness Level: {percentage}%";
        }
    }
}
