

-------customer()
--customerid int,
--customername varchar(20),
--customerage tinyint,
--caddress varchar(50),
--cphone BIGINT);


---------- orders()
--custid int,
--orderid int,
--orderdate Date,
--products varchar(20),
--price int,
--quantity int);
--------------------------Sub Queries

UPDATE customer SET customerid = 10001 WHERE customerid = 1001;
UPDATE customer SET customerid = 10002 WHERE customerid = 1002;
UPDATE customer SET customerid = 10003 WHERE customerid = 1003;
UPDATE customer SET customerid = 10004 WHERE customerid = 1004;
UPDATE customer SET customerid = 10005 WHERE customerid = 1005;

select * from customer where customerid in (select custid from orders where products='earphones')


select * from customer where customerid in (select custid from orders where products in ('earphones','mobile','laptop'))

select * from customer where customerid not in (select custid from orders products)

select  max(customerage) as "secondhighestage" from customer where customerage< (select max(customerage) from customer)

select * from orders where custid in (select custid from customer where caddress= 'banglore')

select * from customer where customerid in (select custid from orders
Where quantity = (Select Min (quantity) FROM orders));


select * from customer where customerage > (select customerage from customer where customername='akshay')

update customer
set customerage = (Select customerage from customer where customerid = 200)
where customerid = 100;

select * from orders where month(orderdate) =12;



Select * From orders where price > (Select Avg(price) from orders)




