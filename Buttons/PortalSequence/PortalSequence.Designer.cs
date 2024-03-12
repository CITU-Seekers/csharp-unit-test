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
            clue1Label = new Label();
            clue2Label = new Label();
            clue3Label = new Label();
            seaButton = new Button();
            sunButton = new Button();
            starButton = new Button();
            lblMessage = new Label();
            messageLabel = new Label();
            SuspendLayout();
            // 
            // clue1Label
            // 
            clue1Label.AutoSize = true;
            clue1Label.Location = new Point(107, 81);
            clue1Label.Name = "clue1Label";
            clue1Label.Size = new Size(423, 15);
            clue1Label.TabIndex = 0;
            clue1Label.Text = "Clue 1: \"In the dance of day and night, find the button bathed in the first light.\"";
            // 
            // clue2Label
            // 
            clue2Label.AutoSize = true;
            clue2Label.Location = new Point(107, 111);
            clue2Label.Name = "clue2Label";
            clue2Label.Size = new Size(471, 15);
            clue2Label.TabIndex = 1;
            clue2Label.Text = "Clue 2: \"Where the ocean meets the shore, press the button that echoes its mighty roar.\"";
            // 
            // clue3Label
            // 
            clue3Label.AutoSize = true;
            clue3Label.Location = new Point(107, 142);
            clue3Label.Name = "clue3Label";
            clue3Label.Size = new Size(527, 15);
            clue3Label.TabIndex = 2;
            clue3Label.Text = "Clue 3: \"When the sky is adorned with twinkling lights, seek the button that matches their heights.\"";
            // 
            // seaButton
            // 
            seaButton.Location = new Point(123, 199);
            seaButton.Name = "seaButton";
            seaButton.Size = new Size(102, 37);
            seaButton.TabIndex = 3;
            seaButton.Text = "Seas";
            seaButton.UseVisualStyleBackColor = true;
            // 
            // sunButton
            // 
            sunButton.Location = new Point(282, 199);
            sunButton.Name = "sunButton";
            sunButton.Size = new Size(102, 37);
            sunButton.TabIndex = 4;
            sunButton.Text = "Sun";
            sunButton.UseVisualStyleBackColor = true;
            // 
            // starButton
            // 
            starButton.Location = new Point(439, 199);
            starButton.Name = "starButton";
            starButton.Size = new Size(102, 37);
            starButton.TabIndex = 5;
            starButton.Text = "Stars";
            starButton.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(314, 287);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 6;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new Point(202, 287);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(38, 15);
            messageLabel.TabIndex = 7;
            messageLabel.Text = "label4";
            // 
            // PortalSequence
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 408);
            Controls.Add(messageLabel);
            Controls.Add(lblMessage);
            Controls.Add(starButton);
            Controls.Add(sunButton);
            Controls.Add(seaButton);
            Controls.Add(clue3Label);
            Controls.Add(clue2Label);
            Controls.Add(clue1Label);
            Name = "PortalSequence";
            Text = "PortalSequence";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label clue1Label;
        private Label clue2Label;
        private Label clue3Label;
        private Button seaButton;
        private Button sunButton;
        private Button starButton;
        private Label lblMessage;
        private Label messageLabel;
    }
}