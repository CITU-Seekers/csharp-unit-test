namespace CodeChum
{
    partial class VirtualPet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VirtualPet));
            petPictureBox = new PictureBox();
            feedButton = new Button();
            playButton = new Button();
            petButton = new Button();
            checkMoodButton = new Button();
            ((System.ComponentModel.ISupportInitialize)petPictureBox).BeginInit();
            SuspendLayout();
            // 
            // petPictureBox
            // 
            petPictureBox.Image = (Image)resources.GetObject("petPictureBox.Image");
            petPictureBox.Location = new Point(57, 25);
            petPictureBox.Name = "petPictureBox";
            petPictureBox.Size = new Size(274, 273);
            petPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            petPictureBox.TabIndex = 0;
            petPictureBox.TabStop = false;
            // 
            // feedButton
            // 
            feedButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            feedButton.Location = new Point(79, 328);
            feedButton.Name = "feedButton";
            feedButton.Size = new Size(84, 43);
            feedButton.TabIndex = 1;
            feedButton.Text = "Feed";
            feedButton.UseVisualStyleBackColor = true;
            feedButton.Click += btnFeed_Click;
            // 
            // playButton
            // 
            playButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            playButton.Location = new Point(220, 328);
            playButton.Name = "playButton";
            playButton.Size = new Size(84, 43);
            playButton.TabIndex = 2;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += btnPlay_Click;
            // 
            // petButton
            // 
            petButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            petButton.Location = new Point(79, 390);
            petButton.Name = "petButton";
            petButton.Size = new Size(84, 48);
            petButton.TabIndex = 3;
            petButton.Text = "Pet";
            petButton.UseVisualStyleBackColor = true;
            petButton.Click += btnPet_Click;
            // 
            // checkMoodButton
            // 
            checkMoodButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkMoodButton.Location = new Point(220, 390);
            checkMoodButton.Name = "checkMoodButton";
            checkMoodButton.Size = new Size(84, 48);
            checkMoodButton.TabIndex = 4;
            checkMoodButton.Text = "Check Mood";
            checkMoodButton.UseVisualStyleBackColor = true;
            checkMoodButton.Click += btnCheckMood_Click;
            // 
            // VirtualPet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 561);
            Controls.Add(checkMoodButton);
            Controls.Add(petButton);
            Controls.Add(playButton);
            Controls.Add(feedButton);
            Controls.Add(petPictureBox);
            Name = "VirtualPet";
            Text = "VirtualPet";
            ((System.ComponentModel.ISupportInitialize)petPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox petPictureBox;
        private Button feedButton;
        private Button playButton;
        private Button petButton;
        private Button checkMoodButton;
    }
}