namespace CodeChum
{
    partial class RoboGreeter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoboGreeter));
            pictureBox1 = new PictureBox();
            btnFarewell = new Button();
            btnGreet = new Button();
            GreeterName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(102, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnFarewell
            // 
            btnFarewell.Location = new Point(253, 267);
            btnFarewell.Name = "btnFarewell";
            btnFarewell.Size = new Size(75, 23);
            btnFarewell.TabIndex = 6;
            btnFarewell.Text = "Farewell";
            btnFarewell.UseVisualStyleBackColor = true;
            btnFarewell.Click += btnFarewell_Click;
            // 
            // btnGreet
            // 
            btnGreet.Location = new Point(73, 267);
            btnGreet.Name = "btnGreet";
            btnGreet.Size = new Size(75, 23);
            btnGreet.TabIndex = 5;
            btnGreet.Text = "Greet";
            btnGreet.UseVisualStyleBackColor = true;
            btnGreet.Click += btnGreet_Click;
            // 
            // GreeterName
            // 
            GreeterName.Location = new Point(56, 217);
            GreeterName.Name = "GreeterName";
            GreeterName.PlaceholderText = "Name";
            GreeterName.Size = new Size(292, 23);
            GreeterName.TabIndex = 4;
            // 
            // RoboGreeter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 349);
            Controls.Add(pictureBox1);
            Controls.Add(btnFarewell);
            Controls.Add(btnGreet);
            Controls.Add(GreeterName);
            Name = "RoboGreeter";
            Text = "RoboGreeter";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnFarewell;
        private Button btnGreet;
        private TextBox GreeterName;
    }
}