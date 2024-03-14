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
            mainTabControl = new TabControl();
            tabPage1 = new TabPage();
            createButton = new Button();
            pictureBox1 = new PictureBox();
            statementsTextBox = new TextBox();
            cluesTextBox = new TextBox();
            petTypeTextBox = new TextBox();
            petNameTextBox = new TextBox();
            mainTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(tabPage1);
            mainTabControl.Location = new Point(12, 12);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(651, 395);
            mainTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(createButton);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(statementsTextBox);
            tabPage1.Controls.Add(cluesTextBox);
            tabPage1.Controls.Add(petTypeTextBox);
            tabPage1.Controls.Add(petNameTextBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(643, 367);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Form";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            createButton.Location = new Point(426, 298);
            createButton.Name = "createButton";
            createButton.Size = new Size(83, 28);
            createButton.TabIndex = 5;
            createButton.Text = "Create File";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += CreateButton_Click;
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
            // statementsTextBox
            // 
            statementsTextBox.Location = new Point(64, 227);
            statementsTextBox.Multiline = true;
            statementsTextBox.Name = "statementsTextBox";
            statementsTextBox.PlaceholderText = "Witness Statements";
            statementsTextBox.Size = new Size(239, 99);
            statementsTextBox.TabIndex = 3;
            // 
            // cluesTextBox
            // 
            cluesTextBox.Location = new Point(64, 122);
            cluesTextBox.Multiline = true;
            cluesTextBox.Name = "cluesTextBox";
            cluesTextBox.PlaceholderText = "Clues Gathered";
            cluesTextBox.Size = new Size(239, 99);
            cluesTextBox.TabIndex = 2;
            // 
            // petTypeTextBox
            // 
            petTypeTextBox.Location = new Point(64, 81);
            petTypeTextBox.Name = "petTypeTextBox";
            petTypeTextBox.PlaceholderText = "Pet Type";
            petTypeTextBox.Size = new Size(239, 23);
            petTypeTextBox.TabIndex = 1;
            // 
            // petNameTextBox
            // 
            petNameTextBox.Location = new Point(64, 42);
            petNameTextBox.Name = "petNameTextBox";
            petNameTextBox.PlaceholderText = "Pet Name";
            petNameTextBox.Size = new Size(239, 23);
            petNameTextBox.TabIndex = 0;
            // 
            // PetDetectiveAgency
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 429);
            Controls.Add(mainTabControl);
            Name = "PetDetectiveAgency";
            Text = "PetDetectiveAgency";
            mainTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl mainTabControl;
        private TabPage tabPage1;
        private TextBox petNameTextBox;
        private TextBox cluesTextBox;
        private TextBox petTypeTextBox;
        private Button createButton;
        private PictureBox pictureBox1;
        private TextBox statementsTextBox;
    }
}