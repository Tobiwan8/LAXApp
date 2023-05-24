using LAXApp.Model;
using System;
using System.Data.SqlClient;
using System.Windows;

namespace LAXApp.MSSQL
{
    internal class EditMovie
    {
        internal void Edit_Movie(Genres genre, Movie movie)
        {
            ConnectionString connectionString = new();

            try
            {
                using SqlConnection sqlCon = new(connectionString.ConnectionToSql);
                {
                    sqlCon.Open();

                    using SqlCommand editMovieFromDB = new("UPDATE Movies SET GenreId = @GenreId WHERE Title = @Title", sqlCon);
                    {
                        editMovieFromDB.Parameters.Add(new SqlParameter("@GenreId", genre.Id));
                        editMovieFromDB.Parameters.Add(new SqlParameter("@Title", movie.Title));
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
    }
}
