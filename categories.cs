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
    public partial class categories : Form
    {
        MoviesContext db = new MoviesContext();
        public categories()
        {
            InitializeComponent();
        }

        private void categories_Load(object sender, EventArgs e)
        {
            dataGridViewCat.DataSource = db.Categories.ToList();
        }

        private void btnaddcat_Click(object sender, EventArgs e)
        {
            Category newcat = new Category();
            newcat.CategoryName = textBox1.Text;
            db.Categories.Add(newcat);
            db.SaveChanges();
            dataGridViewCat.DataSource = db.Categories.ToList();

        }

        private void btndltcat_Click(object sender, EventArgs e)
        {

            if (dataGridViewCat.SelectedRows.Count > 0)
            {

                int categoryId = (int)dataGridViewCat.SelectedRows[0].Cells["CategoryId"].Value;
                Category category = db.Categories.Find(categoryId);


                db.Categories.Remove(category);
                db.SaveChanges();


                dataGridViewCat.DataSource = db.Categories.ToList();
            }
            else
            {
                MessageBox.Show("Please select a category to delete.");
            }
        }



    }
    }

