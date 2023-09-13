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
    public partial class actors : Form
    {
        MoviesContext db = new MoviesContext();
        public actors()
        {
            InitializeComponent();
        }

        private void actors_Load(object sender, EventArgs e)
        {
            dataGridViewAct.DataSource = db.Actors.ToList();

        }

        private void btnaddact_Click(object sender, EventArgs e)
        {
            Actor newactor = new Actor();
            newactor.ActorName = textBox1.Text;
            db.Actors.Add(newactor);
            db.SaveChanges();
            dataGridViewAct.DataSource = db.Actors.ToList();


        }

        private void btndltact_Click(object sender, EventArgs e)
        {

            if (dataGridViewAct.SelectedRows.Count > 0)
            {

                int actorId = (int)dataGridViewAct.SelectedRows[0].Cells["ActorId"].Value;
                Actor actor = db.Actors.Find(actorId);


                db.Actors.Remove(actor);
                db.SaveChanges();


                dataGridViewAct.DataSource = db.Actors.ToList();
            }
            else
            {
                MessageBox.Show("Please select an actor to delete.");
            }



        }
    }
}
