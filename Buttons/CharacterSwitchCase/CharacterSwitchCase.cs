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
    public partial class CharacterSwitchCase : Form
    {
        char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
        public CharacterSwitchCase()
        {
            InitializeComponent();
        }

        private void SwitchCaseVowelsButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(textLabel.Text);

            for (int i = 0; i < sb.Length; i++)
            {
                char c = sb[i];

                if (vowels.Contains(c))
                {
                    if (Char.IsUpper(c))
                    {
                        sb[i] = Char.ToLower(c);
                    }
                    else
                    {
                        sb[i] = Char.ToUpper(c);
                    }
                }
            }

            textLabel.Text = sb.ToString();
        }

        private void SwitchCaseConsonantsButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(textLabel.Text);

            for (int i = 0; i < sb.Length; i++)
            {
                char c = sb[i];

                if (!vowels.Contains(c))
                {
                    if (Char.IsUpper(c))
                    {
                        sb[i] = Char.ToLower(c);
                    }
                    else
                    {
                        sb[i] = Char.ToUpper(c);
                    }
                }
            }

            textLabel.Text = sb.ToString();
        }

        private void SwitchCaseAllButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(textLabel.Text);

            for (int i = 0; i < sb.Length; i++)
            {
                char c = sb[i];

                if (Char.IsUpper(c))
                {
                    sb[i] = Char.ToLower(c);
                }
                else
                {
                    sb[i] = Char.ToUpper(c);
                }
                
            }

            textLabel.Text = sb.ToString();
        }
    }
}
