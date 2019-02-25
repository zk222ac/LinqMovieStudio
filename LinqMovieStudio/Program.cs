using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMovieStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1 : set up data source
            // Load studio data
            Studio[] studios = new Studio[]
            {
                new Studio("New Line Cinema", "Boston", 4000),
                new Studio("20th Century Fox", "New York", 2500),
                new Studio("Paramount Pictures", "New York", 8000)
            };

            Movie[] movies = new Movie[]
            {
                new Movie("Se7en", studios[0], 1995, 127),
                new Movie("Alien", studios[1], 1979, 117),
                new Movie("Forrest Gump", studios[2], 1994, 142),
                new Movie("True Grit", studios[2], 2010, 122),
                new Movie("Dark City", studios[0], 2019, 150),

            };

            // Make a Query 
            var query = from s in studios
                select new {Name = s.StudioName, City = s.HqCity, Employee = s.NoOfEmployees};
            
            // Execute Query 
           Printing(query);


            Console.ReadKey();
        }
        // Load studio data

        static void Printing(dynamic query)
        {
            foreach (var tile in query)
            {
                Console.WriteLine(tile);
            }
        }
    }
}
