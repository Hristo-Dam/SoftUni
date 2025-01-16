USE TreasureHunt
GO

SELECT TOP 1 g.[GuardianName], g.[GuardianID], COUNT(r.RelicID) as 'RelicsCount'
FROM Guardians AS g
JOIN Relics AS r
ON r.[GuardianID] = g.[GuardianID]
GROUP BY g.[GuardianName], g.[GuardianID]
ORDER BY COUNT(r.RelicID) DESC

SELECT t.[MapID], t.[ClueID], c.[Riddle], c.[Hints]
FROM TreasureMaps AS t
JOIN Guardians AS g
ON g.[GuardianID] = t.[GuardianID]
JOIN Clues AS c
ON t.[ClueID] = c.[ClueID]
WHERE t.[GuardianID] = 1

SELECT l.[LocationName], l.[LocationID], c.[ClueID], c.[Riddle], c.[Hints]
FROM Locations AS l
JOIN Clues AS c
ON l.[LocationID] = c.[ClueID]
WHERE LocationName LIKE '%sunset%'

SELECT l.[LocationName], l.[LocationID], a.[ArtifactName]
FROM Locations AS l
JOIN Artifacts AS a
ON l.[LocationID] = a.[LocationID]
WHERE l.[LocationName] LIKE '%Forest Shrine%'