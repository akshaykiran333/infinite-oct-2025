
----Functions Practice
----1. Built in 
----len()

select len('sql server') as lengthresult
-----concat()

select concat ('hello','world') as fulltext
-----replace()

select replace ('akshay kiran kola','kiran','ram')
-----substring()

select SUBSTRING('akshay kiran',4,3)
select SUBSTRING('helloworld',2,3)

 --UPPER()

SELECT UPPER('sql server') AS UpperCaseText;

-- LOWER()

SELECT LOWER('SQL SERVER') AS LowerCaseText;

-- RIGHT()

SELECT RIGHT('SQLSERVER', 6) AS LastCharacters;

--LEFT()

SELECT LEFT('DATABASE', 4) AS FirstCharacters;

--Aggregate Functions

select * from Sales
--MAX()
SELECT MAX(saleAmount) AS MaxAmount FROM Sales;

--MIN()
SELECT MIN(saleAmount) AS MinAmount FROM Sales;

-- SUM()
SELECT SUM(saleAmount) AS TotalAmount FROM Sales;

-- COUNT()
SELECT COUNT(*) AS TotalRows FROM Sales;

-- AVG()
SELECT AVG(saleAmount) AS AverageAmount FROM Sales;

-- Numeric Functions
--SQRT()
SELECT SQRT(100) AS SquareRoot;

-- ROUND()
SELECT ROUND(99.4567, 2) AS RoundedValue;

select POWER(2, 3);

-- RAND()
SELECT RAND AS RandomNumber;       -- Random number between 0 and 1

select getdate()
--date function
SELECT DATENAME(year, GETDATE()) as Year,
       DATENAME(week, GETDATE()) as Week,
       DATENAME(dayofyear, GETDATE()) as DayOfYear,
       DATENAME(month, GETDATE()) as Month,
       DATENAME(day, GETDATE()) as Day,
       DATENAME(weekday, GETDATE()) as WEEKDAY



SELECT DATEADD(DAY, 10, '2024-01-01');
SELECT DATEADD(MONTH, -2, '2024-06-15');
SELECT DATEADD(YEAR, 1, GETDATE())


select DATEDIFF(DAY, '2024-01-01', '2024-01-02')
SELECT DATEDIFF(YEAR, '2010-01-01', GETDATE());
SELECT DATEDIFF(MONTH, '2024-01-01', '2024-06-01');


-----cast functions
---cast & convert
declare @x int
set @x = 10
--print 'you have entered' + cast(@x as varchar)---no formatting
print 'you have entered ' + convert(varchar(10),@x)-- supports formatting


