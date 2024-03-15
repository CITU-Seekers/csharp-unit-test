namespace CodeChum.Tests
{
    public class MyFavoritePlaylistTests
    {
        MyFavoritePlaylist? form;
        ListBox? regularListBox, favoritesListBox;
        TextBox? musicTextBox;
        Button? addButton, removeButton, addToFavoritesButton;

        public MyFavoritePlaylistTests()
        {
            form = new MyFavoritePlaylist();
            form.Show();
            regularListBox = (ListBox)TestUtils.GetControlNamed(form, "regularListBox", true);
            favoritesListBox = (ListBox)TestUtils.GetControlNamed(form, "favoritesListBox", true);
            musicTextBox = (TextBox)TestUtils.GetControlNamed(form, "musicTextBox", true);
            addButton = (Button)TestUtils.GetControlNamed(form, "addButton", true);
            removeButton = (Button)TestUtils.GetControlNamed(form, "removeButton", true);
            addToFavoritesButton = (Button)TestUtils.GetControlNamed(form, "addToFavoritesButton", true);
        }

        [Fact]
        // Description: Should have all the controls `regularListBox`, `favoritesListBox`, `musicTextBox`, `addButton`, `removeButton`, and `addToFavoritesButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(regularListBox);
            Assert.NotNull(favoritesListBox);
            Assert.NotNull(musicTextBox);
            Assert.NotNull(addButton);
            Assert.NotNull(removeButton);
            Assert.NotNull(addToFavoritesButton);
        }

        [Fact]
        // Description: Should add music from `musicTextBox` to `regularListBox` on `addButton` click.
        public void ShouldAddTextBoxOnAddButtonClick()
        {
            string test = "MusicTest";
            musicTextBox.Text = test;

            addButton.PerformClick();

            Assert.Equal(test, regularListBox.Items[0]);
        }

        [Fact]
        // Description: Should remove selected music from `regularListBox` on `removeButton` click.
        public void ShouldRemoveMusicSelectedFromListBox()
        {
            string musicName0 = "Take a Break";
            string musicName1 = "Breakaway";

            regularListBox.Items.Add(musicName0);
            regularListBox.Items.Add(musicName1);
            regularListBox.SelectedIndex = 0;
            removeButton.PerformClick();

            Assert.False(regularListBox.Items.Contains(musicName0));
        }

        [Fact]
        // Description: Should add selected music from `regularListBox` to `favoritesListBox` on `addToFavoritesButton` click.
        public void ShouldTransferToFavoritesOnTransferButtonClick()
        {
            string test = "MusicTest";
            musicTextBox.Text = test;

            addButton.PerformClick();
            regularListBox.SelectedIndex = 0;
            addToFavoritesButton.PerformClick();

            Assert.Equal(test, favoritesListBox.Items[0]);
        }

        [Fact]
        // Description: Should remove selected music from `regularListBox` at the same time from `favoritesListBox` if it exists on `removeButton` click.
        public void shouldDeleteFromBothLists()
        {
            string musicName0 = "Take a Break";
            string musicName1 = "Breakaway";

            regularListBox.Items.Add(musicName0);
            regularListBox.Items.Add(musicName1);
            favoritesListBox.Items.Add(musicName0);
            regularListBox.SelectedIndex = 0;
            removeButton.PerformClick();

            Assert.False(regularListBox.Items.Contains(musicName0));
            Assert.False(favoritesListBox.Items.Contains(musicName0));
        }
    }
}