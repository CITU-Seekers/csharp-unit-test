namespace CodeChum.Tests
{
    public class SurveyFormTests
    {
        SurveyForm? form;
        TextBox? nameTextBox, emailTextBox;
        NumericUpDown? satisfactionNumericControl;
        RadioButton? yesRadioButton, noRadioButton;
        Button? submitButton;

        public SurveyFormTests()
        {
            form = new SurveyForm();
            form.Show();
            nameTextBox = (TextBox)TestUtils.GetControlNamed(form, "nameTextBox", true);
            emailTextBox = (TextBox)TestUtils.GetControlNamed(form, "emailTextBox", true);
            satisfactionNumericControl = (NumericUpDown)TestUtils.GetControlNamed(form, "satisfactionNumericControl", true);
            yesRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "yesRadioButton", true);
            noRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "noRadioButton", true);
            submitButton = (Button)TestUtils.GetControlNamed(form, "submitButton", true);
            MessageBoxWrapper2.IsOpened = false;
        }

        [Fact]
        // Description: Should have all the controls `nameTextBox`, `emailTextBox`, `satisfactionNumericControl`, `yesRadioButton`, `noRadioButton`, and `submitButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(nameTextBox);
            Assert.NotNull(emailTextBox);
            Assert.NotNull(satisfactionNumericControl);
            Assert.NotNull(yesRadioButton);
            Assert.NotNull(noRadioButton);
            Assert.NotNull(submitButton);
        }

        [Fact]
        // Description: Should show invalid message box when at least one text box is empty on click `submitButton`.
        public void ShouldShowInvalidMessageBoxOnClickSubmitButtonWithEmptyTextBox()
        {
            submitButton.PerformClick();

            Assert.True(MessageBoxWrapper2.IsOpened, "The `Invalid` message box should appear.");
            Assert.Equal("Invalid", MessageBoxWrapper2.Title);
            Assert.Equal(MessageBoxButtons.OK, MessageBoxWrapper2.MessageBoxButtons);
            Assert.True(MessageBoxWrapper2.Message.Length > 0, "There should be a proper message.");
        }

        [Fact]
        // Description: Should show success message when all controls have values on click `submitButton`.
        public void ShouldShowSuccessMessageOnClickSubmitButtonThenYes()
        {
            nameTextBox.Text = "Test";
            emailTextBox.Text = "Test@test.com";
            satisfactionNumericControl.Value = 5;
            yesRadioButton.Checked = true;

            Task.Factory.StartNew(() =>
            {
                submitButton.PerformClick();
                Assert.True(MessageBoxWrapper2.IsOpened, "The `Success` message box should appear.");
                Assert.Equal("Success", MessageBoxWrapper2.Title);
                Assert.Equal(MessageBoxButtons.OK, MessageBoxWrapper2.MessageBoxButtons);
                Assert.True(MessageBoxWrapper2.Message.Length > 0, "There should be a proper message.");
            });
        }
    }
}