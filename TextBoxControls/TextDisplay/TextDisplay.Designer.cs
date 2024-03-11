namespace CodeChum
{
    partial class TextDisplay
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.DisplayTextButton = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(41, 106);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(202, 27);
            this.TextBox.TabIndex = 0;
            // 
            // DisplayTextButton
            // 
            this.DisplayTextButton.Location = new System.Drawing.Point(248, 106);
            this.DisplayTextButton.Name = "DisplayTextButton";
            this.DisplayTextButton.Size = new System.Drawing.Size(84, 25);
            this.DisplayTextButton.TabIndex = 1;
            this.DisplayTextButton.Text = "Display";
            this.DisplayTextButton.UseVisualStyleBackColor = true;
            this.DisplayTextButton.Click += new System.EventHandler(this.DisplayTextButton_Click);
            // 
            // Label
            // 
            this.Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label.Location = new System.Drawing.Point(41, 41);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(291, 48);
            this.Label.TabIndex = 2;
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 176);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.DisplayTextButton);
            this.Controls.Add(this.TextBox);
            this.Name = "TextDisplay";
            this.Text = "Text Display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TextBox;
        private Button DisplayTextButton;
        private Label Label;
    }
}