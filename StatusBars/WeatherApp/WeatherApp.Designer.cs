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
            statusStrip = new StatusStrip();
            weatherStatusLabel = new ToolStripStatusLabel();
            generateButton = new Button();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { weatherStatusLabel });
            statusStrip.Location = new Point(0, 230);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(465, 22);
            statusStrip.TabIndex = 0;
            statusStrip.Text = "statusStrip1";
            // 
            // weatherStatusLabel
            // 
            weatherStatusLabel.Name = "weatherStatusLabel";
            weatherStatusLabel.Size = new Size(83, 17);
            weatherStatusLabel.Text = "WeatherStatus";
            // 
            // generateButton
            // 
            generateButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            generateButton.Location = new Point(104, 89);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(234, 41);
            generateButton.TabIndex = 1;
            generateButton.Text = "Generate Weather Condition";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += btnGenerate_Click;
            // 
            // WeatherApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 252);
            Controls.Add(generateButton);
            Controls.Add(statusStrip);
            Name = "WeatherApp";
            Text = "WeatherApp";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip;
        private ToolStripStatusLabel weatherStatusLabel;
        private Button generateButton;
    }
}