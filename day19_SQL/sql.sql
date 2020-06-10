USE ofiss;

create table employees
(
employeeId INT,
employeeName varchar(20),
employeeLastName varchar(20)
);

drop table emplyees;

insert into employees  (employeeId, employeeName, employeeLastname)
values(1, "juris", "berzins"),
(2, "anete", "cauna");

Alter table employees
modify column employeeId int primary key


insert into employees(employeeName, employeeLastName)
values("karlis", "marks");

from employees
where employeeId = 1;