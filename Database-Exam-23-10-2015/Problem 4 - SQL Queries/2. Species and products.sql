SELECT s.Name, COUNT(*) [Number of Products]
FROM Species s
	INNER JOIN ProductSpecies ps
	ON s.Id = ps.SpeciesId
	INNER JOIN Products p
	ON p.Id = ps.ProductId
GROUP BY s.Name
ORDER BY [Number of Products] 