
-----Joins Assign------


Select c.customerid,c.customername,c.customerage,o.orderid,o.orderdate
From customer c
Inner Join orders o ON c.customerid = o.custid
Where o.products IN ('laptop','earphones')
Order by c.customername DESC;
------------

Select c.customerid,c.customername,o.price
from customer c 
inner join orders o on c.customerid=o.custid
where c.caddress = ( select caddress from customer where customername='akshay') 
and o.price>500;
-----------

Select c.customername,o.orderid,o.orderdate,o.products,o.quantity,o.price
From customer c
Join orders o on c.customerid = o.custid
Where o.quantity > 2;
----------------

Select c.customerid ,c.customername,o.orderid,o.price * 20/100
From customer c
Join orders o ON c.customerid = o.custid
Where c.caddress = 'banglore';
----------------


-----
create table Products
(
productid int,
custid int,
product varchar(20))
 
insert into Products values
(1,1,'Notes'),
(2,2,'Pen Set'),
(3,3,'USB Cable'),
(4,4,'Mouse'),
(5,5,'Keyboard'),
(6,6,'Pen Set'),
(7,7,'Notebook');
 
select * from customer;
select * from Orders;
select * from Products;
 
select * from customer as c
join Orders as o
on c.customerid=o.custid
join Products as p 
on o.custid=p.custid;
-----

update orders set price = price + price * 0.05
where price in (select o.price from orders as o
join customer as c 
on c.customerid=o.custid
where c.caddress in ('ap','chennai'))


select * from orders
select * from customer
----------------------

SELECT 
    CONCAT('cid', c.customerid, '-', 'ordid', o.orderid) AS custidord,
    UPPER(c.customername) AS custname,
    LEFT(o.products, 3) AS product,
    o.price,
    o.orderdate
FROM 
    customer AS c
JOIN 
    orders AS o 
        ON c.customerid = o.custid
WHERE 
    MONTH(o.orderdate) = 12 
    AND YEAR(o.orderdate) = 2025;



    --------------Validations

    create table students(
    studentrollnumber int,
    studentname varchar(20),
    dob date,
    class int)
   
    insert into students values
    (10,'jai','2000-05-10'),
    (11,'raj','2001-06-11'),
    (12,'ramesh','2005-09-06'),
    (13,'suresh','2003-05-12')
     select * from students




