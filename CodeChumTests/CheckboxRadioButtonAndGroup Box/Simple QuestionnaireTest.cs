namespace CodeChum.Tests
{
    public class SimpleQuestionnaireTests
    {
        SimpleQuestionnaire? form;
        RadioButton? CharRadioButton, IntRadioButton, BooleanRadioButton, StringRadioButton;
        Label? ResultLabel;
        Button? CheckButton;

        public SimpleQuestionnaireTests()
        {
            form = new SimpleQuestionnaire();
            form.Show();
            CharRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "CharRadioButton", true);
            IntRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "IntRadioButton", true);
            BooleanRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "BooleanRadioButton", true);
            StringRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "StringRadioButton", true);
            ResultLabel = (Label)TestUtils.GetControlNamed(form, "ResultLabel", true);
            CheckButton = (Button)TestUtils.GetControlNamed(form, "CheckButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(CharRadioButton);
            Assert.NotNull(IntRadioButton);
            Assert.NotNull(BooleanRadioButton);
            Assert.NotNull(StringRadioButton);
            Assert.NotNull(ResultLabel);
            Assert.NotNull(CheckButton);
        }
        [Fact]
        public void ShouldBeIncorrectOnNotStringRadioButton()
        {
            string incorrect = "Incorrect";
            IntRadioButton.PerformClick();
            CheckButton.PerformClick();
            BooleanRadioButton.PerformClick();
            CheckButton.PerformClick();
            CharRadioButton.PerformClick();
            CheckButton.PerformClick();

            Assert.True(ResultLabel.Text.Contains(incorrect), "A message with the word \"Incorrect\" should be displayed.");
        }

        [Fact]
        public void ShouldBeCorrectOnStringRadioButton()
        {
            StringRadioButton.Checked = true;
            string correct = "Correct";

            CheckButton.PerformClick();

            Assert.True(ResultLabel.Text.Contains(correct), "A message with the word \"Correct\" should be displayed.");
        }
    }
}