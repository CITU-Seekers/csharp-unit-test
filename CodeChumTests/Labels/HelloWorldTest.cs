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
        // Description: Should have a control `textDisplayLabel`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(textDisplayLabel);
        }

        [Fact]
        // Description: Should have a text value of "Hello World!" in `textDisplayLabel`.
        public void ShouldHaveCorrectTextOntextDisplayLabel()
        {
            string expected = "Hello World!";

            Assert.Equal(expected, textDisplayLabel.Text);
        }
    }
}