namespace CodeChum
{
    partial class PictureExplorer
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
            pictureBox = new PictureBox();
            openButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(31, 119);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(415, 216);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // openButton
            // 
            openButton.Location = new Point(69, 68);
            openButton.Name = "openButton";
            openButton.Size = new Size(75, 23);
            openButton.TabIndex = 1;
            openButton.Text = "Open";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += btnOpen_Click;
            // 
            // PictureExplorer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 390);
            Controls.Add(openButton);
            Controls.Add(pictureBox);
            Name = "PictureExplorer";
            Text = "PictureExplorer";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Button openButton;
    }
}