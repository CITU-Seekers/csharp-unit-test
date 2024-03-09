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
            FontComboBox.SelectedIndex = 0;
            FontSizeComboBox.SelectedIndex = 0;
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

            if (FontSizeComboBox.SelectedItem is not null && FontComboBox.SelectedItem is not null) {
                FontStyle fontStyle = getFontStyle();

                if (comboBox.Name.Equals("FontComboBox"))
                {
                    int fontSize = int.Parse((string)FontSizeComboBox.SelectedItem);
                    Font newFont = new Font((string)comboBox.SelectedItem, fontSize, fontStyle);
                    MainRichTextBox.Font = newFont;
                }
                else
                {
                    int fontSize = int.Parse((string)comboBox.SelectedItem);
                    Font newFont = new Font((string)FontComboBox.SelectedItem, fontSize, fontStyle);
                    MainRichTextBox.Font = newFont;
                }
            }
        }

        private void buttonClick(object sender, EventArgs e)
        {
            ToolStripButton button = sender as ToolStripButton;

            if(button.Name.Equals("UnderlineButton"))
            {
                isUnderlined = !isUnderlined;
            }
            else if (button.Name.Equals("BoldButton"))
            {
                isBold = !isBold;
            }
            else
            {
                isItalic = !isItalic;
            }

            FontStyle fontStyle = getFontStyle();

            int fontSize = int.Parse((string)FontSizeComboBox.SelectedItem);
            Font newFont = new Font((string)FontComboBox.SelectedItem, fontSize, fontStyle);
            MainRichTextBox.Font = newFont;
        }
    }
}
