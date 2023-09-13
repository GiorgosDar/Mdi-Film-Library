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

    public partial class moviedetails : Form
    {
        MoviesContext db = new MoviesContext();
        public moviedetails(Int32 movieid)
        {
            InitializeComponent();
            var theMovie = db.Movies.Find(movieid);
            textBox1.Text = theMovie.MovieTitle;
        }

        private void moviedetails_Load(object sender, EventArgs e)
        {

        }
    }
}
