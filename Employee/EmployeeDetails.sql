USE EmployeeDB
Go

CREATE TABLE Employee_Details(
	 EmployeeID int identity(1, 1) primary key,
	 Employee_Name varchar(50), 
	 Age int not null,
	 Designation varchar(50) DEFAULT ('Employee'),
	 Worked_Years int not null
) 

select * from Employee_Details;


INSERT INTO Employee_Details(Employee_Name, Age, Designation, Worked_Years) VALUES
('John', 25, 'Consultant 1', 2),
('Johnny', 21, 'Consultant 2', 3),
('Thor', 25, 'Senior Consultant', 8),
('Robert', 26, 'Manager 1', 10),
('Wanda', 29, 'Senior Developer', 16)

INSERT INTO Employee_Details (Employee_Name, Age, Worked_Years) VALUES	
('Tom', 19, 1),
('Kendra', 20, 3)
