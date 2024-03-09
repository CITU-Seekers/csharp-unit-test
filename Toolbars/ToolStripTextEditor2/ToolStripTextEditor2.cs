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
            FontComboBox.SelectedIndex = 0;
            FontSizeComboBox.SelectedIndex = 0;
        }

        public void onColorButtonClick(object sender, EventArgs e)
        {
            ToolStripButton button = sender as ToolStripButton;

            if (button.Name.Equals("BlackButton"))
            {
                MainRichTextBox.ForeColor = Color.Black;
            }
            else if (button.Name.Equals("BlueButton"))
            {
                MainRichTextBox.ForeColor = Color.Blue;
            }
            else if (button.Name.Equals("GreenButton"))
            {
                MainRichTextBox.ForeColor = Color.Green;
            }
            else if (button.Name.Equals("RedButton"))
            {
                MainRichTextBox.ForeColor = Color.Red;
            }
            else if (button.Name.Equals("YellowButton"))
            {
                MainRichTextBox.ForeColor = Color.Yellow;
            }
        }

        private void onEditorButtonsClick(object sender, EventArgs e)
        {
            ToolStripButton button = sender as ToolStripButton;

            if (button.Name.Equals("ReplaceAllButton"))
            {
                String newString = MainRichTextBox.Text.Replace(FindTextBox.Text, ReplaceAllTextBox.Text);
                MainRichTextBox.Text = newString;
            }
            else
            {
                ColorToolStrip.Visible = !ColorToolStrip.Visible;
            }
        }

        private void onComboBoxSelectionChange(object sender, EventArgs e)
        {
            ToolStripComboBox comboBox = sender as ToolStripComboBox;

            if (FontSizeComboBox.SelectedItem is not null && FontComboBox.SelectedItem is not null)
            {
                if (comboBox.Name.Equals("FontComboBox"))
                {
                    int fontSize = int.Parse((string)FontSizeComboBox.SelectedItem);
                    Font newFont = new Font((string)comboBox.SelectedItem, fontSize);
                    MainRichTextBox.Font = newFont;
                }
                else
                {
                    int fontSize = int.Parse((string)comboBox.SelectedItem);
                    Font newFont = new Font((string)FontComboBox.SelectedItem, fontSize);
                    MainRichTextBox.Font = newFont;
                }
            }
        }
    }
}
