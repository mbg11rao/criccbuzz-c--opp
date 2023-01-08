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
    public partial class MatchesForm : Form
    {
        MatchesClass mat = new MatchesClass();
        public MatchesForm()
        {
            InitializeComponent();
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            MainForm a = new MainForm();
            a.Show();
            this.Hide();
        }

        private void MatchesForm_Load(object sender, EventArgs e)
        {
            if (Admin_user_form.Admin == false)
            {
                button_WOC4.Hide();
                button_WOC3.Hide();
                button_WOC2.Hide();
            }
        }
        // update match form 
        private void button_WOC4_Click(object sender, EventArgs e)
        {
            Add_Match a = new Add_Match();
            a.Show();
        }
        //display match  form  2 argument 
        private void button_WOC21_Click(object sender, EventArgs e)
        {
            String textFile = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Matches\" + txt_name.Text;
            if (File.Exists(textFile))
            {
                Add_Match a = new Add_Match(txt_name.Text, true);
                a.Show();
            }
            else
            {
                MessageBox.Show("This Match " + txt_name.Text + " is not exist in our records", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //delete match 1 argument 
        private void button_WOC3_Click(object sender, EventArgs e)
        {
            String textFile = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Matches\" + txt_name.Text;
            if (File.Exists(textFile))
            {
                Add_Match a = new Add_Match(txt_name.Text);
                a.Show();
            }
            else
            {
                MessageBox.Show("This Match " + txt_name.Text + " is not exist in our records", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // delete match
        private void button_WOC2_Click(object sender, EventArgs e)
        {
            String textFile = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Matches\" + txt_name.Text;
            if (File.Exists(textFile))
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete this Match?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    
                    mat.DeleteMatch(txt_name.Text);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
