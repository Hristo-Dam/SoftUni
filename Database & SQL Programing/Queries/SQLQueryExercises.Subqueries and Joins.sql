USE SoftUni
GO

--1
--SELECT TOP 5
--	e.[EmployeeID],
--	e.[JobTitle],
--	a.[AddressID],
--	a.[AddressText]
--FROM [Employees] AS e
--JOIN [Addresses] AS a
--ON e.[AddressID] = a.[AddressID]
--ORDER BY a.[AddressID]

--2
--SELECT TOP 5
--	e.[EmployeeID],
--	e.[FirstName],
--	e.[Salary],
--	d.[Name]
--FROM [Employees] AS e
--JOIN [Departments] AS d
--ON e.[DepartmentID] = d.[DepartmentID]
--WHERE e.[Salary] > 15000
--ORDER BY d.[DepartmentID]

--3
--SELECT TOP 3
--	e.[EmployeeID],
--	e.[FirstName]
--FROM [Employees] AS e
--LEFT OUTER JOIN [EmployeesProjects] AS ep
--ON e.[EmployeeID] = ep.[EmployeeID]
--WHERE ep.[ProjectID] IS NULL

--4
--SELECT TOP 5
--	e.[EmployeeID],
--	e.[FirstName],
--	p.[Name] AS 'ProjectName'
--FROM [Employees] AS e
--JOIN [EmployeesProjects] AS ep
--ON e.[EmployeeID] = ep.[EmployeeID]
--RIGHT OUTER JOIN [Projects] AS p
--ON p.[ProjectID] = ep.[ProjectID]
--WHERE p.[StartDate] > '13/8/2002' AND p.[EndDate] IS NULL
--ORDER BY e.[EmployeeID] ASC

--5
SELECT TOP 5
	e.[EmployeeID],
	e.[FirstName],
	p.[Name] AS 'ProjectName'
FROM [Employees] AS e
FULL OUTER JOIN [EmployeesProjects] AS ep
ON e.[EmployeeID] = ep.[EmployeeID]
FULL OUTER JOIN [Projects] AS p
ON p.[ProjectID] = ep.[ProjectID]
WHERE ep.[EmployeeID] = 24 AND p.[StartDate] >= 2015