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
    public partial class SplitterActivity : Form
    {
        public SplitterActivity()
        {
            InitializeComponent();
        }

        private void EditableTextBox_TextChanged(object sender, EventArgs e)
        {
            CapitalizedTextBox.Text = NormalTextBox.Text.ToUpper();
        }

        private void S(object sender, EventArgs e)
        {

        }
    }
}
