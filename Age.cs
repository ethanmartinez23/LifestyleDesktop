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
    public partial class Age : Form
    {
        public Age()
        {
            InitializeComponent();
        }

        private void nextCreation_Click(object sender, EventArgs e)
        {
            Gender gender = new Gender();
            this.Hide();
            gender.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Profile form = new Profile();
            this.Hide();
            form.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
