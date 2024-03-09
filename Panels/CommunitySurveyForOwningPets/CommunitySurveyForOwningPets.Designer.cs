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
            this.RespondentPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NoRadioButton = new System.Windows.Forms.RadioButton();
            this.YesRadioButton = new System.Windows.Forms.RadioButton();
            this.RespondentNameTextBox = new System.Windows.Forms.TextBox();
            this.PetDetailsPanel = new System.Windows.Forms.Panel();
            this.HappyLevelsNumericControl = new System.Windows.Forms.NumericUpDown();
            this.PetTypeTextBox = new System.Windows.Forms.TextBox();
            this.PetNameTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.RespondentPanel.SuspendLayout();
            this.PetDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HappyLevelsNumericControl)).BeginInit();
            this.SuspendLayout();
            // 
            // RespondentPanel
            // 
            this.RespondentPanel.Controls.Add(this.label1);
            this.RespondentPanel.Controls.Add(this.NoRadioButton);
            this.RespondentPanel.Controls.Add(this.YesRadioButton);
            this.RespondentPanel.Controls.Add(this.RespondentNameTextBox);
            this.RespondentPanel.Location = new System.Drawing.Point(24, 21);
            this.RespondentPanel.Name = "RespondentPanel";
            this.RespondentPanel.Size = new System.Drawing.Size(240, 137);
            this.RespondentPanel.TabIndex = 0;
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
            // NoRadioButton
            // 
            this.NoRadioButton.AutoSize = true;
            this.NoRadioButton.Location = new System.Drawing.Point(80, 96);
            this.NoRadioButton.Name = "NoRadioButton";
            this.NoRadioButton.Size = new System.Drawing.Size(50, 24);
            this.NoRadioButton.TabIndex = 2;
            this.NoRadioButton.TabStop = true;
            this.NoRadioButton.Text = "No";
            this.NoRadioButton.UseVisualStyleBackColor = true;
            this.NoRadioButton.CheckedChanged += new System.EventHandler(this.NoRadioButton_CheckedChanged);
            // 
            // YesRadioButton
            // 
            this.YesRadioButton.AutoSize = true;
            this.YesRadioButton.Location = new System.Drawing.Point(15, 96);
            this.YesRadioButton.Name = "YesRadioButton";
            this.YesRadioButton.Size = new System.Drawing.Size(51, 24);
            this.YesRadioButton.TabIndex = 1;
            this.YesRadioButton.TabStop = true;
            this.YesRadioButton.Text = "Yes";
            this.YesRadioButton.UseVisualStyleBackColor = true;
            this.YesRadioButton.CheckedChanged += new System.EventHandler(this.YesRadioButton_CheckedChanged);
            // 
            // RespondentNameTextBox
            // 
            this.RespondentNameTextBox.Location = new System.Drawing.Point(15, 22);
            this.RespondentNameTextBox.Name = "RespondentNameTextBox";
            this.RespondentNameTextBox.PlaceholderText = "Pet Owner Name";
            this.RespondentNameTextBox.Size = new System.Drawing.Size(215, 27);
            this.RespondentNameTextBox.TabIndex = 0;
            this.RespondentNameTextBox.TextChanged += new System.EventHandler(this.RespondentNameTextBox_TextChanged);
            // 
            // PetDetailsPanel
            // 
            this.PetDetailsPanel.Controls.Add(this.HappyLevelsNumericControl);
            this.PetDetailsPanel.Controls.Add(this.PetTypeTextBox);
            this.PetDetailsPanel.Controls.Add(this.PetNameTextBox);
            this.PetDetailsPanel.Location = new System.Drawing.Point(281, 21);
            this.PetDetailsPanel.Name = "PetDetailsPanel";
            this.PetDetailsPanel.Size = new System.Drawing.Size(222, 137);
            this.PetDetailsPanel.TabIndex = 1;
            this.PetDetailsPanel.Visible = false;
            // 
            // HappyLevelsNumericControl
            // 
            this.HappyLevelsNumericControl.Location = new System.Drawing.Point(20, 84);
            this.HappyLevelsNumericControl.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.HappyLevelsNumericControl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HappyLevelsNumericControl.Name = "HappyLevelsNumericControl";
            this.HappyLevelsNumericControl.Size = new System.Drawing.Size(175, 27);
            this.HappyLevelsNumericControl.TabIndex = 2;
            this.HappyLevelsNumericControl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PetTypeTextBox
            // 
            this.PetTypeTextBox.Location = new System.Drawing.Point(20, 53);
            this.PetTypeTextBox.Name = "PetTypeTextBox";
            this.PetTypeTextBox.PlaceholderText = "Pet Type";
            this.PetTypeTextBox.Size = new System.Drawing.Size(176, 27);
            this.PetTypeTextBox.TabIndex = 1;
            this.PetTypeTextBox.TextChanged += new System.EventHandler(this.PetTypeTextBox_TextChanged);
            // 
            // PetNameTextBox
            // 
            this.PetNameTextBox.Location = new System.Drawing.Point(20, 22);
            this.PetNameTextBox.Name = "PetNameTextBox";
            this.PetNameTextBox.PlaceholderText = "Pet Name";
            this.PetNameTextBox.Size = new System.Drawing.Size(176, 27);
            this.PetNameTextBox.TabIndex = 0;
            this.PetNameTextBox.TextChanged += new System.EventHandler(this.PetNameTextBox_TextChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Enabled = false;
            this.SubmitButton.Location = new System.Drawing.Point(420, 163);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(84, 25);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CommunitySurveyForOwningPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 208);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PetDetailsPanel);
            this.Controls.Add(this.RespondentPanel);
            this.Name = "CommunitySurveyForOwningPets";
            this.Text = "Community Survey for Owning Pets";
            this.RespondentPanel.ResumeLayout(false);
            this.RespondentPanel.PerformLayout();
            this.PetDetailsPanel.ResumeLayout(false);
            this.PetDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HappyLevelsNumericControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel RespondentPanel;
        private Label label1;
        private RadioButton NoRadioButton;
        private RadioButton YesRadioButton;
        private TextBox RespondentNameTextBox;
        private Panel PetDetailsPanel;
        private NumericUpDown HappyLevelsNumericControl;
        private TextBox PetTypeTextBox;
        private TextBox PetNameTextBox;
        private Button SubmitButton;
    }
}