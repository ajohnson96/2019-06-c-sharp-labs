drop database test_02
drop table table_02

create database test_02
create table table_02
(
	id int NOT NULL IDENTITY,
	name nvarchar(50) NOT NULL,
	isHappy BIT,
	date_of_birth DATETIME NULL,
)

INSERT INTO table_02 (name, date_of_birth) VALUES ('SIM','2019-01-01 10:20:01.13')
INSERT INTO table_02 (name, date_of_birth) VALUES ('TIM','2019-01-01 10:20:01.13')
INSERT INTO table_02 (name, date_of_birth) VALUES ('JIM','2019-01-01 10:20:01.13')
INSERT INTO table_02 (name, date_of_birth, isHappy) VALUES ('KIM','2019-01-01 10:20:01.13' , 'true')


select * from table_02

/* "where" is very important as it stops every entry being changed */
UPDATE table_02 set isHappy ='false' where id = 3

select * from table_02