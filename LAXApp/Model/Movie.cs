using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LAXApp.Model
{
    internal class Movie
    {
        //Fields
        private string? _title;
        private int _genreID;

        //Properties
        internal string? Title{ get => _title; set => _title = value;}
        internal int GenreID
        {
            get { return _genreID; }
            set { _genreID = value; }
        }

        public Movie(string title)
        {
            Title = title;
        }

        public Movie(string title, int genreId)
        {
            Title=title;
            GenreID = genreId;
        }

    }
}
