using LAXApp.Model;
using System;
using System.Data.SqlClient;
using System.Windows;

namespace LAXApp.MSSQL
{
    internal class CreateMovie
    {
        private readonly string _message = "Angiv venligst Titel og Genre";
        private static bool IsValid(Movie movie)
        {
            if (movie.Title == null)
                return false;
            else
                return true;
        }
        internal void AddMovie(Movie movie)
        {
            if (IsValid(movie))
            {
                try
                {
                    ConnectionString connectionString = new();
                    SqlConnection sqlCon = new(connectionString.ConnectionToSql);
                    sqlCon.Open();

                    SqlCommand insertNewUserData = new($"INSERT INTO Movies VALUES ('{movie.Title}', '{movie.GenreID}')", sqlCon);
                    insertNewUserData.ExecuteNonQuery();

                    MessageBox.Show("Bruger oprettet");

                    sqlCon.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
                MessageBox.Show(_message, "FEJL", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
