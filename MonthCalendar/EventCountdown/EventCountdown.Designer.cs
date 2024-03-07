namespace CodeChum
{
    partial class EventCountdown
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
            components = new System.ComponentModel.Container();
            MonthCalendar = new MonthCalendar();
            btnAdd = new Button();
            EventName = new TextBox();
            lblCountdown = new Label();
            CountdownTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // MonthCalendar
            // 
            MonthCalendar.Location = new Point(54, 36);
            MonthCalendar.Name = "MonthCalendar";
            MonthCalendar.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(206, 210);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Event";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // EventName
            // 
            EventName.Location = new Point(54, 210);
            EventName.Multiline = true;
            EventName.Name = "EventName";
            EventName.Size = new Size(136, 23);
            EventName.TabIndex = 4;
            // 
            // lblCountdown
            // 
            lblCountdown.AutoSize = true;
            lblCountdown.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCountdown.Location = new Point(54, 249);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(0, 20);
            lblCountdown.TabIndex = 7;
            // 
            // CountdownTimer
            // 
            CountdownTimer.Tick += CountdownTimer_Tick;
            // 
            // EventCountdown
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 354);
            Controls.Add(lblCountdown);
            Controls.Add(btnAdd);
            Controls.Add(EventName);
            Controls.Add(MonthCalendar);
            Name = "EventCountdown";
            Text = "EventCountdown";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar MonthCalendar;
        private Button btnAdd;
        private TextBox EventName;
        private Label lblCountdown;
        private System.Windows.Forms.Timer CountdownTimer;
    }
}