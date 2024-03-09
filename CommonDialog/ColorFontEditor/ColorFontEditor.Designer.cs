namespace CodeChum
{
    partial class ColorFontEditor
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
            this.MainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ColorButton = new System.Windows.Forms.Button();
            this.FontButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainRichTextBox
            // 
            this.MainRichTextBox.Location = new System.Drawing.Point(12, 87);
            this.MainRichTextBox.Name = "MainRichTextBox";
            this.MainRichTextBox.Size = new System.Drawing.Size(440, 199);
            this.MainRichTextBox.TabIndex = 0;
            this.MainRichTextBox.Text = "";
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(53, 26);
            this.ColorButton.Name = "OpenFileButton";
            this.ColorButton.Size = new System.Drawing.Size(116, 37);
            this.ColorButton.TabIndex = 1;
            this.ColorButton.Text = "Color";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // FontButton
            // 
            this.FontButton.Location = new System.Drawing.Point(287, 26);
            this.FontButton.Name = "SaveFileButton";
            this.FontButton.Size = new System.Drawing.Size(116, 37);
            this.FontButton.TabIndex = 2;
            this.FontButton.Text = "Font";
            this.FontButton.UseVisualStyleBackColor = true;
            this.FontButton.Click += new System.EventHandler(this.FontButton_Click);
            // 
            // ColorFontEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 298);
            this.Controls.Add(this.FontButton);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.MainRichTextBox);
            this.Name = "ColorFontEditor";
            this.Text = "Color & Font Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox MainRichTextBox;
        private Button ColorButton;
        private Button FontButton;
    }
}