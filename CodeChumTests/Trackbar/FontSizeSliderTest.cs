namespace CodeChum.Tests
{
    public class FontSizeResizerTests
    {
        FontSizeResizer? form;
        TrackBar? resizeTrackBar;
        Label? fontSizeLabel;

        public FontSizeResizerTests()
        {
            form = new FontSizeResizer();
            resizeTrackBar = (TrackBar)TestUtils.GetControlNamed(form, "resizeTrackBar", true);
            fontSizeLabel = (Label)TestUtils.GetControlNamed(form, "fontSizeLabel", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(resizeTrackBar);
            Assert.NotNull(fontSizeLabel);
        }

        [Fact]
        public void ShouldChangeFontSizeOnTrackBarValueChange()
        {
            resizeTrackBar.Value = resizeTrackBar.Maximum;

            Assert.Equal(resizeTrackBar.Value, fontSizeLabel.Font.Size);
        }
    }
}