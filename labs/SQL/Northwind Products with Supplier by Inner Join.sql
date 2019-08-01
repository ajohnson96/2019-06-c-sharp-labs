/* products grouped by supplier id */
select p.SupplierID, companyName, AVG(UnitsOnOrder) as 'AverageOrder'
from Products p
Inner Join Suppliers s on p.SupplierID = s.SupplierID
Group by p.SupplierID, CompanyName
having AVG(UnitsOnOrder) > 0
order by AVG(UnitsOnOrder) desc

