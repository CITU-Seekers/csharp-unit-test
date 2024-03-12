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
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(helloWorldLabel);
            Assert.NotNull(programmingLabel);
            Assert.NotNull(codechumLabel);
            Assert.NotNull(csharpLabel);
        }

        [Fact]
        public void ShouldHaveCorrectValueInhelloWorldLabel()
        {
            string label1 = "Hello World!";

            Assert.Equal(label1, helloWorldLabel.Text);
        }

        [Fact]
        public void ShouldHaveCorrectValueInprogrammingLabel()
        {
            string label2 = "I love programming";

            Assert.Equal(label2, programmingLabel.Text);
        }

        [Fact]
        public void ShouldHaveCorrectValueIncodechumLabel()
        {
            string label3 = "I love CodeChum";

            Assert.Equal(label3, codechumLabel.Text);
        }

        [Fact]
        public void ShouldHaveCorrectValueIncsharpLabel()
        {
            string label4 = "I love C#";

            Assert.Equal(label4, csharpLabel.Text);
        }
    }
}