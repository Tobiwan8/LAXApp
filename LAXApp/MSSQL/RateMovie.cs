using LAXApp.Model;
using System;
using System.Data.SqlClient;
using System.Windows;

namespace LAXApp.MSSQL
{
    internal class RateMovie
    {
        internal void Rate_Movie(Genres genre, Movie movie)
        {
            ConnectionString connectionString = new();

            try
            {
                using SqlConnection sqlCon = new(connectionString.ConnectionToSql);
                {
                    sqlCon.Open();

                    using SqlCommand CreateRatingInDB = new("UPDATE Movies SET GenreId = @GenreId WHERE Title = @Title", sqlCon);
                    {
                        CreateRatingInDB.Parameters.Add(new SqlParameter("@GenreId", genre.Id));
                        CreateRatingInDB.Parameters.Add(new SqlParameter("@Title", movie.Title));
                        CreateRatingInDB.ExecuteNonQuery();
                    }

                    MessageBox.Show("Rating er tilføjet til filmen");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
