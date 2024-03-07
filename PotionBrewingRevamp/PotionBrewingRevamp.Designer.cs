namespace CodeChum
{
    partial class PotionBrewingRevamp
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
            potencyTrackBar = new TrackBar();
            durationTrackBar = new TrackBar();
            intensityTrackBar = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            PotencyLevel = new Label();
            Duration = new Label();
            IntensityLevel = new Label();
            ((System.ComponentModel.ISupportInitialize)potencyTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)durationTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)intensityTrackBar).BeginInit();
            SuspendLayout();
            // 
            // potencyTrackBar
            // 
            potencyTrackBar.Location = new Point(144, 85);
            potencyTrackBar.Name = "potencyTrackBar";
            potencyTrackBar.Size = new Size(372, 45);
            potencyTrackBar.TabIndex = 0;
            // 
            // durationTrackBar
            // 
            durationTrackBar.Location = new Point(144, 185);
            durationTrackBar.Name = "durationTrackBar";
            durationTrackBar.Size = new Size(372, 45);
            durationTrackBar.TabIndex = 1;
            // 
            // intensityTrackBar
            // 
            intensityTrackBar.Location = new Point(144, 283);
            intensityTrackBar.Name = "intensityTrackBar";
            intensityTrackBar.Size = new Size(372, 45);
            intensityTrackBar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(144, 46);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 3;
            label1.Text = "Potency";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(144, 152);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "Duration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(147, 251);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 5;
            label3.Text = "Intensity";
            // 
            // PotencyLevel
            // 
            PotencyLevel.AutoSize = true;
            PotencyLevel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            PotencyLevel.Location = new Point(144, 366);
            PotencyLevel.Name = "PotencyLevel";
            PotencyLevel.Size = new Size(60, 20);
            PotencyLevel.TabIndex = 6;
            PotencyLevel.Text = "Potency";
            // 
            // Duration
            // 
            Duration.AutoSize = true;
            Duration.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Duration.Location = new Point(144, 396);
            Duration.Name = "Duration";
            Duration.Size = new Size(67, 20);
            Duration.TabIndex = 7;
            Duration.Text = "Duration";
            // 
            // IntensityLevel
            // 
            IntensityLevel.AutoSize = true;
            IntensityLevel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            IntensityLevel.Location = new Point(147, 427);
            IntensityLevel.Name = "IntensityLevel";
            IntensityLevel.Size = new Size(64, 20);
            IntensityLevel.TabIndex = 8;
            IntensityLevel.Text = "Intensity";
            // 
            // PotionBrewing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 527);
            Controls.Add(IntensityLevel);
            Controls.Add(Duration);
            Controls.Add(PotencyLevel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(intensityTrackBar);
            Controls.Add(durationTrackBar);
            Controls.Add(potencyTrackBar);
            Name = "PotionBrewing";
            Text = "PotionBrewing";
            ((System.ComponentModel.ISupportInitialize)potencyTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)durationTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)intensityTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar potencyTrackBar;
        private TrackBar durationTrackBar;
        private TrackBar intensityTrackBar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label PotencyLevel;
        private Label Duration;
        private Label IntensityLevel;
    }
}