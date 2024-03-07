namespace CodeChum.Tests
{
    public class GreetingsTest
    {
        Greetings? form;

        public GreetingsTest()
        {
            form = new Greetings();
        }

        [Fact]
        public void ShouldHaveLabels()
        {
            Label label1 = (Label)TestUtils.GetControlNamed(form, "label1", true);
            Label label2 = (Label)TestUtils.GetControlNamed(form, "label2", true);
            Label label3 = (Label)TestUtils.GetControlNamed(form, "label3", true);
            Label label4 = (Label)TestUtils.GetControlNamed(form, "label4", true);
            Assert.NotNull(label1);
            Assert.NotNull(label2);
            Assert.NotNull(label3);
            Assert.NotNull(label4);
        }

        [Fact]
        public void ShouldDisplayCorrectGreetings()
        {
            Label label1 = (Label)TestUtils.GetControlNamed(form, "label1", true);
            Label label2 = (Label)TestUtils.GetControlNamed(form, "label2", true);
            Label label3 = (Label)TestUtils.GetControlNamed(form, "label3", true);
            Label label4 = (Label)TestUtils.GetControlNamed(form, "label4", true);

            Assert.Equal("Welcome from Planet Quark!", label1.Text);
            Assert.Equal("Population: 12 billion friendly aliens.", label2.Text);
            Assert.Equal("Greetings in Quarkian: Bloop Blorp!", label3.Text);
            Assert.Equal("Favorite pastimes: Stargazing, intergalactic travel, and solving coding puzzles.", label4.Text);
        }
    }
}
