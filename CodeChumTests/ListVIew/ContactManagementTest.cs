namespace CodeChum.Tests
{
    public class ContactManagementTest
    {
        ContactManagement? form;
        ListView? contactListView;
        TextBox? nameTextBox;
        TextBox? emailTextBox;
        TextBox? phoneNumberTextBox;
        ComboBox? telecomComboBox;
        Button? addButton;
        Button? updateButton;
        Button? removeButton;

        public ContactManagementTest()
        {
            form = new ContactManagement();
            form.Show();
            contactListView = (ListView)TestUtils.GetControlNamed(form, "contactListView", true);
            nameTextBox = (TextBox)TestUtils.GetControlNamed(form, "nameTextBox", true);
            emailTextBox = (TextBox)TestUtils.GetControlNamed(form, "emailTextBox", true);
            phoneNumberTextBox = (TextBox)TestUtils.GetControlNamed(form, "phoneNumberTextBox", true);
            telecomComboBox = (ComboBox)TestUtils.GetControlNamed(form, "telecomComboBox", true);
            addButton = (Button)TestUtils.GetControlNamed(form, "addButton", true);
            updateButton = (Button)TestUtils.GetControlNamed(form, "updateButton", true);
            removeButton = (Button)TestUtils.GetControlNamed(form, "removeButton", true);
        }

        [Fact]
        // Description: Should have all controls `contactListView`, `nameTextBox`, `emailTextBox`, `phoneNumberTextBox`, `telecomComboBox`, `addButton`, `updateButton`, and `removeButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(contactListView);
            Assert.NotNull(nameTextBox);
            Assert.NotNull(emailTextBox);
            Assert.NotNull(phoneNumberTextBox);
            Assert.NotNull(telecomComboBox);
            Assert.NotNull(addButton);
            Assert.NotNull(updateButton);
            Assert.NotNull(removeButton);
        }

        [Fact]
        // Description: Should have all telecoms "Smart", "Sun", "TNT", "Globe", "TM", and "DITO" in `telecomComboBox`.
        public void ShouldHaveAllTelecoms()
        {
            // The following are the telecoms: Smart Sun TNT Globe TM DITO
            // Order should not matter
            var telecomComboBoxItems = telecomComboBox.Items.Cast<string>().ToList();

            Assert.Equal(6, telecomComboBox.Items.Count);
            Assert.Contains("Smart", telecomComboBoxItems);
            Assert.Contains("Sun", telecomComboBoxItems);
            Assert.Contains("TNT", telecomComboBoxItems);
            Assert.Contains("Globe", telecomComboBoxItems);
            Assert.Contains("TM", telecomComboBoxItems);
            Assert.Contains("DITO", telecomComboBoxItems);
        }

        [Fact]
        // Description: Should add a contact with the name "John Doe" in `nameTextBox`, email "qweqwe@gmail.com" in `emailTextBox`, phone number "1234567890" in `phoneNumberTextBox`, and telecom "Smart" in `telecomComboBox` to `contactListView` when `addButton` is clicked.
        public void ShouldAddContact()
        {
            nameTextBox.Text = "John Doe";
            emailTextBox.Text = "qweqwe@gmail.com";
            phoneNumberTextBox.Text = "1234567890";
            telecomComboBox.SelectedIndex = 0;
            addButton.PerformClick();

            Assert.Equal(1, contactListView.Items.Count);
            Assert.Equal("John Doe", contactListView.Items[0].SubItems[0].Text);
            Assert.Equal("qweqwe@gmail.com", contactListView.Items[0].SubItems[1].Text);
            Assert.Equal("1234567890", contactListView.Items[0].SubItems[2].Text);
            Assert.Equal("Smart", contactListView.Items[0].SubItems[3].Text);
        }

        [Fact]
        // Description: Should update the contact with the name "John Doe" to "Jane Doe" in `nameTextBox`, phone number "0987654321" in `phoneNumberTextBox`, and telecom "Sun" in `telecomComboBox` when `updateButton` is clicked.
        public void ShouldUpdateContact()
        {
            nameTextBox.Text = "John Doe";
            emailTextBox.Text = "";
            phoneNumberTextBox.Text = "1234567890";
            telecomComboBox.SelectedIndex = 0;
            addButton.PerformClick();

            contactListView.Items[0].Selected = true;
            nameTextBox.Text = "Jane Doe";
            emailTextBox.Text = "";
            phoneNumberTextBox.Text = "0987654321";
            telecomComboBox.SelectedIndex = 1;
            updateButton.PerformClick();

            Assert.Equal(1, contactListView.Items.Count);
            Assert.Equal("Jane Doe", contactListView.Items[0].SubItems[0].Text);
            Assert.Equal("", contactListView.Items[0].SubItems[1].Text);
            Assert.Equal("0987654321", contactListView.Items[0].SubItems[2].Text);
            Assert.Equal("Sun", contactListView.Items[0].SubItems[3].Text);
        }

        [Fact]
        // Description: Should remove the contact with the name "John Doe" from `contactListView` when `removeButton` is clicked.
        public void ShouldRemoveContact()
        {
            nameTextBox.Text = "John Doe";
            emailTextBox.Text = "";
            phoneNumberTextBox.Text = "1234567890";
            telecomComboBox.SelectedIndex = 0;
            addButton.PerformClick();

            contactListView.Items[0].Selected = true;
            removeButton.PerformClick();

            Assert.Equal(0, contactListView.Items.Count);
        }
    }
}
