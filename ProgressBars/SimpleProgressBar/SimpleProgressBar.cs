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
    public partial class SimpleProgressBar : Form
    {
        public SimpleProgressBar()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            ProgressTimer.Start();
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            if (ProgressBar.Value + 1 <= ProgressBar.Maximum)
            {
                ProgressBar.Value += 1;
            }
            else
            {
                ProgressTimer.Stop();
            }
            
        }
    }
}
