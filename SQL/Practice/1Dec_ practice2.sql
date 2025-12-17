 


 create view v1
 with encryption
 as
 select studentid,studentname,age from student

 select * from v1     --with encryption

---- sp_helptext v1   (doesnt show as it is encrypted)

create view v2
as
select studentid, studentname,age from student
where age = 23
with check option

select * from v2    ------ with check option

create view v3
with schemabinding
as 
select studentid,studentname,age from dbo.student

select * from v3   --------with schema binding which we cannt drop table must use dbo


create view v4
with encryption, schemabinding
as
select studentid, studentname, age
from dbo.student
where age = 23
with check option

select * from v4        ---all 3 keywords in single view



insert into v1 values (600,'raj_kumar',24)

select studentid,studentname from dbo.student
where studentname LIKE '%[_]%';