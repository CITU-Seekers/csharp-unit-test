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
            CounterLabel.Text = (Convert.ToInt32(CounterLabel.Text) + 1).ToString();
        }
    }
}
