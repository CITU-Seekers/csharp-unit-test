namespace CodeChum.Tests
{
    public class FontSizeResizerTests
    {
        FontSizeResizer? form;
        TrackBar? ResizeTrackBar;
        Label? Label;

        public FontSizeResizerTests()
        {
            form = new FontSizeResizer();
            ResizeTrackBar = (TrackBar)TestUtils.GetControlNamed(form, "ResizeTrackBar", true);
            Label = (Label)TestUtils.GetControlNamed(form, "Label", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(ResizeTrackBar);
            Assert.NotNull(Label);
        }

        [Fact]
        public void ShouldChangeFontSizeOnTrackBarValueChange()
        {
            ResizeTrackBar.Value = ResizeTrackBar.Maximum;

            Assert.Equal(ResizeTrackBar.Value, Label.Font.Size);
        }
    }
}