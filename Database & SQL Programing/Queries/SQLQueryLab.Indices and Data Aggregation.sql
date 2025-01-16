USE SoftUni
GO

--1
--SELECT
--	e.[DepartmentID],
--	SUM(e.[Salary]) AS 'TotalSalary'
--FROM Employees AS e
--GROUP BY e.[DepartmentID]
--ORDER BY e.[DepartmentID]

--2
--SELECT
--	e.[DepartmentID],
--	COUNT(e.[Salary]) AS 'SalaryCount'
--FROM Employees AS e
--WHERE e.[Salary] IS NOT NULL
--GROUP BY e.[DepartmentID]

--3
--SELECT
--	e.[DepartmentID],
--	SUM(e.[Salary]) AS 'TotalSalary'
--FROM Employees AS e
--GROUP BY e.[DepartmentID]
--ORDER BY e.[DepartmentID]

--4
--SELECT
--	e.[DepartmentID],
--	MAX(e.[Salary]) AS 'MaxSalary'
--FROM Employees AS e
--GROUP BY e.[DepartmentID]
--ORDER BY e.[DepartmentID]

--5
--SELECT
--	e.[DepartmentID],
--	MIN(e.[Salary]) AS 'MinSalary'
--FROM Employees AS e
--GROUP BY e.[DepartmentID]
--ORDER BY e.[DepartmentID]

--6
--SELECT
--	e.[DepartmentID],
--	SUM(e.[Salary]) AS 'TotalSalary'
--FROM Employees AS e
--GROUP BY e.[DepartmentID]
--HAVING SUM(e.[Salary]) >= 150000
--ORDER BY e.[DepartmentID]