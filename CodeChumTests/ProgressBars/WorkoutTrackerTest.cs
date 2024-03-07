using Timer = System.Windows.Forms.Timer;

namespace CodeChum.Tests
{
    public class WorkoutTrackerTest
    {
        WorkoutTracker? form;
        Button? start;
        Button? finish;
        ProgressBar? progress;
        NumericUpDown? duration;
        ComboBox? workout;
        Timer? timer;

        public WorkoutTrackerTest()
        {
            form = new WorkoutTracker();
            form.Show();
            start = (Button)TestUtils.GetControlNamed(form, "btnStart", true);
            finish = (Button)TestUtils.GetControlNamed(form, "btnFinish", true);
            progress = (ProgressBar)TestUtils.GetControlNamed(form, "progressBar1", true);
            duration = (NumericUpDown)TestUtils.GetControlNamed(form, "numericUpDown1", true);
            workout = (ComboBox)TestUtils.GetControlNamed(form, "comboBox1", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(start);
            Assert.NotNull(finish);
            Assert.NotNull(progress);
            Assert.NotNull(duration);
            Assert.NotNull(workout);
        }

        [Fact]
        public void ShouldStartWorkout()
        {
            duration.Value = 5;
            //progress.Value = 0;
            progress.Maximum = (int)duration.Value;
            workout.SelectedIndex = 0;

            // Act
            start.PerformClick();

            // Wait for the workout to complete
            wait(5000);

            // Assert
            Assert.NotEqual(0, progress.Value);
        }

        public void wait(int milliseconds)
        {
            var timer = new Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            timer.Interval = milliseconds;
            timer.Enabled = true;
            timer.Start();

            timer.Tick += (s, e) =>
            {
                timer.Enabled = false;
                timer.Stop();
            };

            while (timer.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}
