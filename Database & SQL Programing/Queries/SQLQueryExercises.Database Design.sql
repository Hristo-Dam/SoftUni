--1
--CREATE TABLE Passports(
--	[PassportID] INT PRIMARY KEY,
--	[PassportNumber] VARCHAR(8)
--)

--CREATE TABLE Persons(
--	[PersonID] INT PRIMARY KEY IDENTITY,
--	[FirstName] VARCHAR(30),
--	[Salary] DECIMAL,
--	[PassportID] INT
--	CONSTRAINT FK_Persons_Passports
--	FOREIGN KEY (PassportID)
--	REFERENCES Passports(PassportID)
--)

--INSERT INTO Passports([PassportID], [PassportNumber])
--VALUES (101, 'N34FG21B');

--INSERT INTO Passports([PassportID], [PassportNumber])
--VALUES (102, 'K65LO4R7');

--INSERT INTO Passports([PassportID], [PassportNumber])
--VALUES (103, 'ZE657QP2');

--INSERT INTO Persons ([FirstName], [Salary], [PassportID])
--VALUES ('Roberto' ,43300.00, 102);

--INSERT INTO Persons ([FirstName], [Salary], [PassportID])
--VALUES ('Tom', 56100.00, 103);

--INSERT INTO Persons ([FirstName], [Salary], [PassportID])
--VALUES ('Yana', 60200.00, 101);

--2
--CREATE TABLE Manufacturers(
--	[ManufacturerID] INT PRIMARY KEY IDENTITY(1, 1),
--	[Name] VARCHAR(30),
--	[EstablishedOn] DATE
--)

--CREATE TABLE Models(
--	[ModelID] INT PRIMARY KEY IDENTITY(101, 1),
--	[Name] VARCHAR(30),
--	[ManufacturerID] INT

--	CONSTRAINT FK_Models_Manufacturers
--	FOREIGN KEY ([ManufacturerID])
--	REFERENCES Manufacturers([ManufacturerID])
--)

--INSERT INTO Manufacturers([Name], [EstablishedOn])
--VALUES
--	('BMW', '07/03/1916'),
--	('Tesla', '01/01/2003'),
--	('Lada', '01/05/1966')

--INSERT INTO Models([Name], [ManufacturerID])
--VALUES
--	('X1', 1),
--	('i6', 1),
--	('Model S', 2),
--	('Model X', 2),
--	('Model 3', 2),
--	('Nova', 3)

--3
--CREATE TABLE Students(
--	[StudentID] INT PRIMARY KEY IDENTITY,
--	[Name] VARCHAR(30)
--)

--CREATE TABLE Exams(
--	[ExamID] INT PRIMARY KEY IDENTITY(101, 1),
--	[Name] VARCHAR(30)
--)

--CREATE TABLE StudentsExams(
--	[StudentID] INT NOT NULL,
--	[ExamID] INT NOT NULL

--	CONSTRAINT PK_StudentsExams
--	PRIMARY KEY(StudentID, ExamID)

--	CONSTRAINT FK_StudentsExams_Students
--	FOREIGN KEY (StudentID)
--	REFERENCES Students(StudentID),

--	CONSTRAINT FK_SturentsExams_Exams
--	FOREIGN KEY (ExamID)
--	REFERENCES Exams(ExamID)
--)

--7
--SELECT m.MountainRange, p.PeakName, p.Elevation
--FROM Mountains AS m
--JOIN Peaks AS p
--ON m.Id = p.MountainId
--WHERE m.MountainRange = 'Rila'
--ORDER BY Elevation DESC