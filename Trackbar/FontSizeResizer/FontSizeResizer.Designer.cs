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
            this.ResizeTrackBar = new System.Windows.Forms.TrackBar();
            this.Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ResizeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ResizeTrackBar
            // 
            this.ResizeTrackBar.Location = new System.Drawing.Point(89, 60);
            this.ResizeTrackBar.Maximum = 20;
            this.ResizeTrackBar.Minimum = 1;
            this.ResizeTrackBar.Name = "ResizeTrackBar";
            this.ResizeTrackBar.Size = new System.Drawing.Size(329, 56);
            this.ResizeTrackBar.TabIndex = 0;
            this.ResizeTrackBar.Value = 1;
            this.ResizeTrackBar.ValueChanged += new System.EventHandler(this.ResizeTrackBar_ValueChanged);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label.Location = new System.Drawing.Point(224, 141);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(6, 3);
            this.Label.TabIndex = 1;
            this.Label.Text = "Test";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FontSizeSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 252);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.ResizeTrackBar);
            this.Name = "FontSizeSlider";
            this.Text = "FontSizeSlider";
            ((System.ComponentModel.ISupportInitialize)(this.ResizeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar ResizeTrackBar;
        private Label Label;
    }
}