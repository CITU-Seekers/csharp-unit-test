namespace CodeChum.Tests
{
    public class OrchestraTest
    {
        Orchestra? form;
        Label? messageLabel;
        Button? violinButton;
        Button? celloButton;
        Button? trumpetButton;
        Button? drumButton;

        public OrchestraTest()
        {
            form = new Orchestra();
            form.Show();
            messageLabel = (Label)TestUtils.GetControlNamed(form, "messageLabel", true);
            violinButton = (Button)TestUtils.GetControlNamed(form, "violinButton", true);
            celloButton = (Button)TestUtils.GetControlNamed(form, "celloButton", true);
            trumpetButton = (Button)TestUtils.GetControlNamed(form, "trumpetButton", true);
            drumButton = (Button)TestUtils.GetControlNamed(form, "drumButton", true);
        }

        [Fact]
        // Description: Should have all the controls `messageLabel`, `violinButton`, `celloButton`, `trumpetButton`, and `drumButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(messageLabel);
            Assert.NotNull(violinButton);
            Assert.NotNull(celloButton);
            Assert.NotNull(trumpetButton);
            Assert.NotNull(drumButton);
        }

        [Fact]
        // Description: Should display message "Violins are playing!" in `messageLabel` when the `violinButton` is clicked.
        public void ShouldDisplayMessageWhenViolinButtonIsClicked()
        {
            violinButton.PerformClick();
            Assert.Equal("Violins are playing!", messageLabel.Text);
        }

        [Fact]
        // Description: Should display message "Cellos are playing!" in `messageLabel` when the `celloButton` is clicked.
        public void ShouldDisplayMessageWhenCelloButtonIsClicked()
        {
            celloButton.PerformClick();
            Assert.Equal("Cellos are playing!", messageLabel.Text);
        }

        [Fact]
        // Description: Should display message "Trumpets are playing!" in `messageLabel` when the `trumpetButton` is clicked.
        public void ShouldDisplayMessageWhenTrumpetButtonIsClicked()
        {
            trumpetButton.PerformClick();
            Assert.Equal("Trumpets are playing!", messageLabel.Text);
        }

        [Fact]
        // Description: Should display message "Drums are playing!" in `messageLabel` when the `drumButton` is clicked.
        public void ShouldDisplayMessageWhenDrumButtonIsClicked()
        {
            drumButton.PerformClick();
            Assert.Equal("Drums are playing!", messageLabel.Text);
        }

        [Fact]
        // Description: Should display only one yellow button when all buttons are clicked.
        public void ShouldDisplayOnlyOneYellowButton()
        {
            violinButton.PerformClick();
            celloButton.PerformClick();
            trumpetButton.PerformClick();
            drumButton.PerformClick();

            int yellowCount = 0;
            if (violinButton.BackColor == System.Drawing.Color.Yellow)
            {
                yellowCount++;
            }
            if (celloButton.BackColor == System.Drawing.Color.Yellow)
            {
                yellowCount++;
            }
            if (trumpetButton.BackColor == System.Drawing.Color.Yellow)
            {
                yellowCount++;
            }
            if (drumButton.BackColor == System.Drawing.Color.Yellow)
            {
                yellowCount++;
            }

            Assert.Equal(1, yellowCount);
        }
    }
}
