namespace CodeChum
{
    partial class Holidays
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
            this.MonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.HolidaysLabel = new System.Windows.Forms.Label();
            this.DisplayHolidaysButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MonthCalendar
            // 
            this.MonthCalendar.BoldedDates = new System.DateTime[] {
        new System.DateTime(2022, 12, 25, 0, 0, 0, 0),
        new System.DateTime(2022, 12, 30, 0, 0, 0, 0),
        new System.DateTime(2023, 1, 1, 0, 0, 0, 0),
        new System.DateTime(2023, 1, 22, 0, 0, 0, 0)};
            this.MonthCalendar.Location = new System.Drawing.Point(34, 34);
            this.MonthCalendar.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MonthCalendar.Name = "MonthCalendar";
            this.MonthCalendar.TabIndex = 0;
            // 
            // HolidaysLabel
            // 
            this.HolidaysLabel.AutoSize = true;
            this.HolidaysLabel.Location = new System.Drawing.Point(34, 298);
            this.HolidaysLabel.MaximumSize = new System.Drawing.Size(200, 200);
            this.HolidaysLabel.MinimumSize = new System.Drawing.Size(280, 50);
            this.HolidaysLabel.Name = "HolidaysLabel";
            this.HolidaysLabel.Size = new System.Drawing.Size(280, 50);
            this.HolidaysLabel.TabIndex = 1;
            this.HolidaysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DisplayHolidaysButton
            // 
            this.DisplayHolidaysButton.Location = new System.Drawing.Point(104, 252);
            this.DisplayHolidaysButton.Name = "DisplayHolidaysButton";
            this.DisplayHolidaysButton.Size = new System.Drawing.Size(130, 25);
            this.DisplayHolidaysButton.TabIndex = 2;
            this.DisplayHolidaysButton.Text = "Show Holidays";
            this.DisplayHolidaysButton.UseVisualStyleBackColor = true;
            this.DisplayHolidaysButton.Click += new System.EventHandler(this.DisplayHolidaysButton_Click);
            // 
            // Holidays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 422);
            this.Controls.Add(this.DisplayHolidaysButton);
            this.Controls.Add(this.HolidaysLabel);
            this.Controls.Add(this.MonthCalendar);
            this.Name = "Holidays";
            this.Text = "Holidays";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar MonthCalendar;
        private Label HolidaysLabel;
        private Button DisplayHolidaysButton;
    }
}