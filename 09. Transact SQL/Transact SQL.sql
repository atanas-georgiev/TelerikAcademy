-- 1. Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and Accounts(Id(PK), PersonId(FK), Balance).
-- Insert few records for testing.
-- Write a stored procedure that selects the full names of all persons.
CREATE TABLE Persons (
    PersonId int NOT NULL IDENTITY,
    FirstName nvarchar(100) NOT NULL,
	LastName nvarchar(100) NOT NULL,
    SSN int NOT NULL UNIQUE,
    CONSTRAINT PK_Person PRIMARY KEY(PersonId)
) 
GO

CREATE TABLE Accounts (
    AccountId int  NOT NULL IDENTITY,
	PersonId Int NOT NULL,
    Balance money NOT NULL,
	CONSTRAINT PK_Accounts PRIMARY KEY(AccountId),
	CONSTRAINT FK_Persons_Accounts
		FOREIGN KEY (PersonId)
		REFERENCES Persons(PersonId)
) 
GO

INSERT INTO Persons (FirstName, LastName, SSN) VALUES ('peter', 'petrov', 12345678)
INSERT INTO Persons (FirstName, LastName, SSN) VALUES ('atanas', 'georgiev', 12345679)
INSERT INTO Persons (FirstName, LastName, SSN) VALUES ('gosho', 'goshev', 12345671)
INSERT INTO Persons (FirstName, LastName, SSN) VALUES ('stamat', 'ivanov', 23456781)
GO

INSERT INTO Accounts (PersonId, Balance) VALUES (1, 1000)
INSERT INTO Accounts (PersonId, Balance) VALUES (2, 1)
INSERT INTO Accounts (PersonId, Balance) VALUES (3, 10000)
INSERT INTO Accounts (PersonId, Balance) VALUES (4, 100000)
GO

CREATE PROC dbo.usp_SelectAllFullNames
AS
  SELECT  FirstName + ' ' + LastName [Full Name]
  FROM Persons  
GO

-- 2. Create a stored procedure that accepts a number as a parameter and returns all persons who have more money in their accounts than the supplied number.
CREATE PROC usp_SelectAllPersonsWithSomeMoney(
  @minMoney money = 1)
AS
SELECT p.FirstName + ' ' + p.LastName [Name], a.Balance
	FROM Persons p
INNER JOIN
	Accounts a
	ON p.PersonId = a.PersonId
WHERE a.Balance > @minMoney
GO

EXEC usp_SelectAllPersonsWithSomeMoney 100

-- 3. Create a function that accepts as parameters – sum, yearly interest rate and number of months.
-- It should calculate and return the new sum.
-- Write a SELECT to test whether the function works as expected.
CREATE PROC usp_ColaculateMoney(
  @sum money,
  @yearlyRate decimal,
  @months int,
  @result money OUTPUT)
AS
	SET @result = @sum + (@months * (@yearlyRate / 12) / 100) * @sum
GO

DECLARE @answer money
EXECUTE usp_ColaculateMoney 1000, 5, 12, @answer OUTPUT
SELECT 'The result is: ', @answer

-- 4. Create a stored procedure that uses the function from the previous example to give an interest to a person's account for one month.
-- It should take the AccountId and the interest rate as parameters.
CREATE PROC usp_GetInteresetForAMonth(
  @accountId int,
  @yearlyRate decimal)
AS
	DECLARE @accountMoney money
	DECLARE @result money

	SELECT @accountMoney = Balance FROM Accounts WHERE AccountId = @accountId	
	EXECUTE usp_ColaculateMoney @accountMoney, @yearlyRate, 1, @result OUTPUT
	RETURN @result
GO

DECLARE @answer money
EXEC @answer = usp_GetInteresetForAMonth 1, 5
SELECT 'The result is: ', @answer

-- 5. Add two more stored procedures WithdrawMoney(AccountId, money) and DepositMoney(AccountId, money) that operate in transactions.
 CREATE PROC usp_WithdrawMoney(
  @accountId int,
  @moneyParam money)
AS
	DECLARE @accountMoney money
	SELECT @accountMoney = Balance FROM Accounts WHERE AccountId = @accountId	
	UPDATE Accounts SET Balance = @accountMoney - @moneyParam WHERE AccountId = @accountId
GO

CREATE PROC usp_DepositMoney(
  @accountId int,
  @moneyParam money)
AS
	DECLARE @accountMoney money
	SELECT @accountMoney = Balance FROM Accounts WHERE AccountId = @accountId	
	UPDATE Accounts SET Balance = @accountMoney + @moneyParam WHERE AccountId = @accountId
GO

EXEC usp_DepositMoney 1, 150000
EXEC usp_WithdrawMoney 1, 50000

-- 6. Create another table – Logs(LogID, AccountID, OldSum, NewSum).
-- Add a trigger to the Accounts table that enters a new entry into the Logs table every time the sum on an account changes.
CREATE TABLE Logs (
    LogId int NOT NULL IDENTITY,
    AccountID int NOT NULL,
	OldSum money NOT NULL,
    NewSum money NOT NULL,
    CONSTRAINT PK_Logs PRIMARY KEY(LogId)
) 
GO

CREATE TRIGGER tr_AccountsUpdate ON Accounts FOR UPDATE
AS
    DECLARE @oldSum money;
    SELECT @oldSum = Balance FROM deleted;

    INSERT INTO Logs(AccountId, OldSum, NewSum)
        SELECT AccountId, @oldSum, Balance
        FROM inserted
GO

EXEC usp_WithdrawMoney 1, 1000
EXEC usp_DepositMoney 2, 2000

-- 7. Define a function in the database TelerikAcademy that returns all Employee's names (first or middle or last name) and all town's names that are comprised of given set of letters.
-- Example: 'oistmiahf' will return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.
use TelerikAcademy
GO

CREATE FUNCTION ufn_CheckName(
@nameToCheck NVARCHAR(50), 
@letters NVARCHAR(50))
RETURNS INT
AS
BEGIN
	DECLARE @i INT = 1
	DECLARE @currentChar NVARCHAR(1)
	WHILE (@i <= LEN(@nameToCheck))
	BEGIN
		SET @currentChar = SUBSTRING(@nameToCheck,@i, 1)
		IF (CHARINDEX(LOWER(@currentChar),LOWER(@letters)) <= 0) 
		BEGIN  
			RETURN 0
		END
		SET @i = @i + 1
	END
	RETURN 1
END
GO

CREATE FUNCTION dbo.ufn_AllEmploeeysAndTownByStringCondition(@format nvarchar(50))
RETURNS @table TABLE
	([Name] nvarchar(50) NOT NULL)
AS
BEGIN
	INSERT @table
	SELECT newTbl.LastName FROM
		(SELECT LastName FROM Employees
		UNION
		SELECT Name FROM Towns) as newTbl
		WHERE dbo.ufn_CheckName(newTbl.LastName, @format) > 0
	 RETURN
END
GO

-- 8. Using database cursor write a T-SQL script that scans all employees and their addresses and prints all pairs of employees that live in the same town.
DECLARE empCursor CURSOR READ_ONLY FOR
	SELECT e.FirstName, e.LastName, t.Name FROM Employees e
	JOIN Addresses a
	ON e.AddressID = a.AddressID
	JOIN Towns t
	ON a.TownID = t.TownID

OPEN empCursor
DECLARE @firstName nvarchar(50), @lastName nvarchar(50), @town nvarchar(50)
FETCH NEXT FROM empCursor INTO @firstName, @lastName, @town

WHILE @@FETCH_STATUS = 0
BEGIN
	DECLARE empCursor1 CURSOR READ_ONLY FOR
	SELECT e.FirstName, e.LastName, t.Name FROM Employees e
	JOIN Addresses a
	ON e.AddressID = a.AddressID
	JOIN Towns t
	ON a.TownID = t.TownID

	OPEN empCursor1
	DECLARE @firstName1 nvarchar(50), @lastName1 nvarchar(50), @town1 nvarchar(50)
	FETCH NEXT FROM empCursor1 INTO @firstName1, @lastName1, @town1

	WHILE @@FETCH_STATUS = 0
	BEGIN
	IF(@town=@town1 AND @firstName != @firstName1 AND @lastName != @lastName1)
	BEGIN
	PRINT @town+':'+ @firstName + ' ' + @lastName + ':' + @firstName1 + ' ' + @lastName1 
	END
	FETCH NEXT FROM empCursor1 INTO @firstName1, @lastName1, @town1
	END

	CLOSE empCursor1
	DEALLOCATE empCursor1

	FETCH NEXT FROM empCursor  INTO @firstName, @lastName, @town
END

CLOSE empCursor
DEALLOCATE empCursor

--9.	*Write a T-SQL script that shows for each town a list of all employees that live in it.

DECLARE empCursor CURSOR READ_ONLY FOR
  SELECT DISTINCT t.Name, t.Name AS [fullNames] FROM Towns t

OPEN empCursor
DECLARE @town nvarchar(50), @fullNames nvarchar(2000)
FETCH NEXT FROM empCursor INTO @town, @fullNames

WHILE @@FETCH_STATUS = 0
BEGIN
	DECLARE empCursor1 CURSOR READ_ONLY FOR
	SELECT e.FirstName, e.LastName, t.Name FROM Employees e
	JOIN Addresses a
	ON e.AddressID = a.AddressID
	JOIN Towns t
	ON a.TownID = t.TownID

	OPEN empCursor1
	DECLARE @firstName1 nvarchar(50), @lastName1 nvarchar(50), @town1 nvarchar(50)
	FETCH NEXT FROM empCursor1 INTO @firstName1, @lastName1, @town1

	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF(@town=@town1)
		BEGIN
			SET @fullNames+= @firstName1 + ' ' + @lastName1 + ', ' 
		END
		FETCH NEXT FROM empCursor1 INTO @firstName1, @lastName1, @town1
	END

	CLOSE empCursor1
	DEALLOCATE empCursor1
	PRINT @town + ' -> '+ @fullNames
	FETCH NEXT FROM empCursor INTO @town, @fullNames
END

CLOSE empCursor
DEALLOCATE empCursor

-- 10. Define a .NET aggregate function StrConcat that takes as input a sequence of strings and return a single string that consists of the input strings separated by ','.
-- For example the following SQL statement should return a single string:
-- SELECT StrConcat(FirstName + ' ' + LastName)
-- FROM Employees
EXEC sp_configure 'clr enabled', 1
GO
RECONFIGURE
GO

CREATE ASSEMBLY CommaSeparatedValue
AUTHORIZATION dbo
FROM 'C:\Users\Nevena\Dropbox\education\Chapter11_Database\Databases-Homework\09. Transact-SQL\CommaSeparatedValue\bin\Debug\CommaSeparatedValue.dll'
WITH PERMISSION_SET = SAFE;
GO

CREATE AGGREGATE dbo.StringConcat (
@value nvarchar(MAX), 
@delimiter nvarchar(50)
) 
RETURNS nvarchar(MAX)
EXTERNAL NAME CommaSeparatedValue.[CommaSeparatedValue.CommaSeparatedValue]
--–EXTERNAL NAME SQLAssemblyName.[C#NameSpace”.C#ClassName].C#MethodName

SELECT dbo.StringConcat(FirstName, ',')
FROM Employees

DROP AGGREGATE dbo.StringConcat
DROP ASSEMBLY CommaSeparatedValue