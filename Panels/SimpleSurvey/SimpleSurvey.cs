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
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            panel2.Location = panel1.Location;
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void BackToPanel1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void ToPanel3Button_Click(object sender, EventArgs e)
        {
            panel3.Location = panel2.Location;
            panel3.Visible = true;
            panel2.Visible = false;
        }

        private void BackToPanel2Button_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = true;
        }

        private void ToPanel4Button_Click(object sender, EventArgs e)
        {
            panel4.Location = panel3.Location;
            panel4.Visible = true;
            panel3.Visible = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
