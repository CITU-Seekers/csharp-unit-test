namespace CodeChum.Tests
{
    public class ContactManagementTest
    {
        ContactManagement? form;
        ListView? ContactList;
        TextBox? ContactName;
        TextBox? ContactEmail;
        TextBox? ContactNum;
        ComboBox? cboTelecom;
        Button? btnAdd;
        Button? btnUpdate;
        Button? btnRemove;

        public ContactManagementTest()
        {
            form = new ContactManagement();
            form.Show();
            ContactList = (ListView)TestUtils.GetControlNamed(form, "ContactList", true);
            ContactName = (TextBox)TestUtils.GetControlNamed(form, "ContactName", true);
            ContactEmail = (TextBox)TestUtils.GetControlNamed(form, "ContactEmail", true);
            ContactNum = (TextBox)TestUtils.GetControlNamed(form, "ContactNum", true);
            cboTelecom = (ComboBox)TestUtils.GetControlNamed(form, "cboTelecom", true);
            btnAdd = (Button)TestUtils.GetControlNamed(form, "btnAdd", true);
            btnUpdate = (Button)TestUtils.GetControlNamed(form, "btnUpdate", true);
            btnRemove = (Button)TestUtils.GetControlNamed(form, "btnRemove", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(ContactList);
            Assert.NotNull(ContactName);
            Assert.NotNull(ContactEmail);
            Assert.NotNull(ContactNum);
            Assert.NotNull(cboTelecom);
            Assert.NotNull(btnAdd);
            Assert.NotNull(btnUpdate);
            Assert.NotNull(btnRemove);
        }

        [Fact]
        public void ShouldAddContact()
        {
            ContactName.Text = "John Doe";
            ContactEmail.Text = "qweqwe@gmail.com";
            ContactNum.Text = "1234567890";
            cboTelecom.SelectedIndex = 0;
            btnAdd.PerformClick();

            Assert.Equal(1, ContactList.Items.Count);
            Assert.Equal("John Doe", ContactList.Items[0].SubItems[0].Text);
            Assert.Equal("qweqwe@gmail.com", ContactList.Items[0].SubItems[1].Text);
            Assert.Equal("1234567890", ContactList.Items[0].SubItems[2].Text);
            Assert.Equal("SMART", ContactList.Items[0].SubItems[3].Text);
        }

        [Fact]
        public void ShouldUpdateContact()
        {
            ContactName.Text = "John Doe";
            ContactEmail.Text = "";
            ContactNum.Text = "1234567890";
            cboTelecom.SelectedIndex = 0;
            btnAdd.PerformClick();

            ContactList.Items[0].Selected = true;
            ContactName.Text = "Jane Doe";
            ContactEmail.Text = "";
            ContactNum.Text = "0987654321";
            cboTelecom.SelectedIndex = 1;
            btnUpdate.PerformClick();

            Assert.Equal(1, ContactList.Items.Count);
            Assert.Equal("Jane Doe", ContactList.Items[0].SubItems[0].Text);
            Assert.Equal("", ContactList.Items[0].SubItems[1].Text);
            Assert.Equal("0987654321", ContactList.Items[0].SubItems[2].Text);
            Assert.Equal("Sun", ContactList.Items[0].SubItems[3].Text);
        }

        [Fact]
        public void ShouldRemoveContact()
        {
            ContactName.Text = "John Doe";
            ContactEmail.Text = "";
            ContactNum.Text = "1234567890";
            cboTelecom.SelectedIndex = 0;
            btnAdd.PerformClick();

            ContactList.Items[0].Selected = true;
            btnRemove.PerformClick();

            Assert.Equal(0, ContactList.Items.Count);
        }
    }
}
