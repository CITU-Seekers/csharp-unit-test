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
            this.holidaysMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.holidaysLabel = new System.Windows.Forms.Label();
            this.displayHolidaysButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // holidaysMonthCalendar
            // 
            this.holidaysMonthCalendar.BoldedDates = new System.DateTime[] {
        new System.DateTime(2022, 12, 25, 0, 0, 0, 0),
        new System.DateTime(2022, 12, 30, 0, 0, 0, 0),
        new System.DateTime(2023, 1, 1, 0, 0, 0, 0),
        new System.DateTime(2023, 1, 22, 0, 0, 0, 0)};
            this.holidaysMonthCalendar.Location = new System.Drawing.Point(34, 34);
            this.holidaysMonthCalendar.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.holidaysMonthCalendar.Name = "holidaysMonthCalendar";
            this.holidaysMonthCalendar.TabIndex = 0;
            // 
            // holidaysLabel
            // 
            this.holidaysLabel.AutoSize = true;
            this.holidaysLabel.Location = new System.Drawing.Point(34, 298);
            this.holidaysLabel.MaximumSize = new System.Drawing.Size(200, 200);
            this.holidaysLabel.MinimumSize = new System.Drawing.Size(280, 50);
            this.holidaysLabel.Name = "holidaysLabel";
            this.holidaysLabel.Size = new System.Drawing.Size(280, 50);
            this.holidaysLabel.TabIndex = 1;
            this.holidaysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayHolidaysButton
            // 
            this.displayHolidaysButton.Location = new System.Drawing.Point(104, 252);
            this.displayHolidaysButton.Name = "displayHolidaysButton";
            this.displayHolidaysButton.Size = new System.Drawing.Size(130, 25);
            this.displayHolidaysButton.TabIndex = 2;
            this.displayHolidaysButton.Text = "Show Holidays";
            this.displayHolidaysButton.UseVisualStyleBackColor = true;
            this.displayHolidaysButton.Click += new System.EventHandler(this.DisplayHolidaysButton_Click);
            // 
            // Holidays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 422);
            this.Controls.Add(this.displayHolidaysButton);
            this.Controls.Add(this.holidaysLabel);
            this.Controls.Add(this.holidaysMonthCalendar);
            this.Name = "Holidays";
            this.Text = "Holidays";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar holidaysMonthCalendar;
        private Label holidaysLabel;
        private Button displayHolidaysButton;
    }
}