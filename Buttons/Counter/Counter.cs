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
    public partial class Counter : Form
    {
        public Counter()
        {
            InitializeComponent();
        }

        private void CounterButton_Click(object sender, EventArgs e)
        {
            counterLabel.Text = (Convert.ToInt32(counterLabel.Text) + 1).ToString();
        }
    }
}
