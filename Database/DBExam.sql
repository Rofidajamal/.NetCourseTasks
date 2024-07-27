/* 1-  Write a query that displays Full name of an employee who has more than
3 letters in his/her First Name.*/
select Fname +' '+Lname as 'Full Name'
from Employee
where len(Fname) > 3


/* 2-	Write a query to display the total number of Programming books 
available in the library with alias name ‘NO OF PROGRAMMING
BOOKS’*/
select Count(C.Cat_name) as 'NO OF PROGRAMMING Books'
from Book B inner join Category C
ON C.Id = B.Cat_id 
where C.Cat_name = 'Programming'


/*3- Write a query to display the number of books published by
(HarperCollins) with the alias name 'NO_OF_BOOKS'*/

select Count(B.Title) as 'NO_OF_BOOKS'
from Book B inner join Publisher P
ON P.Id = B.Publisher_id
where P.Name = 'HarperCollins'

/*4- Write 
a query to display the User SSN and name, date of borrowing and due date 
of the User whose due date is before July 2022.*/

select U.SSN, U.User_Name, B.Borrow_date, B.Due_date
from Users U inner join Borrowing B
ON U.SSN = B.User_ssn
where B.Due_date < 'July 2022'


/* 5- Write a query to display book title, author name and display in the 
following format,
' [Book Title] is written by [Author Name]. */

select CONCAT(B.Title,' is Written by ', A.Name) as Result
from Book B inner join Book_Author BA
ON B.Id = BA.Book_id inner join Author A
ON A.Id = BA.Author_id

/* 6- Write a query to display the name of users who have letter 'A' in their 
names */

select  User_Name
from Users 
where User_Name like '%A%'

/* 7- Write a query that display user SSN who makes the most borrowing */
select top(1) U.SSN, U.User_Name
from Users U inner join Borrowing B
ON U.SSN = B.User_ssn
Group by U.User_Name, U.SSN
order by Count (U.SSN)

/* 8-  Write a query that displays the total amount of money that each user paid 
for borrowing books.*/

select  U.User_Name, Sum(B.Amount)
from Users U inner join Borrowing B
ON U.SSN = B.User_ssn
group by U.User_Name

/* 9- write a query that displays the category which has the book that has the 
minimum amount of money for borrowing. */

select C.Cat_name
from Book B inner join Borrowing BW
ON B.Id = BW.Book_id inner join Category C
ON C.Id = B.Cat_id
where BW.Amount = (select min(Amount) from Borrowing )



/* 10- write a query that displays the email of an employee if it's not found, 
display address if it's not found, display date of birthday.*/

select coalesce(Email, Address, convert(varchar(50), DOB), 'Not Found') 
from Employee

/* 11- Write a query to list the category and number of books in each category 
with the alias name 'Count Of Books'.*/

select C.Cat_name, COUNT(B.Id) as 'Count Of Books' 
from Book B inner join Category C
ON C.Id = B.Cat_id
group by C.Cat_name

/* 12- Write a query that display books id which is not found in floor num = 1 
and shelf-code = A1.*/

select B.Id as 'Book_ID'
from Book B inner join Shelf SH
ON SH.Code = B.Shelf_code inner join Floor F
ON F.Number = SH.Floor_num
where F.Number != 1 and SH.Code != 'A1'

/* 13- Write a query that displays the floor number , Number of Blocks and 
number of employees working on that floor.*/

select F.Number as 'Floor_Number', F.Num_blocks, Count(E.Id) as 'Number Of Employee'
from Floor F inner join Employee E
ON F.Number=E.Floor_no
group by F.Number, F.Num_blocks


/* 14- Display Book Title and User Name to designate Borrowing that occurred 
within the period ‘3/1/2022’ and ‘10/1/2022’.*/

 select B.Title as 'Book Title', U.User_Name as 'User Name'
 from Users U inner join Borrowing BW
 ON U.SSN = BW.User_ssn inner join Book B 
 ON B.Id = BW.Book_id
 where BW.Borrow_date between '3/1/2022' and '10/1/2022'


 /* 15- Display Employee Full Name and Name Of his/her Supervisor as
Supervisor Name.*/

select E1.Fname + ' '+E1.Lname as 'Employee Name', E2.Fname + ' '+E2.Lname as 'Super Name' 
from Employee E1 inner join Employee E2
ON E2.Super_id = E1.Id

--If we need to display All Employees even who does not have a Supervisor we will use Left join istead of inner join 
--and The supervisor name will be NULL for Managers.



/* 16- Select Employee name and his/her salary but if there is no salary display
Employee bonus. */

select  Fname + ' '+ Lname AS 'Employee Name', isNull(Salary, Bouns)as 'Salary or bonus' 
from Employee

/* 17- Display max and min salary for Employees*/

select max(Salary) as 'Max Salar', min (Salary) as 'Min Salary'
from Employee


/* 18- Write a function that take Number and display if it is even or odd*/

create function isEven (@num int)
returns varchar(50)
begin 
declare @Message varchar(50) 
	if @num % 2 = 0
		set @Message = 'Number is Even'
	else
		set @Message = 'Number is odd'
	return @Message
end

declare @me varchar(50)
set @me = dbo.isEven(3)
print(@me)


/* 19- write a function that take category name and display Title of books in that 
category*/

create function BooksInCategory (@Cat_name varchar(20))
returns Table
as

return (
select B.Title, C.Cat_name
from Book B inner join Category C
ON C.Id = B.Cat_id
where C.Cat_name = @Cat_name
)

declare @catName varchar(20)
set @catName = 'Programming'
select * from BooksInCategory (@catName)



/* 20- write a function that takes the phone of the user and displays Book Title , 
user-name, amount of money and due-date.*/

create or alter function UserBorrowingData (@phone varchar(11))
returns table
as 
return(
	select B.Title as 'Book Title', U.User_Name as 'User Name', BW.Amount as 'Amount of Money', BW.Due_date
	from Users U inner join User_phones UP
	ON U.SSN = UP.User_ssn inner join Borrowing BW
	ON U.SSN = BW.User_ssn inner join Book B
	ON B.Id = BW.Book_id
	where UP.Phone_num = @phone
)

select * from UserBorrowingData('0123654122')


/* 21- Write a function that take user name and check if it's duplicated
return Message in the following format ([User Name] is Repeated 
[Count] times) if it's not duplicated display msg with this format [user 
name] is not duplicated,if it's not Found Return [User Name] is Not
Found*/

create function CountUserName (@userName varchar(20))
returns varchar(50)
as 
begin 
	declare @message varchar(50)
	declare @Counter int

	select @Counter = Count(User_Name)
	from Users
	where User_Name = @userName

	if @Counter >1 
		--[User Name] is Repeated [Count] times)
		set @message = CONCAT(@userName, ' is repeated ' ,@Counter, ' Time') 
	else if @Counter = 0
		--[user name] is not found
			set @message = CONCAT(@userName, ' is not found')
	else
		-- [user name] is not duplicated
		set @message = CONCAT(@userName, 'is not Duplicated')

		return @message
end

declare @mr varchar(50)
set @mr = dbo.CountUserName('Amr Ahmed')	
print(@mr)


/* 22- Create a scalar function that takes date and Format to return Date With
That Format.*/

create or alter function DateWithFormat (@date date, @Format varchar(20))
returns varchar(50)
as
begin
	declare @formattedDate varchar(50)
	set @formattedDate = format(@date, @Format)

	return @formattedDate
end

declare @formattedDate varchar(50)
set @formattedDate = dbo.DateWithFormat(getdate(), 'ddd-MMM-yyyy') 
print(@formattedDate)


/* 23- Create a stored procedure to show the number of books per Category*/

create or alter proc SP_NumberOfBooksPerCategory 
as 

	select C.Cat_name , Count(B.Id) as 'Number of books' 
	from Category C inner join Book B
	ON C.Id = B.Cat_id
	group by C.Cat_name


exec SP_NumberOfBooksPerCategory


/* 24- Create a stored procedure that will be used in case there is an old manager 
who has left the floor and a new one becomes his replacement. The 
procedure should take 3 parameters (old Emp.id, new Emp.id and the 
floor number) and it will be used to update the floor table. */

create or alter proc ManagerReplacement @OldEmpId int, @newEmpId int, @FloorNum int
as 
	update Floor
	set MG_ID = @newEmpId
	where MG_ID = @OldEmpId and Number = @FloorNum
	


/* 25- Create a view AlexAndCairoEmp that displays Employee data for users 
who live in Alex or Cairo.*/

create or alter View AlexAndCairoEmpView 
as 
	select * 
	from Employee
	where Address in ('Cairo', 'Alex')


select * from AlexAndCairoEmpView

/* 26- create a view "V2" That displays number of books per shelf*/

create or alter View V2_View 
as 
	select SH.Code, Count(B.Id) as 'Number of books'
	from Book B inner join Shelf SH
	ON SH.Code = B.Shelf_code
	group by SH.Code

select * from V2_View

/* 27- .create a view "V3" That display the shelf code that have maximum 
number of books using the previous view "V2" */

create or alter View V3_View 
as 
	select  Code 
	from V2_View
	where [Number of books] = (select max ([Number of books]) from  V2_View)

select * from V3_View


/* 28- Create a table named ‘ReturnedBooks’ With the Following Structure : then create
A trigger that instead of inserting the data of returned book 
checks if the return date is the due date or not if not so the user must pay 
a fee and it will be 20% of the amount that was paid before.*/

 create table ReturnedBooks(
	User_SSN varChar(50) not null,
	Book_ID int not null,
	Due_Date date not null,
	Return_Date date not null,
	fees money ,
	primary key(User_SSN,Book_ID)
 )

 alter table ReturnedBooks
 add constraint USER_KEY foreign key (User_SSN) references Users(SSN)

  alter table ReturnedBooks
 add constraint Book_Key foreign key (Book_ID) references Book(Id)

 create or alter trigger tr_ReturnBooks
 on ReturnedBooks
 instead of insert
 as

	declare @UserSSN varchar(50)
	declare @BooKID int
	declare @ReturnDate date
	declare @FEES money
	declare @DueDate date

	select @UserSSN = i.User_SSN, @BooKID = i.Book_ID, @ReturnDate = i.Return_Date,
			@DueDate = i.Due_Date
	from inserted i

	declare @am int	
	select @am Amount
	from Borrowing 
	where Book_id = @BooKID and User_ssn = @UserSSN

	if @ReturnDate > @DueDate
		set @Fees = @Fees+ (@am*0.2)
	else
		set @Fees = 0

	insert into ReturnedBooks  
	values (@UserSSN, @BookID, @DueDate, @ReturnDate, @FEES)




/* 29- In the Floor table insert new Floor With Number of blocks 2 , employee 
with SSN = 20 as a manager for this Floor,The start date for this manager 
is Now. Do what is required if you know that : Mr.Omar Amr(SSN=5) 
moved to be the manager of the new Floor (id = 7), and they give Mr. Ali
Mohamed(his SSN =12) His position .*/

insert into Floor(Number ,Num_blocks, MG_ID, Hiring_Date)
values ( 7, 2, 20, GETDATE())

-- To know the number of the floor that employee 5 manage
select F.Number
from Floor F inner join Employee E
ON E.Id = F.MG_ID
where E.Id = 5

-- To make employee 5 manager to the new floor
update Floor 
set MG_ID = 5
where Number = 7

-- To make employee 12 the manager instead of employee 5
update Floor
set MG_ID = 12
where Number = 4


/* 30- Create view name (v_2006_check) that will display Manager id, Floor 
Number where he/she works , Number of Blocks and the Hiring Date 
which must be from the first of March and the end of May 2022.this view 
will be used to insert data so make sure that the coming new data must 
match the condition then try to insert this 2 rows and
*/

create or alter view v_2006_checkView
as 
	select MG_ID, Number, Num_blocks, Hiring_Date
	from  Floor 
	where Hiring_Date between '2022-03-01' and '2022-05-31'

create trigger Tri_V_2006_CHeck
on v_2006_checkView
instead of insert
as
	declare @MNG int
	declare @FloorNum int
	declare @NumBlocks int 
	declare @HiringDate date

	select @MNG = i.MG_ID, @FloorNum = i.Number, @NumBlocks = i.Num_blocks, @HiringDate = i.Hiring_Date 
	from inserted i

	if @HiringDate not between '2022-03-01' and '2022-05-31'
		print('ERROR You cannot insert')
	else
		insert into v_2006_checkView
		values ( @MNG, @FloorNum, @NumBlocks, @HiringDate)

-- Try to insert 
insert into v_2006_checkView
values(2, 6, 2, '2023-08-07'),
	  (4, 7, 1, '2022-08-04')   --> it print the ERROR  message that i made in the trigger

/* 31- Create a trigger to prevent anyone from Modifying or Delete or Insert in 
the Employee table ( Display a message for user to tell him that he can’t 
take any action with this Table)*/

create or alter trigger Tri_EmployeeActionPervent
on Employee
instead of insert, delete, update
as
	print('ERROR you can’t take any action with this Table')
	

/* 32- Testing Referential Integrity , Mention What Will Happen When:
A. Add a new User Phone Number with User_SSN = 50 in
User_Phones Table {1 Point}
B. Modify the employee id 20 in the employee table to 21 {1 Point}
C. Delete the employee with id 1 {1 Point}
D. Delete the employee with id 12 {1 Point}
E. Create an index on column (Salary) that allows you to cluster the 
data in table Employee. {1 Point}
*/

-- A. Add a new User Phone Number with User_SSN = 50 in User_Phones Table

insert into User_phones 
values (50, '01007377260') -- It gives an Error INSERT statement conflicted with the FOREIGN KEY constraint "FK_User_phones_User".

-- B. Modify the employee id 20 in the employee table to 21 
update Employee
set Id = 21
where Id = 20 -- it gives an Error because of The trigger we did in 31 but if we diable it,
			  -- it gives an Error because we Cannot update identity column 'Id' 


-- C. Delete the employee with id 1
delete 
from Employee
where Id = 1
-- it gives an Error because of The trigger we did in 31 but if we diable it, 
--The DELETE statement conflicted with the REFERENCE constraint "FK_Borrowing_Employee"

-- D. Delete the employee with id 12
delete 
from Employee
where Id = 12 

-- it gives an Error because of The trigger we did in 31 but if we diable it,
--The DELETE statement conflicted with the REFERENCE constraint "FK_Borrowing_Employee"

-- E. Create an index on column (Salary) that allows you to cluster the data in table Employee.
create clustered index indx_Salary
on Employee(Salary) 
--ERROR, there  a clustered Index on PK_Employee,
--we cannot make 2 clustered index on the same Table but we can make non-clustered one.


/*32- Try to Create Login With Your Name And give yourself access Only to 
Employee and Floor tables then allow this login to select and insert data 
into tables and deny Delete and update */

create Schema RofidaSchema

alter schema RofidaSchema
transfer  Employee

alter schema RofidaSchema
transfer  Floor











		


















