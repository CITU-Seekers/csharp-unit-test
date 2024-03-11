namespace CodeChum.Tests
{
    public class HelloWorldTests
    {
        HelloWorld? form;
        Label? TextDisplayLabel;

        public HelloWorldTests()
        {
            form = new HelloWorld();
            TextDisplayLabel = (Label)TestUtils.GetControlNamed(form, "TextDisplayLabel", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(TextDisplayLabel);
        }

        [Fact]
        public void ShouldHaveCorrectTextOnTextDisplayLabel()
        {
            string expected = "Hello World!";

            Assert.Equal(expected, TextDisplayLabel.Text);
        }
    }
}