namespace CodeChum
{
    partial class SimpleLabels
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
            this.helloWorldLabel = new System.Windows.Forms.Label();
            this.programmingLabel = new System.Windows.Forms.Label();
            this.codechumLabel = new System.Windows.Forms.Label();
            this.csharpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helloWorldLabel
            // 
            this.helloWorldLabel.AutoSize = true;
            this.helloWorldLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helloWorldLabel.Location = new System.Drawing.Point(86, 23);
            this.helloWorldLabel.Name = "helloWorldLabel";
            this.helloWorldLabel.Size = new System.Drawing.Size(172, 38);
            this.helloWorldLabel.TabIndex = 0;
            this.helloWorldLabel.Text = "Hello World!";
            // 
            // programmingLabel
            // 
            this.programmingLabel.AutoSize = true;
            this.programmingLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.programmingLabel.Location = new System.Drawing.Point(49, 72);
            this.programmingLabel.Name = "programmingLabel";
            this.programmingLabel.Size = new System.Drawing.Size(260, 38);
            this.programmingLabel.TabIndex = 1;
            this.programmingLabel.Text = "I love programming";
            // 
            // codechumLabel
            // 
            this.codechumLabel.AutoSize = true;
            this.codechumLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codechumLabel.Location = new System.Drawing.Point(73, 125);
            this.codechumLabel.Name = "codechumLabel";
            this.codechumLabel.Size = new System.Drawing.Size(228, 38);
            this.codechumLabel.TabIndex = 2;
            this.codechumLabel.Text = "I love CodeChum";
            // 
            // csharpLabel
            // 
            this.csharpLabel.AutoSize = true;
            this.csharpLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.csharpLabel.Location = new System.Drawing.Point(113, 173);
            this.csharpLabel.Name = "csharpLabel";
            this.csharpLabel.Size = new System.Drawing.Size(125, 38);
            this.csharpLabel.TabIndex = 3;
            this.csharpLabel.Text = "I love C#";
            // 
            // SimpleLabels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 234);
            this.Controls.Add(this.csharpLabel);
            this.Controls.Add(this.codechumLabel);
            this.Controls.Add(this.programmingLabel);
            this.Controls.Add(this.helloWorldLabel);
            this.Name = "SimpleLabels";
            this.Text = "Simple Labels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label helloWorldLabel;
        private Label programmingLabel;
        private Label codechumLabel;
        private Label csharpLabel;
    }
}