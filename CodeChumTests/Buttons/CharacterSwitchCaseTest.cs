namespace CodeChum.Tests
{
    public class CharacterSwitchCaseTests
    {
        CharacterSwitchCase? form;
        Label? Label;
        Button? SwitchCaseVowelsButton, SwitchCaseConsonantsButton, SwitchCaseAllButton;

        public CharacterSwitchCaseTests()
        {
            form = new CharacterSwitchCase();
            form.Show();
            Label = (Label)TestUtils.GetControlNamed(form, "Label", true);
            SwitchCaseVowelsButton = (Button)TestUtils.GetControlNamed(form, "SwitchCaseVowelsButton", true);
            SwitchCaseConsonantsButton = (Button)TestUtils.GetControlNamed(form, "SwitchCaseConsonantsButton", true);
            SwitchCaseAllButton = (Button)TestUtils.GetControlNamed(form, "SwitchCaseAllButton", true);
        }

        [Fact]
        public void ShouldHaveLabel()
        {
            Assert.NotNull(Label);
            Assert.Equal("I love programming!", Label.Text);
        }

        [Fact]
        public void ShouldHaveAllButtonControls()
        {
            Assert.NotNull(SwitchCaseVowelsButton);
            Assert.NotNull(SwitchCaseConsonantsButton);
            Assert.NotNull(SwitchCaseAllButton);
        }

        [Fact]
        public void ShouldSwitchCaseOfVowelLetters()
        {
            string expected = "i lOvE prOgrAmmIng!";

            SwitchCaseVowelsButton.PerformClick();

            Assert.Equal(expected, Label.Text);
        }

        [Fact]
        public void ShouldSwitchCaseOfConsonantLetters()
        {
            string expected = "I LoVe PRoGRaMMiNG!";

            SwitchCaseConsonantsButton.PerformClick();

            Assert.Equal(expected, Label.Text);
        }

        [Fact]
        public void ShouldSwitchCaseOfAllLetters()
        {
            string expected = "i LOVE PROGRAMMING!";

            SwitchCaseAllButton.PerformClick();

            Assert.Equal(expected, Label.Text);
        }

        [Fact]
        public void ShouldSwitchCaseProperlyWhenAllButtonsAreClicked()
        {
            string expected = "I love programming!";

            SwitchCaseAllButton.PerformClick();
            SwitchCaseAllButton.PerformClick();
            SwitchCaseConsonantsButton.PerformClick();
            SwitchCaseConsonantsButton.PerformClick();
            SwitchCaseVowelsButton.PerformClick();
            SwitchCaseVowelsButton.PerformClick();

            Assert.Equal(expected, Label.Text);
        }
    }
}