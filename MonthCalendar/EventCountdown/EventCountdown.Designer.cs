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
            monthCalendar = new MonthCalendar();
            addButton = new Button();
            eventNameTextBox = new TextBox();
            countdownLabel = new Label();
            countdownTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(54, 36);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Location = new Point(206, 210);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 6;
            addButton.Text = "Add Event";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += btnAdd_Click;
            // 
            // eventNameTextBox
            // 
            eventNameTextBox.Location = new Point(54, 210);
            eventNameTextBox.Multiline = true;
            eventNameTextBox.Name = "eventNameTextBox";
            eventNameTextBox.Size = new Size(136, 23);
            eventNameTextBox.TabIndex = 4;
            // 
            // lblCountdown
            // 
            countdownLabel.AutoSize = true;
            countdownLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            countdownLabel.Location = new Point(54, 249);
            countdownLabel.Name = "countdownLabel";
            countdownLabel.Size = new Size(0, 20);
            countdownLabel.TabIndex = 7;
            // 
            // CountdownTimer
            // 
            countdownTimer.Tick += CountdownTimer_Tick;
            // 
            // EventCountdown
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 354);
            Controls.Add(countdownLabel);
            Controls.Add(addButton);
            Controls.Add(eventNameTextBox);
            Controls.Add(monthCalendar);
            Name = "EventCountdown";
            Text = "EventCountdown";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar;
        private Button addButton;
        private TextBox eventNameTextBox;
        private Label countdownLabel;
        private System.Windows.Forms.Timer countdownTimer;
    }
}