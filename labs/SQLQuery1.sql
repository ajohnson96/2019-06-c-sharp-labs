use master

drop database test01
go
create database test01
go

create database [myDatabase]
/* use this database */
use test01
create table table_01(
	name VARCHAR(10),
	description VARCHAR(30)
)

ALTER TABLE table_01 ALTER COLUMN description VARCHAR(50) NOT NULL;
ALTER TABLE table_01 ADD age INT;
ALTER TABLE table_01 ADD dateofbirth DATETIME;
select * from table_01
