create table Physical_person(
ID int identity(1,1) primary key not null,
Surname varchar(50) not null,
Firstname varchar(50) not null,
Middlename varchar(50),
Date_of_birth date not null,
Passport_series varchar(20) not null,
Place_of_residence varchar(100) not null,
Email varchar(50),
Phone varchar(15) not null,
Post varchar(30) not null,
Job_name varchar(50) not null
);

create table Roles(
ID int identity(1,1) primary key not null,
Name varchar(50) not null
);

create table Users(
ID int identity(1,1) primary key not null,
ID_Role int references Roles(ID) not null,
Login varchar(50) not null,
Password varchar(50) not null
);

create table Educational_programm(
ID int identity(1,1) primary key not null,
Name varchar(100) not null,
Period_of_study varchar(20) not null,
Qualification varchar(50) not null,
Price decimal(8,2) not null
);