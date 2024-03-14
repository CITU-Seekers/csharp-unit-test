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
    public partial class ClassCreationForm : Form
    {
        public string ClassName { get; set; }
        public string ClassSchedule { get; set; }
        public string ClassCode { get; set; }

        public string ClassDescription { get; set; }
        public ClassCreationForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ClassName = classNameTextBox.Text;
            ClassSchedule = scheduleComboBox.SelectedItem.ToString();
            ClassCode = classCodeTextBox.Text;
            ClassDescription = classDescriptionRichTextBox.Text;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
