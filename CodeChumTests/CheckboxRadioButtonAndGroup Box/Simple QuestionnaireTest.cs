namespace CodeChum.Tests
{
    public class SimpleQuestionnaireTests
    {
        SimpleQuestionnaire? form;
        RadioButton? charRadioButton, intRadioButton, booleanRadioButton, stringRadioButton;
        Label? resultLabel;
        Button? checkButton;

        public SimpleQuestionnaireTests()
        {
            form = new SimpleQuestionnaire();
            form.Show();
            charRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "charRadioButton", true);
            intRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "intRadioButton", true);
            booleanRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "booleanRadioButton", true);
            stringRadioButton = (RadioButton)TestUtils.GetControlNamed(form, "stringRadioButton", true);
            resultLabel = (Label)TestUtils.GetControlNamed(form, "resultLabel", true);
            checkButton = (Button)TestUtils.GetControlNamed(form, "checkButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(charRadioButton);
            Assert.NotNull(intRadioButton);
            Assert.NotNull(booleanRadioButton);
            Assert.NotNull(stringRadioButton);
            Assert.NotNull(resultLabel);
            Assert.NotNull(checkButton);
        }
        [Fact]
        public void ShouldBeIncorrectOnNotStringRadioButton()
        {
            string incorrect = "Incorrect";
            intRadioButton.PerformClick();
            checkButton.PerformClick();
            booleanRadioButton.PerformClick();
            checkButton.PerformClick();
            charRadioButton.PerformClick();
            checkButton.PerformClick();

            Assert.True(resultLabel.Text.Contains(incorrect), "A message with the word \"Incorrect\" should be displayed.");
        }

        [Fact]
        public void ShouldBeCorrectOnStringRadioButton()
        {
            stringRadioButton.Checked = true;
            string correct = "Correct";

            checkButton.PerformClick();

            Assert.True(resultLabel.Text.Contains(correct), "A message with the word \"Correct\" should be displayed.");
        }
    }
}