namespace CodeChum
{
    public partial class PotionBrewing : Form
    {
        public PotionBrewing()
        {
            InitializeComponent();
        }

        private void btnConcoct_Click(object sender, EventArgs e)
        {
            string ingredients = GetSelectedItems(groupBox1);
            string enhancements = GetSelectedItems(groupBox2);
            string effect = GetSelectedEffect(groupBox3);
            string potionName = textBox1.Text;

            descriptionLabel.Text = " Base Ingredients: " + ingredients +
                                  "\n together with the enhancements: " + enhancements +
                                  "\n with the effect of: " + effect +
                                  "\n Potion name: " + potionName;
        }

        private string GetSelectedItems(GroupBox groupBox)
        {
            string selectedItems = "";

            foreach (Control control in groupBox.Controls)
            {
                if (control is CheckBox && ((CheckBox)control).Checked)
                {
                    selectedItems += control.Text + ", ";
                }
            }

            // Remove trailing comma and space
            if (!string.IsNullOrEmpty(selectedItems))
            {
                selectedItems = selectedItems.TrimEnd(',', ' ');
            }

            return selectedItems;
        }

        private string GetSelectedEffect(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton && ((RadioButton)control).Checked)
                {
                    return control.Text;
                }
            }

            return "Unknown Effect";
        }
    }
}
