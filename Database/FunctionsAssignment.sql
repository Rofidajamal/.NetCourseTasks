/*
Part 01 using ITI Database
*/

-- 1 Select max two salaries in the instructor table. 
 select top(2) Salary 
 from instructor
  order by salary desc

--2 Write a query to select the highest two salaries in Each Department for instructors
--who have salaries. using one of Ranking Functions”

Select *
from (select dp.Dept_Name,I.Salary,ROW_NUMBER() over (Partition by dp.Dept_Name order by I.Salary desc) AS RN
from Instructor I inner join Department  dp
ON dp.Dept_Id = I.Dept_Id
where I.Salary is not Null 
) as QS
where RN <=2

-- 3 Write a query to select a random  student from each department.  
--“using one of Ranking Functions”
select * 
from (Select S.St_Fname, D.Dept_Name, ROW_NUMBER() over (PARTITION BY D.Dept_Name Order by NEWID() desc) as RN 
FROM Student S inner join Department D
ON D.Dept_Id = S.Dept_Id) as NewTable
where RN = 1



-------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------


/* Part 02*/

-- 1 Display the SalesOrderID, ShipDate of the SalesOrderHearder table (Sales schema) 
-----to designate SalesOrders that occurred within the period ‘7/28/2002’ and ‘7/29/2014’
use AdventureWorks2012

select SalesOrderID, ShipDate
from Sales.SalesOrderHeader
where ShipDate  Between  '7/28/2002' and '7/29/2014'


--2 Display only Products(Production schema) with a StandardCost below $110.00 (show ProductID, Name only)
select ProductID, Name
from Production.Product
where StandardCost < 110.00


--3 Display ProductID, Name if its weight is unknown
select ProductID, Name
from Production.Product
where Weight is null

--4 Display all Products with a Silver, Black, or Red Color
select Name, Color
from Production.Product
where Color in ( 'Silver', 'Black', 'Red')

--5 Display any Product with a Name starting with the letter B
select ProductID, Name
from Production.Product
where Name like 'B%'

--6 Run the following Query
--UPDATE Production.ProductDescription
--SET Description = 'Chromoly steel_High of defects'
---WHERE ProductDescriptionID = 3
---Then write a query that displays any Product description with underscore value in its description.

UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3

select Description
from Production.ProductDescription
where Description like '%-%'

-- 7 Display the Employees HireDate (note no repeated values are allowed)

select distinct  HireDate 
from HumanResources.Employee

-- 8 Display the Product Name and its ListPrice within the values of 100 and 120 
---the list should have the following format "The [product name] is only! [List price]" 
---(the list will be sorted according to its ListPrice value)


select Name +' the Product name' + ' is only ! ' +convert (varchar(50),ListPrice) as 'List'
from Production.Product
where ListPrice between 100 and 120
order by ListPrice




-------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------
-------------------------------------------------------------------------------------

/* Part 03 */

--1 Create a scalar function that takes a date and returns the Month name of that date.

create function getTheMonthName (@Date date)
	returns varchar(20)

	begin 
	declare @MonthName varchar(20)
	select @MonthName = FORMAT(@Date, 'MMMM')
	return @MonthName 
		end

select dbo.getTheMonthName('2018-07-01')

--2 Create a multi-statements table-valued function that takes 2 integers
--and returns the values between them.

create function getNumbersInBetween (@num1 int, @num2 int )
	returns @t table (values_ int)
	as 
	begin 
		set @num1 = @num1 +1
		while (@num1 != @num2)
			begin
				insert into @t 
				values(@num1)
				set @num1 = @num1+1
			end
		return
	end


select* FROM  dbo.getNumbersInBetween(10, 15)

--3 Create a table-valued function that takes Student
--  No and returns Department Name with Student full name

create function getDeptNameAndStudName (@stdID int)
	returns Table
	AS
	return (
		select D.Dept_Name,S.St_Fname + ' ' + S.St_Lname as 'FULL NAME'
		from Student S inner join Department D
		ON D.dept_Id = S.dept_Id 
		where S.ST_Id = @stdID

	)


select * from dbo.getDeptNameAndStudName(3)


-- 4 Create a scalar function that takes Student ID and returns a message to user 
-- a If first name and Last name are null then display 'First name & last name are null'
-- b If First name is null then display 'first name is null'
-- c If Last name is null then display 'last name is null'
-- d Else display 'First name & last name are not null'

create function getaMessage (@stdID int)
returns varchar (50)
	begin 
	declare @Fname varchar(50)
	declare @LName varchar(50)
	declare @Massage varchar(50)

	select @Fname = St_Fname, @LName =St_Lname 
	From Student 
	where St_Id = @stdID

	if @Fname is null and @LName is null
		set @Massage= 'First name & last name are null'
	else if @Fname is null and @LName is not null
		set @Massage= 'First name is null'
	else if @LName is null and @Fname is not null
		set @Massage = 'Last name is null'
	else 
		set @Massage =  'First name & last name are not null'

	return @Massage
	end

select dbo.getaMessage(3)


--5 Create a function that takes an integer which represents the format of the Manager
----hiring date and displays department name, Manager Name and hiring date with this format. 

create function getManagerData (@hiringDate int)
returns @resultTable table(
						DeptName varchar(50),
						ManagerName varchar (50),
						HiringDate varchar(50)
						)
	as 
	begin
		insert into @resultTable(DeptName, ManagerName, HiringDate)
		select D.Dept_Name, I.Ins_Name,CASE @hiringDate
				WHEN 101 THEN CONVERT(varchar(50), D.Manager_hiredate, 101)  -- MM/DD/YYYY
				WHEN 103 THEN CONVERT(varchar(50), D.Manager_hiredate, 103)  -- DD/MM/YYYY
				WHEN 105 THEN CONVERT(varchar(50), D.Manager_hiredate, 105)  -- DD-MM-YYYY
				WHEN 106 THEN CONVERT(varchar(50), D.Manager_hiredate, 106)  -- DD Mon YYYY
				WHEN 110 THEN CONVERT(varchar(50), D.Manager_hiredate, 110)  -- MM-DD-YYYY
				ELSE CONVERT(varchar(50), D.Manager_hiredate, 120)         -- Default: YYYY-MM-DD
			END AS Formatted_Hiring_Date
		from Department D inner join Instructor I 
		ON I.Ins_Id = D.Dept_Manager
		Return 
	END

select * from dbo.getManagerData(120)


-- 6 Create multi-statement table-valued function that takes a string
--If string='first name' returns student first name
--If string='last name' returns student last name 
--If string='full name' returns Full Name from student table  (Note: Use “ISNULL” function)

create function makeaTask (@message varchar(50))
returns @Result table (Name_ varchar(50))
	as 
	begin 

	if @message = 'first name'
		begin 
			insert into @Result (Name_)
			select  isNULL (St_Fname, 'Not Exist')
			from Student 
		end
	else if @message = 'last name'
		begin 
			insert into @Result (Name_)
			select  isNULL (St_Lname, 'Not Exist')
			from Student 
		end
	else if @message = 'full name'
		begin 
			insert into @Result (Name_)
			select  isNULL (St_Fname, '--') + ' ' +isNULL (St_Lname, '--') 
			from Student 
		end
	return 
	end 
	
select * from dbo.makeaTask('first name')
select * from dbo.makeaTask('last name')
select * from dbo.makeaTask('full name')

-- 7 Create function that takes project number and
--display all employees in this project (Use MyCompany DB)

use MyCompany
create function getEmplyeesInProject(@P_number int)
returns @Emplyees table (
						Emp_name varchar(50),
						Gender varchar(50),
						Salary money)
	as 
	begin 
	insert into @Emplyees (Emp_name, Gender,Salary)
	select E.Fname + ' ' + E.Lname, E.Sex, E.Salary
	from Employee E inner join Works_for WF
	ON E.SSN = WF.ESSn inner join Project P
					  ON P.Pnumber = WF.Pno
	where P.Pnumber = @P_number

	return 
	end

select * from dbo.getEmplyeesInProject(300)






		







		

	

	











