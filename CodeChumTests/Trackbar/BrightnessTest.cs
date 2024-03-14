using System.Drawing;

namespace CodeChum.Tests
{
    public class BrightnessTest
    {
        Brightness? form;
        TrackBar? brightnessTrackBar;
        Label? colorLabel;
        Label? brightnessLabel;

        public BrightnessTest()
        {
            form = new Brightness();
            form.Visible = true;
            brightnessTrackBar = (TrackBar)TestUtils.GetControlNamed(form, "brightnessTrackBar", true);
            colorLabel = (Label)TestUtils.GetControlNamed(form, "colorLabel", true);
            brightnessLabel = (Label)TestUtils.GetControlNamed(form, "brightnessLabel", true);
        }

        [Fact]
        // Description: Should have all the controls `brightnessTrackBar`, `colorLabel`, and `brightnessLabel`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(brightnessTrackBar);
            Assert.NotNull(colorLabel);
            Assert.NotNull(brightnessLabel);
        }

        [Fact]
        // Description: Should have `0` as minimum and `100` as maximum value for `brightnessTrackBar`.
        public void ShouldHaveCorrectMinimumAndMaximum()
        {
            Assert.Equal(0, brightnessTrackBar!.Minimum);
            Assert.Equal(100, brightnessTrackBar!.Maximum);
        }

        [Fact]
        // Description: Should have `0` as initial value for `brightnessTrackBar` and `Brightness Level: 0%` as initial value for `brightnessLabel`.
        public void ShouldHaveInitialValues()
        {
            Assert.Equal(0, brightnessTrackBar!.Value);
            Assert.Equal("Brightness Level: 0%", brightnessLabel!.Text);
        }

        [Fact]
        // Description: Should update `brightnessLabel` when the `brightnessTrackBar` value is changed.
        public void ShouldUpdateLabelColor()
        {
            int expectedTrackbarValue = 20;
            int expectedTransparencyLevel = (int)((expectedTrackbarValue / 100.0) * 255);

            brightnessTrackBar!.Value = expectedTrackbarValue;
            colorLabel.BackColor = Color.FromArgb(expectedTransparencyLevel, 0, 0);

            Assert.Equal(expectedTransparencyLevel, colorLabel.BackColor.R);
        }

    }
}
