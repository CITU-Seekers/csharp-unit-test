namespace CodeChum
{
    public partial class PictureExplorer : Form
    {
        public OpenFileDialog OpenFileDialog { get; set; }
        public PictureExplorer(OpenFileDialog openFileDialog = null)
        {
            InitializeComponent();
            OpenFileDialog = openFileDialog ?? new OpenFileDialog();
        }
        public void OpenPicture(string fileName)
        {
            pictureBox.Load(fileName);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();

            //Get the file name
            string fileName = OpenFileDialog.FileName;
            if (fileName != null)
            {
                OpenPicture(fileName);
            }
        }
    }
}
