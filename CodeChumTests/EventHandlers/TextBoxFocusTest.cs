namespace CodeChum.Tests
{
    public class TextBoxFocusTests
    {
        TextBoxFocus? form;
        Label? messageLabel;
        TextBox? firstTextBox, secondTextBox, thirdTextBox;
        Button? firstTextBoxFocusButton, secondTextBoxFocusButton, thirdTextBoxFocusButton;

        public TextBoxFocusTests()
        {
            form = new TextBoxFocus();
            form.Show();
            messageLabel = (Label)TestUtils.GetControlNamed(form, "messageLabel", true);
            firstTextBox = (TextBox)TestUtils.GetControlNamed(form, "firstTextBox", true);
            secondTextBox = (TextBox)TestUtils.GetControlNamed(form, "secondTextBox", true);
            thirdTextBox = (TextBox)TestUtils.GetControlNamed(form, "thirdTextBox", true);
            firstTextBoxFocusButton = (Button)TestUtils.GetControlNamed(form, "firstTextBoxFocusButton", true);
            secondTextBoxFocusButton = (Button)TestUtils.GetControlNamed(form, "secondTextBoxFocusButton", true);
            thirdTextBoxFocusButton = (Button)TestUtils.GetControlNamed(form, "thirdTextBoxFocusButton", true);
        }

        [Fact]
        // Description: Should have all the controls `messageLabel`, `firstTextBox`, `secondTextBox`, `thirdTextBox`, `firstTextBoxFocusButton`, `secondTextBoxFocusButton` and `thirdTextBoxFocusButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(messageLabel);
            Assert.NotNull(firstTextBox);
            Assert.NotNull(secondTextBox);
            Assert.NotNull(thirdTextBox);
            Assert.NotNull(firstTextBoxFocusButton);
            Assert.NotNull(secondTextBoxFocusButton);
            Assert.NotNull(thirdTextBoxFocusButton);
        }

        [Fact]
        // Description: Should display "FirstTextBox is in focus." on `firstTextBox` focus.
        public void ShouldDisplayCorrectTextOnFirstTextBoxFocus()
        {
            string expected = "FirstTextBox is in focus.";
            firstTextBox.Focus();

            Assert.Equal(expected, messageLabel.Text);
        }

        [Fact]
        // Description: Should display "SecondTextBox is in focus." on `secondTextBox` focus.
        public void ShouldDisplayCorrectTextOnSecondTextBoxFocus()
        {
            string expected = "SecondTextBox is in focus.";
            secondTextBox.Focus();

            Assert.Equal(expected, messageLabel.Text);
        }

        [Fact]
        // Description: Should display "ThirdTextBox is in focus." on `thirdTextBox` focus.
        public void ShouldDisplayCorrectTextOnThirdTextBoxFocus()
        {
            string expected = "ThirdTextBox is in focus.";
            thirdTextBox.Focus();

            Assert.Equal(expected, messageLabel.Text);
        }

        [Fact]
        // Description: Should display "FirstTextBox is in focus." on clicking `firstTextBoxFocusButton`.
        public void ShouldDisplayCorrectTextOnFirstButtonClick()
        {
            string expected = "FirstTextBox is in focus.";
            firstTextBoxFocusButton.PerformClick();

            Assert.Equal(expected, messageLabel.Text);
        }

        [Fact]
        // Description: Should display "SecondTextBox is in focus." on clicking `secondTextBoxFocusButton`.
        public void ShouldDisplayCorrectTextOnSecondButtonClick()
        {
            string expected = "SecondTextBox is in focus.";
            secondTextBoxFocusButton.PerformClick();

            Assert.Equal(expected, messageLabel.Text);
        }

        [Fact]
        // Description: Should display "ThirdTextBox is in focus." on clicking `thirdTextBoxFocusButton`.
        public void ShouldDisplayCorrectTextOnThirdButtonClick()
        {
            string expected = "ThirdTextBox is in focus.";
            thirdTextBoxFocusButton.PerformClick();

            Assert.Equal(expected, messageLabel.Text);
        }
    }
}