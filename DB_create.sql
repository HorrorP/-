create database HousingCooperative
go

use HousingCooperative
go
-- , views, 5 queries
CREATE TABLE Employees
(
	Employee_ID          INTEGER NOT NULL IDENTITY(1,1),
	Employee_username    VARCHAR(100) NOT NULL UNIQUE,
	Employee_full_name   VARCHAR(100) NOT NULL,
	Employee_job_title   VARCHAR(50) NOT NULL,
	Employee_phone       VARCHAR(100) NOT NULL UNIQUE,
	Employee_pass_hash   VARCHAR(200) NOT NULL,
	IsAdmin bit
	CHECK (IsAdmin = 0 OR IsAdmin = 1)
);
ALTER TABLE Employees
ADD PRIMARY KEY (Employee_ID);

insert into Employees values
('pro','Петров Игорь Степанович','Администратор','+7(964)160-37-03','C9A92C3DF421B6E9FDBD4AC7AC31FEFD',1),
('user1','Иванов Иван Иванович','Менеджер','+7(900)161-38-04','24C9E15E52AFC47C225B757E7BEE1F9D',0)
;
select * from Employees;

create table Owners
(
Owner_ID INTEGER NOT NULL IDENTITY(1,1),
Owner_full_name  VARCHAR(100) NOT NULL,
Owner_passport_data VARCHAR(100) NOT NULL,
Owner_phone VARCHAR(100) NOT NULL UNIQUE,
);
ALTER TABLE Owners
ADD PRIMARY KEY (Owner_ID);
select * from Owners;

create table Rental
(
Rental_ID INTEGER NOT NULL IDENTITY(1,1),
Rental_address varchar(100) not null unique,
Rental_description varchar(50) NOT NULL,
Owner_ID INTEGER NOT NULL
)
ALTER TABLE Rental
ADD PRIMARY KEY (Rental_ID);
select * from Rental;


ALTER TABLE Rental
ADD CONSTRAINT R_1 FOREIGN KEY  (Owner_ID) REFERENCES Owners (Owner_ID) on update cascade on delete cascade;


CREATE PROC DelRental(@kod int)
AS
IF EXISTS (SELECT *
FROM Rental
WHERE Rental_ID=@kod)
BEGIN
DELETE FROM Rental
WHERE Rental_ID=@kod
PRINT ('Запись успешно удалена')
END
ELSE
PRINT('Такой записи не существует')
go


create trigger TEL
on Owners
instead of insert
as
declare @kod int, @fio  VARCHAR(100), @passport  VARCHAR(100), @phone  VARCHAR(100)
set @kod=(select Owner_ID from inserted)
set @fio=(select Owner_full_name from inserted)
set @passport=(select Owner_passport_data from inserted)
set @phone=(select Owner_phone from inserted)
if exists (select * from inserted where Owner_phone like '+7%') or exists
(select * from inserted where Owner_phone like '+8%')
begin
insert into Owners
values (@kod, @fio, @passport, @phone)
end
else print 'Неверный формат телефона!'
go

-- Queries
--1 Retrieve the full names of all employees who are administrators:
SELECT Employee_full_name
FROM Employees
WHERE IsAdmin = 1;
--2 Retrieve the total count of rentals for each owner, ordered by the owner ID in ascending order:
SELECT Owners.Owner_ID, COUNT(Rental.Rental_ID) AS Rental_Count
FROM Owners
LEFT JOIN Rental ON Owners.Owner_ID = Rental.Owner_ID
GROUP BY Owners.Owner_ID
ORDER BY Owners.Owner_ID ASC;
--3 Retrieve the usernames and job titles of employees who have the same job title as "Менеджер":
SELECT Employee_username, Employee_job_title
FROM Employees
WHERE Employee_job_title = 'Менеджер';
--4 Retrieve the owner names and their corresponding rental addresses for owners who have at least two rentals:
SELECT Owners.Owner_full_name, Rental.Rental_address
FROM Owners
INNER JOIN Rental ON Owners.Owner_ID = Rental.Owner_ID
GROUP BY Owners.Owner_ID, Owners.Owner_full_name, Rental.Rental_address
HAVING COUNT(Rental.Rental_ID) >= 2;
--5 Retrieve the number of rentals for each distinct job title in the employees table:
SELECT Employee_job_title, COUNT(DISTINCT Rental.Rental_ID) AS Rental_Count
FROM Employees
LEFT JOIN Rental ON Employees.Employee_ID = Rental.Owner_ID
GROUP BY Employee_job_title;
-- Views
--1
CREATE VIEW OwnerRental_data AS
SELECT Owner_full_name, Rental_address, Rental_description
FROM Owners join Rental on Owners.Owner_ID=Rental.Owner_ID
go
select * from OwnerRental_data
