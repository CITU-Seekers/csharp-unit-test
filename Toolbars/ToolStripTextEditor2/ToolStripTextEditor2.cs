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
    public partial class ToolStripTextEditor2 : Form
    {
        public ToolStripTextEditor2()
        {
            InitializeComponent();
            fontComboBox.SelectedIndex = 0;
            fontSizeComboBox.SelectedIndex = 0;
        }

        public void onColorButtonClick(object sender, EventArgs e)
        {
            ToolStripButton button = sender as ToolStripButton;

            if (button.Name.Equals("blackButton"))
            {
                mainRichTextBox.ForeColor = Color.Black;
            }
            else if (button.Name.Equals("blueButton"))
            {
                mainRichTextBox.ForeColor = Color.Blue;
            }
            else if (button.Name.Equals("greenButton"))
            {
                mainRichTextBox.ForeColor = Color.Green;
            }
            else if (button.Name.Equals("redButton"))
            {
                mainRichTextBox.ForeColor = Color.Red;
            }
            else if (button.Name.Equals("yellowButton"))
            {
                mainRichTextBox.ForeColor = Color.Yellow;
            }
        }

        private void onEditorButtonsClick(object sender, EventArgs e)
        {
            ToolStripButton button = sender as ToolStripButton;

            if (button.Name.Equals("replaceAllButton"))
            {
                String newString = mainRichTextBox.Text.Replace(findTextBox.Text, replaceAllTextBox.Text);
                mainRichTextBox.Text = newString;
            }
            else
            {
                colorToolStrip.Visible = !colorToolStrip.Visible;
            }
        }

        private void onComboBoxSelectionChange(object sender, EventArgs e)
        {
            ToolStripComboBox comboBox = sender as ToolStripComboBox;

            if (fontSizeComboBox.SelectedItem is not null && fontComboBox.SelectedItem is not null)
            {
                if (comboBox.Name.Equals("fontComboBox"))
                {
                    int fontSize = int.Parse((string)fontSizeComboBox.SelectedItem);
                    Font newFont = new Font((string)comboBox.SelectedItem, fontSize);
                    mainRichTextBox.Font = newFont;
                }
                else
                {
                    int fontSize = int.Parse((string)comboBox.SelectedItem);
                    Font newFont = new Font((string)fontComboBox.SelectedItem, fontSize);
                    mainRichTextBox.Font = newFont;
                }
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
