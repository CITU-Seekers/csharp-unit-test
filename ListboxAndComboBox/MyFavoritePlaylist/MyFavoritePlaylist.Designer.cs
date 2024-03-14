namespace CodeChum
{
    partial class MyFavoritePlaylist
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
            this.components = new System.ComponentModel.Container();
            this.addToFavoritesButton = new System.Windows.Forms.Button();
            this.favoritesListBox = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.musicTextBox = new System.Windows.Forms.TextBox();
            this.regularListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // addToFavoritesButton
            // 
            this.addToFavoritesButton.Location = new System.Drawing.Point(207, 149);
            this.addToFavoritesButton.Name = "addToFavoritesButton";
            this.addToFavoritesButton.Size = new System.Drawing.Size(38, 35);
            this.addToFavoritesButton.TabIndex = 11;
            this.addToFavoritesButton.Text = ">";
            this.toolTip1.SetToolTip(this.addToFavoritesButton, "Add to Favorites");
            this.addToFavoritesButton.UseVisualStyleBackColor = true;
            this.addToFavoritesButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // favoritesListBox
            // 
            this.favoritesListBox.FormattingEnabled = true;
            this.favoritesListBox.ItemHeight = 20;
            this.favoritesListBox.Location = new System.Drawing.Point(262, 56);
            this.favoritesListBox.Name = "favoritesListBox";
            this.favoritesListBox.Size = new System.Drawing.Size(173, 224);
            this.favoritesListBox.TabIndex = 10;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(244, 348);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(132, 36);
            this.removeButton.TabIndex = 9;
            this.removeButton.Text = "Remove Music";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(77, 348);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(139, 36);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add Music";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // musicTextBox
            // 
            this.musicTextBox.Location = new System.Drawing.Point(77, 304);
            this.musicTextBox.Name = "musicTextBox";
            this.musicTextBox.PlaceholderText = "Title";
            this.musicTextBox.Size = new System.Drawing.Size(299, 27);
            this.musicTextBox.TabIndex = 7;
            // 
            // regularListBox
            // 
            this.regularListBox.FormattingEnabled = true;
            this.regularListBox.ItemHeight = 20;
            this.regularListBox.Location = new System.Drawing.Point(27, 56);
            this.regularListBox.Name = "regularListBox";
            this.regularListBox.Size = new System.Drawing.Size(160, 224);
            this.regularListBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Regular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(305, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Favorites";
            // 
            // MyFavoritePlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addToFavoritesButton);
            this.Controls.Add(this.favoritesListBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.musicTextBox);
            this.Controls.Add(this.regularListBox);
            this.Name = "MyFavoritePlaylist";
            this.Text = "My Favorites Playlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addToFavoritesButton;
        private ListBox favoritesListBox;
        private Button removeButton;
        private Button addButton;
        private TextBox musicTextBox;
        private ListBox regularListBox;
        private ToolTip toolTip1;
        private Label label1;
        private Label label2;
    }
}