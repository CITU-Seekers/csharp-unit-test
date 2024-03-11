using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChum
{
    public partial class TabbedTextEditor : Form
    {
        public TabbedTextEditor()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (FileNameTextBox.Text.Equals(string.Empty))
            {
                return;
            }
            TabPage newTabPage = new TabPage();
            newTabPage.Name = FileNameTextBox.Text + "TabPage";
            newTabPage.Text = FileNameTextBox.Text;
            newTabPage.Size = new System.Drawing.Size(796, 352);
            newTabPage.BackColor = Color.White;
            RichTextBox newRichTextBox = new RichTextBox();
            newRichTextBox.Location = new System.Drawing.Point(33, 44);
            newRichTextBox.Size = new System.Drawing.Size(641, 188);
            newRichTextBox.Name = FileNameTextBox.Text + "RichTextBox";
            newTabPage.Size = new System.Drawing.Size(796, 352);
            newTabPage.Controls.Add(newRichTextBox);
            EditorTabControl.TabPages.Add(newTabPage);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var tab = EditorTabControl.SelectedTab;
            EditorTabControl.SelectedTab = EditorTabControl.TabPages[EditorTabControl.SelectedIndex - 1];
            EditorTabControl.TabPages.Remove(tab);
        }

        private void EditorTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditorTabControl.SelectedTab == MainTabPage)
            {
                DeleteButton.Enabled = false;
            }
            else
            {
                DeleteButton.Enabled = true;
            }
        }
    }
}
