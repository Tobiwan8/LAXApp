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
        private static readonly Dictionary<int, string> _movieGenres = new()
        {
            { 1, "Ikke Angivet" },
            { 2, "Action" },
            { 3, "Animated" },
            { 4, "Comedy" },
            { 5, "Drama" },
            { 6, "Horror" },
            { 7, "Romance" },
            { 8, "Sci-Fi" },
            { 9, "Thriller" }
        };

        //Properties
        public int Id { get { return _id; } set { _id = value; } }
        public string Genre { get { return _genre; } set { _genre = value; } }

        public static Dictionary<int, string> MovieGenres
        {
            get
            {
                return _movieGenres;
            }
        }
    }
}
