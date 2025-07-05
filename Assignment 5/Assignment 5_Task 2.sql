--Assignment 5_Task 2
----------------------------------------------------
--Create a table named "Employees" with columns for ID (integer), Name (varchar), and Salary (decimal).
create table new_Employees
(
	ID int,
	Name varchar(20),
	Salary decimal
)
go
----------------------------------------------------
--Add a new column named "Department" to the "Employees" table with data type varchar(50).
alter table new_Employees
add Department varchar(50)
go
----------------------------------------------------
--Remove the "Salary" column from the "Employees" table.
alter table new_Employees
drop column Salary
go
----------------------------------------------------
--Rename the "Department" column in the "Employees" table to "DeptName".
execute sp_rename 'new_Employees.Department','DeptName','column'
go
----------------------------------------------------
--Create a new table called "Projects" with columns for ProjectID (integer) and ProjectName (varchar).
create table Projects
(
	ProjectID int,
	ProjectName varchar(20),
)
go
----------------------------------------------------
--Add a primary key constraint to the "Employees" table for the "ID" column.
alter table new_Employees
drop ID
alter table new_Employees
add ID int primary key
go
----------------------------------------------------
--Add a unique constraint to the "Name" column in the "Employees" table.
alter table new_Employees
drop Name
go
alter table new_Employees
add Name varchar(20) unique
go
----------------------------------------------------
--Create a table named "Customers" with columns for CustomerID (integer), FirstName (varchar), LastName (varchar), and Email (varchar), and Status (varchar).
create table Customers
(
	CustomerID int primary key ,
	FirstNamee varchar(20),
	LastName varchar(20),
	Email varchar(50),
	Status varchar(20),
)
go
----------------------------------------------------
--Add a unique constraint to the combination of "FirstName" and "LastName" columns in the "Customers" table.
ALTER TABLE Customers
ADD CONSTRAINT Customer_FullName UNIQUE (FirstName, LastName);
go
----------------------------------------------------
--Create a table named "Orders" with columns for OrderID (integer), CustomerID (integer), OrderDate (datetime), and TotalAmount (decimal).
create table Orders
(
	OrderID int,
	CustomerID int references Customers(CustomerID),
	OrderDate datetime,
	TotalAmount decimal
)
go
----------------------------------------------------
--Add a check constraint to the "TotalAmount" column in the "Orders" table to ensure that it is greater than zero.
ALTER TABLE Orders
ADD CONSTRAINT TotalAmount_Positive CHECK (TotalAmount > 0);
go
----------------------------------------------------
--Create a schema named "Sales" and move the "Orders" table into this schema.
create schema Sales
go
ALTER SCHEMA Sales TRANSFER dbo.Orders;
go
----------------------------------------------------
--Rename the "Orders" table to "SalesOrders."
execute sp_rename 'Sales.Orders', 'SalesOrders'
go
----------------------------------------------------