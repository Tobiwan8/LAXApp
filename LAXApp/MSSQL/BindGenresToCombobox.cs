using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
using LAXApp.Model;

namespace LAXApp.MSSQL
{
    internal class BindGenresToCombobox
    {
        internal static List<Genres> GenresList()
        {
            List<Genres> genresList = new();
            ConnectionString connectionString = new();
            SqlConnection sqlConnection = new(connectionString.ConnectionToSql);
            SqlCommand sqlCommand = new("SELECT Id, Genre FROM Genres", sqlConnection);
            SqlDataReader dr;

            try
            {
                sqlConnection.Open();
                dr = sqlCommand.ExecuteReader();

                while (dr.Read())
                {
                    genresList.Add(new Genres
                        {
                            Id = (int)dr.GetValue(0),
                            Type = (string)dr.GetValue(1)
                        }
                    );
                }
                        
                dr.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            finally { sqlConnection.Close(); }

            return genresList;
        }

        internal static List<string> MoviesList()
        {
            List<string> moviesList = new();
            ConnectionString connectionString = new();
            SqlConnection sqlConnection = new(connectionString.ConnectionToSql);
            SqlCommand sqlCommand = new("SELECT Title FROM Movies", sqlConnection);
            SqlDataReader dr;

            try
            {
                sqlConnection.Open();
                dr = sqlCommand.ExecuteReader();

                while (dr.Read())
                {
                    moviesList.Add((string)dr.GetValue(0));
                }
                dr.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            finally { sqlConnection.Close(); }

            return moviesList;
        }
    }
}
