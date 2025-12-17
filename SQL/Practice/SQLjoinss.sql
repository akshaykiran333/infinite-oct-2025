
------Practice

---inner join 

select * from customer inner join orders on customer.customerid= orders.custid

----left outer join
select * from customer left outer join orders on customer.customerid =orders.custid

----right outer join

select * from customer right outer join orders on customer.customerid=orders.custid

----full outer join

select * from customer full outer join orders on customer.customerid=orders.custid


-----cross join

select * from customer cross join orders 


-----self join
select a.* from customer a, customer b where a.customerage>b.customerage and b.customername='akshay'


-----union 
select * into newcustomer from customer

select * from newcustomer
select * from customer union select * from newcustomer


------------union all
select * from customer unionall select * from newcustomer


-------except

select * from customer except select * from newcustomer

-----intersept

select * from customer intersept select * from newcustomer



