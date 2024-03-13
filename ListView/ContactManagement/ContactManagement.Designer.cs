namespace CodeChum
{
    partial class ContactManagement
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
            contactListView = new ListView();
            NameColumn = new ColumnHeader();
            Email = new ColumnHeader();
            PhoneNum = new ColumnHeader();
            Telecom = new ColumnHeader();
            nameTextBox = new TextBox();
            emailTextBox = new TextBox();
            phoneNumberTextBox = new TextBox();
            telecomComboBox = new ComboBox();
            addButton = new Button();
            updateButton = new Button();
            removeButton = new Button();
            SuspendLayout();
            // 
            // contactListView
            // 
            contactListView.Columns.AddRange(new ColumnHeader[] { NameColumn, Email, PhoneNum, Telecom });
            contactListView.Location = new Point(64, 32);
            contactListView.Name = "contactListView";
            contactListView.Size = new Size(541, 176);
            contactListView.TabIndex = 0;
            contactListView.UseCompatibleStateImageBehavior = false;
            contactListView.View = View.Details;
            // 
            // Name
            // 
            NameColumn.Text = "Name";
            NameColumn.Width = 150;
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.Width = 150;
            // 
            // PhoneNum
            // 
            PhoneNum.Text = "Phone Number";
            PhoneNum.Width = 120;
            // 
            // Telecom
            // 
            Telecom.Text = "Telecom";
            Telecom.Width = 100;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(64, 235);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Name";
            nameTextBox.Size = new Size(541, 23);
            nameTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(64, 273);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Email";
            emailTextBox.Size = new Size(541, 23);
            emailTextBox.TabIndex = 2;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(64, 312);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.PlaceholderText = "Phone Number";
            phoneNumberTextBox.Size = new Size(294, 23);
            phoneNumberTextBox.TabIndex = 3;
            // 
            // telecomComboBox
            // 
            telecomComboBox.FormattingEnabled = true;
            telecomComboBox.Items.AddRange(new object[] { "Smart", "Sun", "TNT", "Globe", "TM", "DITO" });
            telecomComboBox.Location = new Point(443, 312);
            telecomComboBox.Name = "telecomComboBox";
            telecomComboBox.Size = new Size(162, 23);
            telecomComboBox.TabIndex = 4;
            // 
            // addButton
            // 
            addButton.Location = new Point(114, 366);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += btnAdd_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(297, 366);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 6;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += btnUpdate_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(482, 366);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 23);
            removeButton.TabIndex = 7;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += btnRemove_Click;
            // 
            // ContactManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 450);
            Controls.Add(removeButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(telecomComboBox);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(contactListView);
            Name = "ContactManagement";
            Text = "ContactMangement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView contactListView;
        private ColumnHeader NameColumn;
        private ColumnHeader Email;
        private ColumnHeader PhoneNum;
        private ColumnHeader Telecom;
        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private TextBox phoneNumberTextBox;
        private System.Windows.Forms.ComboBox telecomComboBox;
        private Button addButton;
        private Button updateButton;
        private Button removeButton;
    }
}