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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.displayTextButton = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(41, 106);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(202, 27);
            this.inputTextBox.TabIndex = 0;
            // 
            // displayTextButton
            // 
            this.displayTextButton.Location = new System.Drawing.Point(248, 106);
            this.displayTextButton.Name = "displayTextButton";
            this.displayTextButton.Size = new System.Drawing.Size(84, 25);
            this.displayTextButton.TabIndex = 1;
            this.displayTextButton.Text = "Display";
            this.displayTextButton.UseVisualStyleBackColor = true;
            this.displayTextButton.Click += new System.EventHandler(this.DisplayTextButton_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.displayLabel.Location = new System.Drawing.Point(41, 41);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(291, 48);
            this.displayLabel.TabIndex = 2;
            this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 176);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.displayTextButton);
            this.Controls.Add(this.inputTextBox);
            this.Name = "TextDisplay";
            this.Text = "Text Display";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inputTextBox;
        private Button displayTextButton;
        private Label displayLabel;
    }
}