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
            comedyListBox = new ListBox();
            horrorListBox = new ListBox();
            actionListBox = new ListBox();
            movieNameTextBox = new TextBox();
            genreComboBox = new ComboBox();
            addMovieButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // comedyListBox
            // 
            comedyListBox.FormattingEnabled = true;
            comedyListBox.ItemHeight = 15;
            comedyListBox.Location = new Point(94, 64);
            comedyListBox.Name = "comedyListBox";
            comedyListBox.Size = new Size(168, 169);
            comedyListBox.TabIndex = 0;
            // 
            // horrorListBox
            // 
            horrorListBox.FormattingEnabled = true;
            horrorListBox.ItemHeight = 15;
            horrorListBox.Location = new Point(293, 64);
            horrorListBox.Name = "horrorListBox";
            horrorListBox.Size = new Size(168, 169);
            horrorListBox.TabIndex = 1;
            // 
            // actionListBox
            // 
            actionListBox.FormattingEnabled = true;
            actionListBox.ItemHeight = 15;
            actionListBox.Location = new Point(496, 64);
            actionListBox.Name = "actionListBox";
            actionListBox.Size = new Size(168, 169);
            actionListBox.TabIndex = 2;
            // 
            // movieNameTextBox
            // 
            movieNameTextBox.Location = new Point(171, 265);
            movieNameTextBox.Name = "movieNameTextBox";
            movieNameTextBox.Size = new Size(270, 23);
            movieNameTextBox.TabIndex = 3;
            // 
            // genreComboBox
            // 
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Items.AddRange(new object[] { "Comedy", "Horror", "Action" });
            genreComboBox.Location = new Point(468, 265);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(121, 23);
            genreComboBox.TabIndex = 4;
            // 
            // addMovieButton
            // 
            addMovieButton.Location = new Point(351, 319);
            addMovieButton.Name = "addMovieButton";
            addMovieButton.Size = new Size(75, 23);
            addMovieButton.TabIndex = 5;
            addMovieButton.Text = "Add Movie";
            addMovieButton.UseVisualStyleBackColor = true;
            addMovieButton.Click += btnAdd_Click;
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
            Controls.Add(addMovieButton);
            Controls.Add(genreComboBox);
            Controls.Add(movieNameTextBox);
            Controls.Add(actionListBox);
            Controls.Add(horrorListBox);
            Controls.Add(comedyListBox);
            Name = "MovieCatalogue";
            Text = "MovieCatalogue";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox comedyListBox;
        private System.Windows.Forms.ListBox horrorListBox;
        private System.Windows.Forms.ListBox actionListBox;
        private TextBox movieNameTextBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private Button addMovieButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}