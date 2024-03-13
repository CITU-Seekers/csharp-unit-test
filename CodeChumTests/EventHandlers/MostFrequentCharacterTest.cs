namespace CodeChum.Tests
{
    public class MostFrequentCharTests
    {
        MostFrequentCharacter? form;
        TextBox? inputTextBox;
        Label? frequentCharLabel;

        public MostFrequentCharTests()
        {
            form = new MostFrequentCharacter();
            form.Show();

            inputTextBox = (TextBox)TestUtils.GetControlNamed(form, "inputTextBox", true);
            frequentCharLabel = (Label)TestUtils.GetControlNamed(form, "frequentCharLabel", true);
        }

        public void assertMostFrequent(String expectedCharacter, String failedMessage)
        {
            bool isLetterCorrect = frequentCharLabel.Text.ToLower().Equals(expectedCharacter);

            Assert.True(isLetterCorrect, failedMessage);
        }

        [Fact]
        // Description: Should have all the controls `inputTextBox` and `frequentCharLabel`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(inputTextBox);
            Assert.NotNull(frequentCharLabel);
        }

        [Fact]
        // Description: Should display the most frequent character in `inputTextBox` in `frequentCharLabel`.
        public void ShouldDisplayCorrectFrequentCharacter()
        {
            inputTextBox.Text = "N";
            assertMostFrequent("n", "The displayed text should be 'N' or 'n'");

            inputTextBox.Text = "Neve";
            assertMostFrequent("e", "The displayed text should be 'E' or 'e'");
        }

        [Fact]
        // Description: Should display the most frequent character in `inputTextBox` in `frequentCharLabel` with spaces.
        public void ShouldDisplayCorrectFrequentCharacterWithSpaces()
        {
            inputTextBox.Text = "I";
            assertMostFrequent("i", "The displayed text should be 'I' or 'i'");

            inputTextBox.Text = "I ";
            assertMostFrequent("i", "The displayed text should be 'I' or 'i' and not a white space.");

            inputTextBox.Text = "I a ";

            bool isLetterCorrect = frequentCharLabel.Text.ToLower().Equals("i") ||
                frequentCharLabel.Text.ToLower().Equals("a");

            Assert.True(isLetterCorrect, "The displayed text should be 'A', 'I', 'a', or 'i'");

            inputTextBox.Text = "I a A ";
            assertMostFrequent("a", "The displayed text should be 'A' or 'a'.");
        }
    }
}