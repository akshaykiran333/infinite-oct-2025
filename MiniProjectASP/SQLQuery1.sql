create database ElectricityDb
use electricitydb

create table ElectricityBill(
ConsumerNumber varchar (20),
ConsumerName varchar(30),
Units int,
BillAmount Float)

select * from ElectricityBill