create table orders(
custid int,
orderid int,
orderdate Date,
products varchar(20),
price int,
quantity int);

insert into orders values (10001,10,'10/05/2025','laptop',20000,2),
(10002,11,'10/05/2025','earphones',8000,5),
(10003,12,'11/05/2025','watch',2000,1),
(10004,13,'12/05/2025','Tv',350000,2),
(10005,14,'12/05/2025','mobile',40000,3),
(10006,10,'12/05/2025','mouse',3000,6)

select * from orders

select * from orders where (quantity between 1 And 2) or (quantity between 4 And 6)

select 
    custid As [CustomerID],
    price As [Old Price],
    price + (price * 20 / 100) As [New Price]
from orders;


select top 3 * from orders order by quantity desc

select custid As [customer id],
count (*) As [purchase count]
from orders
group  by custid

select year (GETDATE())
select * from orders where
year(getdate())-year(orderdate)>3


update orders
set price = price-(price * 20/100)
where quantity>3

 select * from orders;

 select * from orders where orderdate='10/5/2025' and price between 6000 and 21000 
 order by price desc


 select custid ,sum(price) as SumofPrice, Count(quantity) as countofquantity from orders group by custid;

 select * from orders where price>4000


 --/////////////////////////


  