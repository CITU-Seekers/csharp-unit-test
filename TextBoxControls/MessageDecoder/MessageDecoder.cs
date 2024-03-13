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
    public partial class MessageDecoder : Form
    {
        public MessageDecoder()
        {
            InitializeComponent();
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            string encodedMessage = encodeTextBox.Text;
            string decodedMessage = DecodeSecretMessage(encodedMessage);
            displayMessageLabel.Text = decodedMessage;
        }

        private string DecodeSecretMessage(string encodedMessage)
        {
            char[] characters = encodedMessage.ToCharArray();
            Array.Reverse(characters);
            return new string(characters);
        }
    }
}
