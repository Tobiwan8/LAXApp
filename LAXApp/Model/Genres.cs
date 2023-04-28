using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace LAXApp.Model
{
    internal class Genres
    {
        //Fields
        private int _id;
        private string _genre;
        private static readonly Dictionary<string, int> _movieGenres = new()
        {
            { "Ikke Angivet", 1 },
            { "Action", 2 },
            { "Animated", 3 },
            { "Comedy", 4 },
            { "Drama", 5 },
            { "Horror", 6 },
            { "Romance", 7 },
            { "Sci-Fi", 8 },
            { "Thriller", 9 }
        };

        //Properties
        public int Id { get { return _id; } set { _id = value; } }
        public string Genre { get { return _genre; } set { _genre = value; } }

        public static Dictionary<string, int> MovieGenres
        {
            get
            {
                return _movieGenres;
            }
        }
    }
}
