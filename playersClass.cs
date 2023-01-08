using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricBuzz
{
    class PlayersClass
    {
        String name;

        public string Name  // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
        String shirtNo;
        public string ShirtNo   
        {
            get { return shirtNo; }   
            set { shirtNo = value; }  
        }
        String avg;
        public string Avg   
        {
            get { return avg; }   
            set { avg = value; }  
        }
        String ranking;
        public string Ranking   
        {
            get { return ranking; }   
            set { ranking = value; }  
        }
        String totallRuns;
        public string TotallRuns  
        {
            get { return totallRuns; }   
            set { totallRuns = value; }  
        }
        String matchPlay;
        public string MatchPlay   
        {
            get { return matchPlay; }
            set { matchPlay = value; }
        }

        String totalWicket;
        public string TotallWickets   
        {
            get { return totalWicket; }
            set { totalWicket = value; }
        }


        ///***Function for add Player***//
        public void addPlayer()
        {

            string path = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Players\" + name;
            String teamData = "\n" + name + "\n" + totalWicket + "\n" + totallRuns + "\n" + shirtNo + "\n" + matchPlay + "\n" + avg + "\n" + ranking;
            File_Handling.Write_file(teamData, path);


        }


        ///***Function for update Player***//
        public void UpdatePlayer()
        {
            string path = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Players\" + name;
            File.Delete(path);
            String teamData = "\n" + name + "\n" + totalWicket + "\n" + totallRuns + "\n" + shirtNo + "\n" + matchPlay + "\n" + avg + "\n" + ranking;

            File_Handling.Write_file(teamData, path);


        }

        ///***Function for Delete Player***//
        public void DeleteMatch(String delPlayer)
        {
            String textFile = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Players\" + delPlayer;

            File.Delete(textFile);



        }
    }
}
