USE Logistics
GO

SELECT *, 
CEILING(
	CEILING(
		CAST([Quantity] AS FLOAT) / [BoxCapacity] / [PalletCapacity]))
		AS Devition
FROM Products

