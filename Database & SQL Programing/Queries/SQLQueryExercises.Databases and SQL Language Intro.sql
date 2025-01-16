--1
--SELECT * FROM [GameTypes]

--2
--SELECT [Name], [Price], [MinLevel] FROM [Items] WHERE [Price] BETWEEN 790 AND 800

--3
--SELECT [Name], [IsFinished] FROM [Games] WHERE [Duration] IS NULL

--4
--SELECT TOP 5 [Name], [Price] FROM [Items] ORDER BY [Price] DESC

--5
--UPDATE [Items] SET [Price] = [Price] * 1.1 WHERE [MinLevel] IN (8, 18, 24, 41)
--SELECT [Price] FROM [Items]

--6
--SELECT TOP 50 g.[Name], g.[Start], GameTypeName.Name
--FROM [Games] AS g
--JOIN [GameTypes] AS GameTypeName
--ON g.GameTypeId = GameTypeName.Id
--ORDER BY g.Duration