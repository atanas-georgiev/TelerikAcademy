##Database Systems - Homework

##What database models do you know?
* Hierarchical (Tree)
* Network (Graph)
* Relational (Table)
* Object-oriented

##Which are the main functions performed by a Relational Database Management System (RDBMS)?
* Stores a set of data in tables
* Stores relations between the tables
* Implement mathematical algorithms to search and organize the data

##Define what is "table" in database terms.
A table is a collection of related data held in a structured format within a database. It consists of fields (columns), and rows. In relational databases and flat file databases, a table is a set of data elements (values) using a model of vertical columns (identifiable by name) and horizontal rows, the cell being the unit where a row and column intersect. A table has a specified number of columns, but can have any number of rows. Each row is identified by one or more values appearing in a particular column subset. The columns subset which uniquely identifies a row is called the primary key.

##Explain the difference between a primary and a foreign key.
* Primary key is a column of the table that uniquely identifies its rows
* The foreign key is an identifier of a record located in another table (usually the primary key of the another table)

##Explain the different kinds of relationships between tables in relational databases.
* one-to-one relationship is a type of cardinality that refers to the relationship between two entities (see also entity–relationship model) A and B in which one element of A may only be linked to one element of B, and vice versa. For instance, think of A as countries, and B as capital cities. A country has only one capital city, and a capital city is the capital of only one country
* one-to-many relationship is a type of cardinality that refers to the relationship between two entities (see also entity–relationship model) A and B in which element of A may be linked to many elements of B, but a member of B is linked to only one element of A. For instance, think of A as mothers, and B as children. A mother can have several children, but a child can have only one mother.
* many-to-many relationship is a type of cardinality that refers to the relationship between two entities (see also entity–relationship model) A and B in which A may contain a parent record for which there are many children in B and vice versa. For instance, think of A as Authors, and B as Books. An Author can write several Books, and a Book can be written by several Authors. Because most database management systems only support one-to-many relationships, it is necessary to implement such relationships physically via a third junction table (also called cross-reference table), say, AB with two one-to-many relationships A -> AB and B -> AB. In this case the logical primary key for AB is formed from the two foreign keys (i.e. copies of the primary keys of A and B).

##When is a certain database schema normalized?
Database normalization (or normalisation) is the process of organizing the columns (attributes) and tables (relations) of a relational database to minimize data redundancy. Normalization involves decomposing a table into less redundant (and smaller) tables without losing information; defining foreign keys in the old table referencing the primary keys of the new ones. The objective is to isolate data so that additions, deletions, and modifications of an attribute can be made in just one table and then propagated through the rest of the database using the defined foreign keys.
Advantages:
* Data is only stored once
* Complex queries can be carried out
* Better security
* Cater for future requirements

##What are database integrity constraints and when are they used?
* Integrity constraints - ensure data integrity in the database tables
* Primary key constraint - ensures that the primary key of a table has unique value for each table row
* Unique key constraint - ensures that all values in a certain column (or a group of columns) are unique
* Foreign key constraint - ensures that the value in given column is a key from another table
* Check constraint - ensures that values in a certain column meet some predefined condition

##Point out the pros and cons of using indexes in a database.
* Advantages: use an index for quick access to a database table specific information. The index is a structure of the database table the value of one or more columns to sort
As a general rule, only when the data in the index column Frequent queries, only need to create an index on the table. The index take up disk space and reduce to add, delete, and update the line speed. In most cases, the speed advantages of indexes for data retrieval greatly exceeds it. 
* Disadvantages: too index will affect the speed of update and insert, because it requires the same update each index file. For a frequently updated and inserted into the table, there is no need for a rarely used where the words indexed separately, small table, the cost of sorting will not be great, there is no need to create additional indexes. In some cases, the indexing words may not be fast, for example, the index is placed in a contiguous memory space, which will increase the burden of disk read, which is optimal, it should be through the actual use of the environment to be tested.

##What's the main purpose of the SQL language?
Purpose of SQL Structured Query Language is to provide a Structured way by which one can Query information in database using a standard Language. SQL provides a global standard of working with databases with little or not differences over different platform. For e.g. if you are familiar with SQL you can work with major DBs like SQL Server mySql & Oracle few minor differences in syntax exists but they aren’t very prominent at least as far as basic operations are concerned.

##What are transactions used for?
Transactions are a sequence of database operations which are executed as a single unit:
* Either all of them execute successfully
* Or none of them is executed at all

Example:
* A bank transfer, it should not be possible to withdraw money twice. 

##What is a NoSQL database?
A NoSQL ("non SQL" or "non relational") database provides a mechanism for storage and retrieval of data that is modeled in means other than the tabular relations used in relational databases. 

##Explain the classical non-relational data models.
* Use document-based model. 
* Schema-free document storage
* Highly optimized for append / retrieve
* Great performance and scalability

##Give few examples of NoSQL databases and their pros and cons.
* Redis - Ultra-fast in-memory data structures server
* MongoDB - Mature and powerful JSON-document database
* CouchDB - JSON-based document database with REST API
* Cassandra - Distributed wide-column database