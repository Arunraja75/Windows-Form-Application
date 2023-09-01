create database registration_form
use registration_form

create table employee
(
employee_Id int primary key identity(1,1),
employee_Name varchar(50),
employee_Surname varchar(50),
employee_Designation varchar(50),
employee_email varchar(50),
emp_id varchar(50),
employee_gender varchar(50),
employee_address varchar(50)
)

select*from employee
truncate table employee
insert into employee values('Arun','Raja','Developer','Admin@arunraja.com','71120','Male','Trichy')
insert into employee values('hari','surya','sales','Admin@arunraja.com','71120','Male','Trichy')

create table Loginuser
(
login_Id int primary key identity(1,1),
login_Name varchar(50),
login_Password varchar(50)
)

select * from Loginuser
insert into Loginuser values('arun','admin7')