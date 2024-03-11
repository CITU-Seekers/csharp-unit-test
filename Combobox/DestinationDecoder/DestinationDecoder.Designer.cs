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
            cboTrait = new System.Windows.Forms.ComboBox();
            btnReveal = new Button();
            lblDestination = new Label();
            SuspendLayout();
            // 
            // cboTrait
            // 
            cboTrait.FormattingEnabled = true;
            cboTrait.Items.AddRange(new object[] { "Adventurer", "Explorer", "Beach Bum", "History Buff", "Foodie", "Nature Lover" });
            cboTrait.Location = new Point(121, 65);
            cboTrait.Name = "cboTrait";
            cboTrait.Size = new Size(175, 23);
            cboTrait.TabIndex = 0;
            // 
            // btnReveal
            // 
            btnReveal.Location = new Point(154, 118);
            btnReveal.Name = "btnReveal";
            btnReveal.Size = new Size(111, 38);
            btnReveal.TabIndex = 1;
            btnReveal.Text = "Reveal Destination";
            btnReveal.UseVisualStyleBackColor = true;
            btnReveal.Click += btnReveal_Click;
            // 
            // lblDestination
            // 
            lblDestination.AutoSize = true;
            lblDestination.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDestination.Location = new Point(121, 187);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(85, 20);
            lblDestination.TabIndex = 2;
            lblDestination.Text = "Destination";
            lblDestination.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DestinationDecoder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 297);
            Controls.Add(lblDestination);
            Controls.Add(btnReveal);
            Controls.Add(cboTrait);
            Name = "DestinationDecoder";
            Text = "DestinationDecoder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cboTrait;
        private Button btnReveal;
        private Label lblDestination;
    }
}