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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            PlayersForm newForm = new PlayersForm();
            newForm.Show();
            this.Hide();
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            TeamsForm newForm = new TeamsForm();
            newForm.Show();
            this.Hide();
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            Form10 newForm = new Form10();
            newForm.Show();
            this.Hide();
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            MatchesForm newForm = new MatchesForm();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_user_form a = new Admin_user_form();
            a.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
