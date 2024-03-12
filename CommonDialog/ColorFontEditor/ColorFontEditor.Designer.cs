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
            this.mainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.fontButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainRichTextBox
            // 
            this.mainRichTextBox.Location = new System.Drawing.Point(12, 87);
            this.mainRichTextBox.Name = "mainRichTextBox";
            this.mainRichTextBox.Size = new System.Drawing.Size(440, 199);
            this.mainRichTextBox.TabIndex = 0;
            this.mainRichTextBox.Text = "";
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(53, 26);
            this.colorButton.Name = "OpenFileButton";
            this.colorButton.Size = new System.Drawing.Size(116, 37);
            this.colorButton.TabIndex = 1;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // fontButton
            // 
            this.fontButton.Location = new System.Drawing.Point(287, 26);
            this.fontButton.Name = "SaveFileButton";
            this.fontButton.Size = new System.Drawing.Size(116, 37);
            this.fontButton.TabIndex = 2;
            this.fontButton.Text = "Font";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.FontButton_Click);
            // 
            // ColorFontEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 298);
            this.Controls.Add(this.fontButton);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.mainRichTextBox);
            this.Name = "ColorFontEditor";
            this.Text = "Color & Font Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox mainRichTextBox;
        private Button colorButton;
        private Button fontButton;
    }
}