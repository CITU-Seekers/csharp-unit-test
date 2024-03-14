namespace CodeChum.Tests
{
    public class ClassCreationTest
    {
        ClassCreationApp? form;
        ClassCreationForm? modal;

        //Class Details
        Label? classNameLabel;
        Label? classScheduleLabel;
        Label? classCodeLabel;
        Label? classDescriptionLabel;
        Button? createButton;

        //Class Creation
        TextBox? classNameTextBox;
        ComboBox? scheduleComboBox;
        TextBox? classCodeTextBox;
        RichTextBox? classDescriptionRichTextBox;
        Button? createClassButton;
        Button? cancelButton;

        public ClassCreationTest()
        {
            form = new ClassCreationApp();
            form.Show();
            classNameLabel = (Label)TestUtils.GetControlNamed(form, "classNameLabel", true);  
            classScheduleLabel = (Label)TestUtils.GetControlNamed(form, "classScheduleLabel", true);
            classCodeLabel = (Label)TestUtils.GetControlNamed(form, "classCodeLabel", true);
            classDescriptionLabel = (Label)TestUtils.GetControlNamed(form, "classDescriptionLabel", true);
            createButton = (Button)TestUtils.GetControlNamed(form, "createButton", true);
        }

        [Fact]
        // Description: Should have all the controls `classNameLabel`, `classScheduleLabel`, `classCodeLabel`, `classDescriptionLabel`, and `createButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(classNameLabel);
            Assert.NotNull(classScheduleLabel);
            Assert.NotNull(classCodeLabel);
            Assert.NotNull(classDescriptionLabel);
            Assert.NotNull(createButton);
        }

        [Fact]
        // Description: Should have all the controls `classNameTextBox`, `scheduleComboBox`, `classCodeTextBox`, `classDescriptionRichTextBox`, `createClassButton`, and `cancelButton` in modal.
        public void ShouldHaveAllControlsInModal()
        {
            modal = new ClassCreationForm();
            modal.Show();

            classNameTextBox = (TextBox)TestUtils.GetControlNamed(modal, "classNameTextBox", true);
            scheduleComboBox = (ComboBox)TestUtils.GetControlNamed(modal, "scheduleComboBox", true);
            classCodeTextBox = (TextBox)TestUtils.GetControlNamed(modal, "classCodeTextBox", true);
            classDescriptionRichTextBox = (RichTextBox)TestUtils.GetControlNamed(modal, "classDescriptionRichTextBox", true);
            createClassButton = (Button)TestUtils.GetControlNamed(modal, "createClassButton", true);
            cancelButton = (Button)TestUtils.GetControlNamed(modal, "cancelButton", true);

            Assert.NotNull(classNameTextBox);
            Assert.NotNull(scheduleComboBox);
            Assert.NotNull(classCodeTextBox);
            Assert.NotNull(classDescriptionRichTextBox);
            Assert.NotNull(createClassButton);
            Assert.NotNull(cancelButton);
        }

        [Fact]
        // Description: Should have schedules "7:30 AM - 9:30 AM", "9:30 AM - 11:30 AM", "1:00 PM - 3:00 PM", "3:00 PM - 5:00 PM", "5:00 PM - 7:00 PM", and "7:00 PM - 9:00 PM" in the `scheduleComboBox`.
        public void ShouldHaveSchedules()
        {
            modal = new ClassCreationForm();
            modal.Show();

            scheduleComboBox = (ComboBox)TestUtils.GetControlNamed(modal, "scheduleComboBox", true);

            string[] expectedSchedules = { "7:30 AM - 9:30 AM", "9:30 AM - 11:30 AM", "1:00 PM - 3:00 PM", "3:00 PM - 5:00 PM", "5:00 PM - 7:00 PM", "7:00 PM - 9:00 PM" };
            string[] actualSchedules = new string[scheduleComboBox.Items.Count];
            scheduleComboBox.Items.CopyTo(actualSchedules, 0);

            Assert.Equal(expectedSchedules, actualSchedules);
        }

        [Fact]
        // Description: Should open modal when the `createButton` is clicked.
        public void ShouldOpenModal()
        {
            bool isModalShown = false;
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                isModalShown = form.CreationModal.Visible;
                form.CreationModal.Close();
            });

            createButton.PerformClick();
            registerTask.Wait();
            Assert.True(isModalShown);
        }

        [Fact]
        // Description: Should close modal when the `cancelButton` is clicked.
        public void ShouldCloseModal()
        {
            Boolean isModalShown = false;
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                cancelButton = (Button)TestUtils.GetControlNamed(form.CreationModal, "cancelButton", true);
                cancelButton.PerformClick();
                await Task.Delay(TimeSpan.FromSeconds(3));
                isModalShown = form.CreationModal.Visible;
            });

            createButton.PerformClick();
            registerTask.Wait();
            Assert.False(isModalShown);
        }

        [Fact]
        // Description: Should create class with the class name "Test Class", schedule "7:30 AM - 9:30 AM", class code "1234", and class description "This is a test class" when the `createClassButton` is clicked.
        public void ShouldCreateClass()
        {
            var registerTask = Task.Factory.StartNew(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(5));
                classNameTextBox = (TextBox)TestUtils.GetControlNamed(form.CreationModal, "classNameTextBox", true);
                scheduleComboBox = (ComboBox)TestUtils.GetControlNamed(form.CreationModal, "scheduleComboBox", true);
                classCodeTextBox = (TextBox)TestUtils.GetControlNamed(form.CreationModal, "classCodeTextBox", true);
                classDescriptionRichTextBox = (RichTextBox)TestUtils.GetControlNamed(form.CreationModal, "classDescriptionRichTextBox", true);
                createClassButton = (Button)TestUtils.GetControlNamed(form.CreationModal, "createClassButton", true);

                classNameTextBox.Text = "Test Class";
                scheduleComboBox.SelectedIndex = 0;
                classCodeTextBox.Text = "1234";
                classDescriptionRichTextBox.Text = "This is a test class";
                createClassButton.PerformClick();
            });

            createButton.PerformClick();

            registerTask.Wait();
            Assert.Equal("Test Class", classNameLabel.Text);   
            Assert.Equal("7:30 AM - 9:30 AM", classScheduleLabel.Text);
            Assert.Equal("1234", classCodeLabel.Text);
            Assert.Equal("This is a test class", classDescriptionLabel.Text);
        }
    }
}
