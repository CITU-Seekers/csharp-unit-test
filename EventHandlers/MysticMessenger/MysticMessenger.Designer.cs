namespace CodeChum
{
    partial class MysticMessenger
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
            messageTextBox = new TextBox();
            label1 = new Label();
            windButton = new Button();
            moonglowButton = new Button();
            twilightButton = new Button();
            translatedMessageLabel = new Label();
            messageLabel = new Label();
            SuspendLayout();
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(158, 109);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(448, 45);
            messageTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(158, 82);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 1;
            label1.Text = "Enter Message:";
            // 
            // windButton
            // 
            windButton.BackColor = Color.Chartreuse;
            windButton.Location = new Point(158, 196);
            windButton.Name = "windButton";
            windButton.Size = new Size(104, 40);
            windButton.TabIndex = 2;
            windButton.Text = "Whisper to the Wind";
            windButton.UseVisualStyleBackColor = false;
            windButton.Click += button1_Click;
            // 
            // moonglowButton
            // 
            moonglowButton.BackColor = Color.LightSkyBlue;
            moonglowButton.ForeColor = SystemColors.ActiveCaptionText;
            moonglowButton.Location = new Point(332, 196);
            moonglowButton.Name = "moonglowButton";
            moonglowButton.Size = new Size(91, 40);
            moonglowButton.TabIndex = 3;
            moonglowButton.Text = "Invoke the Moonglow";
            moonglowButton.UseVisualStyleBackColor = false;
            moonglowButton.Click += button2_Click;
            // 
            // twilightButton
            // 
            twilightButton.BackColor = Color.MediumPurple;
            twilightButton.ForeColor = SystemColors.ButtonFace;
            twilightButton.Location = new Point(497, 196);
            twilightButton.Name = "twilightButton";
            twilightButton.Size = new Size(97, 40);
            twilightButton.TabIndex = 4;
            twilightButton.Text = "Embrace the Twilight";
            twilightButton.UseVisualStyleBackColor = false;
            twilightButton.Click += button3_Click;
            // 
            // translatedMessageLabel
            // 
            translatedMessageLabel.AutoSize = true;
            translatedMessageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            translatedMessageLabel.Location = new Point(158, 298);
            translatedMessageLabel.Name = "translatedMessageLabel";
            translatedMessageLabel.Size = new Size(149, 21);
            translatedMessageLabel.TabIndex = 5;
            translatedMessageLabel.Text = "Translated Message:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            messageLabel.Location = new Point(158, 340);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(226, 21);
            messageLabel.TabIndex = 6;
            messageLabel.Text = "Input Message to be translated.";
            // 
            // MysticMessenger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 485);
            Controls.Add(messageLabel);
            Controls.Add(translatedMessageLabel);
            Controls.Add(twilightButton);
            Controls.Add(moonglowButton);
            Controls.Add(windButton);
            Controls.Add(label1);
            Controls.Add(messageTextBox);
            Name = "MysticMessenger";
            Text = "MysticMessenger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox messageTextBox;
        private Label label1;
        private Button windButton;
        private Button moonglowButton;
        private Button twilightButton;
        private Label translatedMessageLabel;
        private Label messageLabel;
    }
}