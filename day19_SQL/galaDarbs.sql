create table toDoList
(
taskID int NOT NULL,
taskName varchar(20) NOT NULL,
taskDescription varchar(200) NOT NULL
);

Alter table todolist
modify column taskID int primary key AUTO_INCREMENT; 

