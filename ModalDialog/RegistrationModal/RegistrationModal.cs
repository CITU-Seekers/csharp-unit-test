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
    public partial class RegistrationModal : Form
    {
        public String RegisteredName { get; set; }
        public String RegisteredEmail { get; set; }
        public RegistrationModal()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisteredName = nameTextBox.Text;
            RegisteredEmail = emailTextBox.Text;

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
