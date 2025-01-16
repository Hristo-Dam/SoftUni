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
	REFERENCES [Location]([LocationID])
)

CREATE TABLE [Location](
	[LocationID] INT PRIMARY KEY,
	[Country] VARCHAR(50),
	[Town] VARCHAR(50),
	[Address] VARCHAR(50),
	[EmployeeNumber] INT
)

CREATE TABLE Badges(
	[BagdeNumber] INT PRIMARY KEY IDENTITY(101, 1) NOT NULL,
	[First Name] VARCHAR(30) NOT NULL,
	[Last Name] VARCHAR(30) NOT NULL,

	CONSTRAINT FK_Badges_Employees
	FOREIGN KEY (BadgeNumber)
	REFERENCES Employee([BadgeNumber])
)

CREATE TABLE Profit(
	[LocationID] INT PRIMARY KEY,
	[Profit] DECIMAL,
	[ItemsSold] INT,

	CONSTRAINT FK_Profit_Location
	FOREIGN KEY ([LocationID])
	REFERENCES [Location]([LocationID])
)

CREATE TABLE [Products](
	[ProductID] INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(30) NOT NULL,
	[Size] DECIMAL,
	[AvailableQuantity] INT,
	[Price] DECIMAL,

)
CREATE TABLE[CustomerAccounts](
	[AccountID] INT PRIMARY KEY IDENTITY,
	[Points] INT,
	[FirstName] NVARCHAR(15) NOT NULL,
	[LastName] NVARCHAR(15) NOT NULL,
	[Password] NVARCHAR(30) NOT NULL
)

CREATE TABLE [Orders](
	[OrderID] INT PRIMARY KEY IDENTITY(11111, 1),
	[CustomerID] INT,
	
	CONSTRAINT FK_Orders_Custmores 
	FOREIGN KEY ([CustomerID]) 
	REFERENCES [CustomerAccounts]([AccountID]),

	[ProductID] INT,

	CONSTRAINT FK_Orders_Products
	FOREIGN KEY (ProductID)
	REFERENCES Products([ProductID])

)