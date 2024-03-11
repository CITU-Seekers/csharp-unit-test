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
            lblClassCode = new Label();
            lblClassSched = new Label();
            lblClassName = new Label();
            btnCreate = new Button();
            lblClassDesc = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblClassCode
            // 
            lblClassCode.AutoSize = true;
            lblClassCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblClassCode.Location = new Point(124, 98);
            lblClassCode.Name = "lblClassCode";
            lblClassCode.Size = new Size(0, 21);
            lblClassCode.TabIndex = 20;
            // 
            // lblClassSched
            // 
            lblClassSched.AutoSize = true;
            lblClassSched.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblClassSched.Location = new Point(111, 66);
            lblClassSched.Name = "lblClassSched";
            lblClassSched.Size = new Size(0, 21);
            lblClassSched.TabIndex = 19;
            // 
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblClassName.Location = new Point(90, 36);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(0, 21);
            lblClassName.TabIndex = 18;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(151, 276);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 17;
            btnCreate.Text = "Create ";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblClassDesc
            // 
            lblClassDesc.AutoSize = true;
            lblClassDesc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblClassDesc.Location = new Point(66, 163);
            lblClassDesc.Name = "lblClassDesc";
            lblClassDesc.Size = new Size(0, 21);
            lblClassDesc.TabIndex = 16;
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
            Controls.Add(lblClassCode);
            Controls.Add(lblClassSched);
            Controls.Add(lblClassName);
            Controls.Add(btnCreate);
            Controls.Add(lblClassDesc);
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

        private Label lblClassCode;
        private Label lblClassSched;
        private Label lblClassName;
        private Button btnCreate;
        private Label lblClassDesc;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}