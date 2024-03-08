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
            DrawingToolStrip = new ToolStrip();
            LineButton = new ToolStripButton();
            PencilButton = new ToolStripButton();
            RectangleButton = new ToolStripButton();
            EllipseButton = new ToolStripButton();
            ClearButton = new ToolStripButton();
            ColorComboBox = new ToolStripComboBox();
            CanvasBox = new PictureBox();
            DrawingToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CanvasBox).BeginInit();
            SuspendLayout();
            // 
            // DrawingToolStrip
            // 
            DrawingToolStrip.Items.AddRange(new ToolStripItem[] { LineButton, PencilButton, RectangleButton, EllipseButton, ClearButton, ColorComboBox });
            DrawingToolStrip.Location = new Point(0, 0);
            DrawingToolStrip.Name = "DrawingToolStrip";
            DrawingToolStrip.Size = new Size(800, 25);
            DrawingToolStrip.TabIndex = 0;
            DrawingToolStrip.Text = "toolStrip1";
            // 
            // LineButton
            // 
            LineButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            LineButton.Image = (Image)resources.GetObject("LineButton.Image");
            LineButton.ImageTransparentColor = Color.Magenta;
            LineButton.Name = "LineButton";
            LineButton.Size = new Size(33, 22);
            LineButton.Text = "Line";
            // 
            // PencilButton
            // 
            PencilButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            PencilButton.Image = (Image)resources.GetObject("PencilButton.Image");
            PencilButton.ImageTransparentColor = Color.Magenta;
            PencilButton.Name = "PencilButton";
            PencilButton.Size = new Size(43, 22);
            PencilButton.Text = "Pencil";
            // 
            // RectangleButton
            // 
            RectangleButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            RectangleButton.Image = (Image)resources.GetObject("RectangleButton.Image");
            RectangleButton.ImageTransparentColor = Color.Magenta;
            RectangleButton.Name = "RectangleButton";
            RectangleButton.Size = new Size(63, 22);
            RectangleButton.Text = "Rectangle";
            // 
            // EllipseButton
            // 
            EllipseButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            EllipseButton.Image = (Image)resources.GetObject("EllipseButton.Image");
            EllipseButton.ImageTransparentColor = Color.Magenta;
            EllipseButton.Name = "EllipseButton";
            EllipseButton.Size = new Size(44, 22);
            EllipseButton.Text = "Ellipse";
            // 
            // ClearButton
            // 
            ClearButton.Alignment = ToolStripItemAlignment.Right;
            ClearButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ClearButton.Image = (Image)resources.GetObject("ClearButton.Image");
            ClearButton.ImageTransparentColor = Color.Magenta;
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(38, 22);
            ClearButton.Text = "Clear";
            // 
            // ColorComboBox
            // 
            ColorComboBox.Alignment = ToolStripItemAlignment.Right;
            ColorComboBox.Items.AddRange(new object[] { "Red", "Green", "Orange", "Yellow", "Blue", "Black", "White" });
            ColorComboBox.Name = "ColorComboBox";
            ColorComboBox.Size = new Size(75, 25);
            ColorComboBox.Text = "Color";
            ColorComboBox.Click += SelectColor;
            // 
            // CanvasBox
            // 
            CanvasBox.BackColor = Color.White;
            CanvasBox.Location = new Point(33, 47);
            CanvasBox.Name = "CanvasBox";
            CanvasBox.Size = new Size(728, 369);
            CanvasBox.TabIndex = 1;
            CanvasBox.TabStop = false;
            CanvasBox.Paint += CanvasBox_Paint;
            CanvasBox.MouseDown += CanvasBox_MouseDown;
            CanvasBox.MouseMove += CanvasBox_MouseMove;
            CanvasBox.MouseUp += CanvasBox_MouseUp;
            // 
            // DrawingCanvasApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CanvasBox);
            Controls.Add(DrawingToolStrip);
            Name = "DrawingCanvasApp";
            Text = "DrawingCanvasApp";
            DrawingToolStrip.ResumeLayout(false);
            DrawingToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CanvasBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip DrawingToolStrip;
        private ToolStripButton LineButton;
        private ToolStripButton PencilButton;
        private PictureBox CanvasBox;
        private ToolStripButton RectangleButton;
        private ToolStripButton EllipseButton;
        private ToolStripButton ClearButton;
        private ToolStripComboBox ColorComboBox;
    }
}