namespace CodeChum
{
    partial class FontSizeResizer
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
            resizeTrackBar = new TrackBar();
            fontSizeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)resizeTrackBar).BeginInit();
            SuspendLayout();
            // 
            // resizeTrackBar
            // 
            resizeTrackBar.Location = new Point(69, 39);
            resizeTrackBar.Margin = new Padding(2, 2, 2, 2);
            resizeTrackBar.Maximum = 20;
            resizeTrackBar.Minimum = 1;
            resizeTrackBar.Name = "resizeTrackBar";
            resizeTrackBar.Size = new Size(256, 45);
            resizeTrackBar.TabIndex = 0;
            resizeTrackBar.Value = 1;
            resizeTrackBar.Scroll += ResizeTrackBar_Scroll;
            resizeTrackBar.ValueChanged += ResizeTrackBar_ValueChanged;
            // 
            // fontSizeLabel
            // 
            fontSizeLabel.AutoSize = true;
            fontSizeLabel.Font = new Font("Segoe UI", 1F, FontStyle.Bold, GraphicsUnit.Point);
            fontSizeLabel.Location = new Point(174, 92);
            fontSizeLabel.Margin = new Padding(2, 0, 2, 0);
            fontSizeLabel.Name = "fontSizeLabel";
            fontSizeLabel.Size = new Size(6, 3);
            fontSizeLabel.TabIndex = 1;
            fontSizeLabel.Text = "Test";
            fontSizeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FontSizeResizer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 164);
            Controls.Add(fontSizeLabel);
            Controls.Add(resizeTrackBar);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FontSizeResizer";
            Text = "FontSizeSlider";
            ((System.ComponentModel.ISupportInitialize)resizeTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar resizeTrackBar;
        private Label fontSizeLabel;
    }
}