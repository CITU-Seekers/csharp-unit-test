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
            ContactList = new ListView();
            Name = new ColumnHeader();
            Email = new ColumnHeader();
            PhoneNum = new ColumnHeader();
            Telecom = new ColumnHeader();
            ContactName = new TextBox();
            ContactEmail = new TextBox();
            ContactNum = new TextBox();
            cboTelecom = new System.Windows.Forms.ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            SuspendLayout();
            // 
            // ContactList
            // 
            ContactList.Columns.AddRange(new ColumnHeader[] { Name, Email, PhoneNum, Telecom });
            ContactList.Location = new Point(64, 32);
            ContactList.Name = "ContactList";
            ContactList.Size = new Size(541, 176);
            ContactList.TabIndex = 0;
            ContactList.UseCompatibleStateImageBehavior = false;
            ContactList.View = View.Details;
            // 
            // Name
            // 
            Name.Text = "Name";
            Name.Width = 150;
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
            // ContactName
            // 
            ContactName.Location = new Point(64, 235);
            ContactName.Name = "ContactName";
            ContactName.PlaceholderText = "Name";
            ContactName.Size = new Size(541, 23);
            ContactName.TabIndex = 1;
            // 
            // ContactEmail
            // 
            ContactEmail.Location = new Point(64, 273);
            ContactEmail.Name = "ContactEmail";
            ContactEmail.PlaceholderText = "Email";
            ContactEmail.Size = new Size(541, 23);
            ContactEmail.TabIndex = 2;
            // 
            // ContactNum
            // 
            ContactNum.Location = new Point(64, 312);
            ContactNum.Name = "ContactNum";
            ContactNum.PlaceholderText = "Phone Number";
            ContactNum.Size = new Size(294, 23);
            ContactNum.TabIndex = 3;
            // 
            // cboTelecom
            // 
            cboTelecom.FormattingEnabled = true;
            cboTelecom.Items.AddRange(new object[] { "SMART", "Sun", "TNT", "Globe", "TM", "DITO" });
            cboTelecom.Location = new Point(443, 312);
            cboTelecom.Name = "cboTelecom";
            cboTelecom.Size = new Size(162, 23);
            cboTelecom.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(114, 366);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(297, 366);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(482, 366);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // ContactMangement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 450);
            Controls.Add(btnRemove);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cboTelecom);
            Controls.Add(ContactNum);
            Controls.Add(ContactEmail);
            Controls.Add(ContactName);
            Controls.Add(ContactList);
            //Name = "ContactMangement";
            Text = "ContactMangement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ContactList;
        private ColumnHeader Name;
        private ColumnHeader Email;
        private ColumnHeader PhoneNum;
        private ColumnHeader Telecom;
        private TextBox ContactName;
        private TextBox ContactEmail;
        private TextBox ContactNum;
        private System.Windows.Forms.ComboBox cboTelecom;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
    }
}