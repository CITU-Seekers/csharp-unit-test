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
    public partial class SimpleQuestionnaire : Form
    {
        public SimpleQuestionnaire()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (StringRadioButton.Checked == true)
            {
                ResultLabel.Text = "Correct";
            } 
            else
            {
                ResultLabel.Text = "Incorrect";
            }
           
        }
    }
}
