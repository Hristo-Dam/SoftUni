USE Diablo
GO
--4
SELECT TOP 5 g.[Name] AS 'Game Name', u.[Username] AS 'Username'
FROM Games AS g

LEFT JOIN UsersGames AS ug
ON g.[Id] = ug.[GameId]

LEFT JOIN Users AS u
ON ug.[UserId] = u.[Id]

WHERE g.[Duration] = 5
ORDER BY g.[Start] ASC

--3
CREATE VIEW V_UsersRegistrationAfter2014 AS
SELECT [FirstName], [LastName]
FROM Users
WHERE [RegistrationDate] >= '2015'

--2
SELECT [FirstName], [LastName]
FROM Users
WHERE LOWER([LastName]) LIKE '%ov%'

--1
CREATE TABLE [Actor](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[Email] VARCHAR(40) NOT NULL,
	[Born] DATETIME NOT NULL,
	[Number] VARCHAR(10) NOT NULL
)

CREATE TABLE [Role](
	[Id] INT PRIMARY KEY IDENTITY NOT NULL,
	[Name] VARCHAR(60) NOT NULL,
	[Play] VARCHAR(100) NOT NULL,
	[Author] VARCHAR(160) NOT NULL
)

CREATE TABLE [ActorRole](
	[ActorId] INT NOT NULL,
	[RoleId] INT NOT NULL,

	CONSTRAINT PK_ActorRole
	PRIMARY KEY([ActorId], [RoleId]),

	CONSTRAINT FK_ActorRole_Actor
	FOREIGN KEY([ActorId])
	REFERENCES [Actor]([Id]),

	CONSTRAINT FK_ActorRole_Role
	FOREIGN KEY([RoleId])
	REFERENCES [Role]([Id]),
)