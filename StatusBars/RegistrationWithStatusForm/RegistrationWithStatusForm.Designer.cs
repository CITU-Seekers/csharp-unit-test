namespace CodeChum
{
    partial class RegistrationWithStatusForm
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RegistrationStatusStrip = new System.Windows.Forms.StatusStrip();
            this.RegistrationStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.RegistrationStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(25, 27);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PlaceholderText = "Name";
            this.NameTextBox.Size = new System.Drawing.Size(291, 27);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.statusUpdate);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(25, 69);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PlaceholderText = "Email";
            this.EmailTextBox.Size = new System.Drawing.Size(291, 27);
            this.EmailTextBox.TabIndex = 1;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.statusUpdate);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(25, 115);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.PlaceholderText = "Address";
            this.AddressTextBox.Size = new System.Drawing.Size(291, 27);
            this.AddressTextBox.TabIndex = 2;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.statusUpdate);
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Location = new System.Drawing.Point(26, 191);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(290, 27);
            this.BirthDatePicker.TabIndex = 3;
            this.BirthDatePicker.ValueChanged += new System.EventHandler(this.statusUpdate);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(26, 238);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(290, 30);
            this.RegisterButton.TabIndex = 4;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.Location = new System.Drawing.Point(33, 293);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(283, 134);
            this.RegistrationLabel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Birth Date:";
            // 
            // RegistrationStatusStrip
            // 
            this.RegistrationStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.RegistrationStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistrationStatusLabel});
            this.RegistrationStatusStrip.Location = new System.Drawing.Point(0, 433);
            this.RegistrationStatusStrip.Name = "RegistrationStatusStrip";
            this.RegistrationStatusStrip.Size = new System.Drawing.Size(339, 22);
            this.RegistrationStatusStrip.TabIndex = 7;
            // 
            // RegistrationStatusLabel
            // 
            this.RegistrationStatusLabel.Name = "RegistrationStatusLabel";
            this.RegistrationStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // RegistrationWithStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 455);
            this.Controls.Add(this.RegistrationStatusStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegistrationLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "RegistrationWithStatusForm";
            this.Text = "Registration Form";
            this.RegistrationStatusStrip.ResumeLayout(false);
            this.RegistrationStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NameTextBox;
        private TextBox EmailTextBox;
        private TextBox AddressTextBox;
        private DateTimePicker BirthDatePicker;
        private Button RegisterButton;
        private Label RegistrationLabel;
        private Label label1;
        private StatusStrip RegistrationStatusStrip;
        private ToolStripStatusLabel RegistrationStatusLabel;
    }
}