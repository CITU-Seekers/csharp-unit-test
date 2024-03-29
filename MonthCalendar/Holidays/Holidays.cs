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
    public partial class Holidays : Form
    {
        public Holidays()
        {
            InitializeComponent();
        }

        private void DisplayHolidaysButton_Click(object sender, EventArgs e)
        {
            DateTime date = holidaysMonthCalendar.SelectionRange.Start;

            if (date.Month == 12 && date.Year == 2022)
            {
                holidaysLabel.Text = "December 25, 2022 - Christmas\nDecember 30, 2022 - Rizal Day";
            }
            else if (date.Month == 1 && date.Year == 2023)
            {
                holidaysLabel.Text = "January 1, 2023 - New Year's Day\nJanuary 22, 2023 - Lunar New Year";
            }
            else
            {
                holidaysLabel.Text = "";
            }
        }

    }
}
