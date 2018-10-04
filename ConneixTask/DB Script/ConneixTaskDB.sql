Create Database taskemp

use taskemp
drop table Employee
create table Employee
(
	Emp_Id int identity(1,1) primary key, 
	Emp_FirstName nvarchar(100), 
	Emp_LastName nvarchar(100),
	Emp_Email nvarchar(50) ,
	Emp_Salary money,
	Emp_Designation nvarchar(100),
	Emp_DOB date,
	Emp_Address nvarchar(max),
	Gender varchar(20)
)

insert into Employee values('tamanam','joyal','joyal9494@gmail.com',25000,'developer','01-06-1992','kphb','Male')
insert into Employee values('kiran','kumar','kiran1207@gmail.com',20000,'developer',convert(date,'1992-08-15'),'vizag','Male')
insert into Employee values('ragam','venkatesh','venkatesh.r@gmail.com',25000,'developer',convert(date,'1991-06-08'),'kphb','Male')
insert into Employee values('pavan','kassey','pavankassey@gmail.com',19000,'developer','1995-10-28','nizampet','Male')
insert into Employee values('rakesh','chandrs','rakeshchandra143@gmail.com',35000,'developer','09-04-1992','guntur','Male')
insert into Employee values('harish','marapaka','harishm@gmail.com',19800,'developer','07-06-1991','secunderabad','Male')

select * from Employee





