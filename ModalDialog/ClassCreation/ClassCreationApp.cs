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
    public partial class ClassCreationApp : Form
    {
        public ClassCreationForm CreationModal { get; set; }
        public ClassCreationApp()
        {
            InitializeComponent();
            CreationModal = new ClassCreationForm();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreationModal.ShowDialog();

            lblClassName.Text = CreationModal.ClassName;
            lblClassSched.Text = CreationModal.ClassSchedule;
            lblClassCode.Text = CreationModal.ClassCode;
            lblClassDesc.Text = CreationModal.ClassDescription;
        }
    }
}