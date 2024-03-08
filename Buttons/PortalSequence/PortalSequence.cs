using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChum
{
    public partial class PortalSequence : Form
    {
        private int currentStep = 1;
        private Button[] correctSequence;

        public PortalSequence()
        {
            InitializeComponent();

            // Initialize correctSequence in the constructor
            correctSequence = new Button[] { button2, button1, button3 };

            label4.Text = "Press the buttons in the correct order to open the portal.";

            // Assign individual click events to each button
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CheckButtonSequence(button1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CheckButtonSequence(button2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CheckButtonSequence(button3);
        }

        private void CheckButtonSequence(Button clickedButton)
        {
            // Check if the clicked button is the correct one in the sequence
            if (correctSequence[currentStep - 1] == clickedButton)
            {
                // If correct, move to the next step
                // Display success message when all steps are completed
                if (currentStep >= correctSequence.Length)
                {
                    label4.Text = "Congratulations! The portal is now open!";
                    // Optionally, you can add code to change the appearance of the portal.
                }
                else
                {
                    // Update label to show current progress
                    currentStep++;
                    label4.Text = $"Step {currentStep - 1} of {correctSequence.Length} completed. Keep going!";
                }
            }
            else
            {
                // Incorrect button pressed, reset the sequence
                currentStep = 1;
                label4.Text = "Incorrect step. Resetting sequence.";
            }
        }
    }
}