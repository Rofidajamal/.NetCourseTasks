/* Part 01*/

use ITI

-- 1 Create a view that displays the student's full name, course name
----if the student has a grade more than 50. 

create or alter view  StudentNameGradeisGreater50View 
with encryption 
as 
	select S.St_Fname + ' '+ S.St_Lname as 'Full Name', C.Crs_Name, SC.Grade
	from Student S inner join Stud_Course SC
	ON S.St_Id = SC.St_Id inner join Course C
	ON C.Crs_Id = SC.Crs_Id
	WHERE SC.Grade > 50

select * from StudentNameGradeisGreater50View


-- 2 Create an Encrypted view that displays manager names and the topics they teach. 

create or alter view ManagerTopicsView
with encryption 
as 
	select I.Ins_Name, TP.Top_Name
	from Department D inner join Instructor I
	ON I.Ins_Id = D.Dept_Manager inner join Ins_Course IC
	ON I.Ins_Id = IC.Ins_Id inner join Course C
	ON C.Crs_Id = IC.Crs_Id inner join Topic TP
	ON TP.Top_Id = C.Top_Id

select * from ManagerTopicsView


--3	Create a view that will display Instructor Name, Department Name for the ‘SD’ or ‘Java’ Department
-----“use Schema binding” and describe what is the meaning of Schema Binding

create or alter view JavaSDInstructorsDepatmentsView 
with schemabinding 
as
	select I.Ins_Name , D.Dept_Name
	from dbo.Instructor I inner join dbo.Department D
	ON D.Dept_Id = I.Dept_Id
	where D.Dept_Name in ('Java', 'SD')

select * from JavaSDInstructorsDepatmentsView

-- using SCHEMABINDING constraints  makes you not aloowed to delete or drop the original tables as 
--it will give you an ERROR that there is a view binds with the table.

--4 Create a view “V1” that displays student data for students who live in Alex or Cairo.
-- Prevent the users to run the following query 
--Update V1 set st_address=’tanta’
--Where st_address=’alex’;


create or alter view V1 
as 
	select *
	from Student
	where St_Address in ('Cairo', 'Alex')
	with check option

select * from V1


--5 Create a view that will display the project name and the number of employees working on it. (Use Company DB)
use MyCompany

create or alter view ProjectsEmolyeeView 
with encryption 
as 
	select P.Pname , Count(E.SSN) as 'Number of Emplyees'
	from Project p inner join Works_for WF 
	ON P.Pnumber = WF.Pno inner join Employee E
	ON E.SSN = WF.ESSn 
	group by (P.Pname)

select * from ProjectsEmolyeeView

--------------------------------------------------------------------------------
-----------------------------use CompanySD32_DB:--------------------------------
--------------------------------------------------------------------------------
use SD32-Company
-- 1 Create a view named   “v_clerk” that will display employee Number ,
---project Number, the date of hiring of all the jobs of the type 'Clerk'.

create or alter view v_clerkView 
as 
	select P.ProjectNo, WO.Job, WO.Enter_Date, E.EmpNo  
	from HR.Project P inner join dbo.Works_on WO
	ON P.ProjectNo = WO.ProjectNo inner join HR.Employee E
	ON WO.EmpNo = E.EmpNo
	where WO.Job = 'Clerk'


select * from v_clerkView

-- 2  Create view named  “v_without_budget” that will display all the projects data without budget.

create or alter view v_without_budgetView 
as 
	select *
	from HR.Project
	where Budget IS NULL

select * from v_without_budgetView


--3 Create view named  “v_count “ that will display the project name and the Number of jobs in it

create or alter view v_countView 
as 
	select P.ProjectName , COUNT(WO.Job) AS 'Number of Jobs'
	from HR.Project P inner join dbo.Works_on WO
	ON P.ProjectNo = WO.ProjectNo
	group by  P.ProjectName

select * from v_countView

-- 4 Create view named ” v_project_p2” that will display the emp# s for the project# ‘p2’ .
--(use the previously created view  “v_clerk”)

create or alter view v_project_p2View 
as 
	select EmpNo
	from v_clerkView
	where ProjectNO = 'p2'

select * from v_project_p2View

--5 modify the view named  “v_without_budget”  to display all DATA in project p1 and p2.
sp_helptext 'v_without_budgetView'
alter  view v_without_budgetView   
as 
select *
from HR.Project
where Budget is NULL and ProjectNo in ('p1', 'p2')

--6 Delete the views  “v_ clerk” and “v_count”

drop view v_clerkView

--7 Create view that will display the emp# and emp last name who works on deptNumber is ‘d2’
create or alter view EmployeesDepatmentD2View
as 
	select E.EmpNo, E.EmpLname, D.DeptNo 
	from HR.Employee E inner join Company.Department D
	ON D.DeptNo = E.DeptNo
	where D.DeptNo = 2


select * from EmployeesDepatmentD2View

--8 Display the employee  lastname that contains letter “J” (Use the previous view created in Q#7)
select * 
from EmployeesDepatmentD2View
where EmpLname like '%J%'

--9 Create view named “v_dept” that will display the department# and department name
create or alter view v_deptView 
as 
select DeptNo, DeptName
from Company.Department

select * from v_deptView

--10 using the previous view try enter new department data where dept# is ’d4’ and dept name is ‘Development’
insert into v_deptView 
values (4, 'Development')

--11 Create view name “v_2006_check” that will display employee Number,
--the project Number where he works and the date of joining the project 
--which must be from the first of January and the last of December 2006.
--this view will be used to insert data so make sure that the coming new data must match the condition.

create or alter view v_2006_checkView 
as 

	select E.EmpNo , P.ProjectNo, WO.Enter_Date
	from HR.Employee E inner join dbo.Works_on WO
	ON E.EmpNo = WO.EmpNo inner join HR.Project P
	ON P.ProjectNo = WO.ProjectNo
	where Year(WO.Enter_Date) = 2006 
	with check option


select * from v_2006_checkView

-----------------------------------------------------------------------------------
----------------------------------------------------------------------------------
/* Part 02*/

--1 Create a stored procedure to show the number of students per department.[use ITI DB] 
create PROC PS_NOStudentsPerDepartment 
as 
begin 
	select D.Dept_Id, Count(S.St_Id) as 'Students Count'
	from Student S inner join Department D
	ON D.Dept_Id = S.Dept_Id
	group by D.Dept_Id
end

exec PS_NOStudentsPerDepartment

--2 Create a stored procedure that will check for the Number of employees in the project 100 if they are more than 3 
----print message to the user “'The number of employees in the project 100 is 3 or more'”
---if they are less display a message to the user “'The following employees work for the project 100'” 
----in addition to the first name and last name of each one. [MyCompany DB] 

create proc EMPloyeeProjectView  -- Sorry I named it in wrong way
as 
begin 
	declare @NumberOfEmployee int
	select @NumberOfEmployee = Count(E.SSN)
	from Employee E inner join Works_for WF
	ON E.SSN = WF.ESSN INNER JOIN Project p
	ON P.Pnumber = WF.Pno
	WHERE P.Pnumber = 100

	if @NumberOfEmployee >= 3
		begin PRINT 'The number of employees in the project 100 is 3 or more' end
	else 
		begin 
			PRINT 'The following employees work for the project 100'
			select p.Pnumber, E.Fname, E.Lname
			from Employee E inner join Works_for WF
			ON E.SSN = WF.ESSN INNER JOIN Project p
			ON P.Pnumber = WF.Pno
			WHERE P.Pnumber = 100
		end
end

exec EMPloyeeProjectView

--3 Create a stored procedure that will be used in case an old employee has left the project 
----and a new one becomes his replacement. The procedure should take 3 parameters
---(old Emp. number, new Emp. number and the project number)
---and it will be used to update works_on table. [MyCompany DB]

create proc PS_EmployeeReplacement @OLDESSN INT,  @NEESSN INT, @PNO INT
as 
begin 
	BEGIN Update WF
	SET WF.ESSN = @NEESSN 
	from Employee E inner join Works_for WF
	ON E.SSN = WF.ESSn inner join Project P
	ON P.Pnumber = WF.Pno
	WHERE WF.ESSn = @OLDESSN AND WF.Pno = @PNO END

END

-- OR IT CAN BE DONE WITHOUT JOIN 
/*
create proc PS_EmployeeReplacement @OLDESSN INT,  @NEESSN INT, @PNO INT
as 
begin 
	BEGIN Update Works_for
	SET ESSN = @NEESSN 
	from Works_for 
	WHERE WF.ESSn = @OLDESSN AND WF.Pno = @PNO END

END

*/

EXEC PS_EmployeeReplacement 112233, 2,100

--4 This table will be used to audit the update trials on the Budget column (Project table, SD32-Company DB)
--Example:
--If a user updated the budget column then the project number, username that made that update,
--the date of the modification and the value of the old and the new budget will be inserted into the Audit table
--Note: This process will take place only if the user updated the budget column

CREATE TABLE audit_(
	Audit_id int IDENTITY PRIMARY KEY ,
	ProjectNO varchar(50) NOT NULL, 
	username varchar(50) not null, 
	ModifiedDate date not null, 
	OldBudget int null, 
	NewBudget int not null

)

Create Trigger UpdateBudgetTrigger 
ON HR.Project
after Update
as 
begin
	if UPDATE(Budget)
		begin 
			insert into audit_ (ProjectNO, username, ModifiedDate, OldBudget, NewBudget)
			select deleted.ProjectNo, SUSER_NAME(), GETDATE(), deleted.Budget, inserted.Budget
			from inserted inner join deleted 
			on inserted.ProjectNo = deleted.ProjectNo;
		end
end


update HR.Project
set Budget = 600000
where ProjectNo = 3 and Budget = 200000



------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------

/* Part 03 */

-- 1 Create a stored procedure that calculates the sum of a given range of numbers
CREATE PROC SP_SUMNumber @num1 int, @num2 int, @out int OUTPUT
as 
begin
	declare @sum int
	set @sum = 0
	if @num1 >  @num2
	begin 
		declare @temp int  
		set @temp = @num1
		set @num1 = @num2
		set @num2 = @temp
	end
	while @num1 < @num2
		begin
		set @sum = @sum + @num1
		set @num1 = @num1+1
		end  
set @out= @sum 			
end

declare @oup int 
exec SP_SUMNumber 5, 10, @oup OUTPUT

select @oup

--2 Create a stored procedure that calculates the area of a circle given its radius

create PROC SP_CalculateCircleArea @Radius float, @Area float OUTPUT 
as 
begin 
	if @Radius > 0
		begin Set @Area = @Radius * @Radius * PI() end
	else 
		begin set @Area = -1 end

end

declare @area float
exec SP_CalculateCircleArea 3.5, @area output 
select @area 

-- 3 Create a stored procedure that calculates the age category based on a person's age 
--( Note: IF Age < 18 then Category is Child and if
--Age >= 18 AND Age < 60 then Category is Adult otherwise  Category is Senior)

create proc PS_AgeCategory @age int , @result varchar(50) OUTPUT
as 
begin 
	if @age < 18
		begin set @result = 'Child' end
	else if @age >= 18 AND @age < 60 
		begin set @result = 'Adult' end
	else 
		begin set @result = 'Senior' end
end

declare @Category varchar(50)
exec PS_AgeCategory 20 , @Category OUTPUT

select @Category as 'Category'

-- 4 Create a stored procedure that determines the maximum, minimum, and average of a given set of numbers
---------( Note : set of numbers as Numbers = '5, 10, 15, 20, 25')

Create PROC PS_MinMaxAvg @Numbers varchar(20), @Min int OUTPUT , @Max int OUTPUT, @Avg int OUTPUT
as 
begin 

    -- Table variable to store the individual numbers
    DECLARE @NumberTable TABLE (Number INT)
    DECLARE @Pos INT
    DECLARE @Value int

    WHILE LEN(@Numbers) > 0
    BEGIN
        SET @Pos = CHARINDEX(',', @Numbers);

        -- If there is no comma, this is the last number
        IF @Pos = 0
			BEGIN
				SET @Value = convert(int,@Numbers)
				SET @Numbers = ''
			END
        ELSE
			BEGIN
				SET @Value = Convert(int,SUBSTRING(@Numbers, 1, @Pos - 1))
				SET @Numbers = SUBSTRING(@Numbers, @Pos + 1, LEN(@Numbers) - @Pos);
			END

        -- Insert the number into the table variable
        INSERT INTO @NumberTable (Number)
        VALUES (@Value);
    END

	selECT @Min = MIN(Number), @Max = Max(Number), @Avg = AVG(Number)
	from @NumberTable

END

declare @Min int , @Max int , @Avg int  
exec PS_MinMaxAvg '5, 10, 15, 20, 25',  @Min OUTPUT, @Max OUTPUT, @Avg OUTPUT

select  @Min, @Max, @Avg




		






















