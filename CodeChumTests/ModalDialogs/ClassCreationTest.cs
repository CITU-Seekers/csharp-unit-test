namespace CodeChum.Tests
{
    public class ClassCreationTest
    {
        ClassCreationApp? form;
        ClassCreationForm? modal;

        //Class Details
        Label? lblClasName;
        Label? lblClassSched;
        Label? lblClassCode;
        Label? lblClassDesc;
        Button? btnCreate;

        //Class Creation
        TextBox? txtClassName;
        ComboBox? cboSched;
        TextBox? txtClassCode;
        RichTextBox? txtClassDesc;
        Button? btnCreateClass;
        Button? btnCancel;

        public ClassCreationTest()
        {
            form = new ClassCreationApp();
            form.Show();
            lblClasName = (Label)TestUtils.GetControlNamed(form, "lblClassName", true);  
            lblClassSched = (Label)TestUtils.GetControlNamed(form, "lblClassSched", true);
            lblClassCode = (Label)TestUtils.GetControlNamed(form, "lblClassCode", true);
            lblClassDesc = (Label)TestUtils.GetControlNamed(form, "lblClassDesc", true);
            btnCreate = (Button)TestUtils.GetControlNamed(form, "btnCreate", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(lblClasName);
            Assert.NotNull(lblClassSched);
            Assert.NotNull(lblClassCode);
            Assert.NotNull(lblClassDesc);
            Assert.NotNull(btnCreate);
        }

        [Fact]
        public void ShouldHaveAllControlsInModal()
        {
            modal = new ClassCreationForm();
            modal.Show();

            txtClassName = (TextBox)TestUtils.GetControlNamed(modal, "txtClassName", true);
            cboSched = (ComboBox)TestUtils.GetControlNamed(modal, "cboSched", true);
            txtClassCode = (TextBox)TestUtils.GetControlNamed(modal, "txtClassCode", true);
            txtClassDesc = (RichTextBox)TestUtils.GetControlNamed(modal, "txtClassDesc", true);
            btnCreateClass = (Button)TestUtils.GetControlNamed(modal, "btnCreateClass", true);
            btnCancel = (Button)TestUtils.GetControlNamed(modal, "btnCancel", true);

            Assert.NotNull(txtClassName);
            Assert.NotNull(cboSched);
            Assert.NotNull(txtClassCode);
            Assert.NotNull(txtClassDesc);
            Assert.NotNull(btnCreateClass);
            Assert.NotNull(btnCancel);
        }

        [Fact]
        public void ShouldOpenModal()
        {
            Boolean isModalShown = false;
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                isModalShown = form.CreationModal.Visible;
                form.CreationModal.Close();
            });

            btnCreate.PerformClick();
            registerTask.Wait();
            Assert.True(isModalShown);
        }

        [Fact]
        public void ShouldCloseModal()
        {
            Boolean isModalShown = false;
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                btnCancel = (Button)TestUtils.GetControlNamed(form.CreationModal, "btnCancel", true);
                btnCancel.PerformClick();
                await Task.Delay(TimeSpan.FromSeconds(3));
                isModalShown = form.CreationModal.Visible;
            });

            btnCreate.PerformClick();
            registerTask.Wait();
            Assert.False(isModalShown);
        }

        [Fact]
        public void ShouldCreateClass()
        {
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(5));
                txtClassName = (TextBox)TestUtils.GetControlNamed(form.CreationModal, "txtClassName", true);
                cboSched = (ComboBox)TestUtils.GetControlNamed(form.CreationModal, "cboSched", true);
                txtClassCode = (TextBox)TestUtils.GetControlNamed(form.CreationModal, "txtClassCode", true);
                txtClassDesc = (RichTextBox)TestUtils.GetControlNamed(form.CreationModal, "txtClassDesc", true);
                btnCreateClass = (Button)TestUtils.GetControlNamed(form.CreationModal, "btnCreateClass", true);

                txtClassName.Text = "Test Class";
                cboSched.SelectedIndex = 0;
                txtClassCode.Text = "1234";
                txtClassDesc.Text = "This is a test class";
                btnCreateClass.PerformClick();
            });

            btnCreate.PerformClick();

            registerTask.Wait();
            Assert.Equal("Test Class", lblClasName.Text);   
            Assert.Equal("7:30 AM - 9:30 AM", lblClassSched.Text);
            Assert.Equal("1234", lblClassCode.Text);
            Assert.Equal("This is a test class", lblClassDesc.Text);
        }
    }
}
