namespace CodeChum
{
    partial class Counter
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
            this.counterLabel = new System.Windows.Forms.Label();
            this.counterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.counterLabel.Location = new System.Drawing.Point(163, 31);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.counterLabel.Size = new System.Drawing.Size(32, 38);
            this.counterLabel.TabIndex = 0;
            this.counterLabel.Text = "0";
            // 
            // counterButton
            // 
            this.counterButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.counterButton.Location = new System.Drawing.Point(114, 83);
            this.counterButton.Name = "counterButton";
            this.counterButton.Size = new System.Drawing.Size(128, 34);
            this.counterButton.TabIndex = 1;
            this.counterButton.Text = "Increment";
            this.counterButton.UseVisualStyleBackColor = true;
            this.counterButton.Click += new System.EventHandler(this.CounterButton_Click);
            // 
            // Counter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 141);
            this.Controls.Add(this.counterButton);
            this.Controls.Add(this.counterLabel);
            this.Name = "Counter";
            this.Text = "Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label counterLabel;
        private Button counterButton;
    }
}