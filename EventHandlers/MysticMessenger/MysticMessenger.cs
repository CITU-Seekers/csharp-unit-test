using System.Text;

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
            string message = messageTextBox.Text;
            string translated = new string(message.Reverse().ToArray());
            messageLabel.Text = translated;

            windButton.BackColor = Color.Red;
            windButton.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = messageLabel.Text; // Get text from the previous step
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
            moonglowButton.BackColor = Color.Red;
            moonglowButton.ForeColor = Color.White;
            messageLabel.Text = translated.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = messageLabel.Text; // Get text from the previous step
            string translated = "";

            foreach (char c in message)
            {
                translated += char.IsLetter(c) ? char.ToUpper(c) : c;
            }

            twilightButton.BackColor = Color.Red;
            twilightButton.ForeColor = Color.White;
            messageLabel.Text = translated;
        }
    }
}
