using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Favorit_movies
{

    public class RootObject
    {
        public Movie[] Movie { get; set; }
    }

    public class Movie
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Actor { get; set; }
    }




}
