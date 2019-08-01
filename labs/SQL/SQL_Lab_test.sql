/*
select * from products
/* can we list products from supplierID? */
select * from products order by SupplierID
/* statistics (sum,avg) per supplier? */
select supplierid from products order  by SupplierID
/* total units in stock per supplier */

select supplierid, 
	sum(unitsinstock) as 'Stock',
	sum(unitsonorder) as 'OnOrder',
	max(unitsonorder) as 'Max Order'
	from Products
group by supplierid order by 'Stock' desc
*/

/* use GROUP BY to calcilate the average reorder level for all products by categoryID */
/* remember the SELECT clause must match the GROUP BY clause apart from any aggregates */
/* what is the highest Average Reorder Level? Use ORDER BY with DESC to confirm */
/* Note: You CAN use Column ALias in the ORDER BY clause (Due to processing sequence) */
select CategoryID, 
	avg(ReorderLevel) as 'Reorder Level'
	from Products
	where CategoryID >1
	group by CategoryID 
	having avg(ReorderLevel) > 10
	order by 'Reorder Level' desc

select ProductID, 
	sum(unitsinstock) as 'Stock'
	from Products
group by ProductID order by 'Stock' desc

