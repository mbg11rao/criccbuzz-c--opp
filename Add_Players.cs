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
    
    
    public partial class Add_Players : Form
    {
        PlayersClass pl = new PlayersClass();
        //use for player name place 
        String a;
        public Add_Players() // constructor of ADD player form
        {
            InitializeComponent();
            a = "";
            txt_name.ReadOnly = false;
        }


        public Add_Players(String player, bool display) // call display functions 
        {
            InitializeComponent();
            txt_name.ReadOnly = true;
            txt_averege.ReadOnly = true;
            txt_match_played.ReadOnly = true;
            txt_ranking.ReadOnly = true;
            txt_shirtNo.ReadOnly = true;
            txt_totall_runs.ReadOnly = true;
            txt_totall_wickets.ReadOnly = true;
            btn_SignUp.Hide();
            button_WOC1.Text = player;
            a = player;


        }


        public Add_Players(String player) // call update functions 
        {
            InitializeComponent();
            a = player;
            button_WOC1.Text = "Update " + a; // replace add to update 
            btn_SignUp.Text = "Update";


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            pl.Avg = txt_averege.Text;
            pl.Name = txt_name.Text;
            pl.Ranking = txt_ranking.Text;
            pl.TotallRuns = txt_totall_runs.Text;
            pl.TotallWickets = txt_totall_wickets.Text;
            pl.ShirtNo = txt_shirtNo.Text;
            pl.MatchPlay = txt_match_played.Text;
            if (a == "")
            {
                if (txt_averege.Text.Trim() == "" || txt_match_played.Text.Trim() == "" || txt_name.Text.Trim() == "" || txt_ranking.Text.Trim() == "" || txt_shirtNo.Text.Trim() == "" || txt_totall_runs.Text.Trim() == "" || txt_totall_wickets.Text.Trim() == "")

                {
                    MessageBox.Show("Please enter Complete Data");
                }
                else
                {
                    pl.addPlayer();
                    this.Hide();
                }
                //AddRecord();
            }
            else
            {
                pl.UpdatePlayer();
                this.Hide();
            }



        }
        //diplaying  loaded data on form
        private void Add_Players_Load(object sender, EventArgs e)
        {
            if (a != "")
            {
                txt_name.ReadOnly = true;
                String textFile = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Players\" + a;
                if (File.Exists(textFile))
                {

                    txt_name.Text = File.ReadLines(textFile).ElementAt(1);
                    txt_totall_wickets.Text = File.ReadLines(textFile).ElementAt(2);
                    txt_totall_runs.Text = File.ReadLines(textFile).ElementAt(3);
                    txt_shirtNo.Text = File.ReadLines(textFile).ElementAt(4);
                    txt_match_played.Text = File.ReadLines(textFile).ElementAt(5);
                    txt_ranking.Text = File.ReadLines(textFile).ElementAt(7);
                    txt_averege.Text = File.ReadLines(textFile).ElementAt(6);

                }
                else
                {
                    MessageBox.Show("This Player " + txt_name.Text + " is not exist in our records");
                }

            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

        }
    }
}
