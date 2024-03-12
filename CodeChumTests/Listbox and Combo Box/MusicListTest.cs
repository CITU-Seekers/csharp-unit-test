namespace CodeChum.Tests
{
    public class MusicListTests
    {
        MusicList? form;
        ListBox? musicListBox;
        TextBox? musicTextBox;
        Button? addButton, removeButton;

        public MusicListTests()
        {
            form = new MusicList();
            form.Show();
            musicListBox = (ListBox)TestUtils.GetControlNamed(form, "musicListBox", true);
            musicTextBox = (TextBox)TestUtils.GetControlNamed(form, "musicTextBox", true);
            addButton = (Button)TestUtils.GetControlNamed(form, "addButton", true);
            removeButton = (Button)TestUtils.GetControlNamed(form, "removeButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(musicListBox);
            Assert.NotNull(musicTextBox);
            Assert.NotNull(addButton);
            Assert.NotNull(removeButton);
        }

        [Fact]
        public void ShouldAddMusicFromTextBoxToListBox()
        {
            string musicName = "Take a Break";

            musicTextBox.Text = musicName;
            addButton.PerformClick();
            Assert.Equal(musicName, musicListBox.Items[0]);
        }

        [Fact]
        public void ShouldRemoveMusicSelectedFromListBox()
        {
            string musicName0 = "Take a Break";
            string musicName1 = "Breakaway";

            musicListBox.Items.Add(musicName0);
            musicListBox.Items.Add(musicName1);
            musicListBox.SelectedIndex = 0;
            removeButton.PerformClick();

            Assert.False(musicListBox.Items.Contains(musicName0));
        }

    }
}