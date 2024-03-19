using Timer = System.Windows.Forms.Timer;

namespace CodeChum.Tests
{
    public class WorkoutTrackerTest
    {
        WorkoutTracker? form;
        Button? startButton;
        Button? finishButton;
        ProgressBar? progressBar;
        NumericUpDown? durationNumericUpDown;
        ComboBox? workoutComboBox;

        public WorkoutTrackerTest()
        {
            form = new WorkoutTracker();
            form.Show();
            startButton = (Button)TestUtils.GetControlNamed(form, "startButton", true);
            finishButton = (Button)TestUtils.GetControlNamed(form, "finishButton", true);
            progressBar = (ProgressBar)TestUtils.GetControlNamed(form, "progressBar", true);
            durationNumericUpDown = (NumericUpDown)TestUtils.GetControlNamed(form, "durationNumericUpDown", true);
            workoutComboBox = (ComboBox)TestUtils.GetControlNamed(form, "workoutComboBox", true);
        }

        [Fact]
        // Description: Should have all the controls `startButton`, `finishButton`, `progressBar`, `durationNumericUpDown`, and `workoutComboBox`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(startButton);
            Assert.NotNull(finishButton);
            Assert.NotNull(progressBar);
            Assert.NotNull(durationNumericUpDown);
            Assert.NotNull(workoutComboBox);
        }

        [Fact]
        // Description: Should start workout when `startButton` is clicked.
        public void ShouldStartWorkout()
        {
            durationNumericUpDown.Value = 5;
            //progress.Value = 0;
            progressBar.Maximum = (int)durationNumericUpDown.Value;
            workoutComboBox.SelectedIndex = 0;

            // Act
            startButton.PerformClick();

            // Wait for the workout to complete
            wait(5000);

            // Assert
            Assert.NotEqual(0, progressBar.Value);
        }

        [Fact] 
        // Description: Should finish workout when `finishButton` is clicked.
        public void ShouldFinishWorkout()
        {
            durationNumericUpDown.Value = 5;
            progressBar.Maximum = (int)durationNumericUpDown.Value;
            workoutComboBox.SelectedIndex = 0;

            // Act
            startButton.PerformClick();
            wait(5000);
            finishButton.PerformClick();

            // Assert
            Assert.Equal(0, progressBar.Value);
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
