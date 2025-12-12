

create table students(
StudentId int identity(1,1) primary key,
    FullName varchar(100) NOT NULL,
    Email varchar(100) UNIQUE NOT NULL, 
    Department varchar(50) NOT NULL,
    YearOfStudy int NOT NULL
);
insert into Students (FullName, Email, Department, YearOfStudy) Values
('akshay', 'akshay.1@gmail.com', 'Computer Science', 1),
('kiran', 'kiran.2@gmail.com', 'Engineering', 2),
('raj', 'raj.k12@gmail.com', 'Mathematics', 1),
('deeraj', 'deeraj.d32@gmail.com', 'History', 3),
('pradeep', 'pradeep123@gmail.com', 'Computer Science', 2);
select * from students
---------------------------------
Create Table Courses (
    CourseId int identity(1,1) primary key,
    CourseName varchar (100) NOT NULL,
    Credits int NOT NULL,
    Semester varchar (20) NOT NULL
);
Insert into Courses (CourseName, Credits, Semester) Values
('C# Programming', 3, 'Fall 2024'),
('DBMS', 4, 'Fall 2024'),
('Sql', 4, 'Fall 2024'),
('Python', 3, 'Fall 2024'),
('Data Structures', 4, 'Spring 2025'),
('Linear Algebra', 3, 'Spring 2025');
select * from Courses
------------------------------
Create table Enrollments (
    EnrollmentId int identity(1,1) primary key,
    StudentId int NOT NULL,
    CourseId int NOT NULL,
    EnrollDate datetime NOT NULL,
    Grade varchar(5) NULL,
    foreign Key (StudentId) References Students(StudentId),
    foreign Key (CourseId) References Courses(CourseId)
);
Insert into Enrollments (StudentId, CourseId, EnrollDate, Grade) Values
(1, 1, '2025-09-11', NULL), 
(1, 2, '2025-09-12', NULL), 
(2, 3, '2025-10-08', NULL), 
(3, 1, '2025-10-15', 'A'),  
(4, 4, '2024-08-09', NULL), 
(5, 5, '2024-08-05', NULL); 
select * from Enrollments