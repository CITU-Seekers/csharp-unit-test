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
            robotPictureBox = new PictureBox();
            farewellButton = new Button();
            greetButton = new Button();
            greeterNameTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)robotPictureBox).BeginInit();
            SuspendLayout();
            // 
            // robotPictureBox
            // 
            robotPictureBox.Image = (Image)resources.GetObject("robotPictureBox.Image");
            robotPictureBox.Location = new Point(102, 46);
            robotPictureBox.Name = "robotPictureBox";
            robotPictureBox.Size = new Size(200, 146);
            robotPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            robotPictureBox.TabIndex = 7;
            robotPictureBox.TabStop = false;
            // 
            // farewellButton
            // 
            farewellButton.Location = new Point(253, 267);
            farewellButton.Name = "farewellButton";
            farewellButton.Size = new Size(75, 23);
            farewellButton.TabIndex = 6;
            farewellButton.Text = "Farewell";
            farewellButton.UseVisualStyleBackColor = true;
            farewellButton.Click += btnFarewell_Click;
            // 
            // greetButton
            // 
            greetButton.Location = new Point(73, 267);
            greetButton.Name = "greetButton";
            greetButton.Size = new Size(75, 23);
            greetButton.TabIndex = 5;
            greetButton.Text = "Greet";
            greetButton.UseVisualStyleBackColor = true;
            greetButton.Click += btnGreet_Click;
            // 
            // greeterNameTextBox
            // 
            greeterNameTextBox.Location = new Point(56, 217);
            greeterNameTextBox.Name = "greeterNameTextBox";
            greeterNameTextBox.PlaceholderText = "Name";
            greeterNameTextBox.Size = new Size(292, 23);
            greeterNameTextBox.TabIndex = 4;
            // 
            // RoboGreeter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 349);
            Controls.Add(robotPictureBox);
            Controls.Add(farewellButton);
            Controls.Add(greetButton);
            Controls.Add(greeterNameTextBox);
            Name = "RoboGreeter";
            Text = "RoboGreeter";
            ((System.ComponentModel.ISupportInitialize)robotPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox robotPictureBox;
        private Button farewellButton;
        private Button greetButton;
        private TextBox greeterNameTextBox;
    }
}