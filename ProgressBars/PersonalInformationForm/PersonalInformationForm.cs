﻿using System;
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
    public partial class PersonalInformationForm : Form
    {
        bool nameEmpty = true, addressEmpty = true, quoteEmpty = true, checkBoxEmpty = true;
        public PersonalInformationForm()
        {
            InitializeComponent();
        }

        private void IncreaseProgress()
        {
            if (ProgressBar.Value != ProgressBar.Maximum)
            {
                ProgressBar.Value += 1;
            }
            
        }
        private void DecreaseProgress()
        {
            if (ProgressBar.Value != ProgressBar.Minimum)
            {
                ProgressBar.Value -= 1;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ProgrammingLanguageCheckBox1.Checked || ProgrammingLanguageCheckBox2.Checked)
            {
                if (checkBoxEmpty)
                {
                    checkBoxEmpty = false;
                    IncreaseProgress();
                }
            } 
            else if (!ProgrammingLanguageCheckBox1.Checked && !ProgrammingLanguageCheckBox2.Checked)
            {
                checkBoxEmpty = true;
                DecreaseProgress();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Length == 0)
            {
                DecreaseProgress();
                nameEmpty = true;
            }
            else
            {
                if (nameEmpty)
                {
                    nameEmpty = false;
                    IncreaseProgress();
                }
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AddressTextBox.Text.Length == 0)
            {
                DecreaseProgress();
                addressEmpty = true;
            }
            else
            {
                if (addressEmpty)
                {
                    addressEmpty = false;
                    IncreaseProgress();
                }
            }
        }

        private void QuoteTextBox_TextChanged(object sender, EventArgs e)
        {
            if (QuoteTextBox.Text.Length == 0)
            {
                DecreaseProgress();
                quoteEmpty = true;
            }
            else
            {
                if (quoteEmpty)
                {
                    quoteEmpty = false;
                    IncreaseProgress();
                }
            }
        }
    }
}
