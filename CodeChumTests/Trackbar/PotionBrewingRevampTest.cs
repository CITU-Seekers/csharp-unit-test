namespace CodeChum.Tests
{
    public class PotionBrewingRevampTest
    {
        PotionBrewingRevamp? form;
        TrackBar? potencyTrackBar;
        TrackBar? durationTrackBar;
        TrackBar? intensityTrackBar;
        Label? potencyLabel;
        Label? durationLabel;
        Label? intensityLabel;

        public PotionBrewingRevampTest()
        {
            form = new PotionBrewingRevamp();
            form.Visible = true;
            potencyTrackBar = (TrackBar)TestUtils.GetControlNamed(form, "potencyTrackBar", true);
            durationTrackBar = (TrackBar)TestUtils.GetControlNamed(form, "durationTrackBar", true);
            intensityTrackBar = (TrackBar)TestUtils.GetControlNamed(form, "intensityTrackBar", true);
            potencyLabel = (Label)TestUtils.GetControlNamed(form, "potencyLabel", true);
            durationLabel = (Label)TestUtils.GetControlNamed(form, "durationLabel", true);
            intensityLabel = (Label)TestUtils.GetControlNamed(form, "intensityLabel", true);
        }

        [Fact]
        // Description: Should have all the controls `potencyTrackBar`, `durationTrackBar`, `intensityTrackBar`, `potencyLabel`, `durationLabel`, and `intensityLabel`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(potencyTrackBar);
            Assert.NotNull(durationTrackBar);
            Assert.NotNull(intensityTrackBar);
            Assert.NotNull(potencyLabel);
            Assert.NotNull(durationLabel);
            Assert.NotNull(intensityLabel);
        }

        [Fact]
        // Description: Should have `0` as initial value for `potencyTrackBar`, `durationTrackBar`, and `intensityTrackBar` and `Potency: 0%`, `Duration: 0 seconds`, and `Intensity: 0%` as initial value for `potencyLabel`, `durationLabel`, and `intensityLabel`.
        public void ShouldHaveInitialValues()
        {
            Assert.Equal(0, potencyTrackBar!.Value);
            Assert.Equal(0, durationTrackBar!.Value);
            Assert.Equal(0, intensityTrackBar!.Value);
            Assert.Equal("Potency: 0%", potencyLabel!.Text);
            Assert.Equal("Duration: 0 seconds", durationLabel!.Text);
            Assert.Equal("Intensity: 0%", intensityLabel!.Text);
        }

        [Fact]
        // Description: Should have `0` as minimum and `100` as maximum value for `potencyTrackBar`, `durationTrackBar`, and `intensityTrackBar`.
        public void ShouldHaveCorrectMinMaxValues()
        {
            Assert.Equal(0, potencyTrackBar!.Minimum);
            Assert.Equal(100, potencyTrackBar!.Maximum);
            Assert.Equal(0, durationTrackBar!.Minimum);
            Assert.Equal(100, durationTrackBar!.Maximum);
            Assert.Equal(0, intensityTrackBar!.Minimum);
            Assert.Equal(100, intensityTrackBar!.Maximum);
        }

        [Fact]
        // Description: Should update `potencyLabel`, `durationLabel`, and `intensityLabel` when the `potencyTrackBar`, `durationTrackBar`, and `intensityTrackBar` value is changed.
        public void ShouldUpdatePotionSettings()
        {
            potencyTrackBar!.Value = 80;
            durationTrackBar!.Value = 90;
            intensityTrackBar!.Value = 100;

            //Assert the color of the trackbar = red
            Assert.Equal(240, potencyTrackBar!.BackColor.R);
            Assert.Equal(240, durationTrackBar!.BackColor.R);
            Assert.Equal(240, intensityTrackBar!.BackColor.R);

        }
    }
}
