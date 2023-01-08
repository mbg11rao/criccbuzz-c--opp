using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricBuzz
{
    public class RecordClass
    {
        String recordName;

        public string RecordName   // property
        {
            get { return recordName; }   // get method
            set { recordName = value; }  // set method
        }
        String recordHolder;
        public string RecordHolder   
        {
            get { return recordHolder; }  
            set { recordHolder = value; }  
        }
        String opponent;
        public string Opponent   
        {
            get { return opponent; }   
            set { opponent = value; }  
        }
        String date;
        public string Date  
        {
            get { return date; }   
            set { date = value; }  
        }

        ///***Function for add record***//
        public void addRecord()
        {

            string path = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Records\" + recordName;

            String teamData = "\n" + recordName + "\n" + recordHolder + "\n" + opponent + "\n" + date;
            File_Handling.Write_file(teamData, path);


        }


        ///***Function for update record***//
        public void UpdateRecord()
        {
            string path = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Records\" + recordName;
            File.Delete(path);
            String teamData = "\n" + recordName + "\n" + recordHolder + "\n" + opponent + "\n" + Date;

            File_Handling.Write_file(teamData, path);


        }

        ///***Function for Delete record***//
        public void DeleteRecord()
        {
            String textFile = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Records\" + recordName;

            File.Delete(textFile);



        }
    }
}
