USE SoftUni
GO

--1
--SELECT TOP 50
--	e.[FirstName],
--	e.[LastName],
--	t.[Name],
--	a.[AddressText]
--FROM [Employees] AS e
--JOIN [Addresses] AS a
--ON e.[AddressID] = a.[AddressID]
--JOIN [Towns] AS t
--ON t.[TownID] = a.[TownID]
--ORDER BY e.[FirstName], e.[LastName]

--2
--SELECT
--	e.[EmployeeID],
--	e.[FirstName],
--	e.[LastName],
--	d.[Name]
--FROM [Employees] AS e
--JOIN [Departments] AS d
--ON e.[DepartmentID] = d.[DepartmentID]
--WHERE d.[Name] = 'Sales'
--ORDER BY e.[EmployeeID]

--3
--SELECT
--	e.[FirstName],
--	e.[LastName],
--	e.[HireDate],
--	d.[Name]
--FROM [Employees] AS e
--JOIN [Departments] AS d
--ON e.[DepartmentID] = d.[DepartmentID]
--WHERE e.[HireDate] > '1/1/1999'
--AND d.[Name] = 'Sales' OR d.[Name] = 'Finance'

--4
--SELECT TOP 50
--	e.[EmployeeID],
--	e.[FirstName] + ' ' + e.[LastName] AS EmployeeName,
--	m.[FirstName] + ' ' + m.[LastName] AS ManagerName,
--	d.[Name] AS DepartmentName
--FROM [Employees] AS e
--JOIN [Employees] AS m
--ON m.[EmployeeID] = e.[ManagerID]
--JOIN [Departments] AS d
--ON d.[DepartmentID] = e.[DepartmentID]
--ORDER BY e.[EmployeeID]

--5
--SELECT
--	MIN(a.[AverageSalary]) AS MinAverageSalary
--FROM
--(
--	SELECT
--		e.[DepartmentID],
--		AVG(e.[Salary]) AS AverageSalary
--	FROM [Employees] AS e
--	GROUP BY e.[DepartmentID]
--) AS a