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
            this.MonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.EventLabel = new System.Windows.Forms.Label();
            this.EventNameTextBox = new System.Windows.Forms.TextBox();
            this.AddEventButton = new System.Windows.Forms.Button();
            this.RetrieveEventButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MonthCalendar
            // 
            this.MonthCalendar.Location = new System.Drawing.Point(34, 41);
            this.MonthCalendar.Margin = new System.Windows.Forms.Padding(8);
            this.MonthCalendar.MaxSelectionCount = 1;
            this.MonthCalendar.Name = "MonthCalendar";
            this.MonthCalendar.TabIndex = 0;
            // 
            // EventLabel
            // 
            this.EventLabel.Location = new System.Drawing.Point(41, 299);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(137, 49);
            this.EventLabel.TabIndex = 1;
            // 
            // EventNameTextBox
            // 
            this.EventNameTextBox.Location = new System.Drawing.Point(41, 259);
            this.EventNameTextBox.Name = "EventNameTextBox";
            this.EventNameTextBox.Size = new System.Drawing.Size(137, 27);
            this.EventNameTextBox.TabIndex = 2;
            // 
            // AddEventButton
            // 
            this.AddEventButton.Location = new System.Drawing.Point(183, 259);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Size = new System.Drawing.Size(91, 25);
            this.AddEventButton.TabIndex = 3;
            this.AddEventButton.Text = "Add Event";
            this.AddEventButton.UseVisualStyleBackColor = true;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // RetrieveEventButton
            // 
            this.RetrieveEventButton.Location = new System.Drawing.Point(183, 299);
            this.RetrieveEventButton.Name = "RetrieveEventButton";
            this.RetrieveEventButton.Size = new System.Drawing.Size(91, 49);
            this.RetrieveEventButton.TabIndex = 4;
            this.RetrieveEventButton.Text = "Retrieve Event";
            this.RetrieveEventButton.UseVisualStyleBackColor = true;
            this.RetrieveEventButton.Click += new System.EventHandler(this.RetrieveEventButton_Click);
            // 
            // PersonalCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 375);
            this.Controls.Add(this.RetrieveEventButton);
            this.Controls.Add(this.AddEventButton);
            this.Controls.Add(this.EventNameTextBox);
            this.Controls.Add(this.EventLabel);
            this.Controls.Add(this.MonthCalendar);
            this.Name = "PersonalCalendar";
            this.Text = "Personal Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar MonthCalendar;
        private Label EventLabel;
        private TextBox EventNameTextBox;
        private Button AddEventButton;
        private Button RetrieveEventButton;
    }
}