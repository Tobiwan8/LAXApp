﻿using System;
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
            SqlCommand sqlCommand = new("SELECT * FROM Genres", sqlConnection);
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

        internal static List<Movie> MoviesList()
        {
            List<Movie> moviesList = new();
            ConnectionString connectionString = new();
            SqlConnection sqlConnection = new(connectionString.ConnectionToSql);
            SqlCommand sqlCommand = new("SELECT * FROM Movies", sqlConnection);
            SqlDataReader dr;

            try
            {
                sqlConnection.Open();
                dr = sqlCommand.ExecuteReader();

                while (dr.Read())
                {
                    moviesList.Add(new Movie
                    {
                        Id = (int)dr.GetValue(0),
                        Title = (string)dr.GetValue(1),
                        GenreID = (int)dr.GetValue(2)
                    });
                }
                dr.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            finally { sqlConnection.Close(); }

            return moviesList;
        }

        internal static List<Ratings> RatingsList()
        {
            List<Ratings> ratingsList = new();
            ConnectionString connectionString = new();
            SqlConnection sqlConnection = new(connectionString.ConnectionToSql);
            SqlCommand sqlCommand = new("SELECT * FROM Ratings", sqlConnection);
            SqlDataReader dr;

            try
            {
                sqlConnection.Open();
                dr = sqlCommand.ExecuteReader();

                while (dr.Read())
                {
                    ratingsList.Add(new Ratings
                    {
                        Id = (int)dr.GetValue(0),
                        MovieId = (int)dr.GetValue(1),
                    });
                }
                dr.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            finally { sqlConnection.Close(); }

            return ratingsList;
        }
    }
}
