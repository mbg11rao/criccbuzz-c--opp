using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricBuzz
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Trim() == "" || txt_email.Text.Trim() == "" || txt_confirmpass.Text.Trim() == "" || txt_password.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Complete Data");
            }
            else if(txt_password.Text.Trim() != txt_confirmpass.Text.Trim())
            {
                MessageBox.Show("Password Are Not Same ");

            }
            else
            {
                
                try
                {
                    File_Handling.Write_file(txt_username.Text + txt_password.Text, "Text_file");
                    SignInForm b = new SignInForm();
                    b.Show();
                    this.Hide();
                }
                catch (System.IO.DirectoryNotFoundException )
                {
                    MessageBox.Show("error");
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            SignIn_SignUp a = new SignIn_SignUp();
            this.Hide();
            a.Show();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
