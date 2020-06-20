create table studenti
(
studentId int NOT NULL,
studentCourse int NOT NULL,
studentName varchar(20) NOT NULL,
studentLastName varchar(20) NOT NULL 
);

Alter table studenti
modify column studentId int primary key AUTO_INCREMENT; 

 insert into  studenti(studentId, studentCourse, studentName, studentLastName)
 values (1, 1, "janis", "kalnins"),
 (2, 1, "juris", "berzins"),
 (3, 1, "andris", "liepins"),
 (4, 1, "janis", "ozolins"),
 (5, 2, "davis", "lapins"),
 (6, 2, "janis", "zarins"),
 (7, 2, "artis", "ozols"),
 (8, 3, "jurgis", "petersislis"),
 (9, 3, "lauris", "alksnitis"),
 (10, 3, "maija", "liepa"),
 (11, 3, "liene", "ziediņa"),
 (12, 3, "markus", "rozits");