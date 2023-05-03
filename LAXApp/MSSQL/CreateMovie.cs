using LAXApp.Model;
using System;
using System.Data.SqlClient;
using System.Windows;

namespace LAXApp.MSSQL
{
    
    public class Person
    {
        public int Id { get; } = -1;
        public string Navn { get; private set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public string Phone { get; set; }
    }    
    public class Journal
    {
        public int Id { get; set; } = -1;
        public int PersonId { get; set; }
        public string Journaliseret { get; set; }
        public DateTime Consulation { get; set; }
    }


    internal class CreateMovie
    {
        internal void AddMovie(Genres genre, Movie movie)
        {
            ConnectionString connectionString = new();
            int newMovieId = -1;
    
            try
            {
                using SqlConnection sqlCon = new(connectionString.ConnectionToSql);
                {
                    sqlCon.Open();
                    //int genreId = GetGenreId(sqlCon, genre.Type);

                    using SqlCommand addMovieToDB = new("INSERT INTO Movies VALUES (@Title, @GenreId)", sqlCon);
                    {
                        addMovieToDB.Parameters.Add(new SqlParameter("@Title", movie.Title));
                        addMovieToDB.Parameters.Add(new SqlParameter("@GenreId", genre.Id));
                        newMovieId = (int) addMovieToDB.ExecuteScalar();
                        movie.Id = newMovieId;
                    }

                    MessageBox.Show("Film tilføjet");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //private int GetGenreId(SqlConnection sqlCon, string genre)
        //{
        //    SqlCommand sqlCommand = new("SELECT Id FROM Genres WHERE Genre = @Genre", sqlCon);
        //    sqlCommand.Parameters.Add(new SqlParameter("@Genre", genre));

        //    int genreId = (int)sqlCommand.ExecuteScalar();

        //    return genreId;
        //}
    }
}
