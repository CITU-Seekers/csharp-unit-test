namespace CodeChum.Tests
{
    public class MostFrequentCharTests
    {
        MostFrequentCharacter? form;
        TextBox? TextBoxControl;
        Label? FrequentCharLabel;

        public MostFrequentCharTests()
        {
            form = new MostFrequentCharacter();
            form.Show();

            TextBoxControl = (TextBox)TestUtils.GetControlNamed(form, "TextBox", true);
            FrequentCharLabel = (Label)TestUtils.GetControlNamed(form, "FrequentCharLabel", true);
        }

        public void assertMostFrequent(String expectedCharacter, String failedMessage)
        {
            bool isLetterCorrect = FrequentCharLabel.Text.ToLower().Equals(expectedCharacter);

            Assert.True(isLetterCorrect, failedMessage);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(TextBoxControl);
            Assert.NotNull(FrequentCharLabel);
        }

        [Fact]
        public void ShouldDisplayCorrectFrequentCharacter()
        {
            TextBoxControl.Text = "N";
            assertMostFrequent("n", "The displayed text should be 'N' or 'n'");

            TextBoxControl.Text = "Neve";
            assertMostFrequent("e", "The displayed text should be 'E' or 'e'");
        }

        [Fact]
        public void ShouldDisplayCorrectFrequentCharacterWithSpaces()
        {
            TextBoxControl.Text = "I";
            assertMostFrequent("i", "The displayed text should be 'I' or 'i'");

            TextBoxControl.Text = "I ";
            assertMostFrequent("i", "The displayed text should be 'I' or 'i' and not a white space.");

            TextBoxControl.Text = "I a ";

            bool isLetterCorrect = FrequentCharLabel.Text.ToLower().Equals("i") ||
                FrequentCharLabel.Text.ToLower().Equals("a");

            Assert.True(isLetterCorrect, "The displayed text should be 'A', 'I', 'a', or 'i'");

            TextBoxControl.Text = "I a A ";
            assertMostFrequent("a", "The displayed text should be 'A' or 'a'.");
        }
    }
}