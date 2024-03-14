namespace CodeChum
{
    partial class MessageDecoder
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
            label1 = new Label();
            encodeTextBox = new TextBox();
            decodeButton = new Button();
            label2 = new Label();
            displayMessageLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 45);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Encode Message";
            // 
            // encodeTextBox
            // 
            encodeTextBox.Location = new Point(62, 63);
            encodeTextBox.Multiline = true;
            encodeTextBox.Name = "encodeTextBox";
            encodeTextBox.Size = new Size(217, 23);
            encodeTextBox.TabIndex = 1;
            // 
            // decodeButton
            // 
            decodeButton.Location = new Point(272, 113);
            decodeButton.Name = "decodeButton";
            decodeButton.Size = new Size(75, 23);
            decodeButton.TabIndex = 2;
            decodeButton.Text = "Decode";
            decodeButton.UseVisualStyleBackColor = true;
            decodeButton.Click += btnDecode_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 45);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 3;
            label2.Text = "Decoded Message";
            // 
            // displayMessageLabel
            // 
            displayMessageLabel.AutoSize = true;
            displayMessageLabel.BorderStyle = BorderStyle.Fixed3D;
            displayMessageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            displayMessageLabel.Location = new Point(363, 63);
            displayMessageLabel.MinimumSize = new Size(173, 24);
            displayMessageLabel.Name = "displayMessageLabel";
            displayMessageLabel.Size = new Size(173, 24);
            displayMessageLabel.TabIndex = 4;
            // 
            // MessageDecoder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 177);
            Controls.Add(displayMessageLabel);
            Controls.Add(label2);
            Controls.Add(decodeButton);
            Controls.Add(encodeTextBox);
            Controls.Add(label1);
            Name = "MessageDecoder";
            Text = "Decoder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox encodeTextBox;
        private Button decodeButton;
        private Label label2;
        private Label displayMessageLabel;
    }
}