/* 3.1 */
Select EmployeeID, TitleOfCourtesy, FirstName, LastName, ReportsTo from Employees

/* 3.2 */ --TODO
select s.CompanyName, SUM([Order Details].Quantity * [Order Details].UnitPrice * (1-Discount))
from [Order Details]
JOIN Products ON Products.ProductID = [Order Details].ProductID
JOIN Suppliers s ON Products.SupplierID = s.SupplierID
GROUP BY CompanyName
HAVING SUM([Order Details].Quantity * [Order Details].UnitPrice * (1-Discount)) >= 10000
ORDER BY SUM([Order Details].Quantity * [Order Details].UnitPrice * (1-Discount)) desc

/* 3.3 */

/*
select * from Orders

select Categories.CategoryName, Count(*) as 'Highest' from Products p
inner join Categories ON Categories.CategoryID = p.CategoryID
Group BY CategoryName
Order BY 'Highest' Desc
*/

/* 3.4 */