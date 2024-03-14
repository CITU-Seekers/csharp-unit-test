namespace CodeChum
{
    partial class SimpleProgressBar
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
            this.components = new System.ComponentModel.Container();
            this.timedProgressBar = new System.Windows.Forms.ProgressBar();
            this.startButton = new System.Windows.Forms.Button();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timedProgressBar
            // 
            this.timedProgressBar.Location = new System.Drawing.Point(44, 69);
            this.timedProgressBar.Name = "timedProgressBar";
            this.timedProgressBar.Size = new System.Drawing.Size(275, 25);
            this.timedProgressBar.Step = 1;
            this.timedProgressBar.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(138, 130);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(84, 25);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // progressTimer
            // 
            this.progressTimer.Interval = 1000;
            this.progressTimer.Tick += new System.EventHandler(this.ProgressTimer_Tick);
            // 
            // SimpleProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 197);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.timedProgressBar);
            this.Name = "SimpleProgressBar";
            this.Text = "Simple Progress Bar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar timedProgressBar;
        private Button startButton;
        private System.Windows.Forms.Timer progressTimer;
    }
}