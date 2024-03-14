using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CodeChum
{
    public partial class DownloadManager : Form
    {
        private List<System.Windows.Forms.CheckBox> checkBoxes;
        public DownloadManager()
        {
            InitializeComponent();
            downloadProgressBar.Minimum = 0;

            // Initialize and add checkboxes to the list
            checkBoxes = new List<System.Windows.Forms.CheckBox>
            {
                checkBox1,
                checkBox2,
                checkBox3,
                checkBox4,
                checkBox5
            };

            // Attach event handlers for checkbox state changes
            foreach (var checkBox in checkBoxes)
            {
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
            }

            // Set initial maximum value based on checked checkboxes
            UpdateProgressBarMaximum();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Update maximum value when checkbox state changes
            UpdateProgressBarMaximum();
        }

        private void UpdateProgressBarMaximum()
        {
            // Calculate the maximum value based on the number of checked checkboxes
            int max = 0;
            foreach (var checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    // You can adjust the maximum value based on your preference
                    max += 100; // For example, increment by 100 for each checked checkbox
                }
            }

            // Set the maximum value of the progress bar
            downloadProgressBar.Maximum = max;
        }


        private void btnDownload_Click(object sender, EventArgs e)
        {
            // Disable the start button to prevent multiple starts
            downloadButton.Enabled = false;
            ProgressTimer.Start();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Stop the download and reset progress
            ProgressTimer.Stop();
            downloadProgressBar.Value = 0;
            // Enable the start button
            downloadButton.Enabled = true;

            //uncheck all the checkboxes
            foreach (var checkBox in checkBoxes)
            {
                checkBox.Checked = false;
            }
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            // Update the progress bar value based on your download logic
            if (downloadProgressBar.Value < downloadProgressBar.Maximum)
            {
                downloadProgressBar.Value += 10; // Increment by 10 for simulation
            }
            else
            {
                // Download completed, stop the timer
                ProgressTimer.Stop();
                // Enable the start button
                downloadButton.Enabled = true;
            }
        }
    }
}
