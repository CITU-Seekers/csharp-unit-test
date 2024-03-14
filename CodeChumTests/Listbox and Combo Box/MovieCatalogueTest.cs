namespace CodeChum.Tests
{
    public class MovieCatalogueTest
    {
        MovieCatalogue? form;
        ListBox? comedyListBox;
        ListBox? horrorListBox;
        ListBox? actionListBox;
        TextBox? movieNameTextBox;
        ComboBox? genreComboBox;
        Button? addMovieButton;

        public MovieCatalogueTest()
        {
            form = new MovieCatalogue();
            form.Show();
            comedyListBox = (ListBox)TestUtils.GetControlNamed(form, "comedyListBox", true);
            horrorListBox = (ListBox)TestUtils.GetControlNamed(form, "horrorListBox", true);
            actionListBox = (ListBox)TestUtils.GetControlNamed(form, "actionListBox", true);
            movieNameTextBox = (TextBox)TestUtils.GetControlNamed(form, "movieNameTextBox", true);
            genreComboBox = (ComboBox)TestUtils.GetControlNamed(form, "genreComboBox", true);
            addMovieButton = (Button)TestUtils.GetControlNamed(form, "addMovieButton", true);
        }

        [Fact]
        // Description: Should have all controls `comedyListBox`, `horrorListBox`, `actionListBox`, `movieNameTextBox`, `genreComboBox`, and `addMovieButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(comedyListBox);
            Assert.NotNull(horrorListBox);
            Assert.NotNull(actionListBox);
            Assert.NotNull(movieNameTextBox);
            Assert.NotNull(genreComboBox);
            Assert.NotNull(addMovieButton);
        }

        [Fact]
        // Description: Should have 3 items in `genreComboBox` and the items should be "Comedy", "Horror", and "Action".
        public void ShouldHaveComboBoxItems()
        {
            Assert.Equal(3, genreComboBox.Items.Count);
            Assert.Equal("Comedy", genreComboBox.Items[0]);
            Assert.Equal("Horror", genreComboBox.Items[1]);
            Assert.Equal("Action", genreComboBox.Items[2]);
        }

        [Fact]
        // Description: Should add a movie with the name "The Hangover" in `movieNameTextBox` and genre "Comedy" in `genreComboBox` to `comedyListBox` when `addMovieButton` is clicked.
        public void ShouldAddComedy()
        {
            movieNameTextBox.Text = "The Hangover";
            genreComboBox.SelectedIndex = 0;
            addMovieButton.PerformClick();
            Assert.Equal("The Hangover", comedyListBox.Items[0]);
        }

        [Fact]
        // Description: Should add a movie with the name "The Shining" in `movieNameTextBox` and genre "Horror" in `genreComboBox` to `horrorListBox` when `addMovieButton` is clicked.
        public void ShouldAddHorror()
        {
            movieNameTextBox.Text = "The Shining";
            genreComboBox.SelectedIndex = 1;
            addMovieButton.PerformClick();
            Assert.Equal("The Shining", horrorListBox.Items[0]);
        }

        [Fact]
        // Description: Should add a movie with the name "The Matrix" in `movieNameTextBox` and genre "Action" in `genreComboBox` to `actionListBox` when `addMovieButton` is clicked.
        public void ShouldAddAction()
        {
            movieNameTextBox.Text = "The Matrix";
            genreComboBox.SelectedIndex = 2;
            addMovieButton.PerformClick();
            Assert.Equal("The Matrix", actionListBox.Items[0]);
        }

        [Fact]
        // Description: Should add multiple movies to the respective list boxes.
        public void ShouldAddMultiple()
        {
            movieNameTextBox.Text = "The Hangover";
            genreComboBox.SelectedIndex = 0;
            addMovieButton.PerformClick();
            movieNameTextBox.Text = "The Shining";
            genreComboBox.SelectedIndex = 1;
            addMovieButton.PerformClick();
            movieNameTextBox.Text = "The Matrix";
            genreComboBox.SelectedIndex = 2;
            addMovieButton.PerformClick();
            Assert.Equal("The Hangover", comedyListBox.Items[0]);
            Assert.Equal("The Shining", horrorListBox.Items[0]);
            Assert.Equal("The Matrix", actionListBox.Items[0]);
        }

    }
}
