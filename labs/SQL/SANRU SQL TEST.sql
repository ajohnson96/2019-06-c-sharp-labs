--exercise 1

--1.1
	select CustomerID, CompanyName, CONCAT(Address,',' ,PostalCode,',' ,Country) 
 	AS 'Address field' from Customers 
	where City ='London' OR City='Paris'

--1.2
	select * from Products
        where QuantityPerUnit like '%bot%' 

--1.3
	select Products.ProductName, Suppliers.SupplierID, Suppliers.Country from Products
	inner join Suppliers on Products.SupplierID = Suppliers.SupplierID 
	where QuantityPerUnit like '%bot%' 

--1.4
	select Categories.CategoryName, Count(*) As highest  from Products
	join Categories on Categories.CategoryID = Products.CategoryID
	group by Categories.CategoryName
	order by highest desc

--1.5
	select TitleOfCourtesy+','+ FirstName+' '+LastName As Fullname, City from Employees


--1.6
	select Format(SUM (od.UnitPrice * od.Quantity * (1-od.Discount)), '#,###,###')as Saletotal, t.RegionID
	from [Order Details] od
	inner join Orders o on o.OrderID= od.OrderID
	inner join Employees e on e.EmployeeID = o.EmployeeID
	inner join EmployeeTerritories et on et.EmployeeID = e.EmployeeID
	inner join Territories t on t.TerritoryID = et.TerritoryID
	Group by t.RegionID
	having sum (od.UnitPrice * od.Quantity * (1-od.Discount)) > 1000000

--1.7

	select * from orders o
	where o.Freight > 100 AND 
	(o.ShipCountry ='UK' or o.ShipCountry='USA')

--1.8

	select Top 1 (od.Discount* od.Quantity *od.UnitPrice) as total 
	from [Order Details] od
        order by total desc
--2.1
	drop table SpartansTable
	create table SpartansTable(
	ID Int PRIMARY KEY, 
	Firstname VARCHAR(20),
	Surname VARCHAR(20),
	University VARCHAR(20),
	Course Varchar(50),
	Grade Varchar(10)
	)
	INSERT INTO SpartansTable (ID, Firstname, Surname, University, Course, Grade) VALUES (1,'liam','russell','Oxford','GameDesgin','1st')
	INSERT INTO SpartansTable (ID, Firstname, Surname, University, Course, Grade) VALUES (2,'sanru','mathy','Cardiff','Software','1st')
	INSERT INTO SpartansTable (ID, Firstname, Surname, University, Course, Grade) VALUES (3,'alex','bob','Brunel','Computing','2:1')
	INSERT INTO SpartansTable (ID, Firstname, Surname, University, Course, Grade) VALUES (4,'tobby','yoda','Japan','Computing','1st')
	INSERT INTO SpartansTable (ID, Firstname, Surname, University, Course, Grade) VALUES (5,'kieron','tyson','Southampton','GameDesgin','2:1')
	INSERT INTO SpartansTable (ID, Firstname, Surname, University, Course, Grade) VALUES (6,'sam','sam','Herths','GameDesgin','1st')

	select * from SpartansTable

	
--3.1

	Select TitleOfCourtesy + FirstName+ LastName, ReportsTo from Employees


--3.2
	select Suppliers.CompanyName, SUM( [Order Details].UnitPrice* [Order Details].Quantity * (1-Discount))
	from [Order Details]
	join Products on Products.ProductID = [Order Details].ProductID
	join Suppliers on Products.SupplierID = Suppliers.SupplierID
	Group by CompanyName
	Having SUM( [Order Details].UnitPrice* [Order Details].Quantity * (1-Discount)) > 10000

--3.3

	select top 10 customers.ContactName, Count(*)ShippedDate 
	from Orders
	inner join Customers on Customers.CustomerID = Orders.CustomerID
	where YEAR(OrderDate) = 1998
	group by Customers.ContactName 
	order by count(*) desc

--3.4
	Select Convert(nvarchar(20), YEAR(o.OrderDate))+'_=' +
	Convert(nvarchar(20), MONTH(o.OrderDate)) As Month,
	AVG(CAST(DAY(o.ShippedDate-OrderDate) AS decimal)) Average from Orders o
	Group By year(o.OrderDate), Month(o.OrderDate)
	Order by YEAR(o.OrderDate), Month(o.OrderDate)