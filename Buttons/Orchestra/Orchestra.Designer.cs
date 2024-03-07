namespace CodeChum
{
    partial class Orchestra
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
            btnViolins = new Button();
            btnCellos = new Button();
            btnTrumpets = new Button();
            btnDrums = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // btnViolins
            // 
            btnViolins.Location = new Point(117, 140);
            btnViolins.Name = "btnViolins";
            btnViolins.Size = new Size(112, 42);
            btnViolins.TabIndex = 0;
            btnViolins.Text = "Violins";
            btnViolins.UseVisualStyleBackColor = true;
            btnViolins.Click += btnViolins_Click;
            // 
            // btnCellos
            // 
            btnCellos.Location = new Point(265, 140);
            btnCellos.Name = "btnCellos";
            btnCellos.Size = new Size(100, 42);
            btnCellos.TabIndex = 1;
            btnCellos.Text = "Cellos";
            btnCellos.UseVisualStyleBackColor = true;
            btnCellos.Click += btnCellos_Click;
            // 
            // btnTrumpets
            // 
            btnTrumpets.Location = new Point(411, 140);
            btnTrumpets.Name = "btnTrumpets";
            btnTrumpets.Size = new Size(100, 42);
            btnTrumpets.TabIndex = 2;
            btnTrumpets.Text = "Trumpets";
            btnTrumpets.UseVisualStyleBackColor = true;
            btnTrumpets.Click += btnTrumpets_Click;
            // 
            // btnDrums
            // 
            btnDrums.Location = new Point(557, 140);
            btnDrums.Name = "btnDrums";
            btnDrums.Size = new Size(100, 42);
            btnDrums.TabIndex = 3;
            btnDrums.Text = "Drums";
            btnDrums.UseVisualStyleBackColor = true;
            btnDrums.Click += btnDrums_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(327, 246);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(38, 15);
            lblMessage.TabIndex = 4;
            lblMessage.Text = "label1";
            // 
            // Orchestra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMessage);
            Controls.Add(btnDrums);
            Controls.Add(btnTrumpets);
            Controls.Add(btnCellos);
            Controls.Add(btnViolins);
            Name = "Orchestra";
            Text = "Orchestra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViolins;
        private Button btnCellos;
        private Button btnTrumpets;
        private Button btnDrums;
        private Label lblMessage;
    }
}