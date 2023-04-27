using System;
using System.Windows;
using LAXApp.Model;

namespace LAXApp.Commands
{
    internal class CreateMovieCommand : BaseCommand
    {

        public override void Execute(object? parameter)
        {
            MessageBox.Show("almost");
        }

        //private static bool IsValid(Movie m)
        //{
        //    if (m.Title == string.Empty)
        //        return false;
        //    else
        //        return true;
        //}

        //private void AddMovieToDatabase()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
