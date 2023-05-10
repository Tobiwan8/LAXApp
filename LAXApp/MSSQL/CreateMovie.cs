using LAXApp.Model;
using System;
using System.Data.SqlClient;
using System.Windows;

namespace LAXApp.MSSQL
{
    internal class CreateMovie
    {
        internal void AddMovie(Genres genre, Movie movie)
        {
            ConnectionString connectionString = new();
            Movie newMovie = new();
            newMovie.Id = -1;
    
            try
            {
                using SqlConnection sqlCon = new(connectionString.ConnectionToSql);
                {
                    sqlCon.Open();

                    using SqlCommand addMovieToDB = new("INSERT INTO Movies VALUES (@Title, @GenreId)", sqlCon);
                    {
                        addMovieToDB.Parameters.Add(new SqlParameter("@Title", movie.Title));
                        addMovieToDB.Parameters.Add(new SqlParameter("@GenreId", genre.Id));
                        addMovieToDB.ExecuteNonQuery();
                        //newMovieId = (int)addMovieToDB.ExecuteScalar();
                        //movie.Id = newMovieId;
                    }

                    MessageBox.Show("Film tilføjet");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
