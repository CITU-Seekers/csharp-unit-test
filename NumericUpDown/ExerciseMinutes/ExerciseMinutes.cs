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
    public partial class ExerciseMinutes : Form
    {
        public ExerciseMinutes()
        {
            InitializeComponent();
            numericUpDownWalking.ValueChanged += UpdateTotalMinutesLabel;
            numericUpDownRunning.ValueChanged += UpdateTotalMinutesLabel;
            numericUpDownCycling.ValueChanged += UpdateTotalMinutesLabel;

            // Initialize the total minutes label
            UpdateTotalMinutesLabel(null, null);
        }

        private void UpdateTotalMinutesLabel(object sender, EventArgs e)
        {
            int walkingMinutes = (int)numericUpDownWalking.Value;
            int runningMinutes = (int)numericUpDownRunning.Value;
            int cyclingMinutes = (int)numericUpDownCycling.Value;

            int totalMinutes = walkingMinutes + runningMinutes + cyclingMinutes;

            lblTotal.Text = $"Total Exercise Minutes: {totalMinutes} min";
        }

    }
}
