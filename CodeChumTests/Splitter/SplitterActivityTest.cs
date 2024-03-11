namespace CodeChum.Tests
{
    public class SplitterActivityTests
    {
        SplitterActivity? form;
        Splitter? MainSplitter;
        TextBox? NormalTextBox, CapitalizedTextBox;

        public SplitterActivityTests()
        {
            form = new SplitterActivity();
            MainSplitter = (Splitter)TestUtils.GetControlNamed(form, "MainSplitter", true);
            NormalTextBox = (TextBox)TestUtils.GetControlNamed(form, "NormalTextBox", true);
            CapitalizedTextBox = (TextBox)TestUtils.GetControlNamed(form, "CapitalizedTextBox", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(MainSplitter);
            Assert.NotNull(NormalTextBox);
            Assert.NotNull(CapitalizedTextBox);
        }

        [Fact]
        public void ShouldDockTheMainSplitterCorrectly()
        {
            Assert.Equal(DockStyle.Left, MainSplitter.Dock);
        }

        [Fact]
        public void ShouldShowUppercaseTextOnNonEditableTextBox()
        {
            string test = "abcdef";
            string expected = test.ToUpper();

            NormalTextBox.Text = test;

            Assert.Equal(expected, CapitalizedTextBox.Text);
        }
    }
}