
-------> Functions Assign
--1.create a function to find the greatest of three numbers

create function greatest_of_three (@a int, @b int , @c int )
returns int
as 
begin
declare @max int

if (@a>=@b and @a>@c ) 
	set @max=@a
else if (@b>=@a and @b>=@c )
	set @max = @b
else 
	set @max=@c
	return @max
end
Select dbo.greatest_of_three (10, 35, 18);

-----2. . create a function to calculate to discount of 10% on price on all the products

select * from Products

create function calc_discount (@price decimal)
returns decimal
as
begin
	declare @discount_price decimal
	set @discount_price = @price-(@price * 0.10)
	return @discount_price
end
select * ,dbo.calc_discount(price) as discount from Products

------3.create a function to calculate the discount on price as following
	--if productname = 'books' then 10%
	--if productname = toys then 15%
	--else
	--no discount

create function discount2 (@product varchar(20),@price decimal)
returns decimal
as
begin
declare @discounted_price decimal
if @product = 'notes'
	set @discounted_price = @price - (@price *0.10)
else if @product = 'mouse'
	set @discounted_price = @price-(@price * 0.15)
else
	set @discounted_price= @price
return @discounted_price
end

select * , dbo.discount2(product,price) as newdiscounted from Products

--------4.. create inline function which accepts number and prints last n
	        --years of orders made from now.
			--(pass n as a parameter)
create function getlastN_years(@n int)
returns table
as
return 
(select * from orders where orderdate >= DATEADD(YEAR, -@n, GETDATE()))

select * from dbo.getlastN_years(3)

-----------------------------------------------------------------------------------------
---Triggers
---1. . Create a trigger for table customer, which does not allow 
		--the user to delete the record who stays in Bangalore,Chennai, delhi
create trigger tr1 on customer
for delete
as
begin
if exists (select * from deleted where caddress in ('banglore','chennai','ap'))
begin
print 'you cannot delete this record'
rollback transaction
end
end
delete from customer where caddress = 'hyd'

select * from customer

----2. Create a triggers for orders which allows the user to insert only books, cd, mobile 

select * from orders

create trigger tr2 on orders 
for insert
as
begin
if exists(select * from inserted where products not in ('laptop','earphones','watch'))
begin
print 'you cannot insert the values'
rollback transaction
end
end
insert into orders values (11000,20,'2025-12-11','pc',30000,3)

-----3.. Create a trigger for customer table whenever an item is 
		--delete from this table. The corresponding item should be 
		--added in customerhistory table.
create trigger tr3 on customer
for delete
as
begin
insert into custhistory 
select * from deleted
end
delete from customer where customerid=1001;
select * from customer
select * from custhistory

---------4.Create update trigger for stock. Display old values and new values
create trigger tr_stock on customer
for update
as
begin
select c.customerId ,c.customerName,c.customerAge,c.cAddress,c.cPhone,
i.customerId as newid,i.customerName as newname,i.customerAge as newage,i.cAddress as newaddress,c.cPhone
from Customer as c
join inserted as i on c.customerId=i.customerId
end
 
select * from Customer;
update Customer
set cAddress ='mumbai'
where customerId=10002;

------5.	

-- Table A
CREATE TABLE a
(
    custid INT,
    custname VARCHAR(12)
);
-- Table B
CREATE TABLE b
(
    custid INT,
    product VARCHAR(12)
);
CREATE VIEW testview
AS
SELECT a.*, b.product
FROM a
INNER JOIN b ON a.custid = b.custid;

CREATE TRIGGER trg_insert_testview
ON testview
INSTEAD OF INSERT
AS
BEGIN
    INSERT INTO a (custid, custname)
    SELECT custid, custname
    FROM inserted;
    INSERT INTO b (custid, product)
    SELECT custid, product
    FROM inserted;
END;

INSERT INTO testview (custid, custname, product)
VALUES (1, 'Ajay', 'PC');
SELECT * FROM a;
SELECT * FROM b;
SELECT * FROM testview;
