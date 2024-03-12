namespace CodeChum.Tests
{
    public class SplitterActivityTests
    {
        SplitterActivity? form;
        Splitter? mainSplitter;
        TextBox? normalTextBox, capitalizedTextBox;

        public SplitterActivityTests()
        {
            form = new SplitterActivity();
            mainSplitter = (Splitter)TestUtils.GetControlNamed(form, "mainSplitter", true);
            normalTextBox = (TextBox)TestUtils.GetControlNamed(form, "normalTextBox", true);
            capitalizedTextBox = (TextBox)TestUtils.GetControlNamed(form, "capitalizedTextBox", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(mainSplitter);
            Assert.NotNull(normalTextBox);
            Assert.NotNull(capitalizedTextBox);
        }

        [Fact]
        public void ShouldDockTheMainSplitterCorrectly()
        {
            Assert.Equal(DockStyle.Left, mainSplitter.Dock);
        }

        [Fact]
        public void ShouldShowUppercaseTextOnNonEditableTextBox()
        {
            string test = "abcdef";
            string expected = test.ToUpper();

            normalTextBox.Text = test;

            Assert.Equal(expected, capitalizedTextBox.Text);
        }
    }
}