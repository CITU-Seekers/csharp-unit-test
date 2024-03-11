namespace CodeChum.Tests
{
    public class PotionBrewingRevampTest
    {
        PotionBrewingRevamp? form;
        TrackBar? potency;
        TrackBar? duration;
        TrackBar? intensity;
        Label? potencyLevel;
        Label? durationLevel;
        Label? intensityLevel;

        public PotionBrewingRevampTest()
        {
            form = new PotionBrewingRevamp();
            form.Visible = true;
            potency = (TrackBar)TestUtils.GetControlNamed(form, "potencyTrackBar", true);
            duration = (TrackBar)TestUtils.GetControlNamed(form, "durationTrackBar", true);
            intensity = (TrackBar)TestUtils.GetControlNamed(form, "intensityTrackBar", true);
            potencyLevel = (Label)TestUtils.GetControlNamed(form, "PotencyLevel", true);
            durationLevel = (Label)TestUtils.GetControlNamed(form, "Duration", true);
            intensityLevel = (Label)TestUtils.GetControlNamed(form, "IntensityLevel", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(potency);
            Assert.NotNull(duration);
            Assert.NotNull(intensity);
            Assert.NotNull(potencyLevel);
            Assert.NotNull(durationLevel);
            Assert.NotNull(intensityLevel);
        }

        [Fact]
        public void ShouldHaveInitialValues()
        {
            Assert.Equal(0, potency!.Value);
            Assert.Equal(0, duration!.Value);
            Assert.Equal(0, intensity!.Value);
            Assert.Equal("Potency: 0%", potencyLevel!.Text);
            Assert.Equal("Duration: 0 seconds", durationLevel!.Text);
            Assert.Equal("Intensity: 0%", intensityLevel!.Text);
        }

        [Fact]
        public void ShouldHaveCorrectMinMaxValues()
        {
            Assert.Equal(0, potency!.Minimum);
            Assert.Equal(100, potency!.Maximum);
            Assert.Equal(0, duration!.Minimum);
            Assert.Equal(100, duration!.Maximum);
            Assert.Equal(0, intensity!.Minimum);
            Assert.Equal(100, intensity!.Maximum);
        }

        [Fact]
        public void ShouldUpdatePotionSettings()
        {
            potency!.Value = 80;
            duration!.Value = 90;
            intensity!.Value = 100;

            //Assert the color of the trackbar = red
            Assert.Equal(240, potency!.BackColor.R);
            Assert.Equal(240, duration!.BackColor.R);
            Assert.Equal(240, intensity!.BackColor.R);

        }
    }
}
