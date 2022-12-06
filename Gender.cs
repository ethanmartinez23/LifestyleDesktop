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
    public partial class Gender : Form
    {
        public Gender()
        {
            InitializeComponent();
        }

        private void nextCreation_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Age age = new Age();
            this.Hide();
            age.Show();
        }
    }
}
