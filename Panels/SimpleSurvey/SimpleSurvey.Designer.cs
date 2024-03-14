using SimpleSurvey.Properties;

namespace CodeChum
{
    partial class SimpleSurvey
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
            panel1 = new Panel();
            startButton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            toPanel3Button = new Button();
            backToPanel1Button = new Button();
            label2 = new Label();
            panel3 = new Panel();
            toPanel4Button = new Button();
            backToPanel2Button = new Button();
            label4 = new Label();
            trackBar1 = new TrackBar();
            label3 = new Label();
            panel4 = new Panel();
            exitButton = new Button();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(startButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(22, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 273);
            panel1.TabIndex = 0;
            // 
            // startButton
            // 
            startButton.Location = new Point(118, 232);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 2;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += StartButton_Click;
            // 
            // label1
            // 
            label1.Location = new Point(30, 160);
            label1.Name = "label1";
            label1.Size = new Size(263, 58);
            label1.TabIndex = 1;
            label1.Text = "Welcome to our Customer Satisfaction survey! We appreciate your feedback. Let's get started.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.CodeChum2;
            pictureBox1.Location = new Point(40, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(radioButton5);
            panel2.Controls.Add(radioButton4);
            panel2.Controls.Add(radioButton3);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(toPanel3Button);
            panel2.Controls.Add(backToPanel1Button);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(362, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 273);
            panel2.TabIndex = 1;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(36, 185);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(108, 19);
            radioButton5.TabIndex = 7;
            radioButton5.TabStop = true;
            radioButton5.Text = "Very Unsatisfied";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(36, 160);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(83, 19);
            radioButton4.TabIndex = 6;
            radioButton4.TabStop = true;
            radioButton4.Text = "Unsatisfied";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(36, 131);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(64, 19);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "Neutral";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(36, 106);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(69, 19);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Satisfied";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(36, 81);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Very Satisfied";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // toPanel3Button
            // 
            toPanel3Button.Location = new Point(155, 232);
            toPanel3Button.Name = "toPanel3Button";
            toPanel3Button.Size = new Size(75, 23);
            toPanel3Button.TabIndex = 2;
            toPanel3Button.Text = "Next";
            toPanel3Button.UseVisualStyleBackColor = true;
            toPanel3Button.Click += ToPanel3Button_Click;
            // 
            // backToPanel1Button
            // 
            backToPanel1Button.Location = new Point(74, 232);
            backToPanel1Button.Name = "backToPanel1Button";
            backToPanel1Button.Size = new Size(75, 23);
            backToPanel1Button.TabIndex = 2;
            backToPanel1Button.Text = "Back";
            backToPanel1Button.UseVisualStyleBackColor = true;
            backToPanel1Button.Click += BackToPanel1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(24, 33);
            label2.Name = "label2";
            label2.Size = new Size(263, 40);
            label2.TabIndex = 1;
            label2.Text = "How would you rate your overall satisfaction with our product/service?";
            // 
            // panel3
            // 
            panel3.Controls.Add(toPanel4Button);
            panel3.Controls.Add(backToPanel2Button);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(trackBar1);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(702, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(334, 273);
            panel3.TabIndex = 2;
            // 
            // toPanel4Button
            // 
            toPanel4Button.Location = new Point(165, 232);
            toPanel4Button.Name = "toPanel4Button";
            toPanel4Button.Size = new Size(75, 23);
            toPanel4Button.TabIndex = 5;
            toPanel4Button.Text = "Next";
            toPanel4Button.UseVisualStyleBackColor = true;
            toPanel4Button.Click += ToPanel4Button_Click;
            // 
            // backToPanel2Button
            // 
            backToPanel2Button.Location = new Point(84, 232);
            backToPanel2Button.Name = "backToPanel2Button";
            backToPanel2Button.Size = new Size(75, 23);
            backToPanel2Button.TabIndex = 6;
            backToPanel2Button.Text = "Back";
            backToPanel2Button.UseVisualStyleBackColor = true;
            backToPanel2Button.Click += BackToPanel2Button_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(24, 106);
            label4.Name = "label4";
            label4.Size = new Size(291, 16);
            label4.TabIndex = 4;
            label4.Text = "1 - Not Likely at All,  5 - Neutral, 10 - Extremely Likely";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(24, 146);
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(280, 45);
            trackBar1.TabIndex = 3;
            trackBar1.Value = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 33);
            label3.Name = "label3";
            label3.Size = new Size(291, 65);
            label3.TabIndex = 1;
            label3.Text = "On a scale from 1 to 10, how likely are you to recommend our product/service to a friend or colleague?";
            // 
            // panel4
            // 
            panel4.Controls.Add(exitButton);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(1042, 25);
            panel4.Name = "panel4";
            panel4.Size = new Size(334, 273);
            panel4.TabIndex = 3;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(131, 232);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += ExitButton_Click;
            // 
            // label5
            // 
            label5.Location = new Point(17, 160);
            label5.Name = "label5";
            label5.Size = new Size(301, 58);
            label5.TabIndex = 1;
            label5.Text = "Thank you for taking the time to complete our survey. Your feedback is valuable to us. Have a great day!";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resources.CodeChum2;
            pictureBox2.Location = new Point(40, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(243, 130);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // SimpleSurvey
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 312);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SimpleSurvey";
            Text = "SimpleSurvey";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button startButton;
        private Label label1;
        private Panel panel2;
        private Button backToPanel1Button;
        private Label label2;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel panel3;
        private Label label3;
        private TrackBar trackBar1;
        private Label label4;
        private Panel panel4;
        private Button exitButton;
        private Label label5;
        private PictureBox pictureBox2;
        private Button toPanel3Button;
        private Button toPanel4Button;
        private Button backToPanel2Button;
    }
}