USE PetStore
GO

CREATE PROC usp_AddPetColors
AS
DECLARE @numberOfColors int
SET @numberOfColors = (SELECT COUNT(*) FROM Colors)
IF @numberOfColors = 0 
	BEGIN
		INSERT INTO Colors VALUES ('black')
		INSERT INTO Colors VALUES ('white')
		INSERT INTO Colors VALUES ('red')
		INSERT INTO Colors VALUES ('mixed')
	END
GO

EXEC usp_AddPetColors
GO