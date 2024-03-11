using PetDetectiveAgency.Properties;

namespace CodeChum
{
    partial class PetDetectiveAgency
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
            MainTabControl = new TabControl();
            tabPage1 = new TabPage();
            CreateButton = new Button();
            pictureBox1 = new PictureBox();
            txtStatements = new TextBox();
            txtClues = new TextBox();
            txtPetType = new TextBox();
            txtPetName = new TextBox();
            MainTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(tabPage1);
            MainTabControl.Location = new Point(12, 12);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(651, 395);
            MainTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(CreateButton);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(txtStatements);
            tabPage1.Controls.Add(txtClues);
            tabPage1.Controls.Add(txtPetType);
            tabPage1.Controls.Add(txtPetName);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(643, 367);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Form";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(426, 298);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(83, 28);
            CreateButton.TabIndex = 5;
            CreateButton.Text = "Create File";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.golden_retriever_puppy;
            pictureBox1.Location = new Point(360, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtStatements
            // 
            txtStatements.Location = new Point(64, 227);
            txtStatements.Multiline = true;
            txtStatements.Name = "txtStatements";
            txtStatements.PlaceholderText = "Witness Statements";
            txtStatements.Size = new Size(239, 99);
            txtStatements.TabIndex = 3;
            // 
            // txtClues
            // 
            txtClues.Location = new Point(64, 122);
            txtClues.Multiline = true;
            txtClues.Name = "txtClues";
            txtClues.PlaceholderText = "Clues Gathered";
            txtClues.Size = new Size(239, 99);
            txtClues.TabIndex = 2;
            // 
            // txtPetType
            // 
            txtPetType.Location = new Point(64, 81);
            txtPetType.Name = "txtPetType";
            txtPetType.PlaceholderText = "Pet Type";
            txtPetType.Size = new Size(239, 23);
            txtPetType.TabIndex = 1;
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(64, 42);
            txtPetName.Name = "txtPetName";
            txtPetName.PlaceholderText = "Pet Name";
            txtPetName.Size = new Size(239, 23);
            txtPetName.TabIndex = 0;
            // 
            // PetDetectiveAgency
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 429);
            Controls.Add(MainTabControl);
            Name = "PetDetectiveAgency";
            Text = "PetDetectiveAgency";
            MainTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabControl;
        private TabPage tabPage1;
        private TextBox txtPetName;
        private TextBox txtClues;
        private TextBox txtPetType;
        private Button CreateButton;
        private PictureBox pictureBox1;
        private TextBox txtStatements;
    }
}