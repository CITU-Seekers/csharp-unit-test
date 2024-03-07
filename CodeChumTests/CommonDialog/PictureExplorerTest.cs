using System.Drawing.Imaging;
using System.Drawing;

namespace CodeChum.Tests
{
    public class PictureExplorerTest
    {
        PictureExplorer? form;
        Button? btnOpen;
        PictureBox? PictureBox;

        public PictureExplorerTest()
        {
            form = new PictureExplorer();
            form.Show();
            btnOpen = (Button)TestUtils.GetControlNamed(form, "btnOpen", true);
            PictureBox = (PictureBox)TestUtils.GetControlNamed(form, "PictureBox", true);
        }

        public void createImageFile()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string fileName = path + "\\sample_image.png";

            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a simple image (e.g., a white 100x100 pixel image)
                using (Bitmap bitmap = new Bitmap(100, 100))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.Clear(Color.Red); // Filling the entire image with red color for simplicity
                    }

                    // Save the image to the specified file path
                    bitmap.Save(fileName, ImageFormat.Png);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(btnOpen);
            Assert.NotNull(PictureBox);
        }

        [Fact]
        public void ShouldOpenPicture()
        {
            createImageFile();

            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string fileName = path + "\\sample_image.png";

            // Set the file name in the OpenFileDialog
            form.OpenFileDialog.FileName = fileName;

            btnOpen.PerformClick();

            // Check if PictureBox contains the expected image
            Assert.NotNull(PictureBox.Image);
        }
    }
}
