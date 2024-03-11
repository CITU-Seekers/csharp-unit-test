namespace CodeChum
{
    partial class AttendanceCheckerForm
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
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(52, 31);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.PlaceholderText = "Id";
            this.IdTextBox.Size = new System.Drawing.Size(314, 27);
            this.IdTextBox.TabIndex = 0;
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(75, 77);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(106, 36);
            this.CheckButton.TabIndex = 1;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(225, 77);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(115, 36);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AttendanceCheckerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 134);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.IdTextBox);
            this.Name = "AttendanceCheckerForm";
            this.Text = "Attendance Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox IdTextBox;
        private Button CheckButton;
        private Button CancelButton;
    }
}