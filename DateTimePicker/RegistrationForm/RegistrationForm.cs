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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Length != 0 && 
                EmailTextBox.Text.Length != 0 &&
                AddressTextBox.Text.Length != 0)
            {
                string name = NameTextBox.Text;
                string email = EmailTextBox.Text;
                string address = AddressTextBox.Text;
                string birthdate = BirthDatePicker.Value.ToString("MMMM dd, yyyy");
                string age = ((int)(DateTime.Now - BirthDatePicker.Value).TotalDays / 365).ToString();

                RegistrationLabel.Text = $"Name: {name}\nEmail: {email}\nAddress: {address}\n" +
                    $"Birth Date: {birthdate}\nAge: {age}";
            }
          
        }
    }
}
