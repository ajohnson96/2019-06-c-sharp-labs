/* What are the names and product ID's of the products with a unit price below 5.00? */
select * from Products where UnitPrice < 5 

/* Which categories have a category name with initials beginning with B or S?*/
select CategoryName from Categories where CategoryName like '[b,s]%'

/* How many orders are there for EmployeeIDs 5 and 7?*/
select * from Orders where EmployeeID in (5 , 7)

/* as */
select CustomerID as ID, Address + ',' + City + ',' + Country as location from Customers

select DISTINCT Country from Customers where Region IS NOT NULL 
select COUNT(DISTINCT Country) from Customers where Region IS NOT NULL 