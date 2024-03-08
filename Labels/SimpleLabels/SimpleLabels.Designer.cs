namespace CodeChum
{
    partial class SimpleLabels
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.Location = new System.Drawing.Point(86, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(172, 38);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Hello World!";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label2.Location = new System.Drawing.Point(49, 72);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(260, 38);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "I love programming";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label3.Location = new System.Drawing.Point(73, 125);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(228, 38);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "I love CodeChum";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label4.Location = new System.Drawing.Point(113, 173);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(125, 38);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "I love C#";
            // 
            // SimpleLabels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 234);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "SimpleLabels";
            this.Text = "Simple Labels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Label1;
        private Label Label2;
        private Label Label3;
        private Label Label4;
    }
}