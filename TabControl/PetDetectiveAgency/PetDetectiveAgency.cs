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
            PetName = txtPetName.Text;
            PetType = txtPetType.Text;
            Clues = txtClues.Text;
            Statements = txtStatements.Text;

            // Create a new tab page with all the information from the textboxes and put it in labels
            TabPage newPage = new TabPage();
            newPage.Text = PetName;
            newPage.Name = PetName;

            // Create labels for the information
            Label petNameLabel = new Label();
            petNameLabel.Name = "PetNameLabel";
            petNameLabel.Text = "Name: " + PetName;
            petNameLabel.Location = txtPetName.Location;
            petNameLabel.AutoSize = true;
            newPage.Controls.Add(petNameLabel);

            Label petTypeLabel = new Label();
            petTypeLabel.Name = "PetTypeLabel";
            petTypeLabel.Text = "Pet Type: " + PetType;
            petTypeLabel.Location = txtPetType.Location;
            petTypeLabel.AutoSize = true;
            newPage.Controls.Add(petTypeLabel);

            Label cluesLabel = new Label();
            cluesLabel.Name = "CluesLabel";
            cluesLabel.Text = "Clues: \r\n" + Clues;
            cluesLabel.Location = txtClues.Location;
            cluesLabel.AutoSize = true;
            newPage.Controls.Add(cluesLabel);

            Label statementsLabel = new Label();
            statementsLabel.Name = "StatementsLabel";
            statementsLabel.Text = "Statements: \r\n" + Statements;
            statementsLabel.Location = txtStatements.Location;
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
            caseSolvedButton.Name = "CaseSolvedButton";
            caseSolvedButton.Text = "Case Solved";
            caseSolvedButton.Location = CreateButton.Location;
            caseSolvedButton.AutoSize = true;
            caseSolvedButton.Click += (s, args) => MainTabControl.TabPages.Remove(newPage);
            newPage.Controls.Add(caseSolvedButton);


            // Add the newPage to the TabControl
            MainTabControl.TabPages.Add(newPage);
        }
    }
}
