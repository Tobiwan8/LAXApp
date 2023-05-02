using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;

namespace LAXApp.MSSQL
{
    internal class BindGenresToCombobox
    {
        internal static List<string> GenresList()
        {
            List<string> genresList = new();
            ConnectionString connectionString = new();
            SqlConnection sqlConnection = new(connectionString.ConnectionToSql);
            SqlCommand sqlCommand = new("SELECT Genre FROM Genres", sqlConnection);
            SqlDataReader dr;

            try
            {
                sqlConnection.Open();
                dr = sqlCommand.ExecuteReader();

                while (dr.Read())
                {
                    genresList.Add((string)dr.GetValue(0));
                }
                dr.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            finally { sqlConnection.Close(); }

            return genresList;
        }
    }
}
