using System;
using System.Data.SqlClient;
using System.Windows;

namespace LAXApp.MSSQL
{
    internal class EditMovie
    {
        internal static void DeleteMovie(string title)
        {
            ConnectionString connectionString = new();

            try
            {
                using SqlConnection sqlCon = new(connectionString.ConnectionToSql);
                sqlCon.Open();

                using SqlCommand deleteMovieFromDB = new("DELETE FROM Movies WHERE Title = @Title", sqlCon);
                deleteMovieFromDB.Parameters.Add(new SqlParameter("@Title", title));
                deleteMovieFromDB.ExecuteNonQuery();

                MessageBox.Show("Film slettet");
                sqlCon.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
