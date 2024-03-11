namespace CodeChum
{
    partial class PortalSequence
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lblMessage = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 81);
            label1.Name = "label1";
            label1.Size = new Size(423, 15);
            label1.TabIndex = 0;
            label1.Text = "Clue 1: \"In the dance of day and night, find the button bathed in the first light.\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 111);
            label2.Name = "label2";
            label2.Size = new Size(471, 15);
            label2.TabIndex = 1;
            label2.Text = "Clue 2: \"Where the ocean meets the shore, press the button that echoes its mighty roar.\"";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 142);
            label3.Name = "label3";
            label3.Size = new Size(527, 15);
            label3.TabIndex = 2;
            label3.Text = "Clue 3: \"When the sky is adorned with twinkling lights, seek the button that matches their heights.\"";
            // 
            // button1
            // 
            button1.Location = new Point(123, 199);
            button1.Name = "button1";
            button1.Size = new Size(102, 37);
            button1.TabIndex = 3;
            button1.Text = "Seas";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(282, 199);
            button2.Name = "button2";
            button2.Size = new Size(102, 37);
            button2.TabIndex = 4;
            button2.Text = "Sun";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(439, 199);
            button3.Name = "button3";
            button3.Size = new Size(102, 37);
            button3.TabIndex = 5;
            button3.Text = "Stars";
            button3.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(314, 287);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(202, 287);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // PortalSequence
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 408);
            Controls.Add(label4);
            Controls.Add(lblMessage);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PortalSequence";
            Text = "PortalSequence";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label lblMessage;
        private Label label4;
    }
}