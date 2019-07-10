select * from products where ProductName like '%ch%'
select * from products where ProductName like '[ABC]%'
select * from products where ProductName like '[^ABC]%'

select * from products where ProductName like 'ch__'

select* from Employees

/* IN */
select * from Employees where City in ('London' , 'Seattle')

/* BETWEEN */
select * from Employees where EmployeeID between 4 AND 9

/* quoted idenitifer*/
SET QUOTED_IDENTIFIER OFF

/* find items with a single quote in the string */
select * from products where ProductName like "%'%"