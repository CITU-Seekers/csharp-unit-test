namespace CodeChum
{
    partial class StaticWindowForm
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.HomeTabPage = new System.Windows.Forms.TabPage();
            this.SloganLabel = new System.Windows.Forms.Label();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.RegisterTabPage = new System.Windows.Forms.TabPage();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AboutTabPage = new System.Windows.Forms.TabPage();
            this.AboutLabel = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.HomeTabPage.SuspendLayout();
            this.RegisterTabPage.SuspendLayout();
            this.AboutTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.HomeTabPage);
            this.TabControl.Controls.Add(this.RegisterTabPage);
            this.TabControl.Controls.Add(this.AboutTabPage);
            this.TabControl.Location = new System.Drawing.Point(4, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(684, 361);
            this.TabControl.TabIndex = 0;
            // 
            // HomeTabPage
            // 
            this.HomeTabPage.Controls.Add(this.SloganLabel);
            this.HomeTabPage.Controls.Add(this.CompanyNameLabel);
            this.HomeTabPage.Location = new System.Drawing.Point(4, 29);
            this.HomeTabPage.Name = "HomeTabPage";
            this.HomeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTabPage.Size = new System.Drawing.Size(676, 328);
            this.HomeTabPage.TabIndex = 0;
            this.HomeTabPage.Text = "Home";
            this.HomeTabPage.UseVisualStyleBackColor = true;
            // 
            // SloganLabel
            // 
            this.SloganLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SloganLabel.Location = new System.Drawing.Point(124, 157);
            this.SloganLabel.Name = "SloganLabel";
            this.SloganLabel.Size = new System.Drawing.Size(364, 83);
            this.SloganLabel.TabIndex = 1;
            this.SloganLabel.Text = "Best of the best";
            this.SloganLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CompanyNameLabel.Location = new System.Drawing.Point(133, 52);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(364, 83);
            this.CompanyNameLabel.TabIndex = 0;
            this.CompanyNameLabel.Text = "Company X";
            this.CompanyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterTabPage
            // 
            this.RegisterTabPage.Controls.Add(this.RegisterButton);
            this.RegisterTabPage.Controls.Add(this.PasswordTextBox);
            this.RegisterTabPage.Controls.Add(this.EmailTextBox);
            this.RegisterTabPage.Controls.Add(this.NameTextBox);
            this.RegisterTabPage.Location = new System.Drawing.Point(4, 29);
            this.RegisterTabPage.Name = "RegisterTabPage";
            this.RegisterTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RegisterTabPage.Size = new System.Drawing.Size(676, 328);
            this.RegisterTabPage.TabIndex = 1;
            this.RegisterTabPage.Text = "Register";
            this.RegisterTabPage.UseVisualStyleBackColor = true;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(263, 213);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(127, 33);
            this.RegisterButton.TabIndex = 3;
            this.RegisterButton.Text = "Register ";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(150, 161);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PlaceholderText = "Password";
            this.PasswordTextBox.Size = new System.Drawing.Size(360, 27);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(150, 111);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.PlaceholderText = "Email";
            this.EmailTextBox.Size = new System.Drawing.Size(360, 27);
            this.EmailTextBox.TabIndex = 1;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(150, 69);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PlaceholderText = "Name";
            this.NameTextBox.Size = new System.Drawing.Size(360, 27);
            this.NameTextBox.TabIndex = 0;
            // 
            // AboutTabPage
            // 
            this.AboutTabPage.Controls.Add(this.AboutLabel);
            this.AboutTabPage.Location = new System.Drawing.Point(4, 29);
            this.AboutTabPage.Name = "AboutTabPage";
            this.AboutTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AboutTabPage.Size = new System.Drawing.Size(676, 328);
            this.AboutTabPage.TabIndex = 2;
            this.AboutTabPage.Text = "About";
            this.AboutTabPage.UseVisualStyleBackColor = true;
            // 
            // AboutLabel
            // 
            this.AboutLabel.Location = new System.Drawing.Point(196, 110);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(272, 85);
            this.AboutLabel.TabIndex = 0;
            this.AboutLabel.Text = "Company X is a company dedicated in helping our clients be connected.";
            // 
            // StaticWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 367);
            this.Controls.Add(this.TabControl);
            this.Name = "StaticWindowForm";
            this.Text = "Company X";
            this.TabControl.ResumeLayout(false);
            this.HomeTabPage.ResumeLayout(false);
            this.RegisterTabPage.ResumeLayout(false);
            this.RegisterTabPage.PerformLayout();
            this.AboutTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl TabControl;
        private TabPage HomeTabPage;
        private Label SloganLabel;
        private Label CompanyNameLabel;
        private TabPage RegisterTabPage;
        private TabPage AboutTabPage;
        private Button RegisterButton;
        private TextBox PasswordTextBox;
        private TextBox EmailTextBox;
        private TextBox NameTextBox;
        private Label AboutLabel;
    }
}