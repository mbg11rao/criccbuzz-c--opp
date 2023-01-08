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
    public partial class Add_Match : Form
    {
        MatchesClass mat = new MatchesClass();
        string a;
        public Add_Match()
        {
            InitializeComponent();
            a = "";
        }
        //constructor for display
        public Add_Match(String match, bool display)
        {
            InitializeComponent();
            txt_team2.ReadOnly = true;
            txt_team1.ReadOnly = true;
            txt_tournament_name.ReadOnly = true;
            txt_umpires.ReadOnly = true;
            txt_venue.ReadOnly = true;
            txt_match_type.ReadOnly = true;
            txt_match_status.ReadOnly = true;
            txt_date.ReadOnly = true;
            btn_add_Match.Hide();
            button_WOC1.Text = match;
            a = match;


        }

        //constructor for Update

        public Add_Match(String player)
        {
            InitializeComponent();
            a = player;
            button_WOC1.Text = "Update " + a;
            btn_add_Match.Text = "Update";


        }

        private void Add_Match_Load(object sender, EventArgs e)
        {
            if (a != "")
            {
                String textFile = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Matches\" + a;
                if (File.Exists(textFile))
                {

                    txt_team1.Text = File.ReadLines(textFile).ElementAt(1);
                    txt_team2.Text = File.ReadLines(textFile).ElementAt(2);
                    txt_date.Text = File.ReadLines(textFile).ElementAt(3);
                    txt_venue.Text = File.ReadLines(textFile).ElementAt(4);
                    txt_match_type.Text = File.ReadLines(textFile).ElementAt(5);
                    txt_tournament_name.Text = File.ReadLines(textFile).ElementAt(6);
                    txt_umpires.Text = File.ReadLines(textFile).ElementAt(7);
                    txt_match_status.Text = File.ReadLines(textFile).ElementAt(8);

                }

                else
                {
                    MessageBox.Show("This Player  is not exist in our records");
                }

            }
        }

        private void btn_add_Match_Click(object sender, EventArgs e)
        {
            mat.Date = txt_date.Text;
            mat.MatchStatus = txt_match_status.Text;
            mat.Team1 = txt_team1.Text;
            mat.Team2 = txt_team2.Text;
            mat.TourName = txt_tournament_name.Text;
            mat.Umpires = txt_umpires.Text;
            mat.Venue = txt_venue.Text;
            mat.MatchType = txt_match_type.Text;
            if (a == "")
            {
                if (txt_date.Text.Trim() == "" || txt_match_status.Text.Trim() == "" || txt_match_type.Text.Trim() == "" || txt_team1.Text.Trim() == "" || txt_team2.Text.Trim() == "" || txt_tournament_name.Text.Trim() == "" || txt_umpires.Text.Trim() == "" || txt_venue.Text.Trim() == "")

                {
                    MessageBox.Show("Please enter Complete Data");
                }
                else
                {
                    mat.addMatch();
                    this.Hide();
                }
                
            }
            else
            {
                mat.UpdateMatch();
                this.Hide();
            }

           
        }


        

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_team1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
