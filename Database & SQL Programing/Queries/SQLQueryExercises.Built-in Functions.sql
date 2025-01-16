
GO

--1
--SELECT [FirstName], [LastName]
--FROM Employees
--WHERE [FirstName] LIKE 'Sa%'

--2
--SELECT [FirstName], [LastName]
--FROM Employees
--WHERE [LastName] LIKE '%ei%'

--3
--SELECT [FirstName]
--FROM Employees
--WHERE [DepartmentID] = 3 OR [DepartmentID] = 10 AND YEAR([HireDate]) BETWEEN 1995 AND 2005

--4
--SELECT [FirstName], [LastName]
--FROM Employees
--WHERE [JobTitle] NOT LIKE '%ngineer%'

--5
--SELECT [Name]
--FROM Towns
--WHERE LEN([Name]) IN(5, 6)
--ORDER BY [Name]

--6
--SELECT [TownID], [Name]
--FROM Towns
--WHERE LEFT([Name], 1) LIKE('[MKBE]')
--ORDER BY [Name]	

--7
--SELECT [TownID], [Name]
--FROM Towns
--WHERE LEFT([Name], 1) NOT LIKE('[RBD]')
--ORDER BY [Name]	

--8
--CREATE VIEW v_EmployeesHiredAfter2000 AS
--SELECT e.[FirstName], e.[LastName]
--FROM Employees AS e
--WHERE YEAR(e.[HireDate]) > 2000

--9
--SELECT e.[FirstName], e.[LastName]
--FROM Employees AS e
--WHERE LEN(e.[LastName]) = 5

--10
--SELECT
--	e.[EmployeeID],
--	e.[FirstName],
--	e.[LastName],
--	e.[Salary],
--	DENSE_RANK() OVER(PARTITION BY e.[Salary] ORDER BY e.[EmployeeID]) AS 'Rank'
--FROM Employees AS e
--WHERE e.[Salary] BETWEEN 10000 AND 50000
--ORDER BY e.[Salary] DESC

--11
--SELECT * 
--FROM
--(
--	SELECT
--		e.[EmployeeID],
--		e.[FirstName],
--		e.[LastName],
--		e.[Salary],
--		DENSE_RANK() OVER(PARTITION BY e.[Salary] ORDER BY e.[EmployeeID]) AS [Rank]
--	FROM Employees AS e
--	WHERE e.[Salary] BETWEEN 10000 AND 50000
--) AS MyTable
--WHERE MyTable.[Rank] LIKE(2)
--ORDER BY MyTable.[Salary] DESC

--12
--SELECT c.[CountryName], c.[IsoCode]
--FROM Countries AS c
--WHERE LOWER(c.[CountryName]) LIKE '%a%a%a%'
--ORDER BY c.[IsoCode]

--13
--SELECT 
--	p.[PeakName], 
--	r.[RiverName], 
--	CONCAT(LOWER(LEFT(p.[PeakName], LEN(p.[PeakName]) - 1)), LOWER(r.[RiverName])) AS Mix
--FROM Peaks AS p
--JOIN Rivers AS r
--ON UPPER(RIGHT(p.[PeakName], 1)) = LEFT(r.[RiverName], 1)
--ORDER BY Mix