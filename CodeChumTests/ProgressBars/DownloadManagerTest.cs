using Timer = System.Windows.Forms.Timer;

namespace CodeChum.Tests
{
    public class DownloadManagerTest
    {
        DownloadManager? form;
        ProgressBar? progressBar;
        CheckBox? checkBox1, checkBox2, checkBox3, checkBox4, checkBox5;
        Button? btnDownload, btnCancel;

        public DownloadManagerTest()
        {
            form = new DownloadManager();
            form.Visible = true;
            progressBar = (ProgressBar)TestUtils.GetControlNamed(form, "progressBar", true);
            checkBox1 = (CheckBox)TestUtils.GetControlNamed(form, "checkBox1", true);
            checkBox2 = (CheckBox)TestUtils.GetControlNamed(form, "checkBox2", true);
            checkBox3 = (CheckBox)TestUtils.GetControlNamed(form, "checkBox3", true);
            checkBox4 = (CheckBox)TestUtils.GetControlNamed(form, "checkBox4", true);
            checkBox5 = (CheckBox)TestUtils.GetControlNamed(form, "checkBox5", true);
            btnDownload = (Button)TestUtils.GetControlNamed(form, "btnDownload", true);
            btnCancel = (Button)TestUtils.GetControlNamed(form, "btnCancel", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(progressBar);
            Assert.NotNull(checkBox1);
            Assert.NotNull(checkBox2);
            Assert.NotNull(checkBox3);
            Assert.NotNull(checkBox4);
            Assert.NotNull(checkBox5);
            Assert.NotNull(btnDownload);
            Assert.NotNull(btnCancel);
        }

        [Fact]
        public void ShouldUpdateProgressBarMaximum()
        {
            checkBox1!.Checked = true;
            checkBox2!.Checked = true;
            checkBox3!.Checked = true;
            checkBox4!.Checked = true;
            checkBox5!.Checked = true;
            Assert.Equal(500, progressBar!.Maximum);
        }

        [Fact]
        public void ShouldUpdateProgressBarValue()
        {
            checkBox1!.Checked = true;
            checkBox2!.Checked = true;
            btnDownload!.PerformClick();
            wait(5000);
            Assert.NotEqual(0, progressBar!.Value);
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
