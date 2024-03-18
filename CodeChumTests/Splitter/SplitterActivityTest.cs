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
        // Description: Should have all the controls `mainSplitter`, `normalTextBox`, and `capitalizedTextBox`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(mainSplitter);
            Assert.NotNull(normalTextBox);
            Assert.NotNull(capitalizedTextBox);
        }

        [Fact]
        // Description: Should dock the `mainSplitter` in the left.
        public void ShouldDockTheMainSplitterCorrectly()
        {
            Assert.Equal(DockStyle.Left, mainSplitter.Dock);
        }

        [Fact]
        // Description: Should show uppercase text characters to the `capitalizedTextBox`.
        public void ShouldShowUppercaseTextOnTextBox()
        {
            string test = "abcdef";
            string expected = test.ToUpper();

            normalTextBox.Text = test;

            Assert.Equal(expected, capitalizedTextBox.Text);
        }
    }
}