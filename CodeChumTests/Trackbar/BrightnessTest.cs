using System.Drawing;

namespace CodeChum.Tests
{
    public class BrightnessTest
    {
        Brightness? form;
        TrackBar? BrightnessTrackBar;
        Label? lblColor;
        Label? lblBrightness;

        public BrightnessTest()
        {
            form = new Brightness();
            form.Visible = true;
            BrightnessTrackBar = (TrackBar)TestUtils.GetControlNamed(form, "BrightnessTrackBar", true);
            lblColor = (Label)TestUtils.GetControlNamed(form, "lblColor", true);
            lblBrightness = (Label)TestUtils.GetControlNamed(form, "lblBrightness", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(BrightnessTrackBar);
            Assert.NotNull(lblColor);
            Assert.NotNull(lblBrightness);
        }

        [Fact]
        public void ShouldHaveCorrectMinimumAndMaximum()
        {
            Assert.Equal(0, BrightnessTrackBar!.Minimum);
            Assert.Equal(100, BrightnessTrackBar!.Maximum);
        }

        [Fact]
        public void ShouldHaveInitialValues()
        {
            Assert.Equal(0, BrightnessTrackBar!.Value);
            Assert.Equal("Brightness Level: 0%", lblBrightness!.Text);
        }

        [Fact]
        public void ShouldUpdateLabelColor()
        {
            int expectedTrackbarValue = 20;
            int expectedTransparencyLevel = (int)((expectedTrackbarValue / 100.0) * 255);

            BrightnessTrackBar!.Value = expectedTrackbarValue;
            lblColor.BackColor = Color.FromArgb(expectedTransparencyLevel, 0, 0);

            Assert.Equal(expectedTransparencyLevel, lblColor.BackColor.R);
        }

    }
}
