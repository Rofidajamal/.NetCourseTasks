/*Part 1
From The Previous Assignment insert at least 2 rows per table. */

INSERT INTO Course 
values(1,'Software Engineering', 120, null)

INSERT INTO Course 
values(2, 'Machine learning', 120, null)

Insert into Department 
values (1, 'CS', 'Department for Computer science', 'Giza',null ,'2022-12-12'),
(2, 'SE', 'Department for software engineer', 'Cairo', null,'2022-9-12')

insert into Instructor
values (50, 'Mohamed', 'Master', 10000, null),
(51, 'Ahmed', 'Master', 20000, null)


insert into Student 
values (100, 'Rofida', 'Gamal', 'Alsheikh zayed', 22, 1, null),
(101, 'Omnia', 'Fawzy', 'EL Maadi', 22, 2 , 100)

insert into Topic
values ( 101,'Database'),
(201,'Bioinformatics')


insert into Ins_Course
values (50, 1, 'Very Good'),
(51, 2, 'Excellent')


insert into Stud_Course 
values (1, 100, 95),
(2, 101, 85)


Update Course 
set Top_Id = 101
where Crs_ID = 1

Update Course 
set Top_Id = 201
where Crs_ID = 2

update Department 
set Dept_Manager = 50
where Dept_Id = 1

update Department 
set Dept_Manager = 51
where Dept_Id = 2


update Instructor 
set Dept_Id = 1
where Ins_Id= 50


update Instructor 
set Dept_Id =2
where Ins_Id= 51

-------------------------------------------------------------

/*Data Manipulation Language:*/

-- 1.Insert your personal data to the student table as a new Student in department number 30.
insert into Student 
values(103, 'Ahmed', 'mohammed', 'Alex', 22, 30, null)

-- Insert Instructor with personal data of your friend as new Instructor in department number 30, Salary= 4000, but don’t enter any value for bonus.

insert into Instructor
values(16, 'Hanaa', 'Master', 4000, 30)


--3.Upgrade Instructor salary by 20 % of its last value.
update Instructor
set Salary = Salary + (Salary *0.2)
where	Ins_Id = 16

-----------------------------------------------------------------------------------------------------

/*
part 3
Restore ITI Database and then:
*/

--Get all instructors Names without repetition

select distinct Ins_Name
from Instructor

---Display instructor Name and Department Name 
--- Note: display all the instructors if they are attached to a department or not

select I.Ins_Name, D.Dept_Name
FROM Instructor I full join Department D
on D.Dept_Id = I.Dept_Id


-- Display student full name and the name of the course he is taking
---For only courses which have a grade
Select S.St_Fname, S.St_Lname, C.Crs_Name
from Student S inner join Stud_Course SC
On S.St_Id = SC.St_Id inner join Course C 
On C.Crs_Id = SC.Crs_Id and SC.Grade is not null




/*
Bouns
Display results of the following two statements and explain what is the meaning of @@AnyExpression
select @@VERSION
select @@SERVERNAME
*/

select @@VERSION -- Version of my Microsoft SQL server that I worked on 
select @@SERVERNAME -- Server name which is the name of my computer 







--- 












