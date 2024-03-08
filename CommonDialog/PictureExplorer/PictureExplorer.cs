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
    public partial class PictureExplorer : Form
    {
        public OpenFileDialog OpenFileDialog { get; set; }
        public PictureExplorer()
        {
            InitializeComponent();
            OpenFileDialog = new OpenFileDialog();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();

            if (OpenFileDialog.FileName != "")
            {
                String fileName = OpenFileDialog.FileName;
                PictureBox.Load(OpenFileDialog.FileName);
            }
        }
    }
}
