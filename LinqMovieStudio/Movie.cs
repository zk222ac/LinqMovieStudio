using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LinqMovieStudio
{
    class Movie
    {
        
        public string Title { get; set; }
        // Foreign key 
        public Studio StudioName { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }

        public Movie(string title, Studio studioName, int year, int duration)
        {
            Title = title;
            StudioName = studioName;
            Year = year;
            Duration = duration;
        }

        public override string ToString()
        {
            return "Title is " + Title + " by studio " + StudioName + " from the year" + Year.ToString() +
                   " with the duration" + Duration.ToString() + " minutes";
        }
    }
}
