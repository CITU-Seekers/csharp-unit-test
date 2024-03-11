namespace CodeChum.Tests
{
    public class SplittersTests
    {
        Splitters? form;
        Panel? TopPanel, BottomPanel, LeftPanel, RightPanel, CenterPanel;
        Splitter? TopSplitter, BottomSplitter, LeftSplitter, RightSplitter, CenterSplitter;

        public SplittersTests()
        {
            form = new Splitters();
            TopPanel = (Panel)TestUtils.GetControlNamed(form, "TopPanel", true);
            BottomPanel = (Panel)TestUtils.GetControlNamed(form, "BottomPanel", true);
            LeftPanel = (Panel)TestUtils.GetControlNamed(form, "LeftPanel", true);
            RightPanel = (Panel)TestUtils.GetControlNamed(form, "RightPanel", true);
            CenterPanel = (Panel)TestUtils.GetControlNamed(form, "CenterPanel", true);
            TopSplitter = (Splitter)TestUtils.GetControlNamed(form, "TopSplitter", true);
            BottomSplitter = (Splitter)TestUtils.GetControlNamed(form, "BottomSplitter", true);
            LeftSplitter = (Splitter)TestUtils.GetControlNamed(form, "LeftSplitter", true);
            RightSplitter = (Splitter)TestUtils.GetControlNamed(form, "RightSplitter", true);
            CenterSplitter = (Splitter)TestUtils.GetControlNamed(form, "CenterSplitter", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(TopPanel);
            Assert.NotNull(BottomPanel);
            Assert.NotNull(LeftPanel);
            Assert.NotNull(RightPanel);
            Assert.NotNull(CenterPanel);
            Assert.NotNull(TopSplitter);
            Assert.NotNull(BottomSplitter);
            Assert.NotNull(LeftSplitter);
            Assert.NotNull(RightSplitter);
            Assert.NotNull(CenterSplitter);
        }

        [Fact]
        public void ShouldBeDockedProperly()
        {
            Assert.Equal(DockStyle.Top, TopPanel.Dock);
            Assert.Equal(DockStyle.Top, TopSplitter.Dock);
            Assert.Equal(DockStyle.Bottom, BottomPanel.Dock);
            Assert.Equal(DockStyle.Bottom, BottomSplitter.Dock);
            Assert.Equal(DockStyle.Left, LeftPanel.Dock);
            Assert.Equal(DockStyle.Left, LeftSplitter.Dock);
            Assert.Equal(DockStyle.Right, RightPanel.Dock);
            Assert.Equal(DockStyle.Right, RightSplitter.Dock);
            Assert.Equal(DockStyle.Fill, CenterPanel.Dock);
            Assert.Equal(DockStyle.Fill, CenterPanel.Dock);
        }
    }
}