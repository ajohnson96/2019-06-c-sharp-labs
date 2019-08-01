
/* Drop all tables + database */
drop database CollegeDB
drop table Students
drop table Courses

/* Create database */
create database CollegeDB

/* Create table of courses */
create table Courses
(
	courseID int IDENTITY PRIMARY KEY,
	CourseName nvarchar(50) NOT NULL
)

create table Students
(
	StudentID int NOT NULL IDENTITY PRIMARY KEY,
	StudentName nvarchar(50) NOT NULL,
	CourseID int FOREIGN KEY REFERENCES Courses
)

SET IDENTITY_INSERT Courses ON
INSERT INTO Courses (courseID, CourseName) VALUES (10,'Bricklaying')
INSERT INTO Courses (courseID, CourseName) VALUES (20,'Microbiology')
INSERT INTO Courses (CourseID, CourseName) VALUES (30,'Astrophysics')
SET IDENTITY_INSERT Courses OFF

SET IDENTITY_INSERT Students ON
INSERT INTO Students (StudentID, StudentName, CourseID) VALUES (1,'Keith', 10)
INSERT INTO Students (StudentID, StudentName, CourseID) VALUES (2,'Maria', 30)
INSERT INTO Students (StudentID, StudentName, CourseID) VALUES (3,'George', 20)
SET IDENTITY_INSERT Students OFF

select* from Students inner JOIN Courses ON students.CourseID = Courses.courseIDe
