namespace CodeChum
{
    partial class DestinationDecoder
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
            traitComboBox = new ComboBox();
            revealButton = new Button();
            destinationLabel = new Label();
            SuspendLayout();
            // 
            // traitComboBox
            // 
            traitComboBox.FormattingEnabled = true;
            traitComboBox.Items.AddRange(new object[] { "Adventurer", "Explorer", "Beach Bum", "History Buff", "Foodie", "Nature Lover" });
            traitComboBox.Location = new Point(121, 65);
            traitComboBox.Name = "traitComboBox";
            traitComboBox.Size = new Size(175, 23);
            traitComboBox.TabIndex = 0;
            // 
            // revealButton
            // 
            revealButton.Location = new Point(154, 118);
            revealButton.Name = "revealButton";
            revealButton.Size = new Size(111, 38);
            revealButton.TabIndex = 1;
            revealButton.Text = "Reveal Destination";
            revealButton.UseVisualStyleBackColor = true;
            revealButton.Click += btnReveal_Click;
            // 
            // destinationLabel
            // 
            destinationLabel.AutoSize = true;
            destinationLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            destinationLabel.Location = new Point(121, 187);
            destinationLabel.Name = "destinationLabel";
            destinationLabel.Size = new Size(85, 20);
            destinationLabel.TabIndex = 2;
            destinationLabel.Text = "Destination";
            destinationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DestinationDecoder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 297);
            Controls.Add(destinationLabel);
            Controls.Add(revealButton);
            Controls.Add(traitComboBox);
            Name = "DestinationDecoder";
            Text = "DestinationDecoder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox traitComboBox;
        private Button revealButton;
        private Label destinationLabel;
    }
}