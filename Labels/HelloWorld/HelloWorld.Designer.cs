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
            textDisplayLabel = new Label();
            SuspendLayout();
            // 
            // textDisplayLabel
            // 
            textDisplayLabel.AutoSize = true;
            textDisplayLabel.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            textDisplayLabel.Location = new Point(75, 46);
            textDisplayLabel.Margin = new Padding(2, 0, 2, 0);
            textDisplayLabel.Name = "textDisplayLabel";
            textDisplayLabel.Size = new Size(181, 37);
            textDisplayLabel.TabIndex = 0;
            textDisplayLabel.Text = "Hello World!";
            // 
            // HelloWorld
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 124);
            Controls.Add(textDisplayLabel);
            Margin = new Padding(2);
            Name = "HelloWorld";
            Text = "HelloWorld";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textDisplayLabel;
    }
}