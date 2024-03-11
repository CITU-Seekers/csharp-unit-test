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
    public partial class MostFrequentCharacter : Form
    {
        public MostFrequentCharacter()
        {
            InitializeComponent();
        }

        public static char GetMostFreqChar(String str)
        {
            int[] ctr = new int[256];
            int i;
            for (i = 0; i < str.Length ; i++)
                if (!Char.IsWhiteSpace(str.ToCharArray()[i]))
                    (ctr[Char.ToLower(str.ToCharArray()[i])])++;

            int ctr_first = 0;
            for (i = 0; i < 256; i++)
            {
                if (ctr[i] > ctr[ctr_first])
                {
                    ctr_first = i;
                }
            }

            return (char)ctr_first;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            String mostFreq = Char.ToString(GetMostFreqChar(TextBox.Text));
            FrequentCharLabel.Text = mostFreq;
        }
    }
}
