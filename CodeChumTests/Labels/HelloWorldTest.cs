namespace CodeChum.Tests
{
    public class HelloWorldTests
    {
        HelloWorld? form;
        Label? textDisplayLabel;

        public HelloWorldTests()
        {
            form = new HelloWorld();
            textDisplayLabel = (Label)TestUtils.GetControlNamed(form, "textDisplayLabel", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(textDisplayLabel);
        }

        [Fact]
        public void ShouldHaveCorrectTextOntextDisplayLabel()
        {
            string expected = "Hello World!";

            Assert.Equal(expected, textDisplayLabel.Text);
        }
    }
}