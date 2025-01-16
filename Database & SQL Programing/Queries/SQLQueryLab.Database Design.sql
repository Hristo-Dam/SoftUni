--1
--CREATE VIEW v_HighestPeak AS
--SELECT TOP 1 * FROM [Peaks] ORDER BY [Elevation] DESC

--2
--CREATE TABLE Student(
--	StudentID INT PRIMARY KEY IDENTITY,
--	[Name] VARCHAR(100)
--)

--CREATE TABLE Class(
--	ClassID INT PRIMARY KEY IDENTITY,
--	Course VARCHAR(100)
--)

--CREATE TABLE StudentClassRelation(
--	StudentID INT NOT NULL,
--	ClassID INT NOT NULL

--	CONSTRAINT PK_StudentsClasses
--	PRIMARY KEY(StudentID, ClassID),

--	CONSTRAINT FK_StudentsClasses_Students
--	FOREIGN KEY(StudentID)
--	REFERENCES Student(StudentID),

--	CONSTRAINT FK_StudentsClasses_Classes
--	FOREIGN KEY(ClassID)
--	REFERENCES Class(ClassID)
--)

--INSERT INTO Student([Name])
--VALUES('Olaf Alfonson')

--INSERT INTO Student([Name])
--VALUES('Clark Davis')

--INSERT INTO Class([Course])
--VALUES('Biology')

--INSERT INTO Class([Course])
--VALUES('Chemistry')

--INSERT INTO Class([Course])
--VALUES('Physics')

--INSERT INTO Class([Course])
--VALUES('English')

--INSERT INTO Class([Course])
--VALUES('Computer Science')

--INSERT INTO Class([Course])
--VALUES('History')

--INSERT INTO StudentClassRelation(StudentID, ClassID)
--VALUES(1, 2)
--INSERT INTO StudentClassRelation(StudentID, ClassID)
--VALUES(1, 4)
--INSERT INTO StudentClassRelation(StudentID, ClassID)
--VALUES(1, 6)

--INSERT INTO StudentClassRelation(StudentID, ClassID)
--VALUES(2, 1)
--INSERT INTO StudentClassRelation(StudentID, ClassID)
--VALUES(2, 3)
--INSERT INTO StudentClassRelation(StudentID, ClassID)
--VALUES(2, 6)