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
    public partial class Form1 : Form
    {
        Timer tmr;


        public Form1()
        {
            InitializeComponent();
           
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
           
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmr = new Timer();

            //set time interval 4sec

            tmr.Interval = 4000;

            //starts the timer

            tmr.Start();

            tmr.Tick += tmr_Tick;
        }
        void tmr_Tick(object sender, EventArgs e)

        {

            //after 4 sec stop the timer

            tmr.Stop();

            //display mainform

            Admin_user_form mf = new Admin_user_form();

            mf.Show();

            //hide this form

            this.Hide();

        }
    }
}
