CREATE DATABASE Exercise

CREATE TABLE Persons(
	PersonID INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(30),
	Salary DECIMAL,
	PassportID INT

	CONSTRAINT FK_Persons_Passports
	FOREIGN KEY (PassportID)
	REFERENCES Passports(PassportID)
)

CREATE TABLE Passports(
	PassportID INT PRIMARY KEY IDENTITY,
	PassportNumber CHAR(8)
)

INSERT INTO Persons([FirstName], [Salary], [PassportID])
VALUES(1, 'Roberto', 43300.00)