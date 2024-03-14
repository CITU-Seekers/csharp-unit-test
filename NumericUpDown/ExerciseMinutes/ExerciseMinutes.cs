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
            walkingNumericUpDown.ValueChanged += UpdateTotalMinutesLabel;
            runningNumericUpDown.ValueChanged += UpdateTotalMinutesLabel;
            cyclingNumericUpDown.ValueChanged += UpdateTotalMinutesLabel;

            // Initialize the total minutes label
            UpdateTotalMinutesLabel(null, null);
        }

        private void UpdateTotalMinutesLabel(object sender, EventArgs e)
        {
            int walkingMinutes = (int)walkingNumericUpDown.Value;
            int runningMinutes = (int)runningNumericUpDown.Value;
            int cyclingMinutes = (int)cyclingNumericUpDown.Value;

            int totalMinutes = walkingMinutes + runningMinutes + cyclingMinutes;

            totalLabel.Text = $"Total Exercise Minutes: {totalMinutes} min";
        }

    }
}
