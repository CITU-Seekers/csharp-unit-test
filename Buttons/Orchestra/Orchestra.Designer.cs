namespace CodeChum
{
    partial class Orchestra
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
            violinButton = new Button();
            celloButton = new Button();
            trumpetButton = new Button();
            drumButton = new Button();
            messageLabel = new Label();
            SuspendLayout();
            // 
            // violinButton
            // 
            violinButton.Location = new Point(117, 140);
            violinButton.Name = "violinButton";
            violinButton.Size = new Size(112, 42);
            violinButton.TabIndex = 0;
            violinButton.Text = "Violins";
            violinButton.UseVisualStyleBackColor = true;
            violinButton.Click += btnViolins_Click;
            // 
            // celloButton
            // 
            celloButton.Location = new Point(265, 140);
            celloButton.Name = "celloButton";
            celloButton.Size = new Size(100, 42);
            celloButton.TabIndex = 1;
            celloButton.Text = "Cellos";
            celloButton.UseVisualStyleBackColor = true;
            celloButton.Click += btnCellos_Click;
            // 
            // trumpetButton
            // 
            trumpetButton.Location = new Point(411, 140);
            trumpetButton.Name = "trumpetButton";
            trumpetButton.Size = new Size(100, 42);
            trumpetButton.TabIndex = 2;
            trumpetButton.Text = "Trumpets";
            trumpetButton.UseVisualStyleBackColor = true;
            trumpetButton.Click += btnTrumpets_Click;
            // 
            // drumButton
            // 
            drumButton.Location = new Point(557, 140);
            drumButton.Name = "drumButton";
            drumButton.Size = new Size(100, 42);
            drumButton.TabIndex = 3;
            drumButton.Text = "Drums";
            drumButton.UseVisualStyleBackColor = true;
            drumButton.Click += btnDrums_Click;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new Point(327, 246);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(38, 15);
            messageLabel.TabIndex = 4;
            messageLabel.Text = "label1";
            // 
            // Orchestra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(messageLabel);
            Controls.Add(drumButton);
            Controls.Add(trumpetButton);
            Controls.Add(celloButton);
            Controls.Add(violinButton);
            Name = "Orchestra";
            Text = "Orchestra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button violinButton;
        private Button celloButton;
        private Button trumpetButton;
        private Button drumButton;
        private Label messageLabel;
    }
}