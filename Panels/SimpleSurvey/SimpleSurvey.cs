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
    public partial class SimpleSurvey : Form
    {
        public SimpleSurvey()
        {
            InitializeComponent();
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Panel2.Location = Panel1.Location;
            Panel2.Visible = true;
            Panel1.Visible = false;
        }

        private void BackToPanel1_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
            Panel1.Visible = true;
        }

        private void ToPanel3Button_Click(object sender, EventArgs e)
        {
            Panel3.Location = Panel2.Location;
            Panel3.Visible = true;
            Panel2.Visible = false;
        }

        private void BackToPanel2Button_Click(object sender, EventArgs e)
        {
            Panel3.Visible = false;
            Panel2.Visible = true;
        }

        private void ToPanel4Button_Click(object sender, EventArgs e)
        {
            Panel4.Location = Panel3.Location;
            Panel4.Visible = true;
            Panel3.Visible = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
