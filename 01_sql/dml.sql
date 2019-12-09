use master;
go
RESTORE FILELISTONLY
FROM disk = 'AdventureWorks2017.bak';
restore database AdventureWorks2017
from disk = 'AdventureWorks2017.bak'
with
move 'AdventureWorks2017' to '/var/opt/mssql/data/aw2017.mdf'
,move 'AdventureWorks2017_log' to '/var/opt/mssql/data/aw2017_log.ldf';






use AdventureWorks2017;
go

-- select
select 1 + 1

select * 
from Person.Person

select firstname, lastname, middlename
from Person.Person

select firstname, lastname, middlename
from Person.Person
where FirstName = 'robert';

select firstname, lastname, middlename
from Person.Person
where FirstName = 'robert' or FirstName = 'john';

select firstname, lastname, middlename
from Person.Person
where FirstName <> 'robert' or FirstName <> 'john';

select firstname, lastname, middlename
from Person.Person
where FirstName like '%robert%';

select count(*), firstname, lastname
from Person.Person
where FirstName = 'robert' or FirstName = 'john'
group by FirstName, LastName;

select count(*) as "amount of", firstname, lastname
from Person.Person
where FirstName = 'robert' or FirstName = 'john'
group by FirstName, LastName;

select count(*) as "amount of", firstname, lastname
from Person.Person
where FirstName = 'robert' or FirstName = 'john'
group by FirstName, LastName
having count(*) > 1
order by Lastname asc, FirstName desc;

select count(FirstName) as "amount of", firstname, lastname
from Person.Person
where FirstName = 'robert' or FirstName = 'john'
group by FirstName, LastName
having count(*) > 1
order by Lastname asc, FirstName desc; --no difference in current example


--mode of execution 
/*
FROM
WHERE
GROUP BY
HAVING
SELECT
ORDER BY

any alias put in from is available to the entire select statement
*/

-- insert
select * from  Person.Address

insert into Person.Address
values ('UT', NULL, 'Arlington', 79, 76010, 0xE6100000010CAE8BFC28BCE4474067A89189898A5EC0, '9aadcb0d-36cf-483f-84d8-585c2d4ec6ea', '2019-11-08');

insert into Person.Address(AddressLine1, AddressLine2, City, StateProvinceID, PostalCode, SpatialLocation, rowguid, ModifiedDate)
values ('UT', 'American Dream City', 'Arlington', 79, 76010, 0xE6100000010CAE8BFC28BCE4474067A89189898A5EC0, '9aadcb0d-36cf-483f-84d8-585c2d4ec6eb', '2019-11-08')

insert into Person.Address(AddressLine1, AddressLine2, City, StateProvinceID, PostalCode, SpatialLocation, rowguid, ModifiedDate)
select AddressLine1, AddressLine2, City, StateProvinceID, PostalCode, SpatialLocation, rowguid, ModifiedDate
from Person.Address
where AddressLine1 = 'UT';

bulk insert Person.Address from 'data.csv' with (rowterminator = '\n', fieldterminator = ',');

-- update

update Person.Person
set firstname = 'john'
where firstName = 'robert';

--do not write an update without a where clause

update pp
set firstname = 'robert'
from Person.Person as pp
where pp.LastName = 'jones';

-- delete

delete
from Person.Person
where MiddleName is null and FirstName = 'xavier';


-- find a person's address

-- how to find tht tables?


select * 
from Person.AddressType

select pp.firstname, pp.lastname, pa.addressline1, pa.city, pa.postalcode
from Person.Person as pp
inner join Person.BusinessEntityAddress as pbea on pbea.BusinessEntityID = pp.BusinessEntityID
inner join Person.Address as pa on pa.AddressID = pbea.AddressID
where pp.FirstName = 'jimmy';

/* 
always start with table that has potentially the least info (there will never be more info than that table) / / start with smallest subset possible
always try innerjoin and left join, do not mix left and right, if you go left remain left, and vice versa
cross and self are almost never used, and full rarely has a purpose
find the shortest way possible: look at the tables
database diagrams are fairly useless
redgate, database mappers
*/

select pp.firstname, pp.lastname, ppt.Name
from Person.Person as pp
inner join Person.BusinessEntityAddress as pbea on pbea.BusinessEntityID = pp.BusinessEntityID
inner join Person.Address as pa on pa.AddressID = pbea.AddressID
inner join Sales.Customer as sc on sc.CustomerID = pp.BusinessEntityId
inner join Sales.SalesOrderHeader as ssoh on ssoh.CustomerID = sc.CustomerID
inner join Sales.SalesOrderDetail as ssod on ssod.SalesOrderId = ssoh.SalesOrderID
inner join Production.Product as ppt on ppt.ProductID = ssod.ProductID
where pp.FirstName = 'jimmy';

select pp.firstname, pp.lastname, ppt.Name
from Person.Person as pp
inner join Person.BusinessEntityAddress as pbea on pbea.BusinessEntityID = pp.BusinessEntityID
inner join Person.Address as pa on pa.AddressID = pbea.AddressID
inner join Sales.Customer as sc on sc.CustomerID = pp.BusinessEntityId
inner join Sales.SalesOrderHeader as ssoh on ssoh.CustomerID = sc.CustomerID
inner join Sales.SalesOrderDetail as ssod on ssod.SalesOrderId = ssoh.SalesOrderID
inner join Production.Product as ppt on ppt.ProductID = ssod.ProductID
where pp.FirstName = 'jimmy' and datepart(month, ssoh.OrderDate) = 6 and month(ssoh.OrderDate) = 6;

--date in sql is always year month day four digit two digit two digit
--usually sql is one base

select pp.firstname, pp.lastname, ppt.Name
from Person.Person as pp
inner join Person.BusinessEntityAddress as pbea on pbea.BusinessEntityID = pp.BusinessEntityID
inner join Person.Address as pa on pa.AddressID = pbea.AddressID
inner join Sales.Customer as sc on sc.CustomerID = pp.BusinessEntityId
inner join
(
    select salesorderid, customerid
    from Sales.SalesOrderHeader
    where datepart(month, OrderDate) = 7
) as ssoh on ssoh.CustomerID = sc.CustomerID
inner join Sales.SalesOrderDetail as ssod on ssod.SalesOrderId = ssoh.SalesOrderID
inner join 
(
    select productid, name
    from Production.Product
    where Name like '%tire%'
) as ppt on ppt.ProductID = ssod.ProductID
where pp.FirstName = 'jimmy';

--common table expression queries, subqueries reducing the amount of join that has to happen during a mulitjoin process


with OrderHeader as 
(
    select salesorderid, customerid
    from Sales.SalesOrderHeader
    where datepart(month, OrderDate) = 7
),
Product as
(
    select productid, name
    from Production.Product
    where Name like '%tire%'
)
select pp.firstname, pp.lastname, ppt.Name
from Person.Person as pp
inner join Person.BusinessEntityAddress as pbea on pbea.BusinessEntityID = pp.BusinessEntityID
inner join Person.Address as pa on pa.AddressID = pbea.AddressID
inner join Sales.Customer as sc on sc.CustomerID = pp.BusinessEntityId
inner join OrderHeader as ssoh on ssoh.CustomerID = pp.BusinessEntityID
inner join Sales.SalesOrderDetail as ssod on ssod.SalesOrderId = ssoh.SalesOrderID
inner join Product as ppt on ppt.ProductID = ssod.ProductID
where pp.FirstName = 'jimmy';


--all first names that are last names

select distinct pp1.firstname, pp2.lastname
from Person.Person as pp1
inner join Person.Person as pp2 on pp2.LastName = pp1.FirstName;


--as union:

select firstname
from Person.Person
union 
select lastname
from Person.Person;

--as intersect

select firstname
from Person.Person
intersect
select lastname
from Person.Person;

--sql profiling is the process in which a query decides how to run, execution plan in TSQL, process of finding how fastest to run a query in database
--three levels of execution plan: fetch, scan, seek
--fetch is process of going thru entire dataset to find the data you need (turning thru every page)
--scan is is process of querying thru referential indexing (looking at appendix)
--seek is process of direct indexing, just one place to find what you're looking for, process of referencing a record thru keys, primary composite or foreign
--join is usually scan
--where clause is usually fetch
--key is subset of indexing, direct reference to record
--primary key: normal form 1
--foreign key: normal form 2+
--compoosite key: multiple columns put together to form a primary key or a foriegn key
--one to one relation, both primary and foreign key to be composite
--in TSQL you can have only up to 999 indexes in a table (don't make a table more than 15 columns)
--clustered index is the process of generating an index that is unique to that record (primary key as example)
--unclustered index, creating a primary key that serves as a reference (foreign key as example) (all associates have the same reference (same foreign key))