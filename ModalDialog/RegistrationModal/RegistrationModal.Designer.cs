namespace CodeChum
{
    partial class RegistrationModal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EmailTextBox);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Location = new System.Drawing.Point(31, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 127);
            this.panel1.TabIndex = 0;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTextBox.Location = new System.Drawing.Point(21, 14);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PlaceholderText = "Name";
            this.NameTextBox.Size = new System.Drawing.Size(441, 34);
            this.NameTextBox.TabIndex = 0;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailTextBox.Location = new System.Drawing.Point(21, 66);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PlaceholderText = "Email";
            this.EmailTextBox.Size = new System.Drawing.Size(441, 34);
            this.EmailTextBox.TabIndex = 1;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(117, 167);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(113, 36);
            this.RegisterButton.TabIndex = 1;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(311, 167);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(113, 36);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RegistrationModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 215);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.panel1);
            this.Name = "RegistrationModal";
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox EmailTextBox;
        private TextBox NameTextBox;
        private Button RegisterButton;
        private Button CancelButton;
    }
}