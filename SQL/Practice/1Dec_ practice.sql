

with getmax (a,b) as 
(select sum(age),saddress from student group by saddress)
select max(a) from getmax