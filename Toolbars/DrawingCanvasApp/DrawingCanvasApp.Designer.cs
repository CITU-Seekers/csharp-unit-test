namespace CodeChum
{
    partial class DrawingCanvasApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawingCanvasApp));
            drawingToolStrip = new ToolStrip();
            lineToolStripButton = new ToolStripButton();
            pencilToolStripButton = new ToolStripButton();
            rectangleToolStripButton = new ToolStripButton();
            ellipseToolStripButton = new ToolStripButton();
            clearToolStripButton = new ToolStripButton();
            colorToolStripComboBox = new ToolStripComboBox();
            pictureBox = new PictureBox();
            drawingToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // drawingToolStrip
            // 
            drawingToolStrip.Items.AddRange(new ToolStripItem[] { lineToolStripButton, pencilToolStripButton, rectangleToolStripButton, ellipseToolStripButton, clearToolStripButton, colorToolStripComboBox });
            drawingToolStrip.Location = new Point(0, 0);
            drawingToolStrip.Name = "drawingToolStrip";
            drawingToolStrip.Size = new Size(800, 25);
            drawingToolStrip.TabIndex = 0;
            drawingToolStrip.Text = "toolStrip1";
            // 
            // lineToolStripButton
            // 
            lineToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            lineToolStripButton.Image = (Image)resources.GetObject("lineToolStripButton.Image");
            lineToolStripButton.ImageTransparentColor = Color.Magenta;
            lineToolStripButton.Name = "lineToolStripButton";
            lineToolStripButton.Size = new Size(33, 22);
            lineToolStripButton.Text = "Line";
            // 
            // pencilToolStripButton
            // 
            pencilToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            pencilToolStripButton.Image = (Image)resources.GetObject("pencilToolStripButton.Image");
            pencilToolStripButton.ImageTransparentColor = Color.Magenta;
            pencilToolStripButton.Name = "pencilToolStripButton";
            pencilToolStripButton.Size = new Size(43, 22);
            pencilToolStripButton.Text = "Pencil";
            // 
            // rectangleToolStripButton
            // 
            rectangleToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            rectangleToolStripButton.Image = (Image)resources.GetObject("rectangleToolStripButton.Image");
            rectangleToolStripButton.ImageTransparentColor = Color.Magenta;
            rectangleToolStripButton.Name = "rectangleToolStripButton";
            rectangleToolStripButton.Size = new Size(63, 22);
            rectangleToolStripButton.Text = "Rectangle";
            // 
            // ellipseToolStripButton
            // 
            ellipseToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ellipseToolStripButton.Image = (Image)resources.GetObject("ellipseToolStripButton.Image");
            ellipseToolStripButton.ImageTransparentColor = Color.Magenta;
            ellipseToolStripButton.Name = "ellipseToolStripButton";
            ellipseToolStripButton.Size = new Size(44, 22);
            ellipseToolStripButton.Text = "Ellipse";
            // 
            // ClearButton
            // 
            clearToolStripButton.Alignment = ToolStripItemAlignment.Right;
            clearToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            clearToolStripButton.Image = (Image)resources.GetObject("ClearButton.Image");
            clearToolStripButton.ImageTransparentColor = Color.Magenta;
            clearToolStripButton.Name = "clearToolStripButton";
            clearToolStripButton.Size = new Size(38, 22);
            clearToolStripButton.Text = "Clear";
            // 
            // ColorComboBox
            // 
            colorToolStripComboBox.Alignment = ToolStripItemAlignment.Right;
            colorToolStripComboBox.Items.AddRange(new object[] { "Red", "Green", "Orange", "Yellow", "Blue", "Black", "White" });
            colorToolStripComboBox.Name = "colorToolStripComboBox";
            colorToolStripComboBox.Size = new Size(75, 25);
            colorToolStripComboBox.Text = "Color";
            colorToolStripComboBox.Click += SelectColor;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.Location = new Point(33, 47);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(728, 369);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            pictureBox.Paint += CanvasBox_Paint;
            pictureBox.MouseDown += CanvasBox_MouseDown;
            pictureBox.MouseMove += CanvasBox_MouseMove;
            pictureBox.MouseUp += CanvasBox_MouseUp;
            // 
            // DrawingCanvasApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox);
            Controls.Add(drawingToolStrip);
            Name = "DrawingCanvasApp";
            Text = "DrawingCanvasApp";
            drawingToolStrip.ResumeLayout(false);
            drawingToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip drawingToolStrip;
        private ToolStripButton lineToolStripButton;
        private ToolStripButton pencilToolStripButton;
        private PictureBox pictureBox;
        private ToolStripButton rectangleToolStripButton;
        private ToolStripButton ellipseToolStripButton;
        private ToolStripButton clearToolStripButton;
        private ToolStripComboBox colorToolStripComboBox;
    }
}