using LAXApp.Model;
using System;
using System.Data.SqlClient;
using System.Windows;

namespace LAXApp.MSSQL
{
    internal class CreateMovie
    {
        internal void AddMovie(string title, string genre)
        {
            

            try
            {
                ConnectionString connectionString = new();
                SqlConnection sqlCon = new(connectionString.ConnectionToSql);
                sqlCon.Open();

                if(genre == null)
                {
                    SqlCommand insertNewUserData = new($"INSERT INTO Movies VALUES ('{title}'", sqlCon);
                    insertNewUserData.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand insertNewUserData = new($"INSERT INTO Movies VALUES ('{title}', '{genre}'", sqlCon);
                    insertNewUserData.ExecuteNonQuery();
                }

                MessageBox.Show("Bruger oprettet");

                sqlCon.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
