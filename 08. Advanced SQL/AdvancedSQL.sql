-- 1. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
-- Use a nested SELECT statement.
SELECT FirstName + ' ' + LastName Name, Salary
	FROM [TelerikAcademy].[dbo].[Employees]
	WHERE Salary = 
		(SELECT MIN(Salary) FROM [TelerikAcademy].[dbo].[Employees])
		
-- 2. Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.
SELECT FirstName + ' ' + LastName Name, Salary
	FROM [TelerikAcademy].[dbo].[Employees]
	WHERE Salary <=
		(SELECT (MIN(Salary) * 1.1) FROM [TelerikAcademy].[dbo].[Employees])

-- 3. Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
-- Use a nested SELECT statement.
SELECT FirstName + ' ' + LastName [Full Name], DepartmentID, Salary
	FROM [TelerikAcademy].[dbo].[Employees] e
		WHERE Salary = 
			(SELECT MIN(Salary) 
			 FROM [TelerikAcademy].[dbo].[Employees] 
			 WHERE DepartmentID = e.DepartmentID)
ORDER BY DepartmentID

-- 4. Write a SQL query to find the average salary in the department #1.
SELECT AVG(Salary) [Average salary in Department #1]
	FROM [TelerikAcademy].[dbo].[Employees] e
		WHERE DepartmentID = 1
		
-- 5. Write a SQL query to find the average salary in the "Sales" department.
-- Variant 1
SELECT AVG(e.Salary) [Average Salary in Sales Department]
	FROM [TelerikAcademy].[dbo].[Employees] e
WHERE EXISTS
 (SELECT d.Name FROM [TelerikAcademy].[dbo].[Departments] d	
		WHERE e.DepartmentID = d.DepartmentID AND d.Name = 'Sales')
-- Variant 2
SELECT AVG(e.Salary) [Average Salary in Sales Department]
	FROM [TelerikAcademy].[dbo].[Employees] e
INNER JOIN [TelerikAcademy].[dbo].[Departments] d
	ON e.DepartmentID = d.DepartmentID
		WHERE d.Name = 'Sales'
		
-- 6. Write a SQL query to find the number of employees in the "Sales" department.
SELECT COUNT(*) [Employers count in Sales Department]
	FROM [TelerikAcademy].[dbo].[Employees] e
WHERE EXISTS
 (SELECT d.Name FROM [TelerikAcademy].[dbo].[Departments] d	
		WHERE e.DepartmentID = d.DepartmentID AND d.Name = 'Sales')
		
-- 7. Write a SQL query to find the number of all employees that have manager.
SELECT COUNT(*) [Number of employers with manager]
	FROM [TelerikAcademy].[dbo].[Employees] e
		WHERE e.ManagerID IS NOT NULL

-- 8. Write a SQL query to find the number of all employees that have no manager.
SELECT COUNT(*) [Number of employers without manager]
	FROM [TelerikAcademy].[dbo].[Employees] e
		WHERE e.ManagerID IS NULL
		
-- 9. Write a SQL query to find all departments and the average salary for each of them.
SELECT d.Name [Department name], AVG(e.Salary) [Average Salary]
	FROM [TelerikAcademy].[dbo].[Employees] e
INNER JOIN
	[TelerikAcademy].[dbo].[Departments] d
	ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name

-- 10. Write a SQL query to find the count of all employees in each department and for each town.
SELECT d.Name, t.Name [Town], COUNT(*) [Employers count]
	FROM [TelerikAcademy].[dbo].[Employees] e
INNER JOIN
	[TelerikAcademy].[dbo].[Departments] d
	ON e.DepartmentID = d.DepartmentID
INNER JOIN
	[TelerikAcademy].[dbo].[Addresses] a
	ON a.AddressID = e.AddressID
INNER JOIN
	[TelerikAcademy].[dbo].[Towns] t
	ON t.TownID = a.TownID
GROUP BY t.Name, d.Name

-- 11. Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.
SELECT m.FirstName + ' ' + m.LastName [Manager Name], COUNT(e.FirstName) [Employers]
	FROM [TelerikAcademy].[dbo].[Employees] e
INNER JOIN
	[TelerikAcademy].[dbo].[Employees] m
	ON e.ManagerID = m.EmployeeID
GROUP BY m.FirstName + ' ' + m.LastName
HAVING COUNT(e.EmployeeID) = 5

-- 12. Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".
SELECT e.FirstName + ' ' + e.LastName AS [Employee Name], COALESCE(m.FirstName + ' '+ m.LastName, 'no manager') AS [Manager Name]
	FROM [TelerikAcademy].[dbo].[Employees] e
	LEFT JOIN [TelerikAcademy].[dbo].[Employees] m
		ON e.ManagerID = m.EmployeeID
		
-- 13. Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in LEN(str) function.
SELECT FirstName + ' ' + LastName AS [Employee Name]	   
	FROM [TelerikAcademy].[dbo].[Employees]
		WHERE LEN(LastName) = 5
		
-- 14. Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds".
-- Search in Google to find how to format dates in SQL Server.
SELECT FORMAT(GETDATE(), 'dd.MM.yyyy HH:mm:ss:fff')

-- 15. Write a SQL statement to create a table Users. Users should have username, password, full name and last login time.
-- Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
-- Define the primary key column as identity to facilitate inserting records.
-- Define unique constraint to avoid repeating usernames.
-- Define a check constraint to ensure the password is at least 5 characters long.
CREATE TABLE Users (
  UsersID int IDENTITY,
  UserName nvarchar(50) NOT NULL,
  UserPassword nvarchar(100) CHECK (LEN(UserPassword) > 5),
  FullName nvarchar(300) NOT NULL,
  LastLogin datetime,
  CONSTRAINT PK_Users PRIMARY KEY(UsersID),
  CONSTRAINT UC_UserName UNIQUE (UserName)
)
GO

-- 16. Write a SQL statement to create a view that displays the users from the Users table that have been in the system today.
-- Test if the view works correctly.
CREATE VIEW [Users Today] AS 
	SELECT UserName FROM Users
	WHERE DATEDIFF(DAY, LastLogin, GETDATE()) = 0
	
-- 17. Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint).
-- Define primary key and identity column.
CREATE TABLE Groups (
	GroupID int IDENTITY PRIMARY KEY NOT NULL,
	Name nvarchar(100) NOT NULL UNIQUE,  
)
GO

-- 18. Write a SQL statement to add a column GroupID to the table Users.
-- Fill some data in this new column and as well in the `Groups table.
-- Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.
ALTER TABLE Users
	ADD GroupID int
GO

ALTER TABLE Users
	ADD CONSTRAINT FK_Users_Groups
	FOREIGN KEY (GroupID)
	REFERENCES Groups(GroupId)
GO

-- 19. Write SQL statements to insert several records in the Users and Groups tables.
INSERT INTO Groups (Name) VALUES ('Group 1')
INSERT INTO Groups (Name) VALUES ('Group 2')
INSERT INTO Users (UserName, UserPassword, FullName, GroupID) VALUES ('peter', 'mypass', 'Peter Petrov', 1)
INSERT INTO Users (UserName, UserPassword, FullName, GroupID) VALUES ('gosho', 'mypass2', 'Gosho Goshov', 1)
INSERT INTO Users (UserName, UserPassword, FullName, GroupID) VALUES ('john', 'mypass3', 'John Johnson', 2)

-- 20. Write SQL statements to update some of the records in the Users and Groups tables.
UPDATE Groups SET Name='Group 123' WHERE Name='Group 1';
UPDATE Users SET FullName='Peter Ivanov' WHERE FullName='Peter Petrov';

-- 21. Write SQL statements to delete some of the records from the Users and Groups tables.
DELETE FROM Users WHERE UserName='john';
DELETE FROM Groups WHERE Name='Group 2';

-- 22. Write SQL statements to insert in the Users table the names of all employees from the Employees table.
-- Combine the first and last names as a full name.
-- For username use the first letter of the first name + the last name (in lowercase).
-- Use the same for the password, and NULL for last login time.
INSERT INTO Users (UserName, UserPassword, FullName, LastLogin, GroupID)
	SELECT LOWER(SUBSTRING(FirstName, 1, 1) + LastName), 
		   LOWER(SUBSTRING(FirstName, 1, 1) + LastName), 
		   FirstName + ' ' + LastName, 
		   NULL, 
		   NULL
	FROM [TelerikAcademy].[dbo].[Employees]
	
-- 23. Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.
UPDATE Users 
	SET UserPassword = NULL 
	WHERE LastLogin <= '2010-03-10'
	
-- 24. Write a SQL statement that deletes all users without passwords (NULL password).
DELETE FROM Users WHERE UserPassword IS NULL

-- 25. Write a SQL query to display the average employee salary by department and job title.
SELECT d.Name [Department], e.JobTitle [Position], AVG(e.Salary) [Average Salary]
	FROM [TelerikAcademy].[dbo].[Employees] e
INNER JOIN
	[TelerikAcademy].[dbo].[Departments] d
	ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle
ORDER BY d.Name

-- 26. Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.
SELECT d.Name [Department], e.JobTitle [Position], MIN(e.Salary) [Minimal Salary], MIN(CONCAT(e.FirstName, ' ', e.LastName)) AS [Employee]
	FROM [TelerikAcademy].[dbo].[Employees] e
INNER JOIN
	[TelerikAcademy].[dbo].[Departments] d
	ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle
ORDER BY d.Name

-- 27. Write a SQL query to display the town where maximal number of employees work.
SELECT TOP 1 t.Name [Town], COUNT(*) [Employers count]
	FROM [TelerikAcademy].[dbo].[Employees] e
INNER JOIN
	[TelerikAcademy].[dbo].[Departments] d
	ON e.DepartmentID = d.DepartmentID
INNER JOIN
	[TelerikAcademy].[dbo].[Addresses] a
	ON a.AddressID = e.AddressID
INNER JOIN
	[TelerikAcademy].[dbo].[Towns] t
	ON t.TownID = a.TownID
GROUP BY t.Name, d.Name
ORDER BY COUNT(*) DESC

-- 28. Write a SQL query to display the number of managers from each town.
SELECT t.Name, COUNT(m.EmployeeID) [Managers]
	FROM [TelerikAcademy].[dbo].[Employees] e
INNER JOIN
	[TelerikAcademy].[dbo].[Employees] m
	ON e.ManagerID = m.EmployeeID
INNER JOIN
	[TelerikAcademy].[dbo].[Addresses] a
	ON a.AddressID = e.AddressID
INNER JOIN
	[TelerikAcademy].[dbo].Towns t
	ON a.TownID = t.TownID
GROUP BY t.Name
ORDER BY COUNT(m.EmployeeID) DESC

-- 29. Write a SQL to create table WorkHours to store work reports for each employee (employee id, date, task, hours, comments).
-- Don't forget to define identity, primary key and appropriate foreign key.
-- Issue few SQL statements to insert, update and delete of some data in the table.
-- Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers.
-- For each change keep the old record data, the new record data and the command (insert / update / delete).

--- TABLE: WorkHours
CREATE TABLE WorkHours (
    WorkReportId int IDENTITY,
    EmployeeId Int NOT NULL,
    OnDate DATETIME NOT NULL,
    Task nvarchar(256) NOT NULL,
    Hours Int NOT NULL,
    Comments nvarchar(256),
    CONSTRAINT PK_Id PRIMARY KEY(WorkReportId),
    CONSTRAINT FK_Employees_WorkHours 
        FOREIGN KEY (EmployeeId)
        REFERENCES Employees(EmployeeId)
) 
GO
--- INSERT
DECLARE @counter int;
SET @counter = 20;
WHILE @counter > 0
BEGIN
    INSERT INTO WorkHours(EmployeeId, OnDate, Task, [Hours])
    VALUES (@counter, GETDATE(), 'TASK: ' + CONVERT(varchar(10), @counter), @counter)
    SET @counter = @counter - 1
END
--- UPDATE
UPDATE WorkHours
    SET Comments = 'Work hard or go home!'
    WHERE [Hours] > 10
--- DELETE
DELETE *
    FROM WorkHours
    WHERE EmployeeId IN (1, 3, 5, 7, 13)
--- TABLE: WorkHoursLogs
CREATE TABLE WorkHoursLogs (
    WorkLogId int,
    EmployeeId Int NOT NULL,
    OnDate DATETIME NOT NULL,
    Task nvarchar(256) NOT NULL,
    Hours Int NOT NULL,
    Comments nvarchar(256),
    [Action] nvarchar(50) NOT NULL,
    CONSTRAINT FK_Employees_WorkHoursLogs
        FOREIGN KEY (EmployeeId)
        REFERENCES Employees(EmployeeId),
    CONSTRAINT [CC_WorkReportsLogs] CHECK ([Action] IN ('Insert', 'Delete', 'DeleteUpdate', 'InsertUpdate'))
) 
GO
--- TRIGGER FOR INSERT
CREATE TRIGGER tr_InsertWorkReports ON WorkHours FOR INSERT
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, [Hours], Comments, 'Insert'
    FROM inserted
GO
--- TRIGGER FOR DELETE
CREATE TRIGGER tr_DeleteWorkReports ON WorkHours FOR DELETE
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, [Hours], Comments, 'Delete'
    FROM deleted
GO
--- TRIGGER FOR UPDATE
CREATE TRIGGER tr_UpdateWorkReports ON WorkHours FOR UPDATE
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, [Hours], Comments, 'InsertUpdate'
    FROM inserted
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT WorkReportId, EmployeeID, OnDate, Task, [Hours], Comments, 'DeleteUpdate'
    FROM deleted
GO
--- TEST TRIGGERS
DELETE * 
    FROM WorkHoursLogs
INSERT INTO WorkHours(EmployeeId, OnDate, Task, [Hours])
    VALUES (25, GETDATE(), 'TASK: 25', 25)
DELETE * 
    FROM WorkHours
    WHERE EmployeeId = 25
UPDATE WorkHours
    SET Comments = 'Updated'
    WHERE EmployeeId = 2

-- 30. Start a database transaction, delete all employees from the 'Sales' department along with all dependent records from the pother tables.
-- At the end rollback the transaction.
BEGIN TRAN
    ALTER TABLE Departments
        DROP CONSTRAINT FK_Departments_Employees
    GO
    DELETE * 
        FROM Employees e
        JOIN Departments d
            ON e.DepartmentID = d.DepartmentID
        WHERE d.Name = 'Sales'
ROLLBACK TRAN

-- 31. Start a database transaction and drop the table EmployeesProjects.
-- Now how you could restore back the lost table data?
BEGIN TRANSACTION
    DROP TABLE EmployeesProjects
ROLLBACK TRANSACTION

-- 32. Find how to use temporary tables in SQL Server.
-- Using temporary tables backup all records from EmployeesProjects and restore them back after dropping and re-creating the table.
BEGIN TRANSACTION
    SELECT * 
        INTO #TempEmployeesProjects
        FROM EmployeesProjects
    DROP TABLE EmployeesProjects
    SELECT * 
        INTO EmployeesProjects
        FROM #TempEmployeesProjects
    DROP TABLE #TempEmployeesProjects
ROLLBACK TRANSACTION
