--1
--SELECT * FROM Departments

--2
--SELECT Name FROM Departments

--3
--SELECT FirstName, LastName, Salary FROM Employees

--4
--SELECT DISTINCT Salary FROM Employees ORDER BY Salary

--5
--SELECT [FirstName], [LastName], [JobTitle] FROM Employees WHERE [Salary] BETWEEN 20000 AND 30000

--6
--SELECT [FirstName], [LastName] FROM Employees WHERE [ManagerID] IS NULL

--7
--SELECT [FirstName], [LastName], [Salary] FROM Employees WHERE [Salary] > 50000 ORDER BY [Salary] DESC

--8
--SELECT TOP 5 [FirstName], [LastName] FROM Employees ORDER BY [Salary] DESC

--9
--SELECT TOP 7 [FirstName], [LastName], [HireDate] FROM Employees ORDER BY [HireDate] DESC

--10
--UPDATE Employees SET [Salary] = [Salary] * 1.12 WHERE [DepartmentID] IN (1, 2, 4, 11)
--SELECT [Salary] FROM Employees

--15
--SELECT e.[EmployeeID], e.[FirstName]
--FROM [Employees] AS e
--WHERE e.[EmployeeID] NOT IN
--(
--	SELECT [EmployeeID] FROM [EmployeesProjects]
--)
--ORDER BY [EmployeeID]