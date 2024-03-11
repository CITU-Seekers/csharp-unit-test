﻿namespace CodeChum
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
            DatePicker = new System.Windows.Forms.DateTimePicker();
            label1 = new Label();
            cboTime = new System.Windows.Forms.ComboBox();
            label2 = new Label();
            EventName = new TextBox();
            label3 = new Label();
            btnReserve = new Button();
            ReservationSummary = new Label();
            SuspendLayout();
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(74, 84);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(200, 23);
            DatePicker.TabIndex = 0;
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
            // cboTime
            // 
            cboTime.FormattingEnabled = true;
            cboTime.Items.AddRange(new object[] { "8:00 AM", "12:00 PM", "4:00 PM", "8:00 PM" });
            cboTime.Location = new Point(330, 84);
            cboTime.Name = "cboTime";
            cboTime.Size = new Size(121, 23);
            cboTime.TabIndex = 2;
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
            // EventName
            // 
            EventName.Location = new Point(74, 168);
            EventName.Name = "EventName";
            EventName.Size = new Size(377, 23);
            EventName.TabIndex = 4;
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
            // btnReserve
            // 
            btnReserve.Location = new Point(222, 221);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(75, 23);
            btnReserve.TabIndex = 6;
            btnReserve.Text = "Reserve";
            btnReserve.UseVisualStyleBackColor = true;
            btnReserve.Click += btnReserve_Click;
            // 
            // ReservationSummary
            // 
            ReservationSummary.AutoSize = true;
            ReservationSummary.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ReservationSummary.Location = new Point(74, 265);
            ReservationSummary.Name = "ReservationSummary";
            ReservationSummary.Size = new Size(0, 20);
            ReservationSummary.TabIndex = 7;
            // 
            // Reservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 391);
            Controls.Add(ReservationSummary);
            Controls.Add(btnReserve);
            Controls.Add(label3);
            Controls.Add(EventName);
            Controls.Add(label2);
            Controls.Add(cboTime);
            Controls.Add(label1);
            Controls.Add(DatePicker);
            Name = "Reservation";
            Text = "Reservation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker DatePicker;
        private Label label1;
        private System.Windows.Forms.ComboBox cboTime;
        private Label label2;
        private TextBox EventName;
        private Label label3;
        private Button btnReserve;
        private Label ReservationSummary;
    }
}