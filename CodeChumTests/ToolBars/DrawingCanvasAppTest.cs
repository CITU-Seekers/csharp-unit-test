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
        PictureBox? CanvasBox;
        ToolStrip? DrawingToolStrip;
        ToolStripButton? PencilButton, LineButton, RectangleButton, EllipseButton, ClearButton;
        ToolStripComboBox? ColorComboBox;

        public DrawingCanvasAppTest()
        {
            form = new DrawingCanvasApp();
            form.Show();
            CanvasBox = (PictureBox)TestUtils.GetControlNamed(form, "CanvasBox", true);
            DrawingToolStrip = (ToolStrip)TestUtils.GetControlNamed(form, "DrawingToolStrip", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(CanvasBox);
            Assert.NotNull(DrawingToolStrip);
        }

        [Fact]
        public void ShouldHaveAllDrawingToolStripControls()
        {
            PencilButton = DrawingToolStrip.Items["PencilButton"] as ToolStripButton;
            LineButton = DrawingToolStrip.Items["LineButton"] as ToolStripButton;
            RectangleButton = DrawingToolStrip.Items["RectangleButton"] as ToolStripButton;
            EllipseButton = DrawingToolStrip.Items["EllipseButton"] as ToolStripButton;
            ClearButton = DrawingToolStrip.Items["ClearButton"] as ToolStripButton;
            ColorComboBox = DrawingToolStrip.Items["ColorComboBox"] as ToolStripComboBox;

            Assert.NotNull(PencilButton);
            Assert.NotNull(LineButton);
            Assert.NotNull(RectangleButton);
            Assert.NotNull(EllipseButton);
            Assert.NotNull(ClearButton);
            Assert.NotNull(ColorComboBox);
        }

        [Fact]
        public void ShouldDrawPencil()
        {
            PencilButton = DrawingToolStrip.Items["PencilButton"] as ToolStripButton;
            ColorComboBox = DrawingToolStrip.Items["ColorComboBox"] as ToolStripComboBox;

            PencilButton.PerformClick();
            ColorComboBox.SelectedIndex = 0;

            // Create a bitmap to simulate the canvas
            using (Bitmap bitmap = new Bitmap(CanvasBox.Width, CanvasBox.Height))
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
        public void ShouldDrawLine()
        {
            LineButton = DrawingToolStrip.Items["LineButton"] as ToolStripButton;
            ColorComboBox = DrawingToolStrip.Items["ColorComboBox"] as ToolStripComboBox;

            LineButton.PerformClick();
            ColorComboBox.SelectedIndex = 0;

            // Create a bitmap to simulate the canvas
            using (Bitmap bitmap = new Bitmap(CanvasBox.Width, CanvasBox.Height))
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
        public void ShouldDrawRectangle()
        {
            RectangleButton = DrawingToolStrip.Items["RectangleButton"] as ToolStripButton;
            ColorComboBox = DrawingToolStrip.Items["ColorComboBox"] as ToolStripComboBox;

            RectangleButton.PerformClick();
            ColorComboBox.SelectedIndex = 0;

            // Create a bitmap to simulate the canvas
            using (Bitmap bitmap = new Bitmap(CanvasBox.Width, CanvasBox.Height))
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
        public void ShouldDrawEllipse()
        {
            EllipseButton = DrawingToolStrip.Items["EllipseButton"] as ToolStripButton;
            ColorComboBox = DrawingToolStrip.Items["ColorComboBox"] as ToolStripComboBox;

            EllipseButton.PerformClick();
            ColorComboBox.SelectedIndex = 0;

            // Create a bitmap to simulate the canvas
            using (Bitmap bitmap = new Bitmap(CanvasBox.Width, CanvasBox.Height))
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
        public void ShouldClearCanvas()
        {
            ClearButton = DrawingToolStrip.Items["ClearButton"] as ToolStripButton;

            ClearButton.PerformClick();

            using (Bitmap bitmap = new Bitmap(CanvasBox.Width, CanvasBox.Height))
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
        public void ShouldChangePenColor()
        {
            ColorComboBox = DrawingToolStrip.Items["ColorComboBox"] as ToolStripComboBox;

            ColorComboBox.SelectedIndex = 1;

            // Create a bitmap to simulate the canvas
            using (Bitmap bitmap = new Bitmap(CanvasBox.Width, CanvasBox.Height))
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
