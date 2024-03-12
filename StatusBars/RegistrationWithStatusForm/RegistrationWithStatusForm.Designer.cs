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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.birthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.registerButton = new System.Windows.Forms.Button();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.registrationStatusStrip = new System.Windows.Forms.StatusStrip();
            this.registrationStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.registrationStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(25, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PlaceholderText = "Name";
            this.nameTextBox.Size = new System.Drawing.Size(291, 27);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextChanged += new System.EventHandler(this.statusUpdate);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(25, 69);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PlaceholderText = "Email";
            this.emailTextBox.Size = new System.Drawing.Size(291, 27);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.TextChanged += new System.EventHandler(this.statusUpdate);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(25, 115);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.PlaceholderText = "Address";
            this.addressTextBox.Size = new System.Drawing.Size(291, 27);
            this.addressTextBox.TabIndex = 2;
            this.addressTextBox.TextChanged += new System.EventHandler(this.statusUpdate);
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Location = new System.Drawing.Point(26, 191);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(290, 27);
            this.birthDatePicker.TabIndex = 3;
            this.birthDatePicker.ValueChanged += new System.EventHandler(this.statusUpdate);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(26, 238);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(290, 30);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // registrationLabel
            // 
            this.registrationLabel.Location = new System.Drawing.Point(33, 293);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(283, 134);
            this.registrationLabel.TabIndex = 5;
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
            // registrationStatusStrip
            // 
            this.registrationStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.registrationStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrationStatusLabel});
            this.registrationStatusStrip.Location = new System.Drawing.Point(0, 433);
            this.registrationStatusStrip.Name = "registrationStatusStrip";
            this.registrationStatusStrip.Size = new System.Drawing.Size(339, 22);
            this.registrationStatusStrip.TabIndex = 7;
            // 
            // registrationStatusLabel
            // 
            this.registrationStatusLabel.Name = "registrationStatusLabel";
            this.registrationStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // RegistrationWithStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 455);
            this.Controls.Add(this.registrationStatusStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrationLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.birthDatePicker);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "RegistrationWithStatusForm";
            this.Text = "Registration Form";
            this.registrationStatusStrip.ResumeLayout(false);
            this.registrationStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private TextBox addressTextBox;
        private DateTimePicker birthDatePicker;
        private Button registerButton;
        private Label registrationLabel;
        private Label label1;
        private StatusStrip registrationStatusStrip;
        private ToolStripStatusLabel registrationStatusLabel;
    }
}