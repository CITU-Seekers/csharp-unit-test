using Timer = System.Windows.Forms.Timer;

namespace CodeChum.Tests
{
    public class SimpleProgressBarTests
    {
        SimpleProgressBar? form;
        ProgressBar? ProgressBar;
        Button? StartButton;
        public SimpleProgressBarTests()
        {
            form = new SimpleProgressBar();
            form.Show();
            ProgressBar = (ProgressBar)TestUtils.GetControlNamed(form, "ProgressBar", true);
            StartButton = (Button)TestUtils.GetControlNamed(form, "StartButton", true);
        }

        [Fact]
        public void HasAllControls()
        {
            Assert.NotNull(ProgressBar);
            Assert.NotNull(StartButton);
        }

        [Fact]
        public void ShouldStartOnButtonClick()
        {
            StartButton.PerformClick();
            wait(5000);

            Assert.NotEqual(0, ProgressBar.Value);
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