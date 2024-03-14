namespace CodeChum.Tests
{
    public class ColorPickerTests
    {
        ColorPicker? form;
        TrackBar? redTrackBar, greenTrackBar, blueTrackBar;
        Label? colorLabel;

        public ColorPickerTests()
        {
            form = new ColorPicker();
            redTrackBar = (TrackBar)TestUtils.GetControlNamed(form, "redTrackBar", true);
            greenTrackBar = (TrackBar)TestUtils.GetControlNamed(form, "greenTrackBar", true);
            blueTrackBar = (TrackBar)TestUtils.GetControlNamed(form, "blueTrackBar", true);
            colorLabel = (Label)TestUtils.GetControlNamed(form, "colorLabel", true);
        }

        [Fact]
        // Description: Should have all the controls `redTrackBar`, `greenTrackBar`, `blueTrackBar` and `colorLabel`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(redTrackBar);
            Assert.NotNull(greenTrackBar);
            Assert.NotNull(blueTrackBar);
            Assert.NotNull(colorLabel);
        }

        [Fact]
        // Description: Should have correct max and min values for `redTrackBar`, `greenTrackBar` and `blueTrackBar`.
        public void ShouldHaveCorrectMaxMinOnTrackBars()
        {
            int min = 0;
            int max = 255;

            Assert.Equal(min, redTrackBar.Minimum);
            Assert.Equal(min, greenTrackBar.Minimum);
            Assert.Equal(min, blueTrackBar.Minimum);
            Assert.Equal(max, redTrackBar.Maximum);
            Assert.Equal(max, greenTrackBar.Maximum);
            Assert.Equal(max, blueTrackBar.Maximum);
        }
        [Fact]
        // Description: Should change the panel's background according to the `redTrackBar` value.
        public void ShouldChangeColorOnRedTrackBarChange()
        {
            redTrackBar.Value = 20;

            Assert.Equal(colorLabel.BackColor.R, redTrackBar.Value);
        }

        [Fact]
        // Description: Should change the panel's background according to the `greenTrackBar` value.
        public void ShouldChangeColorOnGreenTrackBarChange()
        {
            greenTrackBar.Value = 20;

            Assert.Equal(colorLabel.BackColor.G, greenTrackBar.Value);
        }

        [Fact]
        // Description: Should change the panel's background according to the `blueTrackBar` value.
        public void ShouldChangeColorOnBlueTrackBarChange()
        {
            blueTrackBar.Value = 20;

            Assert.Equal(colorLabel.BackColor.B, blueTrackBar.Value);
        }
    }
}