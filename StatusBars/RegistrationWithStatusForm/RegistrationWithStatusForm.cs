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
    public partial class RegistrationWithStatusForm : Form
    {
        public RegistrationWithStatusForm()
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

        private void statusUpdate(object sender, EventArgs e)
        {
            Control control = sender as Control;
            String updateText = "";

            if (control.Name.Equals("NameTextBox"))
            {
                updateText = "The name field was updated...";
            }
            else if (control.Name.Equals("EmailTextBox"))
            {
                updateText = "The email field was updated...";
            }
            else if (control.Name.Equals("AddressTextBox"))
            {
                updateText = "The address field was updated...";
            }
            else if (control.Name.Equals("BirthDatePicker"))
            {
                updateText = "The birth date was updated...";
            }

            RegistrationStatusLabel.Text = updateText;
        }
    }
}
