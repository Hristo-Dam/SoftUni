USE Gringotts
GO

--1
--SELECT COUNT(wd.[Id])
--FROM WizzardDeposits AS wd

--2
--SELECT MAX(wd.[MagicWandSize]) AS 'LongestMagicWand'
--FROM WizzardDeposits AS wd

--3
--SELECT
--	wd.[DepositGroup],
--	MAX(wd.[MagicWandSize]) AS 'LongestMagicWand'
--FROM WizzardDeposits AS wd
--GROUP BY  wd.[DepositGroup]

--4
--SELECT TOP 2 wd.[DepositGroup]
--FROM WizzardDeposits AS wd
--GROUP BY wd.[DepositGroup]
--ORDER BY AVG(wd.[MagicWandSize])

--5
--SELECT
--	wd.[DepositGroup],
--	SUM(wd.[DepositAmount]) AS 'TotalSum'
--FROM WizzardDeposits AS wd
--GROUP BY wd.[DepositGroup]

--6
--SELECT
--	wd.[DepositGroup],
--	SUM(wd.[DepositAmount]) AS 'TotalSum'
--FROM WizzardDeposits AS wd
--WHERE wd.[MagicWandCreator] = 'Ollivander family'
--GROUP BY wd.[DepositGroup]

--7
--SELECT
--	wd.[DepositGroup],
--	SUM(wd.[DepositAmount]) AS 'TotalSum'
--FROM WizzardDeposits AS wd
--WHERE wd.[MagicWandCreator] = 'Ollivander family'
--GROUP BY wd.[DepositGroup]
--HAVING SUM(wd.[DepositAmount]) <= 150000
--ORDER BY TotalSum DESC

--8
--SELECT
--	wd.[DepositGroup],
--	wd.[MagicWandCreator],
--	MIN(wd.[DepositCharge]) AS 'MinDepositCharge'
--FROM WizzardDeposits AS wd
--GROUP BY wd.[DepositGroup], wd.[MagicWandCreator]
--ORDER BY wd.[MagicWandCreator], [DepositGroup]

--9
--SELECT a.AgeGroup, 
--       COUNT(a.AgeGroup) AS WizardCount 
--  FROM (
--    SELECT 
--        CASE
--            WHEN Age <= 10 THEN '[0-10]'
--            WHEN Age BETWEEN 11 AND 20 THEN '[11-20]'
--            WHEN Age BETWEEN 21 AND 30 THEN '[21-30]'
--            WHEN Age BETWEEN 31 AND 40 THEN '[31-40]'
--            WHEN Age BETWEEN 41 AND 50 THEN '[41-50]'
--            WHEN Age BETWEEN 51 AND 60 THEN '[51-60]'
--            WHEN Age > 60 THEN '[61+]'
--        END AS AgeGroup
--  FROM WizzardDeposits
--) AS a
--GROUP BY a.AgeGroup

--10
--SELECT DISTINCT LEFT(wd.[FirstName], 1)
--FROM WizzardDeposits AS wd
--WHERE wd.[DepositGroup] = 'Troll Chest'

--11
--SELECT
--	wd.[DepositGroup],
--	wd.[IsDepositExpired],
--	AVG(wd.[DepositInterest]) AS 'AverageInterest'
--FROM WizzardDeposits AS wd
--WHERE wd.[DepositStartDate] > '01/01/1985'
--GROUP BY wd.[DepositGroup], wd.[IsDepositExpired]
--ORDER BY wd.[DepositGroup] DESC--, wd.[DepositExpirationDate] ASC

--12


USE SoftUni
GO

--13
--SELECT
--	e.[DepartmentID],
--	SUM(e.[Salary]) AS 'TotalSalary'
--FROM Employees AS e
--GROUP BY e.[DepartmentID]
--ORDER BY e.[DepartmentID]

--14
--SELECT
--	e.[DepartmentID],
--	MIN(e.[Salary]) AS 'MinimumSalary'
--FROM Employees AS e
--WHERE e.[HireDate] > '01/01/2000'
--GROUP BY e.[DepartmentID]
--HAVING e.[DepartmentID] = 2 OR e.[DepartmentID] = 5 OR e.[DepartmentID] = 7

--15

--16
--SELECT
--	e.[DepartmentID],
--	MAX(e.[Salary]) AS 'MaxSalary'
--FROM Employees AS e
--GROUP BY e.[DepartmentID]
--HAVING MAX(e.[Salary]) NOT BETWEEN 30000 AND 70000

--17
--SELECT COUNT(e.[EmployeeID]) AS 'Count'
--FROM Employees AS e
--WHERE e.[ManagerID] IS NULL

--18
SELECT DISTINCT
	ranked.[DepartmentID],
	ranked.[Salary] AS 'ThirdHighestSalary'
FROM(
	SELECT
		e.[DepartmentID],
		e.[Salary],
		DENSE_RANK() OVER(PARTITION BY e.[DepartmentID] ORDER BY e.[Salary] DESC) AS 'SalaryRank'
	FROM Employees AS e
) AS ranked
WHERE ranked.[SalaryRank] = 3