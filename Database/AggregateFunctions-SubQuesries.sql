
/* Part 01 using ITI*/ 
--- 1- Retrieve a number of students who have a value in their age. 
select St_age
from Student 
where St_age is not null

-- 2 Display number of courses for each topic name 
Select count(C.Crs_Id), T.Top_Name
from Course C inner join Topic T
On T.Top_Id = C.Top_Id
group by (T.Top_Name)

-- 3 Select Student first name and the data of his supervisor 
Select S.St_Fname , I.Ins_Name, I.Ins_Degree, I.Ins_Id, I.Salary, I.Dept_Id
from Student S inner join Instructor I
ON I.Ins_Id = S.St_super

-- 4 Display student with the following Format (use isNull function)
select  isNull (S.St_Id, 'Not Exist') as 'Student ID', isNull(S.St_Fname, 'NOT EXIST' )+ ' ' + isNull(S.St_Lname, 'NOT EXIST') as 'Student Full Name', isNULL(D.Dept_Name, 'NOT EXIST' )as 'Department Name'
from Student S inner join Department D
ON D.Dept_Id = S.Dept_Id


--5 Select instructor name and his salary but if there is no salary display value ‘0000’ .
----“use one of Null Function”
select Ins_Name, isNull(Salary, '0000') as Salary 
From Instructor

--6 Select Supervisor first name and the count of students who supervises on them
Select I.Ins_Name , count (S.St_Id) as 'count of students who supervised'
from Instructor I inner join Student S
ON I.Ins_Id = S.St_super 
group by (I.Ins_Name)

--7 Display max and min salary for instructors
select max (Salary) as 'Max Salary' , min(Salary) as 'Min Salary'
from Instructor

--8 Select Average Salary for instructors 
select avg(Salary) as 'Average Salary'
from Instructor

--9 Display instructors who have salaries less than the average salary of all instructors.
Select Ins_Name, Salary
from Instructor
where Salary < (Select AVG(Salary) from Instructor) 

-- 10 Display the Department name that contains the instructor who receives the minimum salary
Select D.Dept_Name, I.Ins_Name
from Department D inner join Instructor I 
ON D.Dept_Id = I.Dept_Id
where I.Salary = (select Min(Salary) from Instructor)    

---------------------------------------------------------------------------
---------------------------------------------------------------------------

/* Part 02 using MyCompany 
-  DQL:-
*/

-- 1 For each project, list the project name and the total hours per week
---(for all employees) spent on that project.

Select P.Pname, SUM(WF.Hours) as 'Total Hours'
from Project P inner join Works_for WF
ON P.Pnumber = WF.Pno
group by (P.Pname)

-- 2 For each department, retrieve the department name and the maximum,
---minimum and average salary of its employees.
select D.Dname, Max(E.Salary) as 'Max Salary', Min(E.Salary) as 'MIn Salary', AVG(Salary) as 'Average salary'
from Departments D inner  join Employee E
ON D.Dnum = E.Dno
group by(D.Dname)

--3 Retrieve a list of employees and the projects they are working on 
--ordered by department and within each department,
--ordered alphabetically by last name, first name.

select E.Fname + ' '+E.Lname as 'Employee name' ,E.SSN, P.Pname, P.Pnumber, D.Dname 
from Employee E inner join Works_for WF
ON E.SSN = WF.ESSn inner join Project P 
ON P.Pnumber = WF.Pno inner join Departments D
ON D.Dnum = P.Dnum
order by D.Dname, E.Fname, E.Lname




--4 Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30% 
update E
set E.Salary = E.Salary + (E.Salary*0.3)
From Employee E inner join Works_for WF
ON E.SSN = WF.ESSn inner join Project P
ON P.Pnumber = WF.Pno
where P.Pname = 'Al Rabwah'

---------------------------------------------------------------------------
---------------------------------------------------------------------------
--DML:--

--1 In the department table insert a new department called "DEPT IT" ,
--with id 100, employee with SSN = 112233 as a manager for this department. 
--The start date for this manager is '1-11-2006'.

insert into Departments
values ('DEPT IT', 100, 112233,'1-11-2006')


-- Do what is required if you know that : Mrs.Noha Mohamed(SSN=968574)  
--moved to be the manager of the new department (id = 100),
--and they give you(your SSN =968618) her position (Dept. 20 manager) 

--a First try to update her record in the department table

update D  
set D.MGRSSN = 968574
from Departments D inner join Employee E
ON D.MGRSSN = E.SSN
where D.Dnum = 100

-- b Update your record to be department 20 manager.
insert into Employee
values('Rofida','Gamal', '2001-11-19', 'Giza', 'F', 10000, null, 10)

update D  
set D.MGRSSN = 968618
from Departments D inner join Employee E
ON D.MGRSSN = E.SSN
where D.Dnum = 20

-- c Update the data of employee number=968597 to be in your teamwork
---(he will be supervised by you) (your SSN =968618)

update super
set super.Superssn = 968618
from Employee super inner join Employee E
ON E.SSN = 968597 
where super.SSN = 968597

-- Unfortunately the company ended the contract with  Mr.Kamel Mohamed (SSN=223344)
---so try to delete him from your database in case you know that 
--you will be temporarily in his position.
--Hint: (Check if Mr. Kamel has dependents, works as a department manager, 
--supervises any employees or works in any projects and handles these cases).
 
 --to handle dependents
Delete 
from Dependent
where ESSN = 223344

-- to handle Department manager

update D  
set D.MGRSSN = 968618
from Departments D inner join Employee E
ON  E.SSN = D.MGRSSN
where D.MGRSSN = 223344
-- to handle the supervision of other employees 

update super
set super.Superssn = 968618
from Employee super inner join Employee E
ON E.SSN = super.SSN 
where super.Superssn = 223344

-- to handle works for 
update WF
set WF.ESSN = 968618
from Employee E inner join Works_for WF
ON E.SSN = WF.ESSN 
where WF.ESSN = 223344

--To delete Kamel
delete 
from Employee
where SSN= 223344


------------------------------------------------------------------------------------
------------------------------------------------------------------------------------

/* Part 03*/

-- 1 Retrieve the names of all employees in department 10 
-----who work more than or equal 10 hours per week on the "AL Rabwah" project.

select E.Fname + ' ' +E.Lname as 'Employee name', D.Dnum, WF.Hours, P.Pname
from Departments D inner join Employee E
ON D.Dnum = E.Dno inner join Works_for WF
ON E.SSN = WF.ESSn inner join Project P
ON P.Pnumber = WF.Pno
where D.Dnum = 10 
and WF.Hours >= 10
and P.Pname = 'AL Rabwah'


-- 2 Retrieve the names of all employees and the names of the projects they are working on,
-----sorted by the project name
select E.Fname + ' '+ E.Lname AS 'Employee Name', P.Pname
from Employee E inner join Works_for WF
ON E.SSN = WF.ESSn inner join Project P
ON P.Pnumber = WF.Pno
order by  P.Pname

-- 3 For each project located in Cairo City , find the project number,
-----the controlling department name ,the department manager last name ,address and birthdate.
select P.Plocation,	P.Pnumber, D.Dname, E.Lname, E.Address, E.Bdate
from Project P inner join Departments D 
ON D.Dnum = P.Dnum inner join Employee E
ON E.SSN = D.MGRSSN
where P.Plocation = 'Cairo'

--4 Display the data of the department which has the smallest employee ID over all employees' ID.
SELECT D.Dname, D.Dnum, D.MGRSSN, D.[MGRStart Date]
from Departments D inner join Employee E
ON D.Dnum = E.Dno
where E.SSN = (Select MIN(SSN) from Employee)

--5 List the last name of all managers who have no dependents

select DISTINCT  Lname 
from Employee 
where SSN in ( select MGRSSN from Departments)
and SSN not in (Select essn from Dependent)

--6 For each department-- if its average salary is less than the average
----salary of all employees display its number, name and number of its employees.

select COUNT(E.SSN) as 'Number of Employees', D.Dname, D.Dnum
from Departments D inner join Employee E
ON D.Dnum = E.Dno
group by D.Dname, D.Dnum
having Avg(E.Salary) < (select Avg(Salary) from Employee)


-- 7 Try to get the max 2 salaries using subquery

select(
select Max(Salary) 
from Employee) as 'MAX SALARY',
( 
Select Max(Salary) as 'Second max' 
From Employee
where Salary != (Select Max(Salary) from Employee)
) 





























 

				  









