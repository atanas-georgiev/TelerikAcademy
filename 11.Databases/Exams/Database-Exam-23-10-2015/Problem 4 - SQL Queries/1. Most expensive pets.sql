SELECT TOP 5 Price, Breed, YEAR(Birthdate) BirthYear
FROM Pets
WHERE YEAR(Birthdate) > 2012
ORDER BY Price DESC