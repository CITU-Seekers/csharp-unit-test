using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChum
{
    public partial class DrawingCanvasApp : Form
    {
        private enum DrawingTool { Pencil, Line, Rectangle, Ellipse }
        private DrawingTool currentTool = DrawingTool.Pencil;
        private Point startPoint;
        private Pen currentPen = new Pen(Color.Black, 2);
        private GraphicsPath currentPath = new GraphicsPath();
        private List<GraphicsPath> paths = new List<GraphicsPath>();
        public DrawingCanvasApp()
        {
            InitializeComponent();
            InitializeToolbar();
            ColorComboBox.SelectedIndex = 0;
            CanvasBox.Paint += CanvasBox_Paint;
        }

        private void InitializeToolbar()
        {
            // Attach event handlers
            PencilButton.Click += (sender, e) => { currentTool = DrawingTool.Pencil; };
            LineButton.Click += (sender, e) => { currentTool = DrawingTool.Line; };
            RectangleButton.Click += (sender, e) => { currentTool = DrawingTool.Rectangle; };
            EllipseButton.Click += (sender, e) => { currentTool = DrawingTool.Ellipse; };
            ColorComboBox.SelectedIndexChanged += SelectColor;
            ClearButton.Click += ClearCanvas;
        }

        private void SelectColor(object sender, EventArgs e)
        {
            currentPen.Dispose(); // Dispose the old pen before creating a new one

            if (ColorComboBox.SelectedItem.ToString() == "Red")
            {
                currentPen = new Pen(Color.Red, 2);
            }
            else if (ColorComboBox.SelectedItem.ToString() == "Blue")
            {
                currentPen = new Pen(Color.Blue, 2);
            }
            else if (ColorComboBox.SelectedItem.ToString() == "Orange")
            {
                currentPen = new Pen(Color.Orange, 2);
            }
            else if (ColorComboBox.SelectedItem.ToString() == "Green")
            {
                currentPen = new Pen(Color.Green, 2);
            }
            else if (ColorComboBox.SelectedItem.ToString() == "Yellow")
            {
                currentPen = new Pen(Color.Yellow, 2);
            }
            else if (ColorComboBox.SelectedItem.ToString() == "Black")
            {
                currentPen = new Pen(Color.Black, 2);
            }
            else if (ColorComboBox.SelectedItem.ToString() == "White")
            {
                currentPen = new Pen(Color.White, 2);
            }
        }

        private void ClearCanvas(object sender, EventArgs e)
        {
            // Dispose all stored paths
            foreach (var path in paths)
            {
                path.Dispose();
            }
            paths.Clear();

            // Clear the canvas
            using (Graphics g = CanvasBox.CreateGraphics())
            {
                g.Clear(Color.White);
            }
        }

        private void CanvasBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (currentTool)
                {
                    case DrawingTool.Pencil:
                        currentPath.AddLine(startPoint, e.Location);
                        startPoint = e.Location;
                        break;
                    case DrawingTool.Line:
                        currentPath.Reset();
                        currentPath.StartFigure();
                        currentPath.AddLine(startPoint, e.Location);
                        break;
                    case DrawingTool.Rectangle:
                        currentPath.Reset();
                        currentPath.StartFigure();
                        currentPath.AddRectangle(new Rectangle(startPoint.X, startPoint.Y, e.X - startPoint.X, e.Y - startPoint.Y));
                        break;
                    case DrawingTool.Ellipse:
                        currentPath.Reset();
                        currentPath.StartFigure();
                        currentPath.AddEllipse(startPoint.X, startPoint.Y, e.X - startPoint.X, e.Y - startPoint.Y);
                        break;
                }

                // Redraw the canvas
                CanvasBox.Invalidate();
            }
        }

        private void CanvasBox_Paint(object sender, PaintEventArgs e)
        {
            // Draw all stored paths on the canvas
            foreach (var path in paths)
            {
                e.Graphics.DrawPath(currentPen, path);
            }

            // Draw the current path
            e.Graphics.DrawPath(currentPen, currentPath);
        }

        private void CanvasBox_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            currentPath = new GraphicsPath();
            currentPath.StartFigure();
        }

        private void CanvasBox_MouseUp(object sender, MouseEventArgs e)
        {
            currentPath.CloseFigure();
            paths.Add(new GraphicsPath(currentPath.PathPoints, currentPath.PathTypes));
            currentPath.Dispose();
        }
    }
}
