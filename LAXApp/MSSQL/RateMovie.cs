using LAXApp.Model;
using System;
using System.Data.SqlClient;
using System.Windows;

namespace LAXApp.MSSQL
{
    internal class RateMovie
    {
        internal void Rate_Movie(Ratings rating, Movie movie)
        {
            ConnectionString connectionString = new();

            try
            {
                using SqlConnection sqlCon = new(connectionString.ConnectionToSql);
                {
                    sqlCon.Open();

                    using SqlCommand CreateRatingInDB = new("INSERT INTO Ratings VALUES (@MovieID, @Rating)", sqlCon);
                    {
                        CreateRatingInDB.Parameters.Add(new SqlParameter("@MovieID", movie.Id));
                        CreateRatingInDB.Parameters.Add(new SqlParameter("@Rating", rating.Rating));
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
