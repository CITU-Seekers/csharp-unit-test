using System.Drawing.Imaging;
using System.Drawing;

namespace CodeChum.Tests
{
    public class PictureExplorerTest : IDisposable
    {
        private PictureExplorer form;
        private Button openButton;
        private PictureBox pictureBox;
        private string testImagePath;

        public PictureExplorerTest()
        {
            form = new PictureExplorer();
            form.Show();
            openButton = (Button)TestUtils.GetControlNamed(form, "openButton", true);
            pictureBox = (PictureBox)TestUtils.GetControlNamed(form, "pictureBox", true);

            testImagePath = CreateTestImagePath();
        }

        private string CreateTestImagePath()
        {
            // Create a unique temporary file for the test
            string path = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName() + ".png");
            CreateImageFile(path);
            return path;
        }

        private void CreateImageFile(string filePath)
        {
            using (var bitmap = new Bitmap(100, 100))
            {
                using (var g = Graphics.FromImage(bitmap))
                {
                    g.Clear(Color.Red);
                }
                bitmap.Save(filePath, ImageFormat.Png);
            }
        }

        [Fact]
        // Description: Should have all controls `openButton` and `pictureBox`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(openButton);
            Assert.NotNull(pictureBox);
        }

        [Fact]
        // Description: Should open picture from the file system and display it in `pictureBox`.
        public void ShouldOpenPicture()
        {
            form.OpenPicture(testImagePath);
            Assert.NotNull(pictureBox.Image);
        }

        public void Dispose()
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
                pictureBox.Image = null;
            }

            // Force a garbage collection to release the file
            GC.Collect();
            GC.WaitForPendingFinalizers();

            try
            {
                File.Delete(testImagePath);
            }
            catch (IOException)
            {
                // Ignore exceptions
            }
        }
    }
}
