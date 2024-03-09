namespace CodeChum
{
    partial class AttendanceRecorder
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
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.CheckerButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegistrationButton.Location = new System.Drawing.Point(90, 25);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(179, 39);
            this.RegistrationButton.TabIndex = 0;
            this.RegistrationButton.Text = "Register Employee";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.onButtonClick);
            // 
            // CheckerButton
            // 
            this.CheckerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckerButton.Location = new System.Drawing.Point(90, 85);
            this.CheckerButton.Name = "CheckerButton";
            this.CheckerButton.Size = new System.Drawing.Size(179, 39);
            this.CheckerButton.TabIndex = 1;
            this.CheckerButton.Text = "Check Attendance";
            this.CheckerButton.UseVisualStyleBackColor = true;
            this.CheckerButton.Click += new System.EventHandler(this.onButtonClick);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(90, 145);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(179, 39);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.onButtonClick);
            // 
            // AttendanceRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 220);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CheckerButton);
            this.Controls.Add(this.RegistrationButton);
            this.Name = "AttendanceRecorder";
            this.Text = "Attendance Recorder";
            this.ResumeLayout(false);

        }

        #endregion

        private Button RegistrationButton;
        private Button CheckerButton;
        private Button ExitButton;
    }
}