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
            if (nameTextBox.Text.Length != 0 && 
                emailTextBox.Text.Length != 0 &&
                addressTextBox.Text.Length != 0)
            {
                string name = nameTextBox.Text;
                string email = emailTextBox.Text;
                string address = addressTextBox.Text;
                string birthdate = birthDatePicker.Value.ToString("MMMM dd, yyyy");
                string age = ((int)(DateTime.Now - birthDatePicker.Value).TotalDays / 365).ToString();

                registrationLabel.Text = $"Name: {name}\nEmail: {email}\nAddress: {address}\n" +
                    $"Birth Date: {birthdate}\nAge: {age}";
            }
          
        }

        private void statusUpdate(object sender, EventArgs e)
        {
            Control control = sender as Control;
            String updateText = "";

            if (control.Name.Equals("nameTextBox"))
            {
                updateText = "The name field was updated...";
            }
            else if (control.Name.Equals("emailTextBox"))
            {
                updateText = "The email field was updated...";
            }
            else if (control.Name.Equals("addressTextBox"))
            {
                updateText = "The address field was updated...";
            }
            else if (control.Name.Equals("birthDatePicker"))
            {
                updateText = "The birth date was updated...";
            }

            registrationStatusLabel.Text = updateText;
        }
    }
}
