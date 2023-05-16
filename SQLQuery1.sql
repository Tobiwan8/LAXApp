﻿USE Master;
GO
DROP DATABASE IF EXISTS LAXMovieDB;
GO
CREATE DATABASE LAXMovieDB;
GO
USE LAXMovieDB;
GO

CREATE TABLE Genres(
Id INT PRIMARY KEY NOT NULL,
Genre NVARCHAR (50) NOT NULL);

INSERT INTO Genres
VALUES 
(1, 'Action'), (2, 'Animated'), (3, 'Comedy'), (4, 'Drama'), (5, 'Horror'), (6, 'Romance'), (7, 'Sci-Fi'), (8, 'Thriller'), (9, 'Ikke Angivet');

CREATE TABLE Movies(
Id INT PRIMARY KEY IDENTITY(1,1),
Title NVARCHAR(50) UNIQUE NOT NULL,
GenreId INT NOT NULL,
CONSTRAINT FK_Movies_Genres FOREIGN KEY (GenreId) REFERENCES Genres(Id));

CREATE TABLE Ratings (
Id INT PRIMARY KEY IDENTITY(1,1),
MovieId INT NOT NULL,
Rating INT NOT NULL,
CONSTRAINT FK_Ratings_Movies FOREIGN KEY (MovieId) REFERENCES Movies(Id)
);

INSERT INTO Movies
VALUES ('Finding Nemo', 2);