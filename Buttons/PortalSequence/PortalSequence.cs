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
            correctSequence = new Button[] { sunButton, seaButton, starButton };

            messageLabel.Text = "Press the buttons in the correct order to open the portal.";

            // Assign individual click events to each button
            seaButton.Click += Button1_Click;
            sunButton.Click += Button2_Click;
            starButton.Click += Button3_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CheckButtonSequence(seaButton);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CheckButtonSequence(sunButton);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CheckButtonSequence(starButton);
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
                    messageLabel.Text = "Congratulations! The portal is now open!";
                    // Optionally, you can add code to change the appearance of the portal.
                }
                else
                {
                    // Update label to show current progress
                    currentStep++;
                    messageLabel.Text = $"Step {currentStep - 1} of {correctSequence.Length} completed. Keep going!";
                }
            }
            else
            {
                // Incorrect button pressed, reset the sequence
                currentStep = 1;
                messageLabel.Text = "Incorrect step. Resetting sequence.";
            }
        }
    }
}