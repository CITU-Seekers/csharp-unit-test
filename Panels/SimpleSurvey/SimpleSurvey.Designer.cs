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
            Panel1 = new Panel();
            StartButton = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Panel2 = new Panel();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            ToPanel3Button = new Button();
            BackToPanel1Button = new Button();
            label2 = new Label();
            Panel3 = new Panel();
            ToPanel4Button = new Button();
            BackToPanel2Button = new Button();
            label4 = new Label();
            trackBar1 = new TrackBar();
            label3 = new Label();
            Panel4 = new Panel();
            ExitButton = new Button();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Panel2.SuspendLayout();
            Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Controls.Add(StartButton);
            Panel1.Controls.Add(label1);
            Panel1.Controls.Add(pictureBox1);
            Panel1.Location = new Point(22, 25);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(334, 273);
            Panel1.TabIndex = 0;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(118, 232);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(75, 23);
            StartButton.TabIndex = 2;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
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
            // Panel2
            // 
            Panel2.Controls.Add(radioButton5);
            Panel2.Controls.Add(radioButton4);
            Panel2.Controls.Add(radioButton3);
            Panel2.Controls.Add(radioButton2);
            Panel2.Controls.Add(radioButton1);
            Panel2.Controls.Add(ToPanel3Button);
            Panel2.Controls.Add(BackToPanel1Button);
            Panel2.Controls.Add(label2);
            Panel2.Location = new Point(362, 25);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(334, 273);
            Panel2.TabIndex = 1;
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
            // ToPanel3Button
            // 
            ToPanel3Button.Location = new Point(155, 232);
            ToPanel3Button.Name = "ToPanel3Button";
            ToPanel3Button.Size = new Size(75, 23);
            ToPanel3Button.TabIndex = 2;
            ToPanel3Button.Text = "Next";
            ToPanel3Button.UseVisualStyleBackColor = true;
            ToPanel3Button.Click += ToPanel3Button_Click;
            // 
            // BackToPanel1Button
            // 
            BackToPanel1Button.Location = new Point(74, 232);
            BackToPanel1Button.Name = "BackToPanel1Button";
            BackToPanel1Button.Size = new Size(75, 23);
            BackToPanel1Button.TabIndex = 2;
            BackToPanel1Button.Text = "Back";
            BackToPanel1Button.UseVisualStyleBackColor = true;
            BackToPanel1Button.Click += BackToPanel1_Click;
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
            // Panel3
            // 
            Panel3.Controls.Add(ToPanel4Button);
            Panel3.Controls.Add(BackToPanel2Button);
            Panel3.Controls.Add(label4);
            Panel3.Controls.Add(trackBar1);
            Panel3.Controls.Add(label3);
            Panel3.Location = new Point(702, 25);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(334, 273);
            Panel3.TabIndex = 2;
            // 
            // ToPanel4Button
            // 
            ToPanel4Button.Location = new Point(165, 232);
            ToPanel4Button.Name = "ToPanel4Button";
            ToPanel4Button.Size = new Size(75, 23);
            ToPanel4Button.TabIndex = 5;
            ToPanel4Button.Text = "Next";
            ToPanel4Button.UseVisualStyleBackColor = true;
            ToPanel4Button.Click += ToPanel4Button_Click;
            // 
            // BackToPanel2Button
            // 
            BackToPanel2Button.Location = new Point(84, 232);
            BackToPanel2Button.Name = "BackToPanel2Button";
            BackToPanel2Button.Size = new Size(75, 23);
            BackToPanel2Button.TabIndex = 6;
            BackToPanel2Button.Text = "Back";
            BackToPanel2Button.UseVisualStyleBackColor = true;
            BackToPanel2Button.Click += BackToPanel2Button_Click;
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
            // Panel4
            // 
            Panel4.Controls.Add(ExitButton);
            Panel4.Controls.Add(label5);
            Panel4.Controls.Add(pictureBox2);
            Panel4.Location = new Point(1042, 25);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(334, 273);
            Panel4.TabIndex = 3;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(131, 232);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
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
            ClientSize = new Size(363, 308);
            Controls.Add(Panel4);
            Controls.Add(Panel3);
            Controls.Add(Panel2);
            Controls.Add(Panel1);
            Name = "SimpleSurvey";
            Text = "SimpleSurvey";
            Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel1;
        private PictureBox pictureBox1;
        private Button StartButton;
        private Label label1;
        private Panel Panel2;
        private Button BackToPanel1Button;
        private Label label2;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel Panel3;
        private Label label3;
        private TrackBar trackBar1;
        private Label label4;
        private Panel Panel4;
        private Button ExitButton;
        private Label label5;
        private PictureBox pictureBox2;
        private Button ToPanel3Button;
        private Button ToPanel4Button;
        private Button BackToPanel2Button;
    }
}