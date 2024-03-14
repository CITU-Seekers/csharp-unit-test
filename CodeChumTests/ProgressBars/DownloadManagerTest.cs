using Timer = System.Windows.Forms.Timer;

namespace CodeChum.Tests
{
    public class DownloadManagerTest
    {
        DownloadManager? form;
        ProgressBar? downloadProgressBar;
        CheckBox? checkBox1, checkBox2, checkBox3, checkBox4, checkBox5;
        Button? downloadButton, cancelButton;

        public DownloadManagerTest()
        {
            form = new DownloadManager();
            form.Show();

            downloadProgressBar = (ProgressBar)TestUtils.GetControlNamed(form, "downloadProgressBar", true);
            checkBox1 = (CheckBox)TestUtils.GetControlNamed(form, "checkBox1", true);
            checkBox2 = (CheckBox)TestUtils.GetControlNamed(form, "checkBox2", true);
            checkBox3 = (CheckBox)TestUtils.GetControlNamed(form, "checkBox3", true);
            checkBox4 = (CheckBox)TestUtils.GetControlNamed(form, "checkBox4", true);
            checkBox5 = (CheckBox)TestUtils.GetControlNamed(form, "checkBox5", true);
            downloadButton = (Button)TestUtils.GetControlNamed(form, "downloadButton", true);
            cancelButton = (Button)TestUtils.GetControlNamed(form, "cancelButton", true);
        }

        [Fact]
        // Description: Should have all the controls `downloadProgressBar`, `checkBox1`, `checkBox2`, `checkBox3`, `checkBox4`, `checkBox5`, `downloadButton`, and `cancelButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(downloadProgressBar);
            Assert.NotNull(checkBox1);
            Assert.NotNull(checkBox2);
            Assert.NotNull(checkBox3);
            Assert.NotNull(checkBox4);
            Assert.NotNull(checkBox5);
            Assert.NotNull(downloadButton);
            Assert.NotNull(cancelButton);
        }

        [Fact]
        // Description: Should have maximum value of 500 for `downloadProgressBar` when all the checkboxes are checked.
        public void ShouldUpdateProgressBarMaximum()
        {
            checkBox1!.Checked = true;
            checkBox2!.Checked = true;
            checkBox3!.Checked = true;
            checkBox4!.Checked = true;
            checkBox5!.Checked = true;
            Assert.Equal(500, downloadProgressBar!.Maximum);
        }

        [Fact]
        // Description: Should have value greater than 0 for `downloadProgressBar` when the `downloadButton` is clicked.
        public void ShouldUpdateProgressBarValue()
        {
            checkBox1!.Checked = true;
            checkBox2!.Checked = true;
            downloadButton!.PerformClick();
            wait(5000);
            Assert.NotEqual(0, downloadProgressBar!.Value);
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
