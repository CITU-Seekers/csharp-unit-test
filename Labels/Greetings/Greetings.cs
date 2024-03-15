namespace CodeChum
{
    public partial class Greetings : Form
    {
        public Greetings()
        {
            InitializeComponent();
            InitializeUI();
        }

        protected void InitializeUI()
        {
            // Initial setup code
            label1.Text = "Welcome from Planet Quark!";
            label2.Text = "Population: 12 billion friendly aliens.";
            label3.Text = "Greetings in Quarkian: Bloop Blorp!";
            label4.Text = "Favorite pastimes: Stargazing, intergalactic travel, and solving coding puzzles.";

            // Customize appearance (optional):
            label1.Font = new Font(label1.Font.FontFamily, 18);
            label2.ForeColor = System.Drawing.Color.Blue;
            label4.TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
