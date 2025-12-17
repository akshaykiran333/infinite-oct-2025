create table customer(
customerid int,
customername varchar(20),
customerage tinyint,
caddress varchar(50),
cphone BIGINT);



insert into customer values(1001,'akshay',23,'ap',9618080336),
(1002,'kiran',23,'ap',9001002000),
(1003,'pradeep',22,'hyd',9084993740),
(1004,'pavan',24,'banglore',7863085683),
(1005,'ganesh',24,'chennai',9076437666)
 
select * from customer

select * from customer where caddress='banglore'

select * from customer where caddress != 'banglore' And caddress !='chennai'

select * from customer where customerage>22 And caddress != 'banglore'

select * from customer where customername like 'A%'

select * from customer where customername like 'g%'

select * from customer where customername like '[a-g]%'

select * from customer where customername like '_____'

select * from customer where customername like 'p%' or customername like '__v%' or customername like '%n'

select Distinct customername from customer

select * from customer where customername like 'ak%y'

select * from customer where customername like NULL



select * into custhistory from customer;
delete from custhistory
insert into custhistory select * from customer where customerage>22
select * from custhistory

--/////////////////////////////////////

 




