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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 109);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(448, 45);
            textBox1.TabIndex = 0;
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
            // button1
            // 
            button1.BackColor = Color.Chartreuse;
            button1.Location = new Point(158, 196);
            button1.Name = "button1";
            button1.Size = new Size(104, 40);
            button1.TabIndex = 2;
            button1.Text = "Whisper to the Wind";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(332, 196);
            button2.Name = "button2";
            button2.Size = new Size(91, 40);
            button2.TabIndex = 3;
            button2.Text = "Invoke the Moonglow";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumPurple;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(497, 196);
            button3.Name = "button3";
            button3.Size = new Size(97, 40);
            button3.TabIndex = 4;
            button3.Text = "Embrace the Twilight";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(158, 298);
            label2.Name = "label2";
            label2.Size = new Size(149, 21);
            label2.TabIndex = 5;
            label2.Text = "Translated Message:";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.Location = new Point(158, 340);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(226, 21);
            lblMessage.TabIndex = 6;
            lblMessage.Text = "Input Message to be translated.";
            // 
            // MysticMessenger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 485);
            Controls.Add(lblMessage);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "MysticMessenger";
            Text = "MysticMessenger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label lblMessage;
    }
}