/* AND */
select * from Products where Discontinued = 0 and CategoryID = 1

/* OR */
select * from Customers  where City = 'London' or City = 'Berlin'

/* <> */
select * from Products where UnitsInStock <> 10

/* != */
select * from Products where UnitsInStock != 0 

/* > */
select * from Products where UnitsInStock < 1 

/* < = */
select * from Products where UnitPrice >= 5
