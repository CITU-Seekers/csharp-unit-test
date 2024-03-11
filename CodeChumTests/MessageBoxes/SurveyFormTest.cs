namespace CodeChum.Tests
{
    public class SurveyFormTests
    {
        SurveyForm? form;
        TextBox? NameTextBox, EmailTextBox;
        NumericUpDown? SatisfactionNumericControl;
        RadioButton? YesRadioButton, NoRadioButton;
        Button? SubmitButton;

        public SurveyFormTests()
        {
            form = new SurveyForm();
            form.Show();
            NameTextBox = (TextBox)TestUtils.GetControlNamed(form, "NameTextBox", true);
            EmailTextBox = (TextBox)TestUtils.GetControlNamed(form, "EmailTextBox", true);
            SatisfactionNumericControl = (NumericUpDown)TestUtils.GetControlNamed(form, "SatisfactionNumericControl", true);
            YesRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "YesRadioButton", true);
            NoRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "NoRadioButton", true);
            SubmitButton = (Button)TestUtils.GetControlNamed(form, "SubmitButton", true);
            MessageBoxWrapper.IsOpened = false;
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(NameTextBox);
            Assert.NotNull(EmailTextBox);
            Assert.NotNull(SatisfactionNumericControl);
            Assert.NotNull(YesRadioButton);
            Assert.NotNull(NoRadioButton);
            Assert.NotNull(SubmitButton);
        }

        [Fact]
        public void ShouldShowInvalidMessageBoxOnClickSubmitButtonWithEmptyTextBox()
        {
            SubmitButton.PerformClick();

            Assert.True(MessageBoxWrapper.IsOpened, "The `Invalid` message box should appear.");
            Assert.Equal("Invalid", MessageBoxWrapper.Title);
            Assert.Equal(MessageBoxButtons.OK, MessageBoxWrapper.MessageBoxButtons);
            Assert.True(MessageBoxWrapper.Message.Length > 0, "There should be a proper message.");
        }

        [Fact]
        public void ShouldShowSuccessMessageOnClickSubmitButtonThenYes()
        {
            NameTextBox.Text = "Test";
            EmailTextBox.Text = "Test@test.com";
            SatisfactionNumericControl.Value = 5;
            YesRadioButton.Checked = true;

            Task.Factory.StartNew(() =>
            {
                SubmitButton.PerformClick();
                Assert.True(MessageBoxWrapper.IsOpened, "The `Success` message box should appear.");
                Assert.Equal("Success", MessageBoxWrapper.Title);
                Assert.Equal(MessageBoxButtons.OK, MessageBoxWrapper.MessageBoxButtons);
                Assert.True(MessageBoxWrapper.Message.Length > 0, "There should be a proper message.");
            });
        }
    }
}