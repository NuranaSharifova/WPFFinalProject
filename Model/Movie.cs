using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFFinalProject.Model
{
     public class Movie
    {
        public Movie(string movieName, string genre,string plot)
        {
            MovieName = movieName;
            Genre = genre;
            Plot = plot;
        }

        public string MovieName { get; set; }
        public string Genre { get; set; }
        public string Plot { get; set; }
        public Movie()
        {

        }
    }
}
