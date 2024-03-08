namespace CodeChum.Tests
{
    public class LayoutDesignTest
    {
        LayoutDesign? form;
        SplitContainer? splitContainer1, splitContainer2;
        TextBox? textBox1;
        PictureBox? pictureBox1;
        ListView? listView1;

        public LayoutDesignTest()
        {
            form = new LayoutDesign();
            form.Show();
            splitContainer1 = (SplitContainer)TestUtils.GetControlNamed(form, "splitContainer1", true);
            splitContainer2 = (SplitContainer)TestUtils.GetControlNamed(form, "splitContainer2", true);
            textBox1 = (TextBox)TestUtils.GetControlNamed(form, "textBox1", true);
            pictureBox1 = (PictureBox)TestUtils.GetControlNamed(form, "pictureBox1", true);
            listView1 = (ListView)TestUtils.GetControlNamed(form, "listView1", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(form);
            Assert.NotNull(splitContainer1);
            Assert.NotNull(splitContainer2);
            Assert.NotNull(textBox1);
            Assert.NotNull(pictureBox1);
            Assert.NotNull(listView1);
        }

        [Fact]
        public void ShouldHaveProperOrientationOnSplitters()
        {
            Assert.True(splitContainer2.Orientation == Orientation.Horizontal);
            Assert.True(splitContainer1.Orientation == Orientation.Vertical);
        }

        [Fact]
        public void ShouldHaveProperDockingOnSplitters()
        {
            Assert.True(splitContainer1.Dock == DockStyle.Fill);
            Assert.True(splitContainer2.Dock == DockStyle.Fill);
        }
    }
}
