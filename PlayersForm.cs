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
    public partial class PlayersForm : Form
    {
        PlayersClass pl = new PlayersClass();
        public PlayersForm()
        {
            InitializeComponent();
        }
        //add player   0 argument
        private void button_WOC4_Click(object sender, EventArgs e)
        {
            //Add_players form will be shown
            Add_Players a = new Add_Players();
            a.Show();
        }
        //display player    2 argument string display
        private void button_WOC15_Click(object sender, EventArgs e)
        {
            String textFile = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Players\" + txt_name.Text;
            
            if (File.Exists(textFile))
            {
                Add_Players a = new Add_Players(txt_name.Text, true);
                a.Show();
            }
            else
            {
                MessageBox.Show("This Player " + txt_name.Text + " is not exist in our records", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //delete player 
        private void button_WOC2_Click(object sender, EventArgs e)
        {
            String textFile = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Players\" + txt_name.Text;
         
            if (File.Exists(textFile))
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete this Player?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    
                    pl.DeleteMatch(txt_name.Text);
                    MessageBox.Show("successfully delete this Player");
                    txt_name.Clear();
                }
                else if (dr == DialogResult.No)
                {

                }        
            }
            else
            {
                MessageBox.Show("This Player " + txt_name.Text + " is not exist in our records");
            }
        }

        //update player 1 argument 
       
        private void button_WOC3_Click(object sender, EventArgs e)
        {
            String textFile = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Players\" + txt_name.Text;
            if (File.Exists(textFile))
            {
                Add_Players a = new Add_Players(txt_name.Text);
                a.Show();
              
            }
            else
            {
                MessageBox.Show("This Player " + txt_name.Text + " is not exist in our records", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void PlayersForm_Load(object sender, EventArgs e)
        {
            if (Admin_user_form.Admin == false)
            {
                button_WOC4.Hide();
                button_WOC3.Hide();
                button_WOC2.Hide();
            }
           
        }

      

        private void button_WOC6_Click(object sender, EventArgs e)
        {
 

        }

        private void button_WOC6_Click_1(object sender, EventArgs e)
        {
            MainForm a = new MainForm();
            a.Show();
            this.Hide();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
