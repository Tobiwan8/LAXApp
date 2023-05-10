using LAXApp.Model;
using System;
using System.Data.SqlClient;
using System.Windows;

namespace LAXApp.MSSQL
{
    internal class EditMovie
    {
        internal static void Edit_Movie(string title, string genre)
        {
            ConnectionString connectionString = new();

            if (genre == null)
            {
                genre = "Ikke Angivet";
            }
            try
            {
                using SqlConnection sqlCon = new(connectionString.ConnectionToSql);
                {
                    sqlCon.Open();
                    int genreId = GetGenreId(sqlCon, genre);

                    using SqlCommand editMovieFromDB = new("UPDATE Movies SET GenreId = @GenreId WHERE Title = @Title", sqlCon);
                    {
                        editMovieFromDB.Parameters.Add(new SqlParameter("@GenreId", genreId));
                        editMovieFromDB.Parameters.Add(new SqlParameter("@Title", title));
                        editMovieFromDB.ExecuteNonQuery();
                    }

                    MessageBox.Show("Film opdateret");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        internal void DeleteMovie(Movie movie)
        {
            ConnectionString connectionString = new();

            try
            {
                using SqlConnection sqlCon = new(connectionString.ConnectionToSql);
                {
                    sqlCon.Open();

                    using SqlCommand deleteMovieFromDB = new("DELETE FROM Movies WHERE Title = @Title", sqlCon);
                    {
                        deleteMovieFromDB.Parameters.Add(new SqlParameter("@Title", movie.Title));
                        deleteMovieFromDB.ExecuteNonQuery();
                    }

                    MessageBox.Show("Film slettet");
                }
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
