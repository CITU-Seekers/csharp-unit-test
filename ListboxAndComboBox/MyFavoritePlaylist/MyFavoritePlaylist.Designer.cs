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
            this.AddToFavoritesButton = new System.Windows.Forms.Button();
            this.FavoritesListBox = new System.Windows.Forms.ListBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.MusicTextBox = new System.Windows.Forms.TextBox();
            this.RegularListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // AddToFavoritesButton
            // 
            this.AddToFavoritesButton.Location = new System.Drawing.Point(207, 149);
            this.AddToFavoritesButton.Name = "AddToFavoritesButton";
            this.AddToFavoritesButton.Size = new System.Drawing.Size(38, 35);
            this.AddToFavoritesButton.TabIndex = 11;
            this.AddToFavoritesButton.Text = ">";
            this.toolTip1.SetToolTip(this.AddToFavoritesButton, "Add to Favorites");
            this.AddToFavoritesButton.UseVisualStyleBackColor = true;
            this.AddToFavoritesButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // FavoritesListBox
            // 
            this.FavoritesListBox.FormattingEnabled = true;
            this.FavoritesListBox.ItemHeight = 20;
            this.FavoritesListBox.Location = new System.Drawing.Point(262, 56);
            this.FavoritesListBox.Name = "FavoritesListBox";
            this.FavoritesListBox.Size = new System.Drawing.Size(173, 224);
            this.FavoritesListBox.TabIndex = 10;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(244, 348);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(132, 36);
            this.RemoveButton.TabIndex = 9;
            this.RemoveButton.Text = "Remove Music";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(77, 348);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(139, 36);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add Music";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MusicTextBox
            // 
            this.MusicTextBox.Location = new System.Drawing.Point(77, 304);
            this.MusicTextBox.Name = "MusicTextBox";
            this.MusicTextBox.PlaceholderText = "Title";
            this.MusicTextBox.Size = new System.Drawing.Size(299, 27);
            this.MusicTextBox.TabIndex = 7;
            // 
            // RegularListBox
            // 
            this.RegularListBox.FormattingEnabled = true;
            this.RegularListBox.ItemHeight = 20;
            this.RegularListBox.Location = new System.Drawing.Point(27, 56);
            this.RegularListBox.Name = "RegularListBox";
            this.RegularListBox.Size = new System.Drawing.Size(160, 224);
            this.RegularListBox.TabIndex = 6;
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
            this.Controls.Add(this.AddToFavoritesButton);
            this.Controls.Add(this.FavoritesListBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MusicTextBox);
            this.Controls.Add(this.RegularListBox);
            this.Name = "MyFavoritePlaylist";
            this.Text = "My Favorites Playlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddToFavoritesButton;
        private ListBox FavoritesListBox;
        private Button RemoveButton;
        private Button AddButton;
        private TextBox MusicTextBox;
        private ListBox RegularListBox;
        private ToolTip toolTip1;
        private Label label1;
        private Label label2;
    }
}