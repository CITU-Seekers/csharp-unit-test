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
    public partial class RegistrationFormApp : Form
    {
        public RegistrationModal RegisterModal { get; set; }
        public RegistrationFormApp()
        {
            InitializeComponent();
            RegisterModal = new RegistrationModal();
        }

        private void OpenRegistrationModalButton_Click(object sender, EventArgs e)
        {
            RegisterModal.ShowDialog();

            nameLabel.Text = RegisterModal.RegisteredName;
            emailLabel.Text = RegisterModal.RegisteredEmail;
        }
    }
}
