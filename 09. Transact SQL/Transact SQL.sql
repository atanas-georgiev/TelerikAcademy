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


-- 8. Using database cursor write a T-SQL script that scans all employees and their addresses and prints all pairs of employees that live in the same town.
-- 9. *Write a T-SQL script that shows for each town a list of all employees that live in it.
-- Sample output:
-- Sofia -> Martin Kulov, George Denchev
-- Ottawa -> Jose Saraiva
-- …
-- 10. Define a .NET aggregate function StrConcat that takes as input a sequence of strings and return a single string that consists of the input strings separated by ','.
-- For example the following SQL statement should return a single string:
-- SELECT StrConcat(FirstName + ' ' + LastName)
-- FROM Employees