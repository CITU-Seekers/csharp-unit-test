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
            progressTimer.Start();
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            if (timedProgressBar.Value + 1 <= timedProgressBar.Maximum)
            {
                timedProgressBar.Value += 1;
            }
            else
            {
                progressTimer.Stop();
            }
            
        }
    }
}
