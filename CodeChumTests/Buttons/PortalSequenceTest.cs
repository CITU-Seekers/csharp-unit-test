namespace CodeChum.Tests
{
    public class PortalSequenceTest
    {
        PortalSequence? form;
        Label? messageLabel;
        Button? seaButton;
        Button? sunButton;
        Button? starButton;

        public PortalSequenceTest()
        {
            form = new PortalSequence();
            form.Show();
            messageLabel = (Label)TestUtils.GetControlNamed(form, "messageLabel", true);
            seaButton = (Button)TestUtils.GetControlNamed(form, "seaButton", true);
            sunButton = (Button)TestUtils.GetControlNamed(form, "sunButton", true);
            starButton = (Button)TestUtils.GetControlNamed(form, "starButton", true);
        }

        [Fact]
        // Description: Should have all the controls `messageLabel`, `seaButton`, `sunButton`, and `starButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(messageLabel);
            Assert.NotNull(seaButton);
            Assert.NotNull(sunButton);
            Assert.NotNull(starButton);
        }

        [Fact]
        // Description: Should display message "Congratulations! The portal is now open!" in `messageLabel` when all the buttons are clicked in the correct order.
        public void ShouldDisplaySuccessMessageWhenAllStepsAreCompleted()
        {
            sunButton.PerformClick();
            seaButton.PerformClick();
            starButton.PerformClick();
            Assert.Equal("Congratulations! The portal is now open!", messageLabel.Text);
        }

        [Fact]
        // Description: Should display message "Step 1 of 3 completed. Keep going!" in `messageLabel` when the `sunButton` is clicked.
        public void ShouldDisplayProgressMessageWhenStep1IsCompleted()
        {
            sunButton.PerformClick();
            Assert.Equal("Step 1 of 3 completed. Keep going!", messageLabel.Text);
        }

        [Fact]
        // Description: Should display message "Step 2 of 3 completed. Keep going!" in `messageLabel` when the `seaButton` is clicked after the `sunButton`.
        public void ShouldDisplayProgressMessageWhenStep2IsCompleted()
        {
            sunButton.PerformClick();
            seaButton.PerformClick();
            Assert.Equal("Step 2 of 3 completed. Keep going!", messageLabel.Text);
        }
    }
}
