using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LAXApp.MSSQL
{
    internal class BindGenresToCombobox
    {
        internal static void BindGenres(ComboBox cb, string command)
        {
            ConnectionString connectionString = new();
            SqlConnection sqlConnection = new(connectionString.ConnectionToSql);
            SqlCommand sqlCommand = new(command, sqlConnection);
            ComboBox comboBox = new();

            sqlConnection.Open();

            SqlDataReader dr = sqlCommand.ExecuteReader();
            comboBox.Items.Add(dr);
            cb.ItemsSource = comboBox.ItemsSource;

            sqlConnection.Close();
        }
    }
}
