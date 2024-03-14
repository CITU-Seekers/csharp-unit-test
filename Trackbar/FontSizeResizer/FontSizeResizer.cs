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
    public partial class FontSizeResizer : Form
    {
        public FontSizeResizer()
        {
            InitializeComponent();
        }

        private void ResizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            fontSizeLabel.Font = new Font(fontSizeLabel.Font.Name.ToString(), resizeTrackBar.Value, FontStyle.Bold);
        }

        private void ResizeTrackBar_Scroll(object sender, EventArgs e)
        {

        }
    }
}
