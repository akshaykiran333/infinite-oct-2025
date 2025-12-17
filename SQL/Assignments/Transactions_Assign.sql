
-----Assignment on Transaction
/*1. Basic Transaction — Commit / Rollback
Create a table BankAccount with sample records.
Write a transaction that transfers money from one account to another.
If the source account balance becomes negative, roll back the transaction; otherwise 
commit*/

create table BankAccount(
AccNo int,
AccName varchar(20),
Balance decimal)

insert into BankAccount values 
(1100,'ragul',19000),
(1110,'sai',39000),
(1120,'mani',25000)
select * from BankAccount

declare @source int=1100
declare @target int=1110
declare @amount decimal=1000

begin transaction
update BankAccount
set Balance = Balance-@amount where AccNo=@source

if (select balance from BankAccount where AccNo =@source)<0
begin
print 'insufficient funds,roll backed'
rollback transaction
end

update BankAccount
set Balance = Balance + @amount
where AccNo=@target

commit transaction
print 'transfer successful'

------2. Using SAVEPOINT
/*Insert three new records into a table Orders.
Create a SAVEPOINT after each insert.
Rollback only the second insert using the SAVEPOINT, then commit the remaining inserts*/

CREATE TABLE Orders3 (
    OrderID INT PRIMARY KEY,
    CustomerName VARCHAR(100),
    Amount DECIMAL(10,2)
);

Begin Transaction;

insert into Orders3 values(101,'raj',1200.0);

Save Transaction Save1;
 
insert into Orders3 values(102,'ram',1500.0);

Save Transaction Save2;
 
insert into Orders3 values(103,'pradeep',1800.0);

Save Transaction Save3;
 
Rollback Transaction Save1;

insert into Orders3 values(103,'chanti',1800.0);

Commit;

select * from Orders3

------3.. Handling Errors with TRY…CATCH
/*Write a transaction that updates prices in a Products table.
Introduce a division-by-zero error inside the transaction.
Use TRY…CATCH to rollback the transaction and log the error message in a separate 
ErrorLog table*/

 select * from BankAccount

 create table storelogs(
 logid int identity(1,1),
 errormessage varchar(100),
 errordate date)

 begin try
begin transaction
update BankAccount set balance = balance + 1000 where AccNo = 1100
declare @n int = 10/0
commit transaction
end try
begin catch
rollback transaction
insert into storelogs values(error_message(),getdate())
print 'Error Occured : '+error_message()
end catch

select * from storelogs

---4. Nested Transactions
/*Create nested transactions:
• Outer transaction inserts a customer
• Inner transaction inserts an order for the customer
• Force an error in the inner transaction
Practice observing whether the outer transaction is committed or rolled back.*/

Create Table Customers1 (
    CustomerID Int identity primary key,
    CustomerName varchar(100) 
);
create Table Orders1 (
    OrderID Int Identity Primary key,
    CustomerID Int ,
    OrderAmount Decimal 
);
select * from customers1;
 
select * from Orders1;
begin transaction
    insert into customers1 (customername)values('kiran')
    declare  @customerid int = scope_identity()
      begin transaction
      begin try
      insert into Orders1(customerid,OrderAmount)values(@customerid,2300)
      declare @y int =1/0
      commit transaction
    commit transaction
    end try
    begin catch
    rollback transaction
    print 'Rolled back the entire transaction due to inner error: ' + ERROR_MESSAGE();
    end catch
 