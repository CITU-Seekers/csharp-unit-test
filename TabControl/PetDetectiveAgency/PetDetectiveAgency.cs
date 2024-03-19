namespace CodeChum
{
    public partial class PetDetectiveAgency : Form
    {
        private string PetName;
        private string PetType;
        private string Clues;
        private string Statements;

        public PetDetectiveAgency()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            PetName = petNameTextBox.Text;
            PetType = petTypeTextBox.Text;
            Clues = cluesTextBox.Text;
            Statements = statementsTextBox.Text;

            // Create a new tab page with all the information from the textboxes and put it in labels
            TabPage newPage = new TabPage();
            newPage.Text = PetName;
            newPage.Name = PetName;

            // Create labels for the information
            Label petNameLabel = new Label();
            petNameLabel.Name = "petNameLabel";
            petNameLabel.Text = "Name: " + PetName;
            petNameLabel.Location = petNameTextBox.Location;
            petNameLabel.AutoSize = true;
            newPage.Controls.Add(petNameLabel);

            Label petTypeLabel = new Label();
            petTypeLabel.Name = "petTypeLabel";
            petTypeLabel.Text = "Pet Type: " + PetType;
            petTypeLabel.Location = petTypeTextBox.Location;
            petTypeLabel.AutoSize = true;
            newPage.Controls.Add(petTypeLabel);

            Label cluesLabel = new Label();
            cluesLabel.Name = "cluesLabel";
            cluesLabel.Text = "Clues: \r\n" + Clues;
            cluesLabel.Location = cluesTextBox.Location;
            cluesLabel.AutoSize = true;
            newPage.Controls.Add(cluesLabel);

            Label statementsLabel = new Label();
            statementsLabel.Name = "statementsLabel";
            statementsLabel.Text = "Statements: \r\n" + Statements;
            statementsLabel.Location = statementsTextBox.Location;
            statementsLabel.AutoSize = true;
            newPage.Controls.Add(statementsLabel);

            //Copy the picture box to the new tab
            PictureBox petPictureBox = new PictureBox();
            petPictureBox.Image = pictureBox1.Image;
            petPictureBox.Location = pictureBox1.Location;
            petPictureBox.Size = pictureBox1.Size;
            petPictureBox.SizeMode = pictureBox1.SizeMode;
            newPage.Controls.Add(petPictureBox);

            //Create a button named CaseSolved and add it to the new tab page and this button will close the tab page
            Button caseSolvedButton = new Button();
            caseSolvedButton.Name = "caseSolvedButton";
            caseSolvedButton.Text = "Case Solved";
            caseSolvedButton.Location = createButton.Location;
            caseSolvedButton.AutoSize = true;
            caseSolvedButton.Click += (s, args) => mainTabControl.TabPages.Remove(newPage);
            newPage.Controls.Add(caseSolvedButton);


            // Add the newPage to the TabControl
            mainTabControl.TabPages.Add(newPage);
        }
    }
}
