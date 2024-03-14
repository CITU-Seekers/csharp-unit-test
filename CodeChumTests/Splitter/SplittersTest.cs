namespace CodeChum.Tests
{
    public class SplittersTests
    {
        Splitters? form;
        Panel? topPanel, bottomPanel, leftPanel, rightPanel, centerPanel;
        Splitter? topSplitter, bottomSplitter, leftSplitter, rightSplitter;

        public SplittersTests()
        {
            form = new Splitters();
            topPanel = (Panel)TestUtils.GetControlNamed(form, "topPanel", true);
            bottomPanel = (Panel)TestUtils.GetControlNamed(form, "bottomPanel", true);
            leftPanel = (Panel)TestUtils.GetControlNamed(form, "leftPanel", true);
            rightPanel = (Panel)TestUtils.GetControlNamed(form, "rightPanel", true);
            centerPanel = (Panel)TestUtils.GetControlNamed(form, "centerPanel", true);
            topSplitter = (Splitter)TestUtils.GetControlNamed(form, "topSplitter", true);
            bottomSplitter = (Splitter)TestUtils.GetControlNamed(form, "bottomSplitter", true);
            leftSplitter = (Splitter)TestUtils.GetControlNamed(form, "leftSplitter", true);
            rightSplitter = (Splitter)TestUtils.GetControlNamed(form, "rightSplitter", true);
        }

        [Fact]
        // Description: Should have all the controls `topPanel`, `bottomPanel`, `leftPanel`, `rightPanel`, `centerPanel`, `topSplitter`, `bottomSplitter`, `leftSplitter`, and `rightSplitter`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(topPanel);
            Assert.NotNull(bottomPanel);
            Assert.NotNull(leftPanel);
            Assert.NotNull(rightPanel);
            Assert.NotNull(centerPanel);
            Assert.NotNull(topSplitter);
            Assert.NotNull(bottomSplitter);
            Assert.NotNull(leftSplitter);
            Assert.NotNull(rightSplitter);
        }

        [Fact]
        // Description: Should correctly dock all controls as specified in the instructions.
        public void ShouldBeDockedProperly()
        {
            Assert.Equal(DockStyle.Top, topPanel.Dock);
            Assert.Equal(DockStyle.Top, topSplitter.Dock);
            Assert.Equal(DockStyle.Bottom, bottomPanel.Dock);
            Assert.Equal(DockStyle.Bottom, bottomSplitter.Dock);
            Assert.Equal(DockStyle.Left, leftPanel.Dock);
            Assert.Equal(DockStyle.Left, leftSplitter.Dock);
            Assert.Equal(DockStyle.Right, rightPanel.Dock);
            Assert.Equal(DockStyle.Right, rightSplitter.Dock);
            Assert.Equal(DockStyle.Fill, centerPanel.Dock);
            Assert.Equal(DockStyle.Fill, centerPanel.Dock);
        }
    }
}