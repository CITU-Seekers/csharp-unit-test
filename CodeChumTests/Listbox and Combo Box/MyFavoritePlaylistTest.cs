namespace CodeChum.Tests
{
    public class MyFavoritePlaylistTests
    {
        MyFavoritePlaylist? form;
        ListBox? RegularListBox, FavoritesListBox;
        TextBox? MusicTextBox;
        Button? AddButton, RemoveButton, AddToFavoritesButton;

        public MyFavoritePlaylistTests()
        {
            form = new MyFavoritePlaylist();
            form.Show();
            RegularListBox = (ListBox)TestUtils.GetControlNamed(form, "RegularListBox", true);
            FavoritesListBox = (ListBox)TestUtils.GetControlNamed(form, "FavoritesListBox", true);
            MusicTextBox = (TextBox)TestUtils.GetControlNamed(form, "MusicTextBox", true);
            AddButton = (Button)TestUtils.GetControlNamed(form, "AddButton", true);
            RemoveButton = (Button)TestUtils.GetControlNamed(form, "RemoveButton", true);
            AddToFavoritesButton = (Button)TestUtils.GetControlNamed(form, "AddToFavoritesButton", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(RegularListBox);
            Assert.NotNull(FavoritesListBox);
            Assert.NotNull(MusicTextBox);
            Assert.NotNull(AddButton);
            Assert.NotNull(RemoveButton);
            Assert.NotNull(AddToFavoritesButton);
        }

        [Fact]
        public void ShouldAddTextBoxOnAddButtonClick()
        {
            string test = "MusicTest";
            MusicTextBox.Text = test;

            AddButton.PerformClick();

            Assert.Equal(test, RegularListBox.Items[0]);
        }

        [Fact]
        public void ShouldRemoveMusicSelectedFromListBox()
        {
            string musicName0 = "Take a Break";
            string musicName1 = "Breakaway";

            RegularListBox.Items.Add(musicName0);
            RegularListBox.Items.Add(musicName1);
            RegularListBox.SelectedIndex = 0;
            RemoveButton.PerformClick();

            Assert.False(RegularListBox.Items.Contains(musicName0));
        }

        [Fact]
        public void ShouldTransferToFavoritesOnTransferButtonClick()
        {
            string test = "MusicTest";
            MusicTextBox.Text = test;

            AddButton.PerformClick();
            RegularListBox.SelectedIndex = 0;
            AddToFavoritesButton.PerformClick();

            Assert.Equal(test, FavoritesListBox.Items[0]);
        }

        [Fact]
        public void shouldDeleteFromBothLists()
        {
            string musicName0 = "Take a Break";
            string musicName1 = "Breakaway";

            RegularListBox.Items.Add(musicName0);
            RegularListBox.Items.Add(musicName1);
            FavoritesListBox.Items.Add(musicName0);
            RegularListBox.SelectedIndex = 0;
            RemoveButton.PerformClick();

            Assert.False(RegularListBox.Items.Contains(musicName0));
            Assert.False(FavoritesListBox.Items.Contains(musicName0));
        }
    }
}