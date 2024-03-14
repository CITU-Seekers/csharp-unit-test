namespace CodeChum.Tests
{
    public class ExerciseMinutesTest
    {
        ExerciseMinutes? form;
        NumericUpDown? walkingNumericUpDown;
        NumericUpDown? runningNumericUpDown;
        NumericUpDown? cyclingNumericUpDown;
        Label? totalLabel;

        public ExerciseMinutesTest()
        {
            form = new ExerciseMinutes();
            form.Visible = true;
            walkingNumericUpDown = (NumericUpDown)TestUtils.GetControlNamed(form, "walkingNumericUpDown", true);
            runningNumericUpDown = (NumericUpDown)TestUtils.GetControlNamed(form, "runningNumericUpDown", true);
            cyclingNumericUpDown = (NumericUpDown)TestUtils.GetControlNamed(form, "cyclingNumericUpDown", true);
            totalLabel = (Label)TestUtils.GetControlNamed(form, "totalLabel", true);
        }

        [Fact]
        // Description: Should have all the controls `walkingNumericUpDown`, `runningNumericUpDown`, `cyclingNumericUpDown`, and `totalLabel`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(walkingNumericUpDown);
            Assert.NotNull(runningNumericUpDown);
            Assert.NotNull(cyclingNumericUpDown);
            Assert.NotNull(totalLabel);
        }

        [Fact]
        // Description: Should have text "Total Exercise Minutes: 0 min" in `totalLabel` when the form is loaded and `0` is set to `walkingNumericUpDown`, `runningNumericUpDown`, and `cyclingNumericUpDown`.
        public void ShouldHaveInitialValues()
        {
            Assert.Equal(0, walkingNumericUpDown!.Value);
            Assert.Equal(0, runningNumericUpDown!.Value);
            Assert.Equal(0, cyclingNumericUpDown!.Value);
            Assert.Equal("Total Exercise Minutes: 0 min", totalLabel!.Text);
        }

        [Fact]
        // Description: Should have text "Total Exercise Minutes: 60 min" in `totalLabel` when `walkingNumericUpDown` is set to `10`, `runningNumericUpDown` is set to `20`, and `cyclingNumericUpDown` is set to `30`.
        public void ShouldUpdateTotalMinutes()
        {
            walkingNumericUpDown!.Value = 10;
            runningNumericUpDown!.Value = 20;
            cyclingNumericUpDown!.Value = 30;
            Assert.Equal("Total Exercise Minutes: 60 min", totalLabel!.Text);
        }
    }
}
