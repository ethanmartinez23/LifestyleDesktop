using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.CodeDom;

namespace LifestyleDesktop
{
    public partial class logIn : Form
    {
        public logIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logForm log = new logForm();
            this.Hide();
            log.Show();
        }

        private void logIn_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("D:\\penna.otf");
            labelWelcome.Font = new Font(pfc.Families[0], 60, FontStyle.Regular);

            PrivateFontCollection pfx = new PrivateFontCollection();
            pfc.AddFontFile("D:\\penna.otf");
            labelWelcome2.Font = new Font(pfc.Families[0], 60, FontStyle.Regular);

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetStarted form = new GetStarted();
            this.Hide();
            form.Show();
        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {
           
        }

        private void welcomeNot_Click(object sender, EventArgs e)
        {
         
            if (passBox.PasswordChar == '\0')
            {

                welcomeShow.BringToFront();
                passBox.PasswordChar = '*';


            }
        }

        private void welcomeShow_Click(object sender, EventArgs e)
        {
            if (passBox.PasswordChar == '*')
            {

                welcomeNot.BringToFront();
                passBox.PasswordChar = '\0';


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void labelWelcome_Enter(object sender, EventArgs e)
        {

        }

        private void passBox_Click(object sender, EventArgs e)
        {
            label1.Show();
            label4.Hide();
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label4.Show();
            label1.Hide();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
