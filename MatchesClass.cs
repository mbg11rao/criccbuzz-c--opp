using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricBuzz
{
    class MatchesClass
    {
        String team1;

        public string Team1  // property
        {
            get { return team1; }   // get method
            set { team1 = value; }  // set method
        }
        String team2;
        public string Team2   // property
        {
            get { return team2; }   // get method
            set { team2 = value; }  // set method
        }
        String date;
        public string Date   // property
        {
            get { return date; }   // get method
            set { date = value; }  // set method
        }
        String venue;
        public string Venue   // property
        {
            get { return venue; }   // get method
            set { venue = value; }  // set method
        }
        String matchType;
        public string MatchType   // property
        {
            get { return matchType; }   // get method
            set { matchType = value; }  // set method
        }
        String tourName;
        public string TourName   // property
        {
            get { return tourName; }
            set { tourName= value; }
        }// get method
        String umpires;
        public string Umpires   // property
        {
            get { return umpires; }   // get method
            set { umpires = value; }  // set method
        }
        String matchStatus;
        public string MatchStatus   // property
        {
            get { return matchStatus; }
            set { matchStatus = value; }
        }


        ///***Function for add Match***//
        public void addMatch()
        {                                                                                                    //substring will get first 3 letters of of teams

            string path = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Matches\" + team1.Substring(0, 3) + " vs " + team2.Substring(0, 3) + " " + tourName;

            String teamData = "\n" + team1 + "\n" + team2 + "\n" + date + "\n" + venue+ "\n" + matchType+ "\n" + tourName + "\n" + umpires + "\n" + matchStatus;
            File_Handling.Write_file(teamData, path);


        }


        ///***Function for update Match***//
        public void UpdateMatch()
        {
            string path = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Matches\" + team1.Substring(0, 3) + " vs " + team2.Substring(0, 3) + " " + tourName;
            File.Delete(path);
            String teamData = "\n" + team1 + "\n" + team2 + "\n" + date + "\n" + venue + "\n" + matchType + "\n" + tourName + "\n" + umpires + "\n" + matchStatus;
            File_Handling.Write_file(teamData, path);


        }

        ///***Function for Delete Matchd***//
        public void DeleteMatch(String delMatch)
        {
            String textFile = @"C:\Users\muham\OneDrive\Desktop\New folder\CricBuzz\bin\Debug\Matches\" + delMatch;

            File.Delete(textFile);



        }
    }
}
