namespace TelikhAskhsh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            categories formCategories = new categories();
            formCategories.MdiParent = this;
            formCategories.Show();

        }

        private void ÁËÔÔÈÔÚToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actors formActors = new actors();
            formActors.MdiParent = this;
            formActors.Show();
        }

        private void Ù·ÈÌﬂÂÚToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoviesForm formMovies = new MoviesForm();
            formMovies.MdiParent = this;
            formMovies.Show();
        }

        private void btnapp_Click(object sender, EventArgs e)
        {
            application application = new application();
            application.MdiParent = this;
            application.Show();
        }
    }
}