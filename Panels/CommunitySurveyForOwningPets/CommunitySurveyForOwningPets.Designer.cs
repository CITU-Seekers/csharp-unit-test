namespace CodeChum
{
    partial class CommunitySurveyForOwningPets
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
            this.respondentPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.respondentNameTextBox = new System.Windows.Forms.TextBox();
            this.petDetailsPanel = new System.Windows.Forms.Panel();
            this.happyLevelsNumericControl = new System.Windows.Forms.NumericUpDown();
            this.petTypeTextBox = new System.Windows.Forms.TextBox();
            this.petNameTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.respondentPanel.SuspendLayout();
            this.petDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.happyLevelsNumericControl)).BeginInit();
            this.SuspendLayout();
            // 
            // respondentPanel
            // 
            this.respondentPanel.Controls.Add(this.label1);
            this.respondentPanel.Controls.Add(this.noRadioButton);
            this.respondentPanel.Controls.Add(this.yesRadioButton);
            this.respondentPanel.Controls.Add(this.respondentNameTextBox);
            this.respondentPanel.Location = new System.Drawing.Point(24, 21);
            this.respondentPanel.Name = "respondentPanel";
            this.respondentPanel.Size = new System.Drawing.Size(240, 137);
            this.respondentPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Do you own a pet?";
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Location = new System.Drawing.Point(80, 96);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(50, 24);
            this.noRadioButton.TabIndex = 2;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            this.noRadioButton.CheckedChanged += new System.EventHandler(this.NoRadioButton_CheckedChanged);
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Location = new System.Drawing.Point(15, 96);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(51, 24);
            this.yesRadioButton.TabIndex = 1;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            this.yesRadioButton.CheckedChanged += new System.EventHandler(this.YesRadioButton_CheckedChanged);
            // 
            // respondentNameTextBox
            // 
            this.respondentNameTextBox.Location = new System.Drawing.Point(15, 22);
            this.respondentNameTextBox.Name = "respondentNameTextBox";
            this.respondentNameTextBox.PlaceholderText = "Pet Owner Name";
            this.respondentNameTextBox.Size = new System.Drawing.Size(215, 27);
            this.respondentNameTextBox.TabIndex = 0;
            this.respondentNameTextBox.TextChanged += new System.EventHandler(this.RespondentNameTextBox_TextChanged);
            // 
            // petDetailsPanel
            // 
            this.petDetailsPanel.Controls.Add(this.happyLevelsNumericControl);
            this.petDetailsPanel.Controls.Add(this.petTypeTextBox);
            this.petDetailsPanel.Controls.Add(this.petNameTextBox);
            this.petDetailsPanel.Location = new System.Drawing.Point(281, 21);
            this.petDetailsPanel.Name = "petDetailsPanel";
            this.petDetailsPanel.Size = new System.Drawing.Size(222, 137);
            this.petDetailsPanel.TabIndex = 1;
            this.petDetailsPanel.Visible = false;
            // 
            // happyLevelsNumericControl
            // 
            this.happyLevelsNumericControl.Location = new System.Drawing.Point(20, 84);
            this.happyLevelsNumericControl.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.happyLevelsNumericControl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.happyLevelsNumericControl.Name = "happyLevelsNumericControl";
            this.happyLevelsNumericControl.Size = new System.Drawing.Size(175, 27);
            this.happyLevelsNumericControl.TabIndex = 2;
            this.happyLevelsNumericControl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // petTypeTextBox
            // 
            this.petTypeTextBox.Location = new System.Drawing.Point(20, 53);
            this.petTypeTextBox.Name = "petTypeTextBox";
            this.petTypeTextBox.PlaceholderText = "Pet Type";
            this.petTypeTextBox.Size = new System.Drawing.Size(176, 27);
            this.petTypeTextBox.TabIndex = 1;
            this.petTypeTextBox.TextChanged += new System.EventHandler(this.PetTypeTextBox_TextChanged);
            // 
            // petNameTextBox
            // 
            this.petNameTextBox.Location = new System.Drawing.Point(20, 22);
            this.petNameTextBox.Name = "petNameTextBox";
            this.petNameTextBox.PlaceholderText = "Pet Name";
            this.petNameTextBox.Size = new System.Drawing.Size(176, 27);
            this.petNameTextBox.TabIndex = 0;
            this.petNameTextBox.TextChanged += new System.EventHandler(this.PetNameTextBox_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Enabled = false;
            this.submitButton.Location = new System.Drawing.Point(420, 163);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(84, 25);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CommunitySurveyForOwningPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 208);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.petDetailsPanel);
            this.Controls.Add(this.respondentPanel);
            this.Name = "CommunitySurveyForOwningPets";
            this.Text = "Community Survey for Owning Pets";
            this.respondentPanel.ResumeLayout(false);
            this.respondentPanel.PerformLayout();
            this.petDetailsPanel.ResumeLayout(false);
            this.petDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.happyLevelsNumericControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel respondentPanel;
        private Label label1;
        private RadioButton noRadioButton;
        private RadioButton yesRadioButton;
        private TextBox respondentNameTextBox;
        private Panel petDetailsPanel;
        private NumericUpDown happyLevelsNumericControl;
        private TextBox petTypeTextBox;
        private TextBox petNameTextBox;
        private Button submitButton;
    }
}