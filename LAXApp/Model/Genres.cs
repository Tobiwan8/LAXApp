using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAXApp.Model
{
    internal class Genres
    {
        private string? _genre;

        internal string? Genre 
        {
            get { return _genre; } 
            set { _genre = value; } 
        }
    }
}
