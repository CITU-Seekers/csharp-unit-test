namespace CodeChum.Tests
{
    public class GreetingsTest
    {
        Greetings? form;
        Label? label1;
        Label? label2;
        Label? label3;
        Label? label4;

        public GreetingsTest()
        {
            form = new Greetings();
            form.Show();
            label1 = (Label)TestUtils.GetControlNamed(form, "label1", true);
            label2 = (Label)TestUtils.GetControlNamed(form, "label2", true);
            label3 = (Label)TestUtils.GetControlNamed(form, "label3", true);
            label4 = (Label)TestUtils.GetControlNamed(form, "label4", true);
        }

        [Fact]
        // Description: Should have all controls `label1`, `label2`, `label3`, and `label4`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(label1);
            Assert.NotNull(label2);
            Assert.NotNull(label3);
            Assert.NotNull(label4);
        }

        [Fact]
        // Description: Should have `label1` with text "Welcome from Planet Quark!".
        public void ShouldHaveLabel1WithCorrectText()
        {
            Assert.Equal("Welcome from Planet Quark!", label1.Text);
        }

        [Fact]
        // Description: Should have `label2` with text "Population: 12 billion friendly aliens.".
        public void ShouldHaveLabel2WithCorrectText()
        {
            Assert.Equal("Population: 12 billion friendly aliens.", label2.Text);
        }

        [Fact]
        // Description: Should have `label3` with text "Greetings in Quarkian: Bloop Blorp!".
        public void ShouldHaveLabel3WithCorrectText()
        {
            Assert.Equal("Greetings in Quarkian: Bloop Blorp!", label3.Text);
        }

        [Fact]
        // Description: Should have `label4` with text "Favorite pastimes: Stargazing, intergalactic travel, and solving coding puzzles.".
        public void ShouldHaveLabel4WithCorrectText()
        {
            Assert.Equal("Favorite pastimes: Stargazing, intergalactic travel, and solving coding puzzles.", label4.Text);
        }
    }
}
