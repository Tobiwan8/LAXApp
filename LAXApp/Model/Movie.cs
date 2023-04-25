using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAXApp.Model
{
    internal class Movie
    {
        //Fields
        private string? _title;
        private string? _categories;
        private int _rating;

        //Properties
        internal string? Title{ get => _title; set => _title = value;}

        internal string? Categories { get => _categories; set => _categories = value;}

        internal int Rating { get => _rating; set => _rating = value;}
    }
}
