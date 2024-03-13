namespace CodeChum.Tests
{
    public class SimpleLabelsTests
    {
        SimpleLabels? form;
        Label? helloWorldLabel, programmingLabel, codechumLabel, csharpLabel;

        public SimpleLabelsTests()
        {
            form = new SimpleLabels();
            helloWorldLabel = (Label)TestUtils.GetControlNamed(form, "helloWorldLabel", true);
            programmingLabel = (Label)TestUtils.GetControlNamed(form, "programmingLabel", true);
            codechumLabel = (Label)TestUtils.GetControlNamed(form, "codechumLabel", true);
            csharpLabel = (Label)TestUtils.GetControlNamed(form, "csharpLabel", true);
        }

        [Fact]
        // Description: Should have all the controls `helloWorldLabel`, `programmingLabel`, `codechumLabel`, and `csharpLabel`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(helloWorldLabel);
            Assert.NotNull(programmingLabel);
            Assert.NotNull(codechumLabel);
            Assert.NotNull(csharpLabel);
        }

        [Fact]
        // Description: Should have a text value of "Hello World!" in `helloWorldLabel`.
        public void ShouldHaveCorrectValueInhelloWorldLabel()
        {
            string label1 = "Hello World!";

            Assert.Equal(label1, helloWorldLabel.Text);
        }

        [Fact]
        // Description: Should have a text value of "I love programming" in `programmingLabel`.
        public void ShouldHaveCorrectValueInprogrammingLabel()
        {
            string label2 = "I love programming";

            Assert.Equal(label2, programmingLabel.Text);
        }

        [Fact]
        // Description: Should have a text value of "I love CodeChum" in `codechumLabel`.
        public void ShouldHaveCorrectValueIncodechumLabel()
        {
            string label3 = "I love CodeChum";

            Assert.Equal(label3, codechumLabel.Text);
        }

        [Fact]
        // Description: Should have a text value of "I love C#" in `csharpLabel`.
        public void ShouldHaveCorrectValueIncsharpLabel()
        {
            string label4 = "I love C#";

            Assert.Equal(label4, csharpLabel.Text);
        }
    }
}