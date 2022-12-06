using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifestyleDesktop
{
    public partial class Mens : Form
    {
        public Mens()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Exercise form = new Exercise();
            this.Hide();
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Profile form = new Profile();
            this.Hide();
            form.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profile form = new Profile();
            this.Hide();
            form.Show();
        }

        private void Mens_Load(object sender, EventArgs e)
        {

        }
    }
}
