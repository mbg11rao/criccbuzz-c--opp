using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricBuzz
{
    public class TeamsClass
    {
        String teamName;

        public string TeamName   // property
        {
            get { return teamName; }   // get method
            set { teamName = value; }  // set method
        }
        String ranking;
        public string Ranking   // property
        {
            get { return ranking; }   // get method
            set { ranking = value; }  // set method
        }
        String totallPlayer;
        public string TotallPlayer   // property
        {
            get { return totallPlayer; }   // get method
            set { totallPlayer = value; }  // set method
        }
        String winMatcheas;
        public string WinMatcheas   // property
        {
            get { return winMatcheas; }   // get method
            set { winMatcheas = value; }  // set method
        }
        String lostMatcheas;
        public string LostMatcheas   // property
        {
            get { return lostMatcheas; }   // get method
            set { lostMatcheas = value; }  // set method
        }
        String captain;
        public string Captain   // property
        {
            get { return captain; }   // get method
            set { captain = value; }  // set method
        }
        String coach;
        public string Coach   // property
        {
            get { return coach; }   // get method
            set { coach = value; }  // set method
        }


        ///***Function for add record***//
        public void addTeam()
        {

            string path = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Teams\" + teamName;


            String teamData = "\n" + teamName + "\n" + captain + "\n" + coach + "\n" + lostMatcheas + "\n" + totallPlayer + "\n" + winMatcheas + "\n" + ranking;
            File_Handling.Write_file(teamData, path);


        }


        ///***Function for update Team***//
        public void UpdateTeam()
        {
            string path = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Teams\" + teamName;
            File.Delete(path);
            String teamData = "\n" + teamName + "\n" + captain + "\n" + coach + "\n" + lostMatcheas + "\n" + totallPlayer + "\n" + winMatcheas + "\n" + ranking;

            File_Handling.Write_file(teamData, path);


        }

        ///***Function for Delete Team***//
        public void DeleteTeam()
        {
            String textFile = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Teams\" + teamName;

            File.Delete(textFile);
           


        }
    }
}
