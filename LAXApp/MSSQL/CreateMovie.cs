using LAXApp.Model;
using System;
using System.Data.SqlClient;
using System.Windows;

namespace LAXApp.MSSQL
{
    internal class CreateMovie
    {
        internal void AddMovie(string title, string genre)
        {
            if(genre == null)
            {
                genre = "Ikke Angivet";
            }
            try
            {
                ConnectionString connectionString = new();
                SqlConnection sqlCon = new(connectionString.ConnectionToSql);
                sqlCon.Open();

                int genreId = GetGenreId(sqlCon, genre);

                SqlCommand insertNewUserData = new($"INSERT INTO Movies VALUES ('{title}', {genreId}", sqlCon);
                insertNewUserData.ExecuteNonQuery();

                MessageBox.Show("Film tilføjet");

                sqlCon.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private static int GetGenreId(SqlConnection connection, string genre)
        {
            SqlConnection sqlCon = connection;

            SqlCommand sqlCommand = new($"SELECT Id FROM Genres WHERE Genre ='{genre}'", sqlCon);
            int genreId = Convert.ToInt32(((string)sqlCommand.ExecuteScalar()).ToString());

            return genreId;
        }
    }
}
