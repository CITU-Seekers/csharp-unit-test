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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(52, 31);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.PlaceholderText = "Id";
            this.idTextBox.Size = new System.Drawing.Size(314, 27);
            this.idTextBox.TabIndex = 0;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(75, 77);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(106, 36);
            this.checkButton.TabIndex = 1;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(225, 77);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(115, 36);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AttendanceCheckerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 134);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.idTextBox);
            this.Name = "AttendanceCheckerForm";
            this.Text = "Attendance Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox idTextBox;
        private Button checkButton;
        private Button cancelButton;
    }
}