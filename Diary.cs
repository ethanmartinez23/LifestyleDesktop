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
    public partial class Diary : Form
    {
        public Diary()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Calendar form = new Calendar();
            this.Hide();
            form.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GetStarted form = new GetStarted();
            this.Hide();
            form.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profile form = new Profile();
            this.Hide();
            form.Show();
        }
    }
}
