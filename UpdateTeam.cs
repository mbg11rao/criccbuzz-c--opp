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
    public partial class UpdateTeam : Form
    {
        TeamsClass rec = new TeamsClass();
        String a;
      
        public UpdateTeam(String team)
        {
            InitializeComponent();
            a = team;
            
            
        }
        //display team 
        public UpdateTeam(String team,bool display)
        {
            InitializeComponent();
            txt_name.ReadOnly = true;
            txt_lost_matches.ReadOnly = true;
            txt_coach.ReadOnly = true;
            txt_ranking.ReadOnly = true;
            txt_totall_player.ReadOnly = true;
            txt_WinMatches.ReadOnly = true;
            txt_captain.ReadOnly = true;
            btn_SignUp.Hide();
            button_WOC1.Text = team;
            a = team;


        }
        //if add team called 
        public UpdateTeam()
        {
            InitializeComponent();
            a = "";
            btn_SignUp.Text = "Add Team";
            button_WOC1.Text = "Add Team";
            txt_name.ReadOnly = false;
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            String textFile = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Teams\" + a;
            if (File.Exists(textFile))
            {
                
            }
            else
            {
                MessageBox.Show("This team " + txt_name.Text + " is not exist in our records");
            }
        }

        private void UpdateTeam_Load(object sender, EventArgs e)
        {
            if (a != "")
            {
                LoadUpdateteamForm();
            }
            else
            {

            }
        }

        // add team 
        private void btn_SignUp_Click_1(object sender, EventArgs e)
        {
            rec.TeamName = txt_name.Text;
            rec.Ranking = txt_ranking.Text;
            rec.TotallPlayer = txt_totall_player.Text;
            rec.LostMatcheas = txt_lost_matches.Text;
            rec.WinMatcheas = txt_WinMatches.Text;
            rec.Captain = txt_captain.Text;
            rec.Coach = txt_coach.Text;

            if (a == "")
            {
                
                if (txt_name.Text.Trim() == "" || txt_captain.Text.Trim() == "" || txt_coach.Text.Trim() == "" || txt_lost_matches.Text.Trim() == "" || txt_totall_player.Text.Trim() == "" || txt_WinMatches.Text.Trim() == "" || txt_ranking.Text.Trim() == "")

                {
                    MessageBox.Show("Please enter Complete Data");
                }
                else
                {
                    rec.addTeam();
                    this.Hide();
                }

            }
            else
            {
                rec.UpdateTeam();
                this.Hide();
            }

            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        ///***Functionon load form***//
        public void LoadUpdateteamForm()
        {
            String textFile = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Teams\" + a;
            if (File.Exists(textFile))
            {

                txt_name.Text = File.ReadLines(textFile).ElementAt(1);
                txt_captain.Text = File.ReadLines(textFile).ElementAt(2);
                txt_coach.Text = File.ReadLines(textFile).ElementAt(3);
                txt_lost_matches.Text = File.ReadLines(textFile).ElementAt(4);
                txt_ranking.Text = File.ReadLines(textFile).ElementAt(7);
                txt_totall_player.Text = File.ReadLines(textFile).ElementAt(5);
                txt_WinMatches.Text = File.ReadLines(textFile).ElementAt(6);

            }
            else
            {
                MessageBox.Show("This team " + txt_name.Text + " is not exist in our records");
            }

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

        }
    }
}
