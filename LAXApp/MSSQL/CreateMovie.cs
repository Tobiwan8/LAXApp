using System;
using System.Data.SqlClient;
using System.Windows;

namespace LAXApp.MSSQL
{
    internal class CreateMovie
    {
        internal static void AddMovie(string title, string genre)
        {
            ConnectionString connectionString = new();

            if (genre == null)
            {
                genre = "Ikke Angivet";
            }
            try
            {
                using SqlConnection sqlCon = new(connectionString.ConnectionToSql);
                sqlCon.Open();
                int genreId = GetGenreId(sqlCon, genre);

                using SqlCommand addMovieToDB = new("INSERT INTO Movies VALUES (@Title, @GenreId)", sqlCon);
                addMovieToDB.Parameters.Add(new SqlParameter("@Title", title));
                addMovieToDB.Parameters.Add(new SqlParameter("@GenreId", genreId));
                addMovieToDB.ExecuteNonQuery();

                MessageBox.Show("Film tilføjet");
                sqlCon.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private static int GetGenreId(SqlConnection sqlCon, string genre)
        {
            SqlCommand sqlCommand = new("SELECT Id FROM Genres WHERE Genre = @Genre", sqlCon);
            sqlCommand.Parameters.Add(new SqlParameter("@Genre", genre));

            int genreId = (int)sqlCommand.ExecuteScalar();

            return genreId;
        }
    }
}
