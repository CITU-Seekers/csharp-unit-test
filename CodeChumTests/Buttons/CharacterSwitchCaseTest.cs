namespace CodeChum.Tests
{
    public class CharacterSwitchCaseTests
    {
        CharacterSwitchCase? form;
        Label? textLabel;
        Button? switchCaseVowelsButton, switchCaseConsonantsButton, switchCaseAllButton;

        public CharacterSwitchCaseTests()
        {
            form = new CharacterSwitchCase();
            form.Show();
            textLabel = (Label)TestUtils.GetControlNamed(form, "textLabel", true);
            switchCaseVowelsButton = (Button)TestUtils.GetControlNamed(form, "switchCaseVowelsButton", true);
            switchCaseConsonantsButton = (Button)TestUtils.GetControlNamed(form, "switchCaseConsonantsButton", true);
            switchCaseAllButton = (Button)TestUtils.GetControlNamed(form, "switchCaseAllButton", true);
        }

        [Fact]
        public void ShouldHaveLabel()
        {
            Assert.NotNull(textLabel);
            Assert.Equal("I love programming!", textLabel.Text);
        }

        [Fact]
        public void ShouldHaveAllButtonControls()
        {
            Assert.NotNull(switchCaseVowelsButton);
            Assert.NotNull(switchCaseConsonantsButton);
            Assert.NotNull(switchCaseAllButton);
        }

        [Fact]
        public void ShouldSwitchCaseOfVowelLetters()
        {
            string expected = "i lOvE prOgrAmmIng!";

            switchCaseVowelsButton.PerformClick();

            Assert.Equal(expected, textLabel.Text);
        }

        [Fact]
        public void ShouldSwitchCaseOfConsonantLetters()
        {
            string expected = "I LoVe PRoGRaMMiNG!";

            switchCaseConsonantsButton.PerformClick();

            Assert.Equal(expected, textLabel.Text);
        }

        [Fact]
        public void ShouldSwitchCaseOfAllLetters()
        {
            string expected = "i LOVE PROGRAMMING!";

            switchCaseAllButton.PerformClick();

            Assert.Equal(expected, textLabel.Text);
        }

        [Fact]
        public void ShouldSwitchCaseProperlyWhenAllButtonsAreClicked()
        {
            string expected = "I love programming!";

            switchCaseAllButton.PerformClick();
            switchCaseAllButton.PerformClick();
            switchCaseConsonantsButton.PerformClick();
            switchCaseConsonantsButton.PerformClick();
            switchCaseVowelsButton.PerformClick();
            switchCaseVowelsButton.PerformClick();

            Assert.Equal(expected, textLabel.Text);
        }
    }
}