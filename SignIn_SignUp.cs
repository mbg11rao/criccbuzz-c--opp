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
    public partial class SignIn_SignUp : Form
    {
        

        public SignIn_SignUp()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            SignInForm a = new SignInForm();
            this.Hide();
            a.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Admin_user_form a = new Admin_user_form();
            this.Hide();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SignUpForm a = new SignUpForm();
            this.Hide();
            a.Show();
        }

        private void SignIn_SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
