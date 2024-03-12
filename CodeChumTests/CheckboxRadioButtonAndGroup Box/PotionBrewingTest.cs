namespace CodeChum.Tests
{
    public class PotionBrewingTest
    {
        PotionBrewing? form;
        Label? descriptionLabel;
        TextBox? textBox1;
        Button? concoctButton;
        GroupBox? groupBox1, groupBox2, groupBox3;
        CheckBox? checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6;
        RadioButton? radioButton1, radioButton2, radioButton3;

        public PotionBrewingTest()
        {
            form = new PotionBrewing();
            form.Show();
            descriptionLabel = (Label)TestUtils.GetControlNamed(form, "descriptionLabel", true);
            textBox1 = (TextBox)TestUtils.GetControlNamed(form, "textBox1", true);
            concoctButton = (Button)TestUtils.GetControlNamed(form, "concoctButton", true);
            groupBox1 = (GroupBox)TestUtils.GetControlNamed(form, "groupBox1", true);
            groupBox2 = (GroupBox)TestUtils.GetControlNamed(form, "groupBox2", true);
            groupBox3 = (GroupBox)TestUtils.GetControlNamed(form, "groupBox3", true);
            checkBox1 = (CheckBox)TestUtils.GetControlNamed(form, "checkBox1", true);
            checkBox2 = (CheckBox)TestUtils.GetControlNamed(form, "checkBox2", true);
            checkBox3 = (CheckBox)TestUtils.GetControlNamed(form, "checkBox3", true);
            checkBox4 = (CheckBox)TestUtils.GetControlNamed(form, "checkBox4", true);
            checkBox5 = (CheckBox)TestUtils.GetControlNamed(form, "checkBox5", true);
            checkBox6 = (CheckBox)TestUtils.GetControlNamed(form, "checkBox6", true);
            radioButton1 = (RadioButton)TestUtils.GetControlNamed(form, "radioButton1", true);
            radioButton2 = (RadioButton)TestUtils.GetControlNamed(form, "radioButton2", true);
            radioButton3 = (RadioButton)TestUtils.GetControlNamed(form, "radioButton3", true);
        }

        [Fact]
        // Description: Should have all controls `descriptionLabel`, `textBox1`, `concoctButton`, `groupBox1`, `groupBox2`, `groupBox3`, `checkBox1`, `checkBox2`, `checkBox3`, `checkBox4`, `checkBox5`, `checkBox6`, `radioButton1`, `radioButton2`, and `radioButton3`.
        public void ShouldHaveAllControls()
        {
            Assert.NotNull(descriptionLabel);
            Assert.NotNull(textBox1);
            Assert.NotNull(concoctButton);
            Assert.NotNull(groupBox1);
            Assert.NotNull(groupBox2);
            Assert.NotNull(groupBox3);
            Assert.NotNull(checkBox1);
            Assert.NotNull(checkBox2);
            Assert.NotNull(checkBox3);
            Assert.NotNull(checkBox4);
            Assert.NotNull(checkBox5);
            Assert.NotNull(checkBox6);
            Assert.NotNull(radioButton1);
            Assert.NotNull(radioButton2);
            Assert.NotNull(radioButton3);
        }

        [Fact]
        // Description: Should display correct ingredients when `checkBox1`, `checkBox2`, and `checkBox3` are checked and `concoctButton` is clicked.
        public void ShouldDisplayCorrectBaseIngredients()
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;

            concoctButton.PerformClick();

            Assert.Equal(" Base Ingredients: Dragon Scale, Moonlight Essence, Fairy Dust" +
                         "\n together with the enhancements: " +
                         "\n with the effect of: Unknown Effect" +
                         "\n Potion name: ", descriptionLabel.Text);
        }

        [Fact]
        // Description: Should display correct enhancements when `checkBox4`, `checkBox5`, and `checkBox6` are checked and `concoctButton` is clicked.
        public void ShouldDisplayCorrectEnhancements()
        {
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox6.Checked = true;

            concoctButton.PerformClick();

            Assert.Equal(" Base Ingredients: " +
                         "\n together with the enhancements: Shadowy Secrets, Fae Favors, Whispers of Wonder" +
                         "\n with the effect of: Unknown Effect" +
                         "\n Potion name: ", descriptionLabel.Text);
        }

        [Fact]
        // Description: Should display correct effect when `radioButton1` is checked and `concoctButton` is clicked.
        public void ShouldDisplayCorrectEffect()
        {
            radioButton1.Checked = true;

            concoctButton.PerformClick();

            Assert.Equal(" Base Ingredients: " +
                         "\n together with the enhancements: " +
                         "\n with the effect of: Strengths" +
                         "\n Potion name: ", descriptionLabel.Text);
        }

        [Fact]
        // Description: Should display correct potion name when `textBox1` is set to "Potion of Wonder", `checkBox1`, `checkBox2`, `checkBox3`, `checkBox4`, `checkBox5`, `checkBox6`, and `radioButton1` are checked and `concoctButton` is clicked.
        public void ShouldDisplayCorrectPotionDescription()
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox6.Checked = true;
            radioButton1.Checked = true;
            textBox1.Text = "Potion of Wonder";

            concoctButton.PerformClick();

            Assert.Equal(" Base Ingredients: Dragon Scale, Moonlight Essence, Fairy Dust" +
                         "\n together with the enhancements: Shadowy Secrets, Fae Favors, Whispers of Wonder" +
                         "\n with the effect of: Strengths" +
                         "\n Potion name: Potion of Wonder", descriptionLabel.Text);
        }

    }
}
