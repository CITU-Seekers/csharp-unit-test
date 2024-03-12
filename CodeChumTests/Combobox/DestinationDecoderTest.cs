namespace CodeChum.Tests
{
    public class DestinationDecoderTest
    {
        DestinationDecoder? form;
        ComboBox? traitComboBox;
        Label? destinationLabel;
        Button? revealButton;

        public DestinationDecoderTest()
        {
            form = new DestinationDecoder();
            form.Show();
            traitComboBox = (ComboBox)TestUtils.GetControlNamed(form, "traitComboBox", true);
            destinationLabel = (Label)TestUtils.GetControlNamed(form, "destinationLabel", true);
            revealButton = (Button)TestUtils.GetControlNamed(form, "revealButton", true);
        }

        [Fact]
        // Description: Should have all controls `traitComboBox`, `destinationLabel`, and `revealButton`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(traitComboBox);
            Assert.NotNull(destinationLabel);
            Assert.NotNull(revealButton);
        }

        [Fact]
        // Description: Should have all traits "Adventurer", "Explorer", "Beach Bum", "History Buff", "Foodie", and "Nature Lover" in `traitComboBox`.
        public void ShouldHaveAllTraits()
        {
            var traitComboBoxItems = traitComboBox.Items.Cast<string>().ToList();

            Assert.Equal(6, traitComboBox.Items.Count);
            Assert.Contains("Adventurer", traitComboBoxItems);
            Assert.Contains("Explorer", traitComboBoxItems);
            Assert.Contains("Beach Bum", traitComboBoxItems);
            Assert.Contains("History Buff", traitComboBoxItems);
            Assert.Contains("Foodie", traitComboBoxItems);
            Assert.Contains("Nature Lover", traitComboBoxItems);
        }

        [Fact]
        // Description: Should display destination "Machu Picchu, Peru" when `traitComboBox` is set to "Adventurer" and `revealButton` is clicked.
        public void ShouldDisplayDestinationWhenRevealClicked()
        {
            traitComboBox.SelectedIndex = 0;
            revealButton.PerformClick();
            Assert.Equal("Machu Picchu, Peru", destinationLabel.Text);
        }

        [Fact]
        // Description: Should display destination "The Great Barrier Reef, Australia" when `traitComboBox` is set to "Explorer" and `revealButton` is clicked.
        public void ShouldDisplayDestinationWhenRevealClicked2()
        {
            traitComboBox.SelectedIndex = 1;
            revealButton.PerformClick();
            Assert.Equal("The Great Barrier Reef, Australia", destinationLabel.Text);
        }

        [Fact]
        // Description: Should display destination "The Maldives" when `traitComboBox` is set to "Beach Bum" and `revealButton` is clicked.
        public void ShouldDisplayDestinationWhenRevealClicked3()
        {
            traitComboBox.SelectedIndex = 2;
            revealButton.PerformClick();
            Assert.Equal("The Maldives", destinationLabel.Text);
        }

        [Fact]
        // Description: Should display destination "Rome, Italy" when `traitComboBox` is set to "History Buff" and `revealButton` is clicked.
        public void ShouldDisplayDestinationWhenRevealClicked4()
        {
            traitComboBox.SelectedIndex = 3;
            revealButton.PerformClick();
            Assert.Equal("Rome, Italy", destinationLabel.Text);
        }

        [Fact]
        // Description: Should display destination "Tokyo, Japan" when `traitComboBox` is set to "Foodie" and `revealButton` is clicked.
        public void ShouldDisplayDestinationWhenRevealClicked5()
        {
            traitComboBox.SelectedIndex = 4;
            revealButton.PerformClick();
            Assert.Equal("Tokyo, Japan", destinationLabel.Text);
        }

        [Fact]
        // Description: Should display destination "Amazon Rainforest, Brazil" when `traitComboBox` is set to "Nature Lover" and `revealButton` is clicked.
        public void ShouldDisplayDestinationWhenRevealClicked6()
        {
            traitComboBox.SelectedIndex = 5;
            revealButton.PerformClick();
            Assert.Equal("Amazon Rainforest, Brazil", destinationLabel.Text);
        }
    }
}
