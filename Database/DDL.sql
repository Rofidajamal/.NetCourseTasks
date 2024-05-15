create database Airline

use Airline 

create table Aicraft (
	ID int  primary key,
	capacity int  not null, 
	Model varchar(100) ,
	Maj_Pilot varchar(50), 
	Assistant varchar(50) not null, 
	Hos1 varchar (50), 
	Host2 varchar (50), 
	AL_ID int,
	
)

create table Airline (
	ID int primary key ,
	Name varchar(100) not null,
	Address varchar(250),
	cont_person varchar(100) not null, 

)

alter table Aicraft
add foreign key (AL_ID) references Airline(ID)

create table Airline_Phones(
	AL_ID int, 
	Phones varchar(10) not null,
	primary key (AL_ID, Phones),

)

alter table Airline_Phones 
add foreign key (AL_ID) references Airline(ID)

create table Transactions(
	ID int primary key, 
	Descreiption varchar(250), 
	Amount money not null, 
	Date_ date, 
	AL_ID int foreign key references Airline(ID)

)

create table Employee (
	ID int primary key, 
	Name varchar(100) not null,
	Address varchar(100),
	gender char, 
	position varchar(100),
	BD_Year int, 
	BD_Month int, 
	BD_Day int, 
	CONSTRAINT CheckValidMonth CHECK (BD_Month BETWEEN 1 AND 12),
	CONSTRAINT CheckValidDay CHECK (BD_Day BETWEEN 1 AND 31),
	AL_ID  int foreign key references Airline(ID)
)

create table Emp_Qualification(
	 Emp_ID int foreign key references Employee(ID),
	 Qualification varchar(100),
	 primary key(Emp_ID, Qualification),
)

create table Route (
	ID int primary key, 
	Distance float not null, 
	Destination varchar(100) not null,
	Origin varchar(100), 
	Classifications varchar(20),

)

create table AirCraft_Routes (
	AC_ID int foreign key references Aicraft(ID), 
	Route_ID int foreign key references Route(ID),
	Departure datetime not null, 
	Num_Of_Pass int,
	price decimal,
	Arrival datetime,
	primary key (AC_ID, Route_ID, Departure),
)
