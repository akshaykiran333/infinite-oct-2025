

-----Views Assignment

----1.Employees Table

CREATE TABLE Employees 
( 
    EmpId INT PRIMARY KEY, 
    EmpName VARCHAR(100), 
    DeptId INT, 
    ManagerId INT NULL, 
    JoinDate DATE, 
    Salary DECIMAL(10,2) 
); 
 
INSERT INTO Employees VALUES 
(1, 'Amit', 10, NULL, '2020-01-10', 65000), 
(2, 'Neha', 10, 1,    '2022-02-15', 50000), 
(3, 'Ravi', 20, 1,    '2023-03-12', 45000), 
(4, 'Sana', 20, 3,    '2024-01-20', 42000), 
(5, 'Karan', 30, 1,   '2021-07-18', 55000); 


select * from Employees

------2. Department Table
CREATE TABLE Departments 
( 
    DeptId INT PRIMARY KEY, 
    DeptName VARCHAR(100) 
); 
 
INSERT INTO Departments VALUES 
(10, 'IT'), 
(20, 'HR'), 
(30, 'Finance');

select * from Departments

------3.Sales Table

CREATE TABLE Sales 
( 
    SaleId INT PRIMARY KEY, 
    EmpId INT, 
    Region VARCHAR(50), 
    SaleAmount DECIMAL(10,2), 
    SaleDate DATE 
); 
 
INSERT INTO Sales VALUES 
(1, 1, 'North', 100000, '2024-01-01'), 
(2, 2, 'North',  90000, '2024-01-10'), 
(3, 3, 'South', 120000, '2024-02-05'), 
(4, 4, 'South', 120000, '2024-02-20'), 
(5, 5, 'North', 110000, '2024-03-15');

select * from Sales

------Transactions Table
CREATE TABLE Transactions 
( 
    TransId INT PRIMARY KEY, 
    AccountId INT, 
    Amount DECIMAL(10,2), 
    TransDate DATE 
); 
 
INSERT INTO Transactions VALUES 
(1, 101, 1000, '2024-01-01'), 
(2, 101, 2000, '2024-02-01'), 
(3, 101, -500, '2024-03-01'), 
(4, 102, 1500, '2024-01-15'), 
(5, 102, -200, '2024-03-10');
 select * from Transactions

  /*Views 
   CTE 
   Programming 
   Ranking*/
   -------1Q.
   select EmpId,EmpName,DeptId,Salary,
   CASE
   when Salary<20000 then 'low'
   when Salary between 20000 and 50000 then 'medium'
   else 'high'
   end as salarycategory from Employees

------2.Q
declare @age int
set @age=23
if (@age<18)
print 'minor'
else if (@age>=18 and @age<=60)
print 'adult'
else 
print 'senior'

-------3.Q

create view dbo.myview 
with schemabinding, encryption
as 
select
E.Empid,
E.Empname,
E.Deptid,
E.joinDate,
E.Salary,
(E.Salary * 12) As AnnualSalary
from dbo.Employees As E
inner join dbo.Departments AS D
on E.DeptId = D.DeptId 
where E.joinDate>= '2022-12-01'

select * from myview

-------------4.Q

CREATE VIEW ViewEmployeeDetails2
AS
SELECT 
e.EmpID,
e.EmpName,
e.DeptId,
s.TotalSales,
RANK() OVER (ORDER BY s.TotalSales DESC) AS SalesRank
FROM dbo.Employees AS e
INNER JOIN 
(
SELECT 
EmpID,
SUM(SaleAmount) AS TotalSales
FROM dbo.Sales
GROUP BY EmpID) AS s
ON e.EmpID = s.EmpID;
select * from ViewEmployeeDetails2
 

 ---------5.Q
 begin try
 declare @x int
 set @x=10
 declare @y int
 declare @result int
 set @y = @x/0
 end try
 begin catch
 print '0 division gives an error'
 end catch

 -----------6.Q
Declare @salary int;
Set @salary = 9000;
Begin try
if (@salary < 1000)
begin
Throw 50001, 'Salary is low', 1;
End
Else
Begin
Print 'Salary is acceptable';
end
end try
Begin catch
Print 'Error occurred: ' + ERROR_MESSAGE();
End catch;


-------------7.Q
SELECT S.Region,
E.EmpId,
E.EmpName,
S.TotalSales,
RANK() OVER (PARTITION BY S.Region ORDER BY S.TotalSales DESC) AS RankSales,
DENSE_RANK() OVER (PARTITION BY S.Region ORDER BY S.TotalSales DESC) AS DenseRankSales,
ROW_NUMBER() OVER (PARTITION BY S.Region ORDER BY S.TotalSales DESC) AS RowNumSales
FROM dbo.Employees E
JOIN (
SELECT EmpId, Region, SUM(SaleAmount) AS TotalSales
 FROM dbo.Sales
GROUP BY EmpId, Region) S ON E.EmpId = S.EmpId
ORDER BY S.Region, S.TotalSales DESC;

----------8.Q
WITH LastYearSales AS (
SELECT *FROM dbo.Sales
WHERE SaleDate >= '2024-01-01'),
RegionSales AS (
SELECT  Region, SUM(SaleAmount) AS TotalSales
FROM LastYearSales
GROUP BY Region),
RankedRegions AS (
SELECT  Region,TotalSales,
RANK() OVER (ORDER BY TotalSales DESC) AS RegionRank
FROM RegionSales)
SELECT *
FROM RankedRegions
WHERE RegionRank <= 3
ORDER BY RegionRank;
 

 ---------9.Q

SELECT e.EmpId,
e.EmpName,
e.DeptId,
d.DeptName,
s.SaleAmount,
s.SaleId,
s.Region,
s.SaleDate
FROM Employees e
JOIN Sales s ON e.EmpId = s.EmpId
JOIN Departments d ON e.DeptId = d.DeptId
WHERE (e.DeptId, s.SaleAmount) IN (
SELECT e2.DeptId, s2.SaleAmount
FROM Employees e2
JOIN Sales s2 ON e2.EmpId = s2.EmpId
GROUP BY e2.DeptId, s2.SaleAmount
HAVING COUNT(*) > 1)
ORDER BY e.DeptId, s.SaleAmount;


 


 

 
