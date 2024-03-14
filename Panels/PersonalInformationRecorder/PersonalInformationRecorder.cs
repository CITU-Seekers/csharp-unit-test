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
    public partial class PersonalInformationRecorder : Form
    {
        int pageNumber = 1;
        public PersonalInformationRecorder()
        {
            InitializeComponent();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            pageNumber--;
            if (pageNumber == 1)
            {
                firstPanel.Visible = true;
                secondPanel.Visible = false;
                prevButton.Enabled = false;
            }
            else if (pageNumber == 2)
            {
                secondPanel.Visible = true;
                thirdPanel.Visible = false;
                nextButton.Enabled = true;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            pageNumber++;
            if (pageNumber == 2)
            {
                Debug.WriteLine("DDD");
                secondPanel.Visible = true;
                firstPanel.Visible = false;
                prevButton.Enabled = true;
            }
            else if (pageNumber == 3)
            {
                thirdPanel.Visible = true;
                secondPanel.Visible = false;
                nextButton.Enabled = false;
            }
            Debug.WriteLine(pageNumber);
            Debug.WriteLine(secondPanel.Visible);
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameLabel.Text = nameTextBox.Text;
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            ageLabel.Text = ageTextBox.Text;
        }

        private void QuoteRichTextBox_TextChanged(object sender, EventArgs e)
        {
            quoteDisplayRichTextBox.Text = quoteRichTextBox.Text;
        }
    }
}
