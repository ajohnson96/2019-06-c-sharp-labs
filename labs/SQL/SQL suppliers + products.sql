/* all products with every supplier for every product LEFT JOIN */
select * from Products
left join suppliers on products.SupplierID = Suppliers.SupplierID
order by ProductID

select * from Products
right join suppliers on products.SupplierID = Suppliers.SupplierID
order by ProductID

select ProductID, ProductName, companyname as 'supplier', Categories.CategoryID, Categories.CategoryName
from Products
inner join suppliers on products.SupplierID = Suppliers.SupplierID
inner join Categories on Products.CategoryID = Categories.CategoryID