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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.QuoteTextBox = new System.Windows.Forms.TextBox();
            this.ProgrammingLanguageGroupBox = new System.Windows.Forms.GroupBox();
            this.ProgrammingLanguageCheckBox2 = new System.Windows.Forms.CheckBox();
            this.ProgrammingLanguageCheckBox1 = new System.Windows.Forms.CheckBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProgrammingLanguageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(192, 78);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(238, 27);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(192, 125);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(238, 27);
            this.AddressTextBox.TabIndex = 1;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // QuoteTextBox
            // 
            this.QuoteTextBox.Location = new System.Drawing.Point(192, 170);
            this.QuoteTextBox.Name = "QuoteTextBox";
            this.QuoteTextBox.Size = new System.Drawing.Size(238, 27);
            this.QuoteTextBox.TabIndex = 2;
            this.QuoteTextBox.TextChanged += new System.EventHandler(this.QuoteTextBox_TextChanged);
            // 
            // ProgrammingLanguageGroupBox
            // 
            this.ProgrammingLanguageGroupBox.Controls.Add(this.ProgrammingLanguageCheckBox2);
            this.ProgrammingLanguageGroupBox.Controls.Add(this.ProgrammingLanguageCheckBox1);
            this.ProgrammingLanguageGroupBox.Location = new System.Drawing.Point(163, 241);
            this.ProgrammingLanguageGroupBox.Name = "ProgrammingLanguageGroupBox";
            this.ProgrammingLanguageGroupBox.Size = new System.Drawing.Size(145, 95);
            this.ProgrammingLanguageGroupBox.TabIndex = 3;
            this.ProgrammingLanguageGroupBox.TabStop = false;
            // 
            // ProgrammingLanguageCheckBox2
            // 
            this.ProgrammingLanguageCheckBox2.AutoSize = true;
            this.ProgrammingLanguageCheckBox2.Location = new System.Drawing.Point(16, 62);
            this.ProgrammingLanguageCheckBox2.Name = "ProgrammingLanguageCheckBox2";
            this.ProgrammingLanguageCheckBox2.Size = new System.Drawing.Size(49, 24);
            this.ProgrammingLanguageCheckBox2.TabIndex = 1;
            this.ProgrammingLanguageCheckBox2.Text = "C#";
            this.ProgrammingLanguageCheckBox2.UseVisualStyleBackColor = true;
            this.ProgrammingLanguageCheckBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ProgrammingLanguageCheckBox1
            // 
            this.ProgrammingLanguageCheckBox1.AutoSize = true;
            this.ProgrammingLanguageCheckBox1.Location = new System.Drawing.Point(16, 25);
            this.ProgrammingLanguageCheckBox1.Name = "ProgrammingLanguageCheckBox1";
            this.ProgrammingLanguageCheckBox1.Size = new System.Drawing.Size(59, 24);
            this.ProgrammingLanguageCheckBox1.TabIndex = 0;
            this.ProgrammingLanguageCheckBox1.Text = "Java";
            this.ProgrammingLanguageCheckBox1.UseVisualStyleBackColor = true;
            this.ProgrammingLanguageCheckBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(1, 0);
            this.ProgressBar.Maximum = 4;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(489, 35);
            this.ProgressBar.Step = 1;
            this.ProgressBar.TabIndex = 4;
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
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ProgrammingLanguageGroupBox);
            this.Controls.Add(this.QuoteTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "PersonalInformationForm";
            this.Text = "Personal Information Form";
            this.ProgrammingLanguageGroupBox.ResumeLayout(false);
            this.ProgrammingLanguageGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NameTextBox;
        private TextBox AddressTextBox;
        private TextBox QuoteTextBox;
        private GroupBox ProgrammingLanguageGroupBox;
        private CheckBox ProgrammingLanguageCheckBox2;
        private CheckBox ProgrammingLanguageCheckBox1;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
    }
}