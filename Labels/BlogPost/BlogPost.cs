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
    public partial class BlogPost : Form
    {
        public BlogPost()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void Problem1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeUI()
        {
            // Add your UI initialization code here if needed

            // Initial setup code
            ApplyLabelStyles();
        }

        public void ApplyLabelStyles()
        {
            // Style the title label
            titleLabel.Font = new Font(titleLabel.Font, FontStyle.Bold);
            titleLabel.Font = new Font(titleLabel.Font.FontFamily, 18, FontStyle.Bold);
            titleLabel.ForeColor = Color.DarkBlue;

            // Style the author label
            authorLabel.Font = new Font(authorLabel.Font, FontStyle.Italic);
            authorLabel.ForeColor = Color.Gray;

            // Style the content label
            contentLabel.Font = new Font(contentLabel.Font.FontFamily, 14);
            // Add additional styling as needed
        }
    }
}
