using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChum
{
    public partial class MysticMessenger : Form
    {
        public MysticMessenger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            string translated = new string(message.Reverse().ToArray());
            lblMessage.Text = translated;

            button1.BackColor = Color.Red;
            button1.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = lblMessage.Text; // Get text from the previous step
            StringBuilder translated = new StringBuilder();

            foreach (char c in message)
            {
                char translatedChar = c;

                switch (char.ToLower(c))
                {
                    case 'a':
                        translatedChar = '@';
                        break;
                    case 'e':
                        translatedChar = '3';
                        break;
                    case 'i':
                        translatedChar = '!';
                        break;
                    case 'o':
                        translatedChar = '0';
                        break;
                    case 'u':
                        translatedChar = '>';
                        break;
                }

                translated.Append(translatedChar);
            }
            button2.BackColor = Color.Red;
            button2.ForeColor = Color.White;
            lblMessage.Text = translated.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = lblMessage.Text; // Get text from the previous step
            string translated = "";

            foreach (char c in message)
            {
                translated += char.IsLetter(c) ? char.ToUpper(c) : c;
            }

            button3.BackColor = Color.Red;
            button3.ForeColor = Color.White;
            lblMessage.Text = translated;
        }
    }
}
