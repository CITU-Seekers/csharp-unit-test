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
            pictureBox1 = new PictureBox();
            btnFeed = new Button();
            btnPlay = new Button();
            btnPet = new Button();
            btnCheckMood = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(57, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 273);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnFeed
            // 
            btnFeed.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFeed.Location = new Point(79, 328);
            btnFeed.Name = "btnFeed";
            btnFeed.Size = new Size(84, 43);
            btnFeed.TabIndex = 1;
            btnFeed.Text = "Feed";
            btnFeed.UseVisualStyleBackColor = true;
            btnFeed.Click += btnFeed_Click;
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlay.Location = new Point(220, 328);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(84, 43);
            btnPlay.TabIndex = 2;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnPet
            // 
            btnPet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPet.Location = new Point(79, 390);
            btnPet.Name = "btnPet";
            btnPet.Size = new Size(84, 48);
            btnPet.TabIndex = 3;
            btnPet.Text = "Pet";
            btnPet.UseVisualStyleBackColor = true;
            btnPet.Click += btnPet_Click;
            // 
            // btnCheckMood
            // 
            btnCheckMood.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCheckMood.Location = new Point(220, 390);
            btnCheckMood.Name = "btnCheckMood";
            btnCheckMood.Size = new Size(84, 48);
            btnCheckMood.TabIndex = 4;
            btnCheckMood.Text = "Check Mood";
            btnCheckMood.UseVisualStyleBackColor = true;
            btnCheckMood.Click += btnCheckMood_Click;
            // 
            // VirtualPet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 561);
            Controls.Add(btnCheckMood);
            Controls.Add(btnPet);
            Controls.Add(btnPlay);
            Controls.Add(btnFeed);
            Controls.Add(pictureBox1);
            Name = "VirtualPet";
            Text = "VirtualPet";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnFeed;
        private Button btnPlay;
        private Button btnPet;
        private Button btnCheckMood;
    }
}