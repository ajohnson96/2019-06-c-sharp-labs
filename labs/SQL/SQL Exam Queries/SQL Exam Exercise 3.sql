/* 3.1 */
Select EmployeeID, TitleOfCourtesy, FirstName, LastName, ReportsTo from Employees

/* 3.2 */ --TODO

select OrderID,
SUM(UnitPrice * Quantity) as TotalPrice
FROM [Order Details]
LEFT JOIN Suppliers s ON s.SupplierID = [Order Details].OrderID
GROUP BY OrderID
HAVING SUM(UnitPrice * Quantity) >= 10000
ORDER BY TotalPrice desc

/* 3.3 */

/*
select * from Orders

select Categories.CategoryName, Count(*) as 'Highest' from Products p
inner join Categories ON Categories.CategoryID = p.CategoryID
Group BY CategoryName
Order BY 'Highest' Desc
*/

/* 3.4 */