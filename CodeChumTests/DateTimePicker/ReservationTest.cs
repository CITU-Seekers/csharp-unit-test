namespace CodeChum.Tests
{
    public class ReservationTest
    {
        Reservation? form;
        ComboBox? timeComboBox;
        TextBox? eventNameTextBox;
        Label? reservationSummaryLabel;
        DateTimePicker? dateTimePicker;
        Button? reserveButton;

        public ReservationTest()
        {
            form = new Reservation();
            form.Show();
            timeComboBox = (ComboBox)TestUtils.GetControlNamed(form, "timeComboBox", true);
            eventNameTextBox = (TextBox)TestUtils.GetControlNamed(form, "eventNameTextBox", true);
            reservationSummaryLabel = (Label)TestUtils.GetControlNamed(form, "reservationSummaryLabel", true);
            dateTimePicker = (DateTimePicker)TestUtils.GetControlNamed(form, "dateTimePicker", true);
            reserveButton = (Button)TestUtils.GetControlNamed(form, "reserveButton", true);
        }

        [Fact]
        // Description: Should have all controls `timeComboBox`, `eventNameTextBox`, `reservationSummaryLabel`, and `dateTimePicker`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(timeComboBox);
            Assert.NotNull(eventNameTextBox);
            Assert.NotNull(reservationSummaryLabel);
            Assert.NotNull(dateTimePicker);
        }

        [Fact]
        // Description: Should have 4 items in `timeComboBox` and the items should be "8:00 AM", "12:00 PM", "4:00 PM", and "8:00 PM".
        public void ShouldHaveCorrectTimeComboBoxItems()
        {
            Assert.Equal(4, timeComboBox.Items.Count);
            Assert.Equal("8:00 AM", timeComboBox.Items[0]);
            Assert.Equal("12:00 PM", timeComboBox.Items[1]);
            Assert.Equal("4:00 PM", timeComboBox.Items[2]);
            Assert.Equal("8:00 PM", timeComboBox.Items[3]);
        }

        [Fact]
        // Description: Should display reservation summary "Your reservation for Birthday Party\nis on Friday, January 1, 2021\nat 12:00 PM" when `eventNameTextBox` is set to "Birthday Party", `dateTimePicker` is set to "1/1/2021", `timeComboBox` is set to "12:00 PM", and `reserveButton` is clicked.
        public void ShouldDisplayReservationSummary()
        {
            eventNameTextBox!.Text = "Birthday Party";
            dateTimePicker!.Value = new DateTime(2021, 1, 1);
            timeComboBox!.SelectedIndex = 1;
            reserveButton.PerformClick();
            Assert.Equal("Your reservation for Birthday Party\nis on Friday, January 1, 2021\nat 12:00 PM", reservationSummaryLabel!.Text);
        }

    }
}
