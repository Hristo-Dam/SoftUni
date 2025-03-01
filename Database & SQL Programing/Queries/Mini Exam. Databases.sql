﻿CREATE DATABASE TownsByCountries
USE TownsByCountries

CREATE TABLE Countries
(
	ID INT PRIMARY KEY,
	[Name] VARCHAR(30),
	[Population] VARCHAR(30)
)
CREATE TABLE Towns
(
	ID INT PRIMARY KEY,
	[Name] VARCHAR(30),
	CountryId INT FOREIGN KEY REFERENCES Countries(ID),
	GPSLocation NVARCHAR(30)
)

INSERT INTO Countries VALUES
(
	'Bulgaria', 6951482
)
INSERT INTO Countries VALUES
(
	'Spain', 47431256
)
INSERT INTO Countries VALUES
(
	'Germany', 83166711
)
INSERT INTO Towns VALUES
(
	'Sofia', 1, '42°41′N 23°19′E'
)
INSERT INTO Towns VALUES
(

	'Plovdiv', 1, '42°9′N 24°45′E'
)
INSERT INTO Towns VALUES
(
	'Varna', 1, '43°13′N 27°55′E'
)
INSERT INTO Towns VALUES
(
	'Madrid', 2, '40°26′N 3°42′W'
)
INSERT INTO Towns VALUES
(
	'Berlin', 3, '52°31′N 13°23′E'
)

SELECT [Name] as Towns
FROM Towns
WHERE CountryId = 1

SELECT * FROM Countries
JOIN Towns ON Countries.Id = Towns.CountryId
WHERE Countries.Population < 7000000