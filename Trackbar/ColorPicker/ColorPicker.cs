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
    public partial class ColorPicker : Form
    {
        public ColorPicker()
        {
            InitializeComponent();
        }

        public void SetLabelColor()
        {
            ColorLabel.BackColor = Color.FromArgb(RedTrackBar.Value, GreenTrackBar.Value, BlueTrackBar.Value);
        }
        private void RedTrackBar_ValueChanged(object sender, EventArgs e)
        {
            SetLabelColor();
        }
        private void GreenTrackBar_ValueChanged(object sender, EventArgs e)
        {
            SetLabelColor();
        }
        private void BlueTrackBar_ValueChanged(object sender, EventArgs e)
        {
            SetLabelColor();
        }
    }
}
