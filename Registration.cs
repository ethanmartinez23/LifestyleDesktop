using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace LifestyleDesktop
{
   public partial class logForm : Form
    {
        public logForm()
        {
            InitializeComponent();
            
        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass1_Click(object sender, EventArgs e)
        {
            
        }

        private void notShow_Click(object sender, EventArgs e)
        {
        }

        private void show1_Click(object sender, EventArgs e)
        {
            if (passBox1.PasswordChar == '*')
            {
                
                notShow2.BringToFront();
                passBox1.PasswordChar = '\0';


            }
        }

        private void hide2_Click(object sender, EventArgs e)
        {
            if (passBox2.PasswordChar == '\0')
            {

                show3.BringToFront();
                passBox2.PasswordChar = '*';

            }
        }

        private void hide1_Click(object sender, EventArgs e)
        {

            if (passBox1.PasswordChar == '\0')
            {
                
                show2.BringToFront();
                passBox1.PasswordChar = '*';

            }
        }

        private void logForm_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("D:\\penna.otf");
            registerLabel.Font = new Font(pfc.Families[0], registerLabel.Font.Size, FontStyle.Regular);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            logIn reg = new logIn();
            this.Hide();
            reg.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Account Successfully Created!");
            logIn log = new logIn();    
            this.Hide();
            log.Show();
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void passBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void passBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void show3_Click(object sender, EventArgs e)
        {
            if (passBox2.PasswordChar == '*')
            {

                notShow3.BringToFront();
                passBox2.PasswordChar = '\0';


            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            usernameLabel.Hide();
            pwLabel.Show();
            confirmLabel.Show();
            emailLabel.Show();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            emailLabel.Hide();
            usernameLabel.Show();
            pwLabel.Show();
            confirmLabel.Show();

        }

        private void passBox1_Click(object sender, EventArgs e)
        {
            emailLabel.Show();
            usernameLabel.Show();
            pwLabel.Hide();
            confirmLabel.Show();
        }

        private void passBox2_Click(object sender, EventArgs e)
        {
            emailLabel.Show();
            usernameLabel.Show();
            pwLabel.Show();
            confirmLabel.Hide();
        }
    }
}
