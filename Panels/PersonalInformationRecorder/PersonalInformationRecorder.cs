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
                FirstPanel.Visible = true;
                SecondPanel.Visible = false;
                PrevButton.Enabled = false;
            }
            else if (pageNumber == 2)
            {
                SecondPanel.Visible = true;
                ThirdPanel.Visible = false;
                NextButton.Enabled = true;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            pageNumber++;
            if (pageNumber == 2)
            {
                Debug.WriteLine("DDD");
                SecondPanel.Visible = true;
                FirstPanel.Visible = false;
                PrevButton.Enabled = true;
            }
            else if (pageNumber == 3)
            {
                ThirdPanel.Visible = true;
                SecondPanel.Visible = false;
                NextButton.Enabled = false;
            }
            Debug.WriteLine(pageNumber);
            Debug.WriteLine(SecondPanel.Visible);
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            NameLabel.Text = NameTextBox.Text;
        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            AgeLabel.Text = AgeTextBox.Text;
        }

        private void QuoteRichTextBox_TextChanged(object sender, EventArgs e)
        {
            QuoteDisplayRichTextBox.Text = QuoteRichTextBox.Text;
        }
    }
}
