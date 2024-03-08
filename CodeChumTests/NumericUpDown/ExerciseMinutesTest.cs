namespace CodeChum.Tests
{
    public class ExerciseMinutesTest
    {
        ExerciseMinutes? form;
        NumericUpDown? walking;
        NumericUpDown? running;
        NumericUpDown? cycling;
        Label? total;

        public ExerciseMinutesTest()
        {
            form = new ExerciseMinutes();
            form.Visible = true;
            walking = (NumericUpDown)TestUtils.GetControlNamed(form, "numericUpDownWalking", true);
            running = (NumericUpDown)TestUtils.GetControlNamed(form, "numericUpDownRunning", true);
            cycling = (NumericUpDown)TestUtils.GetControlNamed(form, "numericUpDownCycling", true);
            total = (Label)TestUtils.GetControlNamed(form, "lblTotal", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(walking);
            Assert.NotNull(running);
            Assert.NotNull(cycling);
            Assert.NotNull(total);
        }

        [Fact]
        public void ShouldHaveInitialValues()
        {
            Assert.Equal(0, walking!.Value);
            Assert.Equal(0, running!.Value);
            Assert.Equal(0, cycling!.Value);
            Assert.Equal("Total Exercise Minutes: 0 min", total!.Text);
        }

        [Fact]
        public void ShouldUpdateTotalMinutes()
        {
            walking!.Value = 10;
            running!.Value = 20;
            cycling!.Value = 30;
            Assert.Equal("Total Exercise Minutes: 60 min", total!.Text);
        }
    }
}
