using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CricBuzz
{
    class File_Handling
    {
        public static bool data_presnt;
        public static void Write_file(String data, String path)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(data);
                    MessageBox.Show("Successfully data proceed");

                }


            }
            catch (System.IO.DirectoryNotFoundException )
            {
                MessageBox.Show("error");
            }
        }

        public static void read_file(String data,String path,bool display)
        {
            using (StreamReader sr = File.OpenText("Text_file"))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    if (s == data)
                    {
                        s = null;
                        data_presnt = true;
                        MessageBox.Show("You successfully Login");
                        

                       
                        break;

                    }

                }
                if (s != null || s == "")
                {
                    MessageBox.Show("Please Enter a valid Credentials");
                }
            }


        }
       
        public static bool check_file(String data, String path)
        {
           bool a= File.ReadLines(path).Any(line => line.Contains(data));
            return a;
        }

        
        
    }
}
