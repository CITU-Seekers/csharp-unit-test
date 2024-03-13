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
    public partial class VirtualPet : Form
    {
        public bool isMessageBoxClosed = false;
        public VirtualPet()
        {
            InitializeComponent();
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            MessageBoxWrapper.Show("Yum! That was delicious! I'm feeling full and happy!", "Feed", MessageBoxButtons.OK);
            isMessageBoxClosed = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            MessageBoxWrapper.Show("That was so much fun! I'm feeling happy and energized!", "Play", MessageBoxButtons.OK);
            isMessageBoxClosed = true;
        }

        private void btnPet_Click(object sender, EventArgs e)
        {
            MessageBoxWrapper.Show("Purr... rubs against you I love your cuddles!", "Pet", MessageBoxButtons.OK);
            isMessageBoxClosed = true;
        }

        private void btnCheckMood_Click(object sender, EventArgs e)
        {
            MessageBoxWrapper.Show("I'm feeling content and loved, thanks to you!", "Check Mood", MessageBoxButtons.OK);
            isMessageBoxClosed = true;
        }
    }
}
