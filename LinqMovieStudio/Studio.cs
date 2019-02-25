using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMovieStudio
{
   public class Studio
    {
        // This is my Primary Key 
        public string StudioName { get; set; }
        public string HqCity { get; set; }
        public int NoOfEmployees { get; set; }

        public Studio(string studioName, string hqCity, int noOfEmployees)
        {
            StudioName = studioName;
            HqCity = hqCity;
            NoOfEmployees = noOfEmployees;
        }

        public override string ToString()
        {
            return $"Studio name :{StudioName} , Hq city :{HqCity} Number of employees :{NoOfEmployees}" ;
        }
    }
}
