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
            textBox1 = new TextBox();
            btnDecode = new Button();
            label2 = new Label();
            DisplayMessage = new Label();
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
            // textBox1
            // 
            textBox1.Location = new Point(62, 63);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 23);
            textBox1.TabIndex = 1;
            // 
            // btnDecode
            // 
            btnDecode.Location = new Point(272, 113);
            btnDecode.Name = "btnDecode";
            btnDecode.Size = new Size(75, 23);
            btnDecode.TabIndex = 2;
            btnDecode.Text = "Decode";
            btnDecode.UseVisualStyleBackColor = true;
            btnDecode.Click += btnDecode_Click;
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
            // DisplayMessage
            // 
            DisplayMessage.AutoSize = true;
            DisplayMessage.BorderStyle = BorderStyle.Fixed3D;
            DisplayMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DisplayMessage.Location = new Point(363, 63);
            DisplayMessage.MinimumSize = new Size(173, 24);
            DisplayMessage.Name = "DisplayMessage";
            DisplayMessage.Size = new Size(173, 24);
            DisplayMessage.TabIndex = 4;
            // 
            // Decoder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 177);
            Controls.Add(DisplayMessage);
            Controls.Add(label2);
            Controls.Add(btnDecode);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Decoder";
            Text = "Decoder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnDecode;
        private Label label2;
        private Label DisplayMessage;
    }
}