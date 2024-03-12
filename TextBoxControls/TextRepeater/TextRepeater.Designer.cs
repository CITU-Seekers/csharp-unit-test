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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.displayTextButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(203, 92);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.PlaceholderText = "Text";
            this.inputTextBox.Size = new System.Drawing.Size(170, 30);
            this.inputTextBox.TabIndex = 0;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(379, 92);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.PlaceholderText = "Number";
            this.numberTextBox.Size = new System.Drawing.Size(80, 30);
            this.numberTextBox.TabIndex = 1;
            // 
            // displayTextButton
            // 
            this.displayTextButton.Location = new System.Drawing.Point(464, 92);
            this.displayTextButton.Name = "displayTextButton";
            this.displayTextButton.Size = new System.Drawing.Size(94, 30);
            this.displayTextButton.TabIndex = 2;
            this.displayTextButton.Text = "Display";
            this.displayTextButton.UseVisualStyleBackColor = true;
            this.displayTextButton.Click += new System.EventHandler(this.DisplayTextButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(49, 39);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(509, 30);
            this.resultTextBox.TabIndex = 3;
            // 
            // TextRepeater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 159);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.displayTextButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Name = "TextRepeater";
            this.Text = "TextRepeater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inputTextBox;
        private TextBox numberTextBox;
        private Button displayTextButton;
        private TextBox resultTextBox;
    }
}