/* Product. Price. Quantity. %Disccount*/
select *, unitprice * quantity as 'Gross Order' from [Order Details]

/* include discount */
select *, unitprice * quantity as 'Gross Order',
UnitPrice * Quantity * (1-Discount) as 'Net Order'
from [Order Details]
order by 'Net Order' desc

/* SUM, AVG, MIN, MAX*/
select SUM(UnitPrice) as 'Total Price' from [Order Details]
select AVG(UnitPrice) as 'Avg Price' from [Order Details]
select MIN(UnitPrice) as 'Min Price' from [Order Details]
select MAX(UnitPrice) as 'Max Price' from [Order Details]
