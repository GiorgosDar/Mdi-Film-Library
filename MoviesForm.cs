using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelikhAskhsh.models;

namespace TelikhAskhsh
{
    public partial class MoviesForm : Form
    {
        MoviesContext db = new MoviesContext();


        public MoviesForm()
        {
            InitializeComponent();
        }

        private void MoviesForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Movies.ToList();

            comboBox1.DataSource = db.Categories.ToList();
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryId";
            comboBox2.DataSource = db.Applications.ToList();
            comboBox2.DisplayMember = "ApplicationName";
            comboBox2.ValueMember = "ApplicationId";


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddMovies_Click(object sender, EventArgs e)
        {
            Movie newmovie = new Movie();
            newmovie.MovieTitle = txtmovie.Text;
            newmovie.MovieDatepub = dateTimePicker1.Value;
            newmovie.MovieImdb = Convert.ToDouble(textImdb.Text);
            newmovie.MovieSeen = checkBox1.Checked;
            newmovie.MovieDateseen = dateTimePicker2.Value;
            newmovie.MovieCatid = Convert.ToInt32(comboBox1.SelectedValue);
            newmovie.MovieAvailableid = Convert.ToInt32(comboBox2.SelectedValue);
            newmovie.MovieImage = "";
            db.Movies.Add(newmovie);
            db.SaveChanges();
            dataGridView1.DataSource = db.Movies.ToList();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var rowClicked = e.RowIndex;
            var movieID = dataGridView1.Rows[rowClicked].Cells["MovieId"].Value;



            moviedetails newForm = new moviedetails(Convert.ToInt32(movieID));
            newForm.Show();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
