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
            mainTabControl = new TabControl();
            homeTabPage = new TabPage();
            sloganLabel = new Label();
            companyNameLabel = new Label();
            registerTabPage = new TabPage();
            registerButton = new Button();
            passwordTextBox = new TextBox();
            emailTextBox = new TextBox();
            nameTextBox = new TextBox();
            aboutTabPage = new TabPage();
            aboutLabel = new Label();
            mainTabControl.SuspendLayout();
            homeTabPage.SuspendLayout();
            registerTabPage.SuspendLayout();
            aboutTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(homeTabPage);
            mainTabControl.Controls.Add(registerTabPage);
            mainTabControl.Controls.Add(aboutTabPage);
            mainTabControl.Location = new Point(4, 2);
            mainTabControl.Margin = new Padding(3, 2, 3, 2);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(598, 271);
            mainTabControl.TabIndex = 0;
            // 
            // homeTabPage
            // 
            homeTabPage.Controls.Add(sloganLabel);
            homeTabPage.Controls.Add(companyNameLabel);
            homeTabPage.Location = new Point(4, 24);
            homeTabPage.Margin = new Padding(3, 2, 3, 2);
            homeTabPage.Name = "homeTabPage";
            homeTabPage.Padding = new Padding(3, 2, 3, 2);
            homeTabPage.Size = new Size(590, 243);
            homeTabPage.TabIndex = 0;
            homeTabPage.Text = "Home";
            homeTabPage.UseVisualStyleBackColor = true;
            homeTabPage.Click += HomeTabPage_Click;
            // 
            // sloganLabel
            // 
            sloganLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            sloganLabel.Location = new Point(108, 118);
            sloganLabel.Name = "sloganLabel";
            sloganLabel.Size = new Size(318, 62);
            sloganLabel.TabIndex = 1;
            sloganLabel.Text = "Best of the best";
            sloganLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // companyNameLabel
            // 
            companyNameLabel.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            companyNameLabel.Location = new Point(116, 39);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new Size(318, 62);
            companyNameLabel.TabIndex = 0;
            companyNameLabel.Text = "Company X";
            companyNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // registerTabPage
            // 
            registerTabPage.Controls.Add(registerButton);
            registerTabPage.Controls.Add(passwordTextBox);
            registerTabPage.Controls.Add(emailTextBox);
            registerTabPage.Controls.Add(nameTextBox);
            registerTabPage.Location = new Point(4, 24);
            registerTabPage.Margin = new Padding(3, 2, 3, 2);
            registerTabPage.Name = "registerTabPage";
            registerTabPage.Padding = new Padding(3, 2, 3, 2);
            registerTabPage.Size = new Size(590, 243);
            registerTabPage.TabIndex = 1;
            registerTabPage.Text = "Register";
            registerTabPage.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(230, 160);
            registerButton.Margin = new Padding(3, 2, 3, 2);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(111, 25);
            registerButton.TabIndex = 3;
            registerButton.Text = "Register ";
            registerButton.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(131, 121);
            passwordTextBox.Margin = new Padding(3, 2, 3, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(316, 23);
            passwordTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(131, 83);
            emailTextBox.Margin = new Padding(3, 2, 3, 2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Email";
            emailTextBox.Size = new Size(316, 23);
            emailTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(131, 52);
            nameTextBox.Margin = new Padding(3, 2, 3, 2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Name";
            nameTextBox.Size = new Size(316, 23);
            nameTextBox.TabIndex = 0;
            // 
            // aboutTabPage
            // 
            aboutTabPage.Controls.Add(aboutLabel);
            aboutTabPage.Location = new Point(4, 24);
            aboutTabPage.Margin = new Padding(3, 2, 3, 2);
            aboutTabPage.Name = "aboutTabPage";
            aboutTabPage.Padding = new Padding(3, 2, 3, 2);
            aboutTabPage.Size = new Size(590, 243);
            aboutTabPage.TabIndex = 2;
            aboutTabPage.Text = "About";
            aboutTabPage.UseVisualStyleBackColor = true;
            // 
            // aboutLabel
            // 
            aboutLabel.Location = new Point(172, 82);
            aboutLabel.Name = "aboutLabel";
            aboutLabel.Size = new Size(238, 64);
            aboutLabel.TabIndex = 0;
            aboutLabel.Text = "Company X is a company dedicated in helping our clients be connected.";
            // 
            // StaticWindowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 275);
            Controls.Add(mainTabControl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StaticWindowForm";
            Text = "Company X";
            mainTabControl.ResumeLayout(false);
            homeTabPage.ResumeLayout(false);
            registerTabPage.ResumeLayout(false);
            registerTabPage.PerformLayout();
            aboutTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl mainTabControl;
        private TabPage homeTabPage;
        private Label sloganLabel;
        private Label companyNameLabel;
        private TabPage registerTabPage;
        private TabPage aboutTabPage;
        private Button registerButton;
        private TextBox passwordTextBox;
        private TextBox emailTextBox;
        private TextBox nameTextBox;
        private Label aboutLabel;
    }
}