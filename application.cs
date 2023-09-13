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
    public partial class application : Form
    {
        MoviesContext db = new MoviesContext();
        public application()
        {
            InitializeComponent();
        }

        private void application_Load(object sender, EventArgs e)
        {
            dataGridViewApp.DataSource = db.Applications.ToList();
        }

        private void btnaddapp_Click(object sender, EventArgs e)
        {
            models.Application newapp = new models.Application();
            newapp.ApplicationName = textBox1.Text;
            db.Applications.Add(newapp);
            db.SaveChanges();
            dataGridViewApp.DataSource = db.Applications.ToList();
        }

        private void btndltapp_Click(object sender, EventArgs e)
        {

            if (dataGridViewApp.SelectedRows.Count > 0)
            {
                int selectedAppId = Convert.ToInt32(dataGridViewApp.SelectedRows[0].Cells["ApplicationId"].Value);


                var appToDelete = db.Applications.FirstOrDefault(a => a.ApplicationId == selectedAppId);

                if (appToDelete != null)
                {

                    db.Applications.Remove(appToDelete);
                    db.SaveChanges();


                    dataGridViewApp.DataSource = db.Applications.ToList();
                }
            }
            else
            {
                MessageBox.Show("Please select an application to delete.");
            }



        }
    }
}
