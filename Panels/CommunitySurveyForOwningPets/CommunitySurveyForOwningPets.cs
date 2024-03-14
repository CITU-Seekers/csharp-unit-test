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
            if (noRadioButton.Checked)
            {
                if (respondentNameTextBox.TextLength > 0)
                {
                    submitButton.Enabled = true;
                    petDetailsPanel.Visible = false;
                }
                else 
                {
                    submitButton.Enabled = false;
                }
            }
        }

        private void YesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (yesRadioButton.Checked)
            {
                petDetailsPanel.Visible = true;
                if (respondentNameTextBox.TextLength > 0 && 
                    petNameTextBox.TextLength > 0 &&
                    petTypeTextBox.TextLength > 0)
                {
                    submitButton.Enabled = true;
                }
                else
                {
                    submitButton.Enabled = false;
                }
            }
        }

        private bool CheckAllIfNonEmpty()
        {
            return respondentNameTextBox.TextLength > 0 && petNameTextBox.TextLength > 0 && petTypeTextBox.TextLength > 0;
        }
        private void RespondentNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (yesRadioButton.Checked && CheckAllIfNonEmpty())
            {
                submitButton.Enabled = true;
            }
            else if (noRadioButton.Checked && respondentNameTextBox.TextLength > 0)
            {
                submitButton.Enabled = true;
            }
            else
            {
                submitButton.Enabled = false;
            }
        }

        private void PetNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CheckAllIfNonEmpty())
            {
                submitButton.Enabled = true;
            }
            else
            {
                submitButton.Enabled = false;
            }
        }

        private void PetTypeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CheckAllIfNonEmpty())
            {
                submitButton.Enabled = true;
            }
            else
            {
                submitButton.Enabled = false;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            MessageBoxWrapper.Show("Thank you for taking part in the survey");
        }
    }
}
