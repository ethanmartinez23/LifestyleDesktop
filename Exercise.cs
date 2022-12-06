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
    public partial class Exercise : Form
    {
        public Exercise()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Mens tracker = new Mens();
            this.Hide();
            tracker.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Calendar form = new Calendar();
            this.Hide();
            form.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profile form = new Profile();
            this.Hide();
            form.Show();
        }
    }
}
