namespace CodeChum.Tests
{
    public class MovieCatalogueTest
    {
        MovieCatalogue? form;
        ListBox? comedyList;
        ListBox? horrorList;
        ListBox? actionList;
        TextBox? movieName;
        ComboBox? genre;
        Button? btnAdd;

        public MovieCatalogueTest()
        {
            form = new MovieCatalogue();
            form.Show();
            comedyList = (ListBox)TestUtils.GetControlNamed(form, "ComedyList", true);
            horrorList = (ListBox)TestUtils.GetControlNamed(form, "HorrorList", true);
            actionList = (ListBox)TestUtils.GetControlNamed(form, "ActionList", true);
            movieName = (TextBox)TestUtils.GetControlNamed(form, "MovieName", true);
            genre = (ComboBox)TestUtils.GetControlNamed(form, "cboGenre", true);
            btnAdd = (Button)TestUtils.GetControlNamed(form, "btnAdd", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(comedyList);
            Assert.NotNull(horrorList);
            Assert.NotNull(actionList);
            Assert.NotNull(movieName);
            Assert.NotNull(genre);
            Assert.NotNull(btnAdd);
        }

        [Fact]
        public void ShouldAddComedy()
        {
            movieName.Text = "The Hangover";
            genre.SelectedIndex = 0;
            btnAdd.PerformClick();
            Assert.Equal("The Hangover", comedyList.Items[0]);
        }

        [Fact]
        public void ShouldAddHorror()
        {
            movieName.Text = "The Shining";
            genre.SelectedIndex = 1;
            btnAdd.PerformClick();
            Assert.Equal("The Shining", horrorList.Items[0]);
        }

        [Fact]
        public void ShouldAddAction()
        {
            movieName.Text = "The Matrix";
            genre.SelectedIndex = 2;
            btnAdd.PerformClick();
            Assert.Equal("The Matrix", actionList.Items[0]);
        }

        [Fact]
        public void ShouldAddMultiple()
        {
            movieName.Text = "The Hangover";
            genre.SelectedIndex = 0;
            btnAdd.PerformClick();
            movieName.Text = "The Shining";
            genre.SelectedIndex = 1;
            btnAdd.PerformClick();
            movieName.Text = "The Matrix";
            genre.SelectedIndex = 2;
            btnAdd.PerformClick();
            Assert.Equal("The Hangover", comedyList.Items[0]);
            Assert.Equal("The Shining", horrorList.Items[0]);
            Assert.Equal("The Matrix", actionList.Items[0]);
        }

    }
}
