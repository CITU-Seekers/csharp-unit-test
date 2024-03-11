namespace CodeChum.Tests
{
    public class SimpleLabelsTests
    {
        SimpleLabels? form;
        Label? Label1, Label2, Label3, Label4;

        public SimpleLabelsTests()
        {
            form = new SimpleLabels();
            Label1 = (Label)TestUtils.GetControlNamed(form, "Label1", true);
            Label2 = (Label)TestUtils.GetControlNamed(form, "Label2", true);
            Label3 = (Label)TestUtils.GetControlNamed(form, "Label3", true);
            Label4 = (Label)TestUtils.GetControlNamed(form, "Label4", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(Label1);
            Assert.NotNull(Label2);
            Assert.NotNull(Label3);
            Assert.NotNull(Label4);
        }

        [Fact]
        public void ShouldHaveCorrectValueInLabel1()
        {
            string label1 = "Hello World!";

            Assert.Equal(label1, Label1.Text);
        }

        [Fact]
        public void ShouldHaveCorrectValueInLabel2()
        {
            string label2 = "I love programming";

            Assert.Equal(label2, Label2.Text);
        }

        [Fact]
        public void ShouldHaveCorrectValueInLabel3()
        {
            string label3 = "I love CodeChum";

            Assert.Equal(label3, Label3.Text);
        }

        [Fact]
        public void ShouldHaveCorrectValueInLabel4()
        {
            string label4 = "I love C#";

            Assert.Equal(label4, Label4.Text);
        }
    }
}