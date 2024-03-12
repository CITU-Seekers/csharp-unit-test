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
    public partial class ColorFontEditor : Form
    {
        public ColorFontEditor()
        {
            InitializeComponent();
            EditorFontDialog = new FontDialog();
            EditorColorDialog = new ColorDialog();
        }

        public FontDialog EditorFontDialog { get; set; }
        public ColorDialog EditorColorDialog { get; set; }

        private void FontButton_Click(object sender, EventArgs e)
        {
            Task.Run(() => {
                EditorFontDialog.ShowDialog();
            });

            mainRichTextBox.Font = EditorFontDialog.Font;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            Task.Run(() => {
                EditorColorDialog.ShowDialog();
            });

            mainRichTextBox.ForeColor = EditorColorDialog.Color;

        }
    }
}
