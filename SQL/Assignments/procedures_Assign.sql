
-----Stored Procedures Assignment
----1Q.
create procedure A1 @customerid int ,@customername varchar(20)
As
Begin
INSERT INTO customer (customerid, customername)
    VALUES (@customerid, @customername);
end
exec A1
@customerid=1001,
@customername='akshay'

select * from customer
-----------2.Q

create procedure pro2(@startdate date,@enddate date)
As
begin
select * from orders where orderdate between @startdate and @enddate
end
exec pro2
@startdate='2025-11-05',
@enddate = '2025-12-05'
-------------3.Q
select * from orders
alter procedure pro3 @custid int, @orderid int output, @quantity int output
As
begin
select  orderid,quantity
from orders where custid= @custid
end

declare @m int,@n int
exec pro3
@custid=10001,
@orderid =@m output,
@quantity= @n  output
print @m
print @n

-----------4.Q
create procedure pro4 
As
begin
if exists(select 1 from Products where Product ='book')
begin
  select sum (productid)  as totalproduct from Products where Product = 'book'
end
else
begin
  print 'Product book not found'
end
end
exec pro4

----------5.Q
create PROCEDURE sp_getdata
AS
BEGIN
    Declare @newCustId int=110;
	return @newCustId;
END;
DECLARE @customerId INT;
EXEC @customerId = sp_getdata;    
INSERT INTO newcustomer(customerId, customerName, customerAge,cAddress,cphone)
VALUES (@customerId, 'raj',24,'delhi',9998889999);

select * from newcustomer

---------6.Q

create procedure alldetails
@start int, @end int as
begin
select * from (select * , ROW_NUMBER() over (order by customerid) as row from customer) as total
where row between @start and @end
end

exec alldetails @start =2, @end =5

--------7.Q

   CREATE TABLE Employees2
( EmployeeID INT IDENTITY(1,1) PRIMARY KEY,Name NVARCHAR(100) NOT NULL,
Department NVARCHAR(50) NOT NULL,
Salary DECIMAL(18, 2) NOT NULL);
 CREATE PROCEDURE spAddEmployee
@Name NVARCHAR(100),
@Department NVARCHAR(50),
@Salary DECIMAL(18, 2),
@NewEmployeeID INT OUTPUT
AS
BEGIN
INSERT INTO Employees2 (Name, Department, Salary)
VALUES (@Name, @Department, @Salary);
SET @NewEmployeeID = SCOPE_IDENTITY();
END;
DECLARE @EmpID INT;
EXEC spAddEmployee
@Name = 'ram',
@Department = 'IT',
@Salary = 60000,
@NewEmployeeID = @EmpID OUTPUT;

select * from Employees2
    
 



 ----------------8.Q
 select * from Products

 CREATE PROCEDURE spGetProductsByCategory
    @Product VARCHAR(100) = 'mouse'
WITH ENCRYPTION
AS
BEGIN
    SET NOCOUNT ON;

    SELECT ProductID,
           CustID,
           Product
    FROM Products
    WHERE Product = @Product;
END;
EXEC spGetProductsByCategory 

