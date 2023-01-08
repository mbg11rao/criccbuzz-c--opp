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
    public partial class Form10 : Form
    {
        RecordClass rec = new RecordClass();
        public Form10()
        {
            InitializeComponent();
        }

        private void button_WOC15_Click(object sender, EventArgs e)
        {

        }
        //display form
        private void button_WOC18_Click(object sender, EventArgs e)
        {
            String textFile = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Records\" + txt_name.Text;
            if (File.Exists(textFile))
            {
                Add_World_Record a = new Add_World_Record(txt_name.Text, true);
                a.Show();
            }
            else
            {
                MessageBox.Show("This Record " + txt_name.Text + " is not exist in our records", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_WOC16_Click(object sender, EventArgs e)
        {
            MainForm a = new MainForm();
            a.Show();
            this.Hide();
        }
        //add record 
        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Add_World_Record a = new Add_World_Record();
            a.Show();
        }
        //update record 
        private void button_WOC3_Click(object sender, EventArgs e)
        {
            String textFile = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Records\" + txt_name.Text;
            if (File.Exists(textFile))
            {
                Add_World_Record a = new Add_World_Record(txt_name.Text);
                a.Show();
            }
            else
            {
                MessageBox.Show("This Record " + txt_name.Text + " is not exist in our records", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        //remove record 
        private void button_WOC4_Click(object sender, EventArgs e)
        {
            String textFile = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Records\" + txt_name.Text;
            if (File.Exists(textFile))
            {
                rec.RecordName = txt_name.Text;
                DialogResult dr = MessageBox.Show("Are you sure to delete this Player?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    rec.DeleteRecord();
                    MessageBox.Show("successfully delete this Record");
                    txt_name.Clear();
                }
                else if (dr == DialogResult.No)
                {

                }


            }
            else
            {
                MessageBox.Show("This Player " + txt_name.Text + " is not exist in our records", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        

        private void Form10_Load(object sender, EventArgs e)
        {


            if (Admin_user_form.Admin == false)
            {
                button_WOC4.Hide();
                button_WOC3.Hide();
                button_WOC2.Hide();
            }
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            MainForm a = new MainForm();
            a.Show();
            this.Hide();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
