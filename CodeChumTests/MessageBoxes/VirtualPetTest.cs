namespace CodeChum.Tests
{
    public class VirtualPetTest
    {
        VirtualPet? form;
        Button? feedButton;
        Button? playButton;
        Button? petButton;
        Button? checkMoodButton;

        public VirtualPetTest()
        {
            form = new VirtualPet();
            form.Show();
            feedButton = (Button)TestUtils.GetControlNamed(form, "feedButton", true);
            playButton = (Button)TestUtils.GetControlNamed(form, "playButton", true);
            petButton = (Button)TestUtils.GetControlNamed(form, "petButton", true);
            checkMoodButton = (Button)TestUtils.GetControlNamed(form, "checkMoodButton", true);
        }

        [Fact]
        // Description: Should have all the controls `feedButton`, `playButton`, `petButton`, and `checkMoodButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(feedButton);
            Assert.NotNull(playButton);
            Assert.NotNull(petButton);
            Assert.NotNull(checkMoodButton);
        }

        [Fact]
        // Description: Should display message "Yum! That was delicious! I'm feeling full and happy!" in a message box when the `feedButton` is clicked.
        public void ShouldDisplayMessageWhenFeedButtonClicked()
        {
            string expectedMessage = "Yum! That was delicious! I'm feeling full and happy!";

            feedButton?.PerformClick();        

            Assert.True(MessageBoxWrapper.IsOpened);
            Assert.Equal(expectedMessage, MessageBoxWrapper.Message);
        }

        [Fact]
        // Description: Should display message "That was so much fun! I'm feeling happy and energized!" in a message box when the `playButton` is clicked.
        public void ShouldDisplayMessageWhenPlayButtonClicked()
        {
            string expectedMessage = "That was so much fun! I'm feeling happy and energized!";

            playButton?.PerformClick();

            Assert.True(MessageBoxWrapper.IsOpened);
            Assert.Equal(expectedMessage, MessageBoxWrapper.Message);
        }

        [Fact]
        // Description: Should display message "Purr... rubs against you I love your cuddles!" in a message box when the `petButton` is clicked.
        public void ShouldDisplayMessageWhenPetButtonClicked()
        {
            string expectedMessage = "Purr... rubs against you I love your cuddles!";

            petButton?.PerformClick();

            Assert.True(MessageBoxWrapper.IsOpened);
            Assert.Equal(expectedMessage, MessageBoxWrapper.Message);
        }

        [Fact]
        // Description: Should display message "I'm feeling content and loved, thanks to you!" in a message box when the `checkMoodButton` is clicked.
        public void ShouldDisplayMessageWhenCheckMoodButtonClicked()
        {
            string expectedMessage = "I'm feeling content and loved, thanks to you!";

            checkMoodButton?.PerformClick();

            Assert.True(MessageBoxWrapper.IsOpened);
            Assert.Equal(expectedMessage, MessageBoxWrapper.Message);
        }
    }
}
