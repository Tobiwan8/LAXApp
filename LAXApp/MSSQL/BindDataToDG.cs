using LAXApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LAXApp.MSSQL
{
    internal class BindDataToDG
    {
        internal static List<DataGridItem> DGItemList()
        {
            List<DataGridItem> list = new();
            ConnectionString connectionString = new();
            SqlDataReader dr;

            using SqlConnection sqlCon = new(connectionString.ConnectionToSql);
            {
                sqlCon.Open();

                using SqlCommand addDGItemToList = new("SELECT m.Title, g.Genre, AVG(r.Rating) AS AverageRating FROM Movies m JOIN Genres g ON m.GenreId = g.Id LEFT JOIN Ratings r ON m.Id = r.MovieId GROUP BY m.Title, g.Genre", sqlCon);
                {
                    dr = addDGItemToList.ExecuteReader();

                    while (dr.Read())
                    {
                        double rating;
                        if (dr.IsDBNull(2))
                        {
                            rating = 0.0;
                        }
                        else
                        {
                            rating = Convert.ToDouble(dr.GetValue(2));
                        }

                        list.Add(new DataGridItem
                        {
                            Title = (string)dr.GetValue(0),
                            Genre = (string)dr.GetValue(1),
                            Rating = rating
                        });
                    }
                }
            }

            return list;    
        }
    }
}
