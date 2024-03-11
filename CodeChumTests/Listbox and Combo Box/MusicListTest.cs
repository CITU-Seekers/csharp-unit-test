namespace CodeChum.Tests
{
    public class MusicListTests
    {
        MusicList? form;
        ListBox? MusicListBox;
        TextBox? MusicTextBox;
        Button? AddButton, RemoveButton;

        public MusicListTests()
        {
            form = new MusicList();
            form.Show();
            MusicListBox = (ListBox)TestUtils.GetControlNamed(form, "MusicListBox", true);
            MusicTextBox = (TextBox)TestUtils.GetControlNamed(form, "MusicTextBox", true);
            AddButton = (Button)TestUtils.GetControlNamed(form, "AddButton", true);
            RemoveButton = (Button)TestUtils.GetControlNamed(form, "RemoveButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(MusicListBox);
            Assert.NotNull(MusicTextBox);
            Assert.NotNull(AddButton);
            Assert.NotNull(RemoveButton);
        }

        [Fact]
        public void ShouldAddMusicFromTextBoxToListBox()
        {
            string musicName = "Take a Break";

            MusicTextBox.Text = musicName;
            AddButton.PerformClick();
            Assert.Equal(musicName, MusicListBox.Items[0]);
        }

        [Fact]
        public void ShouldRemoveMusicSelectedFromListBox()
        {
            string musicName0 = "Take a Break";
            string musicName1 = "Breakaway";

            MusicListBox.Items.Add(musicName0);
            MusicListBox.Items.Add(musicName1);
            MusicListBox.SelectedIndex = 0;
            RemoveButton.PerformClick();

            Assert.False(MusicListBox.Items.Contains(musicName0));
        }

    }
}