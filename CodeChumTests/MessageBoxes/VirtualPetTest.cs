namespace CodeChum.Tests
{
    public class VirtualPetTest
    {
        VirtualPet? form;
        Button? btnFeed;
        Button? btnPlay;
        Button? btnPet;
        Button? btnCheckMood;

        public VirtualPetTest()
        {
            form = new VirtualPet();
            form.Show();
            btnFeed = (Button)TestUtils.GetControlNamed(form, "btnFeed", true);
            btnPlay = (Button)TestUtils.GetControlNamed(form, "btnPlay", true);
            btnPet = (Button)TestUtils.GetControlNamed(form, "btnPet", true);
            btnCheckMood = (Button)TestUtils.GetControlNamed(form, "btnCheckMood", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(btnFeed);
            Assert.NotNull(btnPlay);
            Assert.NotNull(btnPet);
            Assert.NotNull(btnCheckMood);
        }

        [Fact]
        public void ShouldDisplayMessageWhenFeedButtonClicked()
        {
            btnFeed?.PerformClick();

            Assert.True(form?.isMessageBoxClosed);

        }

        [Fact]
        public void ShouldDisplayMessageWhenPlayButtonClicked()
        {
            btnPlay?.PerformClick();

            Assert.True(form?.isMessageBoxClosed);

        }

        [Fact]
        public void ShouldDisplayMessageWhenPetButtonClicked()
        {
            btnPet?.PerformClick();

            Assert.True(form?.isMessageBoxClosed);

        }

        [Fact]
        public void ShouldDisplayMessageWhenCheckMoodButtonClicked()
        {
            btnCheckMood?.PerformClick();

            Assert.True(form?.isMessageBoxClosed);
        }
    }
}
