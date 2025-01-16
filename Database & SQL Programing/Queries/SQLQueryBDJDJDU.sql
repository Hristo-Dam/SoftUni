USE master
GO

CREATE DATABASE Shop
Go

USE Shop
GO

CREATE TABLE Employee(
	[EmployeeID] INT PRIMARY KEY IDENTITY,
	[FirstName] VARCHAR(30) NOT NULL,
	[LastName] VARCHAR(30) NOT NULL,
	[JobTitle] VARCHAR(50),
	[DepartmentID] INT,
	[HireDate] DATETIME2,
	[Salary] DECIMAL,
	[LocationID] INT,
	[BadgeNumber] INT,

	CONSTRAINT FK_Employee_Location
	FOREIGN KEY ([LocationID])
	REFERENCES [Location]([LocationID]),

	CONSTRAINT FK_Employees_Badges
	FOREIGN KEY ([BadgeNumber])
	REFERENCES Badges([BadgeNumber])
)
GO

CREATE TABLE [Location](
	[LocationID] INT PRIMARY KEY,
	[Country] VARCHAR(50),
	[Town] VARCHAR(50),
	[Address] VARCHAR(50),
	[EmployeeNumber] INT
)
GO

CREATE TABLE Badges(
	[BadgeNumber] INT PRIMARY KEY IDENTITY(101, 1) NOT NULL,
	[First Name] VARCHAR(30) NOT NULL,
	[Last Name] VARCHAR(30) NOT NULL,
)
GO

CREATE TABLE Profit(
	[LocationID] INT PRIMARY KEY,
	[Profit] DECIMAL,
	[ItemsSold] INT,

	CONSTRAINT FK_Profit_Location
	FOREIGN KEY ([LocationID])
	REFERENCES [Location]([LocationID])
)
GO

CREATE TABLE [Products](
	[ProductID] INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(30) NOT NULL,
	[Size] DECIMAL,
	[AvailableQuantity] INT,
	[Price] DECIMAL,

)
GO

CREATE TABLE[CustomerAccounts](
	[AccountID] INT PRIMARY KEY IDENTITY,
	[Points] INT,
	[FirstName] NVARCHAR(15) NOT NULL,
	[LastName] NVARCHAR(15) NOT NULL,
	[Password] NVARCHAR(30) NOT NULL
)
GO

CREATE TABLE [Orders](
	[OrderID] INT PRIMARY KEY IDENTITY(11111, 1),
	[CustomerID] INT,
	
	CONSTRAINT FK_Orders_Custmores 
	FOREIGN KEY ([CustomerID]) 
	REFERENCES [CustomerAccounts]([AccountID]),

	[ProductID] INT,

	CONSTRAINT FK_Orders_Products
	FOREIGN KEY (ProductID)
	REFERENCES Products([ProductID]),

	[Compleated] INT
)
GO

CREATE VIEW v_FullAdmin AS
SELECT * FROM [CustomerAccounts];

GO


CREATE VIEW v_RestrictedAcc AS
SELECT 
    [AccountID], 
    [FirstName], 
    [Points], 
    LEFT([Password], 6) + '**********' AS MaskedPassword
FROM [CustomerAccounts];

GO

CREATE VIEW v_UncompleatedOrders AS
SELECT
	* FROM [Orders] WHERE [Compleated] = 0;
GO

INSERT INTO [Location] ([LocationID], [Country], [Town], [Address], [EmployeeNumber])
VALUES (1, 'Bulgaria', 'Sofia', 'Aleksandur Aleksandrov 99', 57),
		(2, 'Germany', 'Berlin', 'BeerStrasse 55', 66)
GO

INSERT INTO Orders([CustomerID], [ProductID], [Compleated])
VALUES(1, 5, 0);

INSERT INTO Orders([CustomerID], [ProductID], [Compleated])
VALUES(1, 4, 0);

INSERT INTO Orders([CustomerID], [ProductID], [Compleated])
VALUES(2, 3, 1);

INSERT INTO Orders([CustomerID], [ProductID], [Compleated])
VALUES(2, 6, 0);

INSERT INTO Orders([CustomerID], [ProductID], [Compleated])
VALUES(3, 7, 1);

INSERT INTO Orders([CustomerID], [ProductID], [Compleated])
VALUES(3, 1, 0);

INSERT INTO Orders([CustomerID], [ProductID], [Compleated])
VALUES(3, 3, 1);
GO

INSERT INTO Employee(FirstName, LastName, JobTitle,    HireDate, Salary)
VALUES ('Dimitur', 'Dimitrov', 'Manager', '21/10/2017', 4567);
INSERT INTO Employee(FirstName, LastName, JobTitle,    HireDate, Salary)
VALUES ('Martin', 'Angelov', 'Driver', '25/06/2022', 2389);
INSERT INTO Employee(FirstName, LastName, JobTitle,    HireDate, Salary)
VALUES ('Boris', 'Markov', 'SalesMan', '08/1/2012', 3189);
INSERT INTO Employee(FirstName, LastName, JobTitle,    HireDate, Salary)
VALUES ('Sasho', 'Todorov', 'Cashier', '04/08/2023', 3210);
INSERT INTO Employee(FirstName, LastName, JobTitle,    HireDate, Salary)
VALUES ('Boyan', 'Dimitrov', 'Janitor', '26/09/2014', 1948);

SELECT * FROM v_UncompleatedOrders
SELECT * FROM v_RestrictedAcc