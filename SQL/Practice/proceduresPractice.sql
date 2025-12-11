

------Practice Procedures
--------create
create procedure getstudents
as
select * from newcustomer
getstudents

----with parameter
alter procedure getstudents(@a varchar(20))
as
select * from newcustomer where customerid=@a

getstudents '1002'

------drop
drop procedure getstudents

---procedure can contain simple logic with out queries as well

create procedure Addproc(@a int, @b int)
as
print @a + @b

Addproc 10, 20

-- can procedure return value?
create procedure Addproc1(@a int, @b int)
as
return @a + @b

-- how to execute procedure which returns ?
declare @result int
   exec @result = AddProc1 10,20
   print @result

------create with multiple values
create procedure addproc2 (@a int, @b int, @c int output,@d int output)
as 
set @c=@a+@b
set @d=@a*@b

declare @m int  ------->to execute
declare @n int
exec addproc2 10,20,@m output,@n output
print @m
print @n


-- how to create procedure with try/catch block

create procedure divided(@a int, @b int)
as
begin try
 print @a/@b
end TRY
begin catch
print 'Error OCCURED : ' + error_message()
end CATCH

divided 10,0




----------to call manually

create procedure displaydata(@tbl varchar(20))
as
declare @myquery nvarchar(100)
set @myquery = 'select * from ' + @tbl
exec sp_executesql @myquery -- runs the select command



displaydata 'orders'
