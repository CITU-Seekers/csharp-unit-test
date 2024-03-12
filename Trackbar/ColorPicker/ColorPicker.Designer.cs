namespace CodeChum
{
    partial class ColorPicker
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
            redTrackBar = new TrackBar();
            greenTrackBar = new TrackBar();
            blueTrackBar = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            colorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)redTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blueTrackBar).BeginInit();
            SuspendLayout();
            // 
            // redTrackBar
            // 
            redTrackBar.Location = new Point(133, 92);
            redTrackBar.Margin = new Padding(3, 2, 3, 2);
            redTrackBar.Maximum = 255;
            redTrackBar.Name = "redTrackBar";
            redTrackBar.Size = new Size(200, 45);
            redTrackBar.TabIndex = 0;
            redTrackBar.ValueChanged += RedTrackBar_ValueChanged;
            // 
            // greenTrackBar
            // 
            greenTrackBar.Location = new Point(133, 132);
            greenTrackBar.Margin = new Padding(3, 2, 3, 2);
            greenTrackBar.Maximum = 255;
            greenTrackBar.Name = "greenTrackBar";
            greenTrackBar.Size = new Size(200, 45);
            greenTrackBar.TabIndex = 1;
            greenTrackBar.ValueChanged += GreenTrackBar_ValueChanged;
            // 
            // blueTrackBar
            // 
            blueTrackBar.Location = new Point(133, 172);
            blueTrackBar.Margin = new Padding(3, 2, 3, 2);
            blueTrackBar.Maximum = 255;
            blueTrackBar.Name = "blueTrackBar";
            blueTrackBar.Size = new Size(200, 45);
            blueTrackBar.TabIndex = 2;
            blueTrackBar.ValueChanged += BlueTrackBar_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 92);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 3;
            label1.Text = "Red";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 132);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "Green";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 172);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 5;
            label3.Text = "Blue";
            // 
            // colorLabel
            // 
            colorLabel.BackColor = Color.Black;
            colorLabel.Location = new Point(60, 28);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(315, 36);
            colorLabel.TabIndex = 6;
            colorLabel.Click += ColorLabel_Click;
            // 
            // ColorPicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 242);
            Controls.Add(colorLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(blueTrackBar);
            Controls.Add(greenTrackBar);
            Controls.Add(redTrackBar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ColorPicker";
            Text = "Color Picker";
            ((System.ComponentModel.ISupportInitialize)redTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)blueTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar redTrackBar;
        private TrackBar greenTrackBar;
        private TrackBar blueTrackBar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label colorLabel;
    }
}