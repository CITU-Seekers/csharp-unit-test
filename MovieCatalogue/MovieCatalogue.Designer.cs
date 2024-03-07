namespace CodeChum
{
    partial class MovieCatalogue
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
            ComedyList = new System.Windows.Forms.ListBox();
            HorrorList = new System.Windows.Forms.ListBox();
            ActionList = new System.Windows.Forms.ListBox();
            MovieName = new TextBox();
            cboGenre = new System.Windows.Forms.ComboBox();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // ComedyList
            // 
            ComedyList.FormattingEnabled = true;
            ComedyList.ItemHeight = 15;
            ComedyList.Location = new Point(94, 64);
            ComedyList.Name = "ComedyList";
            ComedyList.Size = new Size(168, 169);
            ComedyList.TabIndex = 0;
            // 
            // HorrorList
            // 
            HorrorList.FormattingEnabled = true;
            HorrorList.ItemHeight = 15;
            HorrorList.Location = new Point(293, 64);
            HorrorList.Name = "HorrorList";
            HorrorList.Size = new Size(168, 169);
            HorrorList.TabIndex = 1;
            // 
            // ActionList
            // 
            ActionList.FormattingEnabled = true;
            ActionList.ItemHeight = 15;
            ActionList.Location = new Point(496, 64);
            ActionList.Name = "ActionList";
            ActionList.Size = new Size(168, 169);
            ActionList.TabIndex = 2;
            // 
            // MovieName
            // 
            MovieName.Location = new Point(171, 265);
            MovieName.Name = "MovieName";
            MovieName.Size = new Size(270, 23);
            MovieName.TabIndex = 3;
            // 
            // cboGenre
            // 
            cboGenre.FormattingEnabled = true;
            cboGenre.Items.AddRange(new object[] { "Comedy", "Horror", "Action" });
            cboGenre.Location = new Point(468, 265);
            cboGenre.Name = "cboGenre";
            cboGenre.Size = new Size(121, 23);
            cboGenre.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(351, 319);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add Movie";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 46);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 6;
            label1.Text = "Comedy Movies";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 46);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 7;
            label2.Text = "Horror Movies";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(496, 46);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 8;
            label3.Text = "Action Movies";
            // 
            // MovieCatalogue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(cboGenre);
            Controls.Add(MovieName);
            Controls.Add(ActionList);
            Controls.Add(HorrorList);
            Controls.Add(ComedyList);
            Name = "MovieCatalogue";
            Text = "MovieCatalogue";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox ComedyList;
        private System.Windows.Forms.ListBox HorrorList;
        private System.Windows.Forms.ListBox ActionList;
        private TextBox MovieName;
        private System.Windows.Forms.ComboBox cboGenre;
        private Button btnAdd;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}