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
            this.CounterLabel = new System.Windows.Forms.Label();
            this.CounterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CounterLabel
            // 
            this.CounterLabel.AutoSize = true;
            this.CounterLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CounterLabel.Location = new System.Drawing.Point(163, 31);
            this.CounterLabel.Name = "CounterLabel";
            this.CounterLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CounterLabel.Size = new System.Drawing.Size(32, 38);
            this.CounterLabel.TabIndex = 0;
            this.CounterLabel.Text = "0";
            // 
            // CounterButton
            // 
            this.CounterButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CounterButton.Location = new System.Drawing.Point(114, 83);
            this.CounterButton.Name = "CounterButton";
            this.CounterButton.Size = new System.Drawing.Size(128, 34);
            this.CounterButton.TabIndex = 1;
            this.CounterButton.Text = "Increment";
            this.CounterButton.UseVisualStyleBackColor = true;
            this.CounterButton.Click += new System.EventHandler(this.CounterButton_Click);
            // 
            // Counter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 141);
            this.Controls.Add(this.CounterButton);
            this.Controls.Add(this.CounterLabel);
            this.Name = "Counter";
            this.Text = "Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label CounterLabel;
        private Button CounterButton;
    }
}