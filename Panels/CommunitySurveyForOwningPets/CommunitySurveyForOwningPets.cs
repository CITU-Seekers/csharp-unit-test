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
    public partial class CommunitySurveyForOwningPets : Form
    {
        public CommunitySurveyForOwningPets()
        {
            InitializeComponent();
        }

        private void NoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NoRadioButton.Checked)
            {
                if (RespondentNameTextBox.TextLength > 0)
                {
                    SubmitButton.Enabled = true;
                    PetDetailsPanel.Visible = false;
                }
                else 
                {
                    SubmitButton.Enabled = false;
                }
            }
        }

        private void YesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (YesRadioButton.Checked)
            {
                PetDetailsPanel.Visible = true;
                if (RespondentNameTextBox.TextLength > 0 && 
                    PetNameTextBox.TextLength > 0 &&
                    PetTypeTextBox.TextLength > 0)
                {
                    SubmitButton.Enabled = true;
                }
                else
                {
                    SubmitButton.Enabled = false;
                }
            }
        }

        private bool CheckAllIfNonEmpty()
        {
            return RespondentNameTextBox.TextLength > 0 && PetNameTextBox.TextLength > 0 && PetTypeTextBox.TextLength > 0;
        }
        private void RespondentNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (YesRadioButton.Checked && CheckAllIfNonEmpty())
            {
                SubmitButton.Enabled = true;
            }
            else if (NoRadioButton.Checked && RespondentNameTextBox.TextLength > 0)
            {
                SubmitButton.Enabled = true;
            }
            else
            {
                SubmitButton.Enabled = false;
            }
        }

        private void PetNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CheckAllIfNonEmpty())
            {
                SubmitButton.Enabled = true;
            }
            else
            {
                SubmitButton.Enabled = false;
            }
        }

        private void PetTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CheckAllIfNonEmpty())
            {
                SubmitButton.Enabled = true;
            }
            else
            {
                SubmitButton.Enabled = false;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for taking part in the survey", "Success");
        }
    }
}
