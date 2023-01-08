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
    public partial class TeamsForm : Form
    {
        TeamsClass rec = new TeamsClass();
        
        public TeamsForm()
        {
            
            InitializeComponent();
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            MainForm a = new MainForm();
            a.Show();
            this.Hide();
        }

        private void TeamsForm_Load(object sender, EventArgs e)
        {

            if (Admin_user_form.Admin == false)
            {
                button_WOC4.Hide();
                button_WOC3.Hide();
                button_WOC2.Hide();
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

        }
        //diplay team 2 arguments 
        private void button_WOC21_Click(object sender, EventArgs e)
        {
            String textFile = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Teams\" + txt_name.Text;
            if (File.Exists(textFile))
            {
                UpdateTeam a = new UpdateTeam(txt_name.Text,true);
                a.Show();
            }
            else
            {
                MessageBox.Show("This team " + txt_name.Text + " is not exist in our records", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        //Delete team 

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            String textFile = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Teams\" + txt_name.Text;
            if (File.Exists(textFile))
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete this team?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    rec.TeamName = txt_name.Text;
                    rec.DeleteTeam();
                    MessageBox.Show("successfully delete this Team");
                    txt_name.Clear();
                }
                else if (dr == DialogResult.No)
                {
                    
                }
               
                
                
            }
            else
            {
                MessageBox.Show("This team " + txt_name.Text + " is not exist in our records", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }
        //Update team offical form 

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            String textFile = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Teams\" + txt_name.Text;
            if (File.Exists(textFile))
            {
                UpdateTeam a = new UpdateTeam(txt_name.Text);
                a.Show();
            }
            else
            {
                MessageBox.Show("This team " + txt_name.Text + " is not exist in our records", "Not Found",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        //add team 
        private void button_WOC4_Click(object sender, EventArgs e)
        {
            UpdateTeam a = new UpdateTeam();
            a.Show();
        }

     
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
