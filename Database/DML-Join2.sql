

---Part 2 MyCompany
--1 Display all the employees Data.
select * 
from Employee



--2 Display the employee First name, last name, Salary and Department number.
select FName, LName, Salary, Dno 
from Employee 


--3 Display all the projects names, locations and the department which is responsible for it.
select Pnum as 'Project_Name', Plocation, Dnum
from Project

--4 If you know that the company policy is to pay an annual commission for each employee with 
--specific percent equals 10% of his/her annual salary .Display each employee full name and his annual commission in an ANNUAL COMM column (alias).

select Fname + ' ' +Lname as 'Full Name' , Salary *0.1 as 'ANNUAL COMM'
From Employee

--5 Display the employees Id, name who earns more than 1000 LE monthly.
select SSN as 'Emp ID' , Fname + ' ' +Lname as 'Full Name', Salary
From Employee
where Salary > 1000

--6 Display the employees Id, name who earns more than 10000 LE annually.
select SSN as 'Emp ID' , Fname + ' ' +Lname as 'Full Name', Salary
From Employee
where (Salary*12) > 1000




--7 Display the names and salaries of the female employees 
Select Fname + ' ' + Lname as 'Female full name ', Salary
from Employee
where Sex = 'F'


--8 Display each department id, name which is managed by a manager with id equals 968574.
Select Dnum as 'Department ID' ,Dname as 'Department Name' 
from Departments
where MGRSSN = 968574

--9 Display the ids, names and locations of  the projects which are controlled with department 10.
select Pnumber, pnum, Plocation
from Project 
where Dnum = 10

---------------------------------------------------------------------------------------------
/* Part 04 */
---------------------------------------------------------------------------------------------

-- 1 Display the Department id, name and id and the name of its manager. 
Select D.Dnum as 'DEP_ID', D.Dname as 'DEPT_NAME', D.MGRSSN as 'MANG_ID', E.FName as 'MANAGER_NAME'
from Departments D inner join Employee E
On E.SSN = D.MGRSSN

--2 Display the name of the departments and the name of the projects under its control.
select D.Dname as 'DEPT_NAME', P.Pnum as 'Project_Name' 
from Departments D inner join Project P
On D.Dnum = P.Dnum

--3 Display the full data about all the dependence associated
----with the name of the employee they depend on.

select D.Dependent_name,D.Bdate ,E.FName + ' '+ E.LName as 'Employee name'
from Dependent as D inner join Employee E
On E.SSN = D.ESSN

--4 Display the Id, name and location of the projects in Cairo or Alex city.
Select Pnumber, Pnum as 'Project name', Plocation
From Project
where Plocation in ('Cairo', 'Alex')

--5 Display the Projects full data of the projects with a name starting with "a" letter.
Select Pnumber, Pnum as 'Project name', Dnum as 'Cotrolled Department' ,Plocation
From Project
where Pnum like 'a%'

--6 display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
select SSN, FName + ' ' + LName as 'FULL NAME', Salary
from Employee
where Dno= 30 and Salary between 1000 and 2000

--7 Retrieve the names of all employees in department 10 
----who work more than or equal 10 hours per week on the "AL Rabwah" project.

Select E.FName + E.LName as 'Emplyee Name', E.Dno,WF.Hours, P.Pnum as 'Project_Name'
from Employee E inner join Works_for WF
On E.SSN = WF.ESSn inner join Project P 
On P.Pnumber = WF.Pno 
where E.Dno = 10
and P.Pnum = 'AL Rabwah' 
and WF.ESSn >= 10

--8 Retrieve the names of all employees and the names of the projects
---they are working on, sorted by the project name.
Select E.FName + E.LName as 'Emplyee Name', P.Pnum as 'Project_Name'
from  Employee E inner join Works_for WF
ON E.SSN = WF.ESSn inner join Project P
ON P.Pnumber = WF.Pno
order by P.Pnum

--9  For each project located in Cairo City , find the project number, 
-----the controlling department name ,
-----the department manager last name ,address and birthdate.

select P.Pnumber, D.Dname, E.LName, E.Address, E.Bdate
From Project P inner join Departments D
ON D.Dnum = P.Dnum inner join Employee E 
ON E.SSN = D.MGRSSN
where P.Plocation = 'Cairo'











