/* 1.1 */
SELECT CustomerID, CompanyName, Address, PostalCode 
FROM Customers
WHERE City = 'Paris' OR City = 'London'

/* 1.2 */
SELECT ProductID, ProductName, QuantityPerUnit 
FROM Products
WHERE QuantityPerUnit LIKE '%bot%';
 
/* 1.3 */
SELECT s.CompanyName, s.Country,ProductID, ProductName, QuantityPerUnit 
FROM Products
JOIN Suppliers s ON s.SupplierID = Products.SupplierID
WHERE QuantityPerUnit LIKE '%bot%';

/* 1.4 */
SELECT c.CategoryName, COUNT(ProductName) as 'Highest Product'
FROM Products
JOIN Categories c ON c.CategoryID = Products.CategoryID
GROUP BY c.CategoryName
ORDER BY 'Highest Product' desc

/* 1.5 */
SELECT (TitleOfCourtesy + ' ' +  FirstName + ' ' + LastName) AS Name, City
FROM Employees 

/* 1.6 */


/* 1.7 */
SELECT Count(*) as 'Orders over 100 freight' 
FROM Orders o
WHERE o.Freight > 100 AND (ShipCountry = 'UK' or ShipCountry = 'USA')

/* 1.8 */
SELECT TOP 1 OrderID, (UnitPrice * Quantity * Discount) AS HighestDiscount
FROM [Order Details]
ORDER BY HighestDiscount desc

/* 2.1 */
