namespace CodeChum
{
    partial class PersonalCalendar
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
            this.personalMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.eventLabel = new System.Windows.Forms.Label();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.addEventButton = new System.Windows.Forms.Button();
            this.retrieveEventButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personalMonthCalendar
            // 
            this.personalMonthCalendar.Location = new System.Drawing.Point(34, 41);
            this.personalMonthCalendar.Margin = new System.Windows.Forms.Padding(8);
            this.personalMonthCalendar.MaxSelectionCount = 1;
            this.personalMonthCalendar.Name = "personalMonthCalendar";
            this.personalMonthCalendar.TabIndex = 0;
            // 
            // eventLabel
            // 
            this.eventLabel.Location = new System.Drawing.Point(41, 299);
            this.eventLabel.Name = "eventLabel";
            this.eventLabel.Size = new System.Drawing.Size(137, 49);
            this.eventLabel.TabIndex = 1;
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Location = new System.Drawing.Point(41, 259);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(137, 27);
            this.eventNameTextBox.TabIndex = 2;
            // 
            // addEventButton
            // 
            this.addEventButton.Location = new System.Drawing.Point(183, 259);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(91, 25);
            this.addEventButton.TabIndex = 3;
            this.addEventButton.Text = "Add Event";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // retrieveEventButton
            // 
            this.retrieveEventButton.Location = new System.Drawing.Point(183, 299);
            this.retrieveEventButton.Name = "retrieveEventButton";
            this.retrieveEventButton.Size = new System.Drawing.Size(91, 49);
            this.retrieveEventButton.TabIndex = 4;
            this.retrieveEventButton.Text = "Retrieve Event";
            this.retrieveEventButton.UseVisualStyleBackColor = true;
            this.retrieveEventButton.Click += new System.EventHandler(this.RetrieveEventButton_Click);
            // 
            // PersonalCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 375);
            this.Controls.Add(this.retrieveEventButton);
            this.Controls.Add(this.addEventButton);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(this.eventLabel);
            this.Controls.Add(this.personalMonthCalendar);
            this.Name = "PersonalCalendar";
            this.Text = "Personal Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar personalMonthCalendar;
        private Label eventLabel;
        private TextBox eventNameTextBox;
        private Button addEventButton;
        private Button retrieveEventButton;
    }
}