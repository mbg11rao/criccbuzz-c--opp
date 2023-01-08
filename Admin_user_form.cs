using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricBuzz
{
    public partial class Admin_user_form : Form
    {
        public static bool Admin=false;
        public Admin_user_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin = true;
            SignInForm newForm = new SignInForm();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin = false;
            SignIn_SignUp newForm = new SignIn_SignUp();
            newForm.Show();
            this.Hide();

        }

        private void Admin_user_form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
