namespace CodeChum
{
    partial class Reservation
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
            dateTimePicker = new DateTimePicker();
            label1 = new Label();
            timeComboBox = new ComboBox();
            label2 = new Label();
            eventNameTextBox = new TextBox();
            label3 = new Label();
            reserveButton = new Button();
            reservationSummaryLabel = new Label();
            SuspendLayout();
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(74, 84);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(74, 56);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 1;
            label1.Text = "Date";
            // 
            // timeComboBox
            // 
            timeComboBox.FormattingEnabled = true;
            timeComboBox.Items.AddRange(new object[] { "8:00 AM", "12:00 PM", "4:00 PM", "8:00 PM" });
            timeComboBox.Location = new Point(330, 84);
            timeComboBox.Name = "timeComboBox";
            timeComboBox.Size = new Size(121, 23);
            timeComboBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(330, 56);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 3;
            label2.Text = "Time";
            // 
            // eventNameTextBox
            // 
            eventNameTextBox.Location = new Point(74, 168);
            eventNameTextBox.Name = "eventNameTextBox";
            eventNameTextBox.Size = new Size(377, 23);
            eventNameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(74, 136);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 5;
            label3.Text = "Event Name";
            // 
            // reserveButton
            // 
            reserveButton.Location = new Point(222, 221);
            reserveButton.Name = "reserveButton";
            reserveButton.Size = new Size(75, 23);
            reserveButton.TabIndex = 6;
            reserveButton.Text = "Reserve";
            reserveButton.UseVisualStyleBackColor = true;
            reserveButton.Click += btnReserve_Click;
            // 
            // ReservationSummary
            // 
            reservationSummaryLabel.AutoSize = true;
            reservationSummaryLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            reservationSummaryLabel.Location = new Point(74, 265);
            reservationSummaryLabel.Name = "reservationSummaryLabel";
            reservationSummaryLabel.Size = new Size(0, 20);
            reservationSummaryLabel.TabIndex = 7;
            // 
            // Reservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 391);
            Controls.Add(reservationSummaryLabel);
            Controls.Add(reserveButton);
            Controls.Add(label3);
            Controls.Add(eventNameTextBox);
            Controls.Add(label2);
            Controls.Add(timeComboBox);
            Controls.Add(label1);
            Controls.Add(dateTimePicker);
            Name = "Reservation";
            Text = "Reservation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private Label label1;
        private System.Windows.Forms.ComboBox timeComboBox;
        private Label label2;
        private TextBox eventNameTextBox;
        private Label label3;
        private Button reserveButton;
        private Label reservationSummaryLabel;
    }
}