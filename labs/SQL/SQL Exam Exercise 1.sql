/*
select * from Products

select ProductID, ProductName, UnitPrice * UnitsInStock as "Gross Total"
from Products
order by "Gross Total"
*/

/* Exercise 1 */
/* 1.1 */
select CustomerID, CompanyName, Address, City from Customers 
where City = 'London' 
OR City = 'Paris'

/* 1.2 */
select ProductID, ProductName, QuantityPerUnit  from Products
where QuantityPerUnit LIKE '%bottle%';

/* 1.3 */
select p.productname, s.companyname, s.Country from Products p
join Suppliers s ON s.SupplierID = p.SupplierID
where QuantityPerUnit LIKE '%bottle%';

/* 1.4 */
select Categories.CategoryName, Count(*) as 'Highest' from Products p
inner join Categories ON Categories.CategoryID = p.CategoryID
Group BY CategoryName
Order BY 'Highest' Desc

/* 1.5 */
select (TitleOfCourtesy + ' ' + FirstName + ' ' + LastName) as 'Name', City from Employees

/* 1.6 */

/* 1.7 */
select Count(*) as 'Orders over 100 freight' from Orders o
where o.Freight > 100 AND (ShipCountry = 'UK' or ShipCountry = 'USA')

/* 1.8 */
Select Top 1 orderid,(UnitPrice * Quantity * Discount) as HighestDiscount 
from [Order Details] 
order by HighestDiscount desc 