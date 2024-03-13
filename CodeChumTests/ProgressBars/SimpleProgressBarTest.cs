using Timer = System.Windows.Forms.Timer;

namespace CodeChum.Tests
{
    public class SimpleProgressBarTests
    {
        SimpleProgressBar? form;
        ProgressBar? timedProgressBar;
        Button? startButton;
        public SimpleProgressBarTests()
        {
            form = new SimpleProgressBar();
            form.Show();
            timedProgressBar = (ProgressBar)TestUtils.GetControlNamed(form, "timedProgressBar", true);
            startButton = (Button)TestUtils.GetControlNamed(form, "startButton", true);
        }

        [Fact]
        // Description: Should have all the controls `timedProgressBar` and `startButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(timedProgressBar);
            Assert.NotNull(startButton);
        }

        [Fact]
        // Description: Should start the progress bar `timedProgressBar` on `startButton` click.
        public void ShouldStartOnButtonClick()
        {
            startButton.PerformClick();
            wait(5000);

            Assert.NotEqual(0, timedProgressBar.Value);
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