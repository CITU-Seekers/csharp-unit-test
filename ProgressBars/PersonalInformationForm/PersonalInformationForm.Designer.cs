namespace CodeChum
{
    partial class PersonalInformationForm
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
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.quoteTextBox = new System.Windows.Forms.TextBox();
            this.programmingLanguageGroupBox = new System.Windows.Forms.GroupBox();
            this.programmingLanguageCheckBox2 = new System.Windows.Forms.CheckBox();
            this.programmingLanguageCheckBox1 = new System.Windows.Forms.CheckBox();
            this.formProgressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.programmingLanguageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(192, 78);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(238, 27);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(192, 125);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(238, 27);
            this.addressTextBox.TabIndex = 1;
            this.addressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // quoteTextBox
            // 
            this.quoteTextBox.Location = new System.Drawing.Point(192, 170);
            this.quoteTextBox.Name = "quoteTextBox";
            this.quoteTextBox.Size = new System.Drawing.Size(238, 27);
            this.quoteTextBox.TabIndex = 2;
            this.quoteTextBox.TextChanged += new System.EventHandler(this.QuoteTextBox_TextChanged);
            // 
            // programmingLanguageGroupBox
            // 
            this.programmingLanguageGroupBox.Controls.Add(this.programmingLanguageCheckBox2);
            this.programmingLanguageGroupBox.Controls.Add(this.programmingLanguageCheckBox1);
            this.programmingLanguageGroupBox.Location = new System.Drawing.Point(163, 241);
            this.programmingLanguageGroupBox.Name = "programmingLanguageGroupBox";
            this.programmingLanguageGroupBox.Size = new System.Drawing.Size(145, 95);
            this.programmingLanguageGroupBox.TabIndex = 3;
            this.programmingLanguageGroupBox.TabStop = false;
            // 
            // programmingLanguageCheckBox2
            // 
            this.programmingLanguageCheckBox2.AutoSize = true;
            this.programmingLanguageCheckBox2.Location = new System.Drawing.Point(16, 62);
            this.programmingLanguageCheckBox2.Name = "programmingLanguageCheckBox2";
            this.programmingLanguageCheckBox2.Size = new System.Drawing.Size(49, 24);
            this.programmingLanguageCheckBox2.TabIndex = 1;
            this.programmingLanguageCheckBox2.Text = "C#";
            this.programmingLanguageCheckBox2.UseVisualStyleBackColor = true;
            this.programmingLanguageCheckBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // programmingLanguageCheckBox1
            // 
            this.programmingLanguageCheckBox1.AutoSize = true;
            this.programmingLanguageCheckBox1.Location = new System.Drawing.Point(16, 25);
            this.programmingLanguageCheckBox1.Name = "programmingLanguageCheckBox1";
            this.programmingLanguageCheckBox1.Size = new System.Drawing.Size(59, 24);
            this.programmingLanguageCheckBox1.TabIndex = 0;
            this.programmingLanguageCheckBox1.Text = "Java";
            this.programmingLanguageCheckBox1.UseVisualStyleBackColor = true;
            this.programmingLanguageCheckBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // formProgressBar
            // 
            this.formProgressBar.Location = new System.Drawing.Point(1, 0);
            this.formProgressBar.Maximum = 4;
            this.formProgressBar.Name = "formProgressBar";
            this.formProgressBar.Size = new System.Drawing.Size(489, 35);
            this.formProgressBar.Step = 1;
            this.formProgressBar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(109, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Programming Languages Known:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(109, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(103, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(51, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Favorite Quote:";
            // 
            // PersonalInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 369);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formProgressBar);
            this.Controls.Add(this.programmingLanguageGroupBox);
            this.Controls.Add(this.quoteTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "PersonalInformationForm";
            this.Text = "Personal Information Form";
            this.programmingLanguageGroupBox.ResumeLayout(false);
            this.programmingLanguageGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameTextBox;
        private TextBox addressTextBox;
        private TextBox quoteTextBox;
        private GroupBox programmingLanguageGroupBox;
        private CheckBox programmingLanguageCheckBox2;
        private CheckBox programmingLanguageCheckBox1;
        private System.Windows.Forms.ProgressBar formProgressBar;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
    }
}