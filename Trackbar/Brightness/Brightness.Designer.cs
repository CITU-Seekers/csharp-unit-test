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
            brightnessTrackBar = new TrackBar();
            colorLabel = new Label();
            brightnessLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)brightnessTrackBar).BeginInit();
            SuspendLayout();
            // 
            // brightnessTrackBar
            // 
            brightnessTrackBar.Location = new Point(116, 132);
            brightnessTrackBar.Name = "brightnessTrackBar";
            brightnessTrackBar.Size = new Size(291, 45);
            brightnessTrackBar.TabIndex = 0;
            brightnessTrackBar.Scroll += BrightnessTrackBar_Scroll;
            // 
            // lblColor
            // 
            colorLabel.BackColor = Color.Transparent;
            colorLabel.Location = new Point(116, 50);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(291, 47);
            colorLabel.TabIndex = 1;
            // 
            // lblBrightness
            // 
            brightnessLabel.Location = new Point(116, 180);
            brightnessLabel.Name = "brightnessLabel";
            brightnessLabel.Size = new Size(291, 47);
            brightnessLabel.TabIndex = 2;
            // 
            // Brightness
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 308);
            Controls.Add(brightnessLabel);
            Controls.Add(colorLabel);
            Controls.Add(brightnessTrackBar);
            Name = "Brightness";
            Text = "Brightness";
            ((System.ComponentModel.ISupportInitialize)brightnessTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar brightnessTrackBar;
        private Label colorLabel;
        private Label brightnessLabel;
    }
}