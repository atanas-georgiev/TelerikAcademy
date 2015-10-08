-- 1. What is SQL? What is DML? What is DDL? Recite the most important SQL commands.
/*
-> SQL - Structured query language
-> Data Definition Language (DDL) statements are used to define the database structure or schema. Some examples:
CREATE - to create objects in the database
ALTER - alters the structure of the database
DROP - delete objects from the database
TRUNCATE - remove all records from a table, including all spaces allocated for the records are removed
COMMENT - add comments to the data dictionary
RENAME - rename an object
-> Data Manipulation Language (DML) statements are used for managing data within schema objects. Some examples:
SELECT - retrieve data from the a database
INSERT - insert data into a table
UPDATE - updates existing data within a table
DELETE - deletes all records from a table, the space for the records remain
*/

-- 2. What is Transact-SQL (T-SQL)?
/*
T-SQL (Transact-SQL) is a set of programming extensions from Sybase and Microsoft that add several features to the Structured Query Language (SQL) including transaction control, exception and error handling, row processing, and declared variables. Microsoft's SQL Server and Sybase's SQL server support T-SQL statements. 
*/

-- 4. Write a SQL query to find all information about all departments (use "TelerikAcademy" database).
SELECT * FROM [TelerikAcademy].[dbo].[Departments]

-- 5. Write a SQL query to find all department names.
SELECT DISTINCT Name FROM [TelerikAcademy].[dbo].[Departments]

-- 6. Write a SQL query to find the salary of each employee.
SELECT FirstName + ' ' + LastName Name, Salary
	FROM [TelerikAcademy].[dbo].[Employees]

-- 7. Write a SQL to find the full name of each employee.
SELECT FirstName + ' ' + COALESCE(MiddleName, '') + ' ' + LastName [Full Name]
	FROM [TelerikAcademy].[dbo].[Employees]
	
-- 8. Write a SQL query to find the email addresses of each employee (by his first and last name). Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". The produced column should be named "Full Email Addresses".
SELECT FirstName + '.' + LastName + '@telerik.com' [Full Email Addresses]
	FROM [TelerikAcademy].[dbo].[Employees]
	
-- 9. Write a SQL query to find all different employee salaries.
SELECT DISTINCT Salary
	FROM [TelerikAcademy].[dbo].[Employees]
	ORDER BY Salary
	
-- 10. Write a SQL query to find all information about the employees whose job title is “Sales Representative“.
SELECT *
	FROM [TelerikAcademy].[dbo].[Employees]
	WHERE JobTitle = 'Sales Representative'
	
-- 11. Write a SQL query to find the names of all employees whose first name starts with "SA".
SELECT FirstName + ' ' + LastName [Full Name]
	FROM [TelerikAcademy].[dbo].[Employees]
	WHERE FirstName LIKE 'SA%'
	
-- 12. Write a SQL query to find the names of all employees whose last name contains "ei".
SELECT FirstName + ' ' + LastName [Full Name]
	FROM [TelerikAcademy].[dbo].[Employees]
	WHERE LastName LIKE '%ei%'
	
-- 13. Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].
SELECT FirstName + ' ' + LastName [Full Name], Salary
	FROM [TelerikAcademy].[dbo].[Employees]
	WHERE Salary BETWEEN 20000 AND 30000
	ORDER BY Salary
	
-- 14. Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.
SELECT FirstName + ' ' + LastName [Full Name], Salary
	FROM [TelerikAcademy].[dbo].[Employees]
	WHERE Salary IN (12500, 14000, 23600, 25000)
	ORDER BY Salary
	
-- 15. Write a SQL query to find all employees that do not have manager.
SELECT FirstName + ' ' + LastName [Full Name]
	FROM [TelerikAcademy].[dbo].[Employees]
	WHERE ManagerID IS NULL
	
-- 16. Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.
SELECT FirstName + ' ' + LastName [Full Name], Salary
	FROM [TelerikAcademy].[dbo].[Employees]
	WHERE Salary > 50000
	ORDER BY Salary DESC
	
-- 17. Write a SQL query to find the top 5 best paid employees.
SELECT TOP 5 FirstName + ' ' + LastName [Full Name], Salary
	FROM [TelerikAcademy].[dbo].[Employees]
	ORDER BY Salary DESC

-- 18. Write a SQL query to find all employees along with their address. Use inner join with ON clause.
SELECT e.FirstName, e.LastName, a.AddressText
	FROM [TelerikAcademy].[dbo].[Employees] e INNER JOIN [TelerikAcademy].[dbo].[Addresses] a
	ON e.AddressID = a.AddressID
	
-- 19. Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).
SELECT e.FirstName, e.LastName, a.AddressText
	FROM [TelerikAcademy].[dbo].[Employees] e, [TelerikAcademy].[dbo].[Addresses] a
	WHERE e.AddressID = a.AddressID 
	
-- 20. Write a SQL query to find all employees along with their manager.
SELECT e.FirstName, e.LastName, m.FirstName + ' ' + m.LastName Manager
	FROM [TelerikAcademy].[dbo].[Employees] e, [TelerikAcademy].[dbo].[Employees] m
	WHERE e.ManagerID = m.EmployeeID
	
-- 21. Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: Employees e, Employees m and Addresses a.
SELECT e.FirstName, e.LastName, a.AddressText, m.FirstName + ' ' + m.LastName Manager
	FROM [TelerikAcademy].[dbo].[Employees] e 
	INNER JOIN [TelerikAcademy].[dbo].[Employees] m
	ON e.ManagerID = m.EmployeeID
	INNER JOIN [TelerikAcademy].[dbo].[Addresses] a
	ON e.AddressID = a.AddressID
	
-- 22. Write a SQL query to find all departments and all town names as a single list. Use UNION.
SELECT d.Name
FROM [TelerikAcademy].[dbo].[Departments] d 
	UNION
		SELECT t.Name
		FROM [TelerikAcademy].[dbo].[Towns] t

-- 23. Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.
-- LEFT JOIN
SELECT e.FirstName + ' ' + e.LastName Name, m.FirstName + ' ' + m.LastName Manager
FROM [TelerikAcademy].[dbo].[Employees] m
	RIGHT OUTER JOIN [TelerikAcademy].[dbo].[Employees] e
	ON e.ManagerID = m.EmployeeID

-- RIGHT JOIN
SELECT e.FirstName + ' ' + e.LastName Name, m.FirstName + ' ' + m.LastName Manager
FROM [TelerikAcademy].[dbo].[Employees] e 
	LEFT OUTER JOIN [TelerikAcademy].[dbo].[Employees] m
	ON e.ManagerID = m.EmployeeID
	
-- 24. Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.
SELECT e.FirstName + ' ' + e.LastName Name, d.Name Department, e.HireDate
FROM [TelerikAcademy].[dbo].[Employees] e
	INNER JOIN [TelerikAcademy].[dbo].[Departments] d
	ON e.DepartmentID = d.DepartmentID
		WHERE d.Name IN ('Sales', 'Finance') 
		AND e.HireDate BETWEEN '1995-1-1' AND '2005-12-31'
		