using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace CricBuzz
{
    class functions

    {
        public static bool g = false;
        ///UserControl a = new UserControl();

        protected MySqlConnection getConnection()
        {

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "Server=localhost;Database=cafe_database;Uid=root;Pwd=''";

            return con;
        }

        ////fetching
        public DataSet getData(string query)
        {
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

        public void setData(string query)
        {

            try
            {


                MySqlConnection con = getConnection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;


                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("successfully data proceed", "success");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// checking data

        public void checkData(string query)
        {
            MySqlConnection con = getConnection();
            MySqlDataAdapter da = new MySqlDataAdapter(query, con);
            DataTable dtbi = new DataTable();
            da.Fill(dtbi);
            if (dtbi.Rows.Count == 1)
            {
                MessageBox.Show("You Successfully Login");
                g = true;

            }
            else
            {
                MessageBox.Show("Please enter Valid Cradentials");
            }


        }
    }

}


//using System;
//namespace CricBuzz
//public class Class1
//{
//	public Class1()
//	{

//         public String name { get; set; };
//    public int Shirt_No { get; set; };
//    public double Averege { get; set; };
//    public int ranking { get; set; };
//    public int shirt_num { get; set; };
//    public int tital_runs { get; set; };
//    public int matches_played { get; set; };
//    //public int totall_wickets { get; set; };

//}
//}
