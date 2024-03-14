using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace CodeChum.Tests
{
    public static class BitmapExtensions
    {
        public static int[] GetPixels(this Bitmap bitmap)
        {
            int width = bitmap.Width;
            int height = bitmap.Height;
            int[] pixels = new int[width * height];

            BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(bitmapData.Scan0, pixels, 0, pixels.Length);
            bitmap.UnlockBits(bitmapData);

            return pixels;
        }
    }
    public class DrawingCanvasAppTest
    {
        DrawingCanvasApp? form;
        PictureBox? pictureBox;
        ToolStrip? drawingToolStrip;
        ToolStripButton? pencilToolStripButton, lineToolStripButton, rectangleToolStripButton, ellipseToolStripButton, clearToolStripButton;
        ToolStripComboBox? colorToolStripComboBox;

        public DrawingCanvasAppTest()
        {
            form = new DrawingCanvasApp();
            form.Show();
            pictureBox = (PictureBox)TestUtils.GetControlNamed(form, "pictureBox", true);
            drawingToolStrip = (ToolStrip)TestUtils.GetControlNamed(form, "drawingToolStrip", true);
        }

        [Fact]
        // Description: Should have all the controls `pictureBox` and `drawingToolStrip`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(pictureBox);
            Assert.NotNull(drawingToolStrip);
        }

        [Fact]
        // Description: Should have all the drawing tools `pencilToolStripButton`, `lineToolStripButton`, `rectangleToolStripButton`, `ellipseToolStripButton`, `clearToolStripButton`, and `colorToolStripComboBox`.
        public void ShouldHaveAlldrawingToolStripControls()
        {
            pencilToolStripButton = drawingToolStrip.Items["pencilToolStripButton"] as ToolStripButton;
            lineToolStripButton = drawingToolStrip.Items["lineToolStripButton"] as ToolStripButton;
            rectangleToolStripButton = drawingToolStrip.Items["rectangleToolStripButton"] as ToolStripButton;
            ellipseToolStripButton = drawingToolStrip.Items["ellipseToolStripButton"] as ToolStripButton;
            clearToolStripButton = drawingToolStrip.Items["clearToolStripButton"] as ToolStripButton;
            colorToolStripComboBox = drawingToolStrip.Items["colorToolStripComboBox"] as ToolStripComboBox;

            Assert.NotNull(pencilToolStripButton);
            Assert.NotNull(lineToolStripButton);
            Assert.NotNull(rectangleToolStripButton);
            Assert.NotNull(ellipseToolStripButton);
            Assert.NotNull(clearToolStripButton);
            Assert.NotNull(colorToolStripComboBox);
        }

        [Fact]
        // Description: Should draw a line on the canvas with the color red when the `pencilToolStripButton` is clicked and the `colorToolStripComboBox` is set to red.
        public void ShouldDrawPencil()
        {
            pencilToolStripButton = drawingToolStrip.Items["pencilToolStripButton"] as ToolStripButton;
            colorToolStripComboBox = drawingToolStrip.Items["colorToolStripComboBox"] as ToolStripComboBox;

            pencilToolStripButton.PerformClick();
            colorToolStripComboBox.SelectedIndex = 0;

            // Create a bitmap to simulate the canvas
            using (Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    // Draw a line on the bitmap
                    g.DrawLine(new Pen(Color.Red, 2), 0, 0, 100, 100);
                }

                // Get the color of a pixel on the drawn line
                Color pixelColor = bitmap.GetPixel(50, 50);

                // Assert that the line was drawn with the correct color
                Assert.Equal(Color.FromArgb(255, Color.Red), pixelColor);
            }
        }

        [Fact]
        // Description: Should draw a line on the canvas with the color red when the `lineToolStripButton` is clicked and the `colorToolStripComboBox` is set to red.
        public void ShouldDrawLine()
        {
            lineToolStripButton = drawingToolStrip.Items["lineToolStripButton"] as ToolStripButton;
            colorToolStripComboBox = drawingToolStrip.Items["colorToolStripComboBox"] as ToolStripComboBox;

            lineToolStripButton.PerformClick();
            colorToolStripComboBox.SelectedIndex = 0;

            // Create a bitmap to simulate the canvas
            using (Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    // Draw a line on the bitmap
                    g.DrawLine(new Pen(Color.Red, 2), 0, 0, 100, 100);
                }

                // Get the color of a pixel on the drawn line
                Color pixelColor = bitmap.GetPixel(50, 50);

                // Assert that the line was drawn with the correct color
                Assert.Equal(Color.FromArgb(255, Color.Red), pixelColor);
            }
        }

        [Fact]
        // Description: Should draw a rectangle on the canvas with the color red when the `rectangleToolStripButton` is clicked and the `colorToolStripComboBox` is set to red.
        public void ShouldDrawRectangle()
        {
            rectangleToolStripButton = drawingToolStrip.Items["rectangleToolStripButton"] as ToolStripButton;
            colorToolStripComboBox = drawingToolStrip.Items["colorToolStripComboBox"] as ToolStripComboBox;

            rectangleToolStripButton.PerformClick();
            colorToolStripComboBox.SelectedIndex = 0;

            // Create a bitmap to simulate the canvas
            using (Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    // Draw a rectangle on the bitmap
                    g.DrawRectangle(new Pen(Color.Red, 2), 0, 0, 100, 100);
                }

                // Check multiple points along the perimeter of the rectangle
                Color topLeftColor = bitmap.GetPixel(0, 0);
                Color topRightColor = bitmap.GetPixel(99, 0);
                Color bottomLeftColor = bitmap.GetPixel(0, 99);
                Color bottomRightColor = bitmap.GetPixel(99, 99);

                // Assert that the rectangle was drawn with the correct color at different points
                Assert.Equal(Color.FromArgb(255, Color.Red), topLeftColor);
                Assert.Equal(Color.FromArgb(255, Color.Red), topRightColor);
                Assert.Equal(Color.FromArgb(255, Color.Red), bottomLeftColor);
                Assert.Equal(Color.FromArgb(255, Color.Red), bottomRightColor);
            }
        }

        [Fact]
        // Description: Should draw an ellipse on the canvas with the color red when the `ellipseToolStripButton` is clicked and the `colorToolStripComboBox` is set to red.
        public void ShouldDrawEllipse()
        {
            ellipseToolStripButton = drawingToolStrip.Items["ellipseToolStripButton"] as ToolStripButton;
            colorToolStripComboBox = drawingToolStrip.Items["colorToolStripComboBox"] as ToolStripComboBox;

            ellipseToolStripButton.PerformClick();
            colorToolStripComboBox.SelectedIndex = 0;

            // Create a bitmap to simulate the canvas
            using (Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    // Draw an ellipse on the bitmap
                    g.DrawEllipse(new Pen(Color.Red, 2), 0, 0, 100, 100);
                }

                // Check if the bitmap contains the color red
                Assert.Contains(Color.Red.ToArgb(), bitmap.GetPixels());
            }
        }

        [Fact]
        // Description: Should clear the canvas when the `clearToolStripButton` is clicked.
        public void ShouldClearCanvas()
        {
            clearToolStripButton = drawingToolStrip.Items["clearToolStripButton"] as ToolStripButton;

            clearToolStripButton.PerformClick();

            using (Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height))
            {
                // Check if the bitmap does not contains the color red or any color other than white
                Assert.DoesNotContain(Color.Red.ToArgb(), bitmap.GetPixels());
                Assert.DoesNotContain(Color.Blue.ToArgb(), bitmap.GetPixels());
                Assert.DoesNotContain(Color.Orange.ToArgb(), bitmap.GetPixels());
                Assert.DoesNotContain(Color.Green.ToArgb(), bitmap.GetPixels());
                Assert.DoesNotContain(Color.Yellow.ToArgb(), bitmap.GetPixels());
                Assert.DoesNotContain(Color.Black.ToArgb(), bitmap.GetPixels());
            }
        }

        [Fact]
        // Description: Should change the pen color to green when the `colorToolStripComboBox` is set to green and a line is drawn on the canvas.
        public void ShouldChangePenColor()
        {
            colorToolStripComboBox = drawingToolStrip.Items["colorToolStripComboBox"] as ToolStripComboBox;

            colorToolStripComboBox.SelectedIndex = 1;

            // Create a bitmap to simulate the canvas
            using (Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    // Draw a line on the bitmap
                    g.DrawLine(new Pen(Color.Green, 2), 0, 0, 100, 100);
                }

                // Get the color of a pixel on the drawn line
                Color pixelColor = bitmap.GetPixel(50, 50);

                // Assert that the line was drawn with the correct color
                Assert.Equal(Color.FromArgb(255, Color.Green), pixelColor);
            }
        }

    }
}
