namespace CodeChum
{
    partial class HelloWorld
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
            this.TextDisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextDisplayLabel
            // 
            this.TextDisplayLabel.AutoSize = true;
            this.TextDisplayLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextDisplayLabel.Location = new System.Drawing.Point(96, 70);
            this.TextDisplayLabel.Name = "TextDisplayLabel";
            this.TextDisplayLabel.Size = new System.Drawing.Size(224, 46);
            this.TextDisplayLabel.TabIndex = 0;
            this.TextDisplayLabel.Text = "Hello World!";
            // 
            // HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 190);
            this.Controls.Add(this.TextDisplayLabel);
            this.Name = "HelloWorld";
            this.Text = "HelloWorld";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TextDisplayLabel;
    }
}