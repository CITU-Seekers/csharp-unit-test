namespace CodeChum
{
    partial class ClassCreationApp
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
            classCodeLabel = new Label();
            classScheduleLabel = new Label();
            classNameLabel = new Label();
            createButton = new Button();
            classDescriptionLabel = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblClassCode
            // 
            classCodeLabel.AutoSize = true;
            classCodeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            classCodeLabel.Location = new Point(124, 98);
            classCodeLabel.Name = "classCodeLabel";
            classCodeLabel.Size = new Size(0, 21);
            classCodeLabel.TabIndex = 20;
            // 
            // lblClassSched
            // 
            classScheduleLabel.AutoSize = true;
            classScheduleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            classScheduleLabel.Location = new Point(111, 66);
            classScheduleLabel.Name = "classScheduleLabel";
            classScheduleLabel.Size = new Size(0, 21);
            classScheduleLabel.TabIndex = 19;
            // 
            // lblClassName
            // 
            classNameLabel.AutoSize = true;
            classNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            classNameLabel.Location = new Point(90, 36);
            classNameLabel.Name = "classNameLabel";
            classNameLabel.Size = new Size(0, 21);
            classNameLabel.TabIndex = 18;
            // 
            // createButton
            // 
            createButton.Location = new Point(151, 276);
            createButton.Name = "createButton";
            createButton.Size = new Size(75, 23);
            createButton.TabIndex = 17;
            createButton.Text = "Create ";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += btnCreate_Click;
            // 
            // lblClassDesc
            // 
            classDescriptionLabel.AutoSize = true;
            classDescriptionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            classDescriptionLabel.Location = new Point(66, 163);
            classDescriptionLabel.Name = "classDescriptionLabel";
            classDescriptionLabel.Size = new Size(0, 21);
            classDescriptionLabel.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(35, 128);
            label6.Name = "label6";
            label6.Size = new Size(92, 21);
            label6.TabIndex = 15;
            label6.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(35, 98);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 14;
            label4.Text = "Class Code:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(35, 66);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 13;
            label3.Text = "Schedule:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 36);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 12;
            label2.Text = "Name:";
            // 
            // ClassCreationApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 341);
            Controls.Add(classCodeLabel);
            Controls.Add(classScheduleLabel);
            Controls.Add(classNameLabel);
            Controls.Add(createButton);
            Controls.Add(classDescriptionLabel);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "ClassCreationApp";
            Text = "ClassCreationApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label classCodeLabel;
        private Label classScheduleLabel;
        private Label classNameLabel;
        private Button createButton;
        private Label classDescriptionLabel;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}