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

    public partial class Add_World_Record : Form
    {
        RecordClass re = new RecordClass();

        String a;
        public Add_World_Record()
        {
            InitializeComponent();
            a = "";
            txt_Record_name.ReadOnly = false;
        }

        //diplay record 
        public Add_World_Record(String Record, bool display)
        {
            InitializeComponent();
            txt_Record_holder.ReadOnly = true;
            txt_against.ReadOnly = true;
            txt_Record_name.ReadOnly = false;
            txt_Date.ReadOnly = true;
            btn_Record.Hide();
            button_WOC1.Text = Record;
            a = Record;


        }

        //update changed
        public Add_World_Record(String record)
        {
            InitializeComponent();
            a = record;
            button_WOC1.Text = "Update " + a;
            btn_Record.Text = "Update";


        }


        private void txt_shirtNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Add_World_Record_Load(object sender, EventArgs e)
        {
            if (a != "")
            {
                txt_Record_name.ReadOnly = true;
                String textFile = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Records\" + a;
                if (File.Exists(textFile))
                {

                    txt_Record_name.Text = File.ReadLines(textFile).ElementAt(1);
                    txt_Record_holder.Text = File.ReadLines(textFile).ElementAt(2);
                    txt_against.Text = File.ReadLines(textFile).ElementAt(3);
                    txt_Date.Text = File.ReadLines(textFile).ElementAt(4);

                }
                else
                {
                    MessageBox.Show("This Record " + txt_Record_name.Text + " is not exist in our records");
                }


            }
        }
        //writing and updating 
            private void btn_Record_Click(object sender, EventArgs e)
        {
            re.RecordName = txt_Record_name.Text;
            re.RecordHolder = txt_Record_holder.Text;
            re.Opponent = txt_against.Text;
            re.Date = txt_Date.Text;
            if (a == "")
            {
                if (txt_Record_name.Text.Trim() == "" || txt_Record_holder.Text.Trim() == "" || txt_Date.Text.Trim() == "" || txt_against.Text.Trim() == "")

                {
                    MessageBox.Show("Please enter Complete Data");
                }
                else
                {
                    re.addRecord();
                    this.Hide();
                }
                
            }
            else
            {
                re.UpdateRecord();
                this.Hide();
            }

        }

        
    }
}
