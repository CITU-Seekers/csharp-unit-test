﻿using System;
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
    public partial class SurveyForm : Form
    {
        public SurveyForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.TextLength == 0 || 
                EmailTextBox.TextLength == 0 || 
                (!YesRadioButton.Checked && !NoRadioButton.Checked))
            {
                MessageBoxWrapper.Show("You need to fill up all fields", "Invalid", MessageBoxButtons.OK);
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Once you press 'Yes' your response will be recorded. Continue?", "Are you sure?", MessageBoxButtons.YesNo))
                {
                    MessageBoxWrapper.Show("Response Recorded", "Success", MessageBoxButtons.OK);
                }
                else
                {
                    return;
                }
            }
        }
    }
}