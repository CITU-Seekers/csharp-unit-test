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
    public partial class WorkoutTracker : Form
    {
        private int currentProgress;
        public WorkoutTracker()
        {
            InitializeComponent();
            progressBar1.Minimum = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Disable the start button to prevent multiple starts
            btnStart.Enabled = false;

            // Start the workout asynchronously
            currentProgress = 0;
            progressBar1.Maximum = (int)numericUpDown1.Value;
            progressTimer.Start();
        }



        private void btnFinish_Click(object sender, EventArgs e)
        {
            // Reset the progress bar and label
            progressTimer.Stop();
            progressBar1.Value = 0;

            // Enable the start button
            btnStart.Enabled = true;
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            if (currentProgress + 1 <= progressBar1.Maximum)
            {
                currentProgress += 1;
                progressBar1.Value = currentProgress;
            }
            else
            {
                progressTimer.Stop();
            }
        }
    }
}
