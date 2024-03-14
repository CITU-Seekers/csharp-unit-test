using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChum
{
    public partial class ToolStripTextEditor : Form
    {
        private Boolean isBold, isItalic, isUnderlined;
        public ToolStripTextEditor()
        {
            InitializeComponent();
            fontComboBox.SelectedIndex = 0;
            fontSizeComboBox.SelectedIndex = 0;
        }

        private FontStyle getFontStyle()
        {
            FontStyle fontStyle = FontStyle.Regular;

            if (isBold)
            {
                fontStyle = FontStyle.Bold;
            }
            if (isItalic)
            {
                fontStyle = fontStyle | FontStyle.Italic;
            }
            if (isUnderlined)
            {
                fontStyle = fontStyle | FontStyle.Underline;
            }

            return fontStyle;
        }

        private void fontPropertySelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox comboBox = sender as ToolStripComboBox;

            if (fontSizeComboBox.SelectedItem is not null && fontComboBox.SelectedItem is not null)
            {
                FontStyle fontStyle = getFontStyle();

                if (comboBox.Name.Equals("fontComboBox"))
                {
                    int fontSize = int.Parse((string)fontSizeComboBox.SelectedItem);
                    Font newFont = new Font((string)comboBox.SelectedItem, fontSize, fontStyle);
                    mainRichTextBox.Font = newFont;
                }
                else
                {
                    int fontSize = int.Parse((string)comboBox.SelectedItem);
                    Font newFont = new Font((string)fontComboBox.SelectedItem, fontSize, fontStyle);
                    mainRichTextBox.Font = newFont;
                }
            }
        }

        private void buttonClick(object sender, EventArgs e)
        {
            ToolStripButton button = sender as ToolStripButton;

            if (button.Name.Equals("underlineButton"))
            {
                isUnderlined = !isUnderlined;
            }
            else if (button.Name.Equals("boldButton"))
            {
                isBold = !isBold;
            }
            else
            {
                isItalic = !isItalic;
            }

            FontStyle fontStyle = getFontStyle();

            int fontSize = int.Parse((string)fontSizeComboBox.SelectedItem);
            Font newFont = new Font((string)fontComboBox.SelectedItem, fontSize, fontStyle);
            mainRichTextBox.Font = newFont;
        }

        private void FontComboBox_Click(object sender, EventArgs e)
        {

        }
    }
}
