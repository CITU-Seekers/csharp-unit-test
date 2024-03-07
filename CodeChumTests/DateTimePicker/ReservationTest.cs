namespace CodeChum.Tests
{
    public class ReservationTest
    {
        Reservation? form;
        ComboBox? cboTime;
        TextBox? eventName;
        Label? reservationSummary;
        DateTimePicker? datePicker;
        Button? btnReserve;

        public ReservationTest()
        {
            form = new Reservation();
            form.Show();
            cboTime = (ComboBox)TestUtils.GetControlNamed(form, "cboTime", true);
            eventName = (TextBox)TestUtils.GetControlNamed(form, "EventName", true);
            reservationSummary = (Label)TestUtils.GetControlNamed(form, "ReservationSummary", true);
            datePicker = (DateTimePicker)TestUtils.GetControlNamed(form, "DatePicker", true);
            btnReserve = (Button)TestUtils.GetControlNamed(form, "btnReserve", true);
        }

        [Fact]
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(cboTime);
            Assert.NotNull(eventName);
            Assert.NotNull(reservationSummary);
            Assert.NotNull(datePicker);
        }

        [Fact]
        public void ShouldDisplayReservationSummary()
        {
            eventName!.Text = "Birthday Party";
            datePicker!.Value = new DateTime(2021, 1, 1);
            cboTime!.SelectedIndex = 1;
            btnReserve.PerformClick();
            Assert.Equal("Your reservation for Birthday Party\nis on Friday, January 1, 2021\nat 12:00 PM", reservationSummary!.Text);
        }

    }
}
