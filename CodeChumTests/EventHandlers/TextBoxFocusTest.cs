namespace CodeChum.Tests
{
    public class TextBoxFocusTests
    {
        TextBoxFocus? form;
        Label? MessageLabel;
        TextBox? FirstTextBox, SecondTextBox, ThirdTextBox;
        Button? FirstTextBoxFocusButton, SecondTextBoxFocusButton, ThirdTextBoxFocusButton;

        public TextBoxFocusTests()
        {
            form = new TextBoxFocus();
            form.Show();
            MessageLabel = (Label)TestUtils.GetControlNamed(form, "MessageLabel", true);
            FirstTextBox = (TextBox)TestUtils.GetControlNamed(form, "FirstTextBox", true);
            SecondTextBox = (TextBox)TestUtils.GetControlNamed(form, "SecondTextBox", true);
            ThirdTextBox = (TextBox)TestUtils.GetControlNamed(form, "ThirdTextBox", true);
            FirstTextBoxFocusButton = (Button)TestUtils.GetControlNamed(form, "FirstTextBoxFocusButton", true);
            SecondTextBoxFocusButton = (Button)TestUtils.GetControlNamed(form, "SecondTextBoxFocusButton", true);
            ThirdTextBoxFocusButton = (Button)TestUtils.GetControlNamed(form, "ThirdTextBoxFocusButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(MessageLabel);
            Assert.NotNull(FirstTextBox);
            Assert.NotNull(SecondTextBox);
            Assert.NotNull(ThirdTextBox);
            Assert.NotNull(FirstTextBoxFocusButton);
            Assert.NotNull(SecondTextBoxFocusButton);
            Assert.NotNull(ThirdTextBoxFocusButton);
        }

        [Fact]
        public void ShouldDisplayCorrectTextOnFirstTextBoxFocus()
        {
            string expected = "FirstTextBox is in focus.";
            FirstTextBox.Focus();

            Assert.Equal(expected, MessageLabel.Text);
        }

        [Fact]
        public void ShouldDisplayCorrectTextOnSecondTextBoxFocus()
        {
            string expected = "SecondTextBox is in focus.";
            SecondTextBox.Focus();

            Assert.Equal(expected, MessageLabel.Text);
        }

        [Fact]
        public void ShouldDisplayCorrectTextOnThirdTextBoxFocus()
        {
            string expected = "ThirdTextBox is in focus.";
            ThirdTextBox.Focus();

            Assert.Equal(expected, MessageLabel.Text);
        }

        [Fact]
        public void ShouldDisplayCorrectTextOnFirstButtonClick()
        {
            string expected = "FirstTextBox is in focus.";
            FirstTextBoxFocusButton.PerformClick();

            Assert.Equal(expected, MessageLabel.Text);
        }

        [Fact]
        public void ShouldDisplayCorrectTextOnSecondButtonClick()
        {
            string expected = "SecondTextBox is in focus.";
            SecondTextBoxFocusButton.PerformClick();

            Assert.Equal(expected, MessageLabel.Text);
        }

        [Fact]
        public void ShouldDisplayCorrectTextOnThirdButtonClick()
        {
            string expected = "ThirdTextBox is in focus.";
            ThirdTextBoxFocusButton.PerformClick();

            Assert.Equal(expected, MessageLabel.Text);
        }
    }
}