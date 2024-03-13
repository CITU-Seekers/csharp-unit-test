namespace CodeChum.Tests
{
    public class LayoutDesignTest
    {
        LayoutDesign? form;
        SplitContainer? splitContainer1, splitContainer2;
        TextBox? textBox;
        PictureBox? pictureBox;
        ListView? studentListView;

        public LayoutDesignTest()
        {
            form = new LayoutDesign();
            form.Show();
            splitContainer1 = (SplitContainer)TestUtils.GetControlNamed(form, "splitContainer1", true);
            splitContainer2 = (SplitContainer)TestUtils.GetControlNamed(form, "splitContainer2", true);
            textBox = (TextBox)TestUtils.GetControlNamed(form, "textBox", true);
            pictureBox = (PictureBox)TestUtils.GetControlNamed(form, "pictureBox", true);
            studentListView = (ListView)TestUtils.GetControlNamed(form, "studentListView", true);
        }

        [Fact]
        // Description: Should have all the controls `splitContainer1`, `splitContainer2`, `textBox`, `pictureBox`, and `studentListView`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(form);
            Assert.NotNull(splitContainer1);
            Assert.NotNull(splitContainer2);
            Assert.NotNull(textBox);
            Assert.NotNull(pictureBox);
            Assert.NotNull(studentListView);
        }

        [Fact]
        // Description: Should have proper orientation of `splitContainer1` to be `Vertical` and `splitContainer2` to be `Horizontal`.
        public void ShouldHaveProperOrientationOnSplitters()
        {
            Assert.True(splitContainer2.Orientation == Orientation.Horizontal);
            Assert.True(splitContainer1.Orientation == Orientation.Vertical);
        }

        [Fact]
        // Description: Should have proper docking of `splitContainer1` and `splitContainer2` to be `Fill`.
        public void ShouldHaveProperDockingOnSplitters()
        {
            Assert.True(splitContainer1.Dock == DockStyle.Fill);
            Assert.True(splitContainer2.Dock == DockStyle.Fill);
        }
    }
}
