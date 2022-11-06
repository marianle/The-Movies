using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Booking_TheMovies
{
    public class Movie
    {
        public string Title { get; set; }
   

        //"Major Genre": null,
        //"Creative Type": null,
        //"Director": null,
        //"Rotten Tomatoes Rating": null,
        //"IMDB Rating": 6.1,
        //"IMDB Votes": 1071
        public int US_Gross {get;set;}
        public int Worldwide_Gross {get;set;}
        public int US_DVD_Sales {get;set;}
        public int Production_Budget {get;set;}
        public DateTime Release_Date {get;set;}
        public char MPAA_Rating {get;set;}
        public int Running_Time_min { get; set; }
        public string Distributor { get; set; }
        public string Source { get; set; }
        public string Major_Genre { get; set; }
        public string Creative_Type { get; set; }
        public string Director { get; set; }
        public double Rotten_Tomatoes_Rating { get; set; }
        public double IMDB_Rating { get; set; }
        public int IMDB_Votes { get; set; }

        public void LoadJson()
        {
            using (StreamReader r = new StreamReader("..\\..\\..\\movies.json"))
            {
                string json = r.ReadToEnd();
                List<Movie> items = JsonConvert.DeserializeObject<List<Movie>>(json);
                foreach (Movie m in items) 
                {
                    Console.WriteLine(m.Title);
                }
            }
        }

        //public override string ToString()
        //{
        //    return $"Movie: {Title} \nMovie Length: {MovieDuration} \nGenre: {Genre} \nInstructor: {Instructor} \nPremier Date: {PremierDate} ";
        //}

    }
}



