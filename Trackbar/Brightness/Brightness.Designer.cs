namespace CodeChum
{
    partial class Brightness
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
            BrightnessTrackBar = new TrackBar();
            lblColor = new Label();
            lblBrightness = new Label();
            ((System.ComponentModel.ISupportInitialize)BrightnessTrackBar).BeginInit();
            SuspendLayout();
            // 
            // BrightnessTrackBar
            // 
            BrightnessTrackBar.Location = new Point(116, 132);
            BrightnessTrackBar.Name = "BrightnessTrackBar";
            BrightnessTrackBar.Size = new Size(291, 45);
            BrightnessTrackBar.TabIndex = 0;
            BrightnessTrackBar.Scroll += BrightnessTrackBar_Scroll;
            // 
            // lblColor
            // 
            lblColor.BackColor = Color.Transparent;
            lblColor.Location = new Point(116, 50);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(291, 47);
            lblColor.TabIndex = 1;
            // 
            // lblBrightness
            // 
            lblBrightness.Location = new Point(116, 180);
            lblBrightness.Name = "lblBrightness";
            lblBrightness.Size = new Size(291, 47);
            lblBrightness.TabIndex = 2;
            // 
            // Brightness
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 308);
            Controls.Add(lblBrightness);
            Controls.Add(lblColor);
            Controls.Add(BrightnessTrackBar);
            Name = "Brightness";
            Text = "Brightness";
            ((System.ComponentModel.ISupportInitialize)BrightnessTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar BrightnessTrackBar;
        private Label lblColor;
        private Label lblBrightness;
    }
}