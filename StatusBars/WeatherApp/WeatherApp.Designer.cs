namespace CodeChum
{
    partial class WeatherApp
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
            StatusStrip = new StatusStrip();
            WeatherStatus = new ToolStripStatusLabel();
            btnGenerate = new Button();
            StatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // StatusStrip
            // 
            StatusStrip.Items.AddRange(new ToolStripItem[] { WeatherStatus });
            StatusStrip.Location = new Point(0, 230);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(465, 22);
            StatusStrip.TabIndex = 0;
            StatusStrip.Text = "statusStrip1";
            // 
            // WeatherStatus
            // 
            WeatherStatus.Name = "WeatherStatus";
            WeatherStatus.Size = new Size(83, 17);
            WeatherStatus.Text = "WeatherStatus";
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerate.Location = new Point(104, 89);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(234, 41);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate Weather Condition";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // WeatherApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 252);
            Controls.Add(btnGenerate);
            Controls.Add(StatusStrip);
            Name = "WeatherApp";
            Text = "WeatherApp";
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip StatusStrip;
        private ToolStripStatusLabel WeatherStatus;
        private Button btnGenerate;
    }
}