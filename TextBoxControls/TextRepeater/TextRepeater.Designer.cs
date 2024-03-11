namespace CodeChum
{
    partial class TextRepeater
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
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.DisplayTextButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(203, 92);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.PlaceholderText = "Text";
            this.InputTextBox.Size = new System.Drawing.Size(170, 30);
            this.InputTextBox.TabIndex = 0;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(379, 92);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.PlaceholderText = "Number";
            this.NumberTextBox.Size = new System.Drawing.Size(80, 30);
            this.NumberTextBox.TabIndex = 1;
            // 
            // DisplayTextButton
            // 
            this.DisplayTextButton.Location = new System.Drawing.Point(464, 92);
            this.DisplayTextButton.Name = "DisplayTextButton";
            this.DisplayTextButton.Size = new System.Drawing.Size(94, 30);
            this.DisplayTextButton.TabIndex = 2;
            this.DisplayTextButton.Text = "Display";
            this.DisplayTextButton.UseVisualStyleBackColor = true;
            this.DisplayTextButton.Click += new System.EventHandler(this.DisplayTextButton_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(49, 39);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(509, 30);
            this.ResultTextBox.TabIndex = 3;
            // 
            // TextRepeater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 159);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.DisplayTextButton);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Name = "TextRepeater";
            this.Text = "TextRepeater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox InputTextBox;
        private TextBox NumberTextBox;
        private Button DisplayTextButton;
        private TextBox ResultTextBox;
    }
}