namespace CodeChum.Tests
{
    public class ColorPickerTests
    {
        ColorPicker? form;
        TrackBar? RedTrackBar, GreenTrackBar, BlueTrackBar;
        Label? ColorLabel;

        public ColorPickerTests()
        {
            form = new ColorPicker();
            RedTrackBar = (TrackBar)TestUtils.GetControlNamed(form, "RedTrackBar", true);
            GreenTrackBar = (TrackBar)TestUtils.GetControlNamed(form, "GreenTrackBar", true);
            BlueTrackBar = (TrackBar)TestUtils.GetControlNamed(form, "BlueTrackBar", true);
            ColorLabel = (Label)TestUtils.GetControlNamed(form, "ColorLabel", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(RedTrackBar);
            Assert.NotNull(GreenTrackBar);
            Assert.NotNull(BlueTrackBar);
            Assert.NotNull(ColorLabel);
        }

        [Fact]
        public void ShouldHaveCorrectMaxMinOnTrackBars()
        {
            int min = 0;
            int max = 255;

            Assert.Equal(min, RedTrackBar.Minimum);
            Assert.Equal(min, GreenTrackBar.Minimum);
            Assert.Equal(min, BlueTrackBar.Minimum);
            Assert.Equal(max, RedTrackBar.Maximum);
            Assert.Equal(max, GreenTrackBar.Maximum);
            Assert.Equal(max, BlueTrackBar.Maximum);
        }
        [Fact]
        public void ShouldChangeColorOnRedTrackBarChange()
        {
            RedTrackBar.Value = 20;

            Assert.Equal(ColorLabel.BackColor.R, RedTrackBar.Value);
        }

        [Fact]
        public void ShouldChangeColorOnGreenTrackBarChange()
        {
            GreenTrackBar.Value = 20;

            Assert.Equal(ColorLabel.BackColor.G, GreenTrackBar.Value);
        }

        [Fact]
        public void ShouldChangeColorOnBlueTrackBarChange()
        {
            RedTrackBar.Value = 20;

            Assert.Equal(ColorLabel.BackColor.B, BlueTrackBar.Value);
        }
    }
}