using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CricBuzz
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Admin_user_form.Admin==false)
            {
                if (txt_username.Text.Trim() == "" || txt_email.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter Complete Data");
                }
                else
                {

                    File_Handling.read_file(txt_username.Text + txt_email.Text, "Text_file",false);
                    if (File_Handling.data_presnt == true)
                    {
                        File_Handling.data_presnt = false;
                        MainForm a = new MainForm();
                        a.Show();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid Data");
                    }
                }
            }
            else
            {
                if (txt_username.Text.Trim() == "cricbuzz" && txt_email.Text.Trim() == "123mhm")
                {
                    MessageBox.Show("You successfully login");
                    MainForm a = new MainForm();
                    a.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Please enter valid  Data");
                }

                if (txt_username.Text.Trim() == "" || txt_email.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter Complete Data");
                }
               

            }
         
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (Admin_user_form.Admin == true)
            {
                Admin_user_form.Admin = false;
                Admin_user_form b = new Admin_user_form();
                this.Hide();
                b.Show();

            }
            else
            {
                SignIn_SignUp a = new SignIn_SignUp();
                this.Hide();
                a.Show();
            }
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }
    }
        }
    

