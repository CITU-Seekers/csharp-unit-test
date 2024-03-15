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
            editorFontDialog = new FontDialog();
            editorColorDialog = new ColorDialog();
        }

        public FontDialog editorFontDialog { get; set; }
        public ColorDialog editorColorDialog { get; set; }

        private void FontButton_Click(object sender, EventArgs e)
        {
            Task.Run(() => {
                editorFontDialog.ShowDialog();
            });

            mainRichTextBox.Font = editorFontDialog.Font;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            Task.Run(() => {
                editorColorDialog.ShowDialog();
            });

            mainRichTextBox.ForeColor = editorColorDialog.Color;

        }
    }
}
