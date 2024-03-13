using LayoutDesign.Properties;

namespace CodeChum
{
    partial class LayoutDesign
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
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "18-0142-382", "John Doe", "Cebu Institute of Technology" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "18-0382-282", "Jane Doesnt", "Mapua University" }, -1);
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            textBox = new TextBox();
            studentListView = new ListView();
            ID = new ColumnHeader();
            StudentName = new ColumnHeader();
            University = new ColumnHeader();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Orange;
            splitContainer1.Panel2.Controls.Add(pictureBox);
            splitContainer1.Size = new Size(875, 654);
            splitContainer1.SplitterDistance = 429;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.FixedPanel = FixedPanel.Panel1;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.Red;
            splitContainer2.Panel1.Controls.Add(textBox);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = SystemColors.ActiveCaption;
            splitContainer2.Panel2.Controls.Add(studentListView);
            splitContainer2.Size = new Size(429, 654);
            splitContainer2.SplitterDistance = 366;
            splitContainer2.TabIndex = 0;
            // 
            // textBox
            // 
            textBox.Font = new Font("Viner Hand ITC", 12F, FontStyle.Italic, GraphicsUnit.Point);
            textBox.Location = new Point(37, 88);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(333, 156);
            textBox.TabIndex = 0;
            // 
            // studentListView
            // 
            studentListView.Columns.AddRange(new ColumnHeader[] { ID, StudentName, University });
            studentListView.Items.AddRange(new ListViewItem[] { listViewItem3, listViewItem4 });
            studentListView.Location = new Point(12, 29);
            studentListView.Name = "studentListView";
            studentListView.Size = new Size(394, 221);
            studentListView.TabIndex = 0;
            studentListView.UseCompatibleStateImageBehavior = false;
            studentListView.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 100;
            // 
            // StudentName
            // 
            StudentName.Text = "Name";
            StudentName.Width = 120;
            // 
            // University
            // 
            University.Text = "University";
            University.Width = 170;
            // 
            // pictureBox
            // 
            pictureBox.Image = Resources.CodeChum2;
            pictureBox.Location = new Point(42, 188);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(356, 258);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // LayoutDesign
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 654);
            Controls.Add(splitContainer1);
            Name = "LayoutDesign";
            Text = "LayoutDesign";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TextBox textBox;
        private PictureBox pictureBox;
        private ListView studentListView;
        private ColumnHeader ID;
        private ColumnHeader StudentName;
        private ColumnHeader University;
    }
}