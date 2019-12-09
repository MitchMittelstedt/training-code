use master;
go

-- create

create database PizzaBox;
go

use PizzaBox;
go


--three files created: .mdf (master data file saved in xml format, database doing serialization for us), .ldf(log data file, keeping track of changes made to database, can be many), .ndf (none master data file, replicates more datafiles for the database to save more information while keeping datafiles small) 
--schemas in SQL are namespaces in C#: case insensitive, accent sensitive, collation, we are using Latin languages, UTF8 unica type font 8 supporting all languages in the world spoken

create schema [Order];
go

create schema Account;
go 

create schema Pizza;
go


create table Account.Account
(
    AccountId int not null identity(1,2),
    Username nvarchar(50),
    Password nvarchar(50)
)
alter table Account.Account
    add constraint PK_Account_AccountId primary key (AccountId);


create table Account.Address
(
    AddressId int not null identity(1,2),
    Address nvarchar(100)
)
alter table Account.Address
    add constraint PK_Address_AddressId primary key (AddressId);


create table Pizza.Crust
(
    CrustId int not null identity(1,2),
    Crust nvarchar(50)
);
alter table Pizza.Crust
    add constraint PK_Crust_CrustId primary key (CrustId);


create table Pizza.Size
(
    SizeId int not null identity(1,2),
    Size nvarchar(50),
);
alter table Pizza.Size
    add constraint PK_Size_SizeId primary key (SizeId);


create table Pizza.Topping
(
    ToppingId int not null identity(1,2),
    Topping nvarchar(50)
)
alter table Pizza.Topping
    add constraint PK_Topping_ToppingId primary key (ToppingId);


create table Account.Location  
(
    LocationId int not null identity(1,2),
    AccountId int not null,
    AddressId int not null
)
alter table Account.Location
    add constraint PK_Location_LocationId primary key (LocationId);
alter table Account.Location
    add constraint FK_Location_AccountId foreign key (AccountId) references Account.Account(AccountId);
alter table Account.Location
    add constraint FK_Location_AddressId foreign key (AddressId) references Account.Address(AddressId);


create table Account.[User]
(
    UserId int not null identity(1,2),
    AccountId int not null,
    AddressId int not null
);
alter table Account.[User]
    add constraint PK_User_UserId primary key (UserId);
alter table Account.[User]
    add constraint FK_User_AddressId foreign key (AddressId) references Account.Address(AddressId);
alter table Account.[User]
    add constraint FK_User_AccountId foreign key (AccountId) references Account.Account(AccountId);


create table [Order].[Order]

(    
    OrderId int not null identity(1,2), --first normal form, primary key
    UserId int not null, --foreign key references Account.User.Id -second normal form, foreign key
    LocationId int not null, --foreign key
    TotalCost decimal(5,2) not null,
    OrderDate datetime2(7) not null, --computed
    --constraint PX_Order_OrderId primary key (OrderId)
    --constraint FK_Order_UserId foreign key UserId references Account.User(UserId)
);
alter table [Order].[Order]
    add constraint PK_Order_OrderId primary key (OrderId);
alter table [Order].[Order]
    add constraint FK_Order_UserId foreign key (UserId) references Account.[User](UserId);
alter table [Order].[Order]
    add constraint FK_Order_LocationId foreign key (LocationId) references Account.Location(LocationId);


create table [Order].Pizza
(
    PizzaId int not null identity(1,2),
    SizeId int not null,
    CrustId int not null,
    Price decimal(4,2) not null,
    --Active bit not null --default
);
alter table [Order].[Pizza]
    add constraint PK_Pizza_PizzaId primary key (PizzaId);
alter table [Order].Pizza
    add constraint FK_Pizza_SizeId foreign key (SizeId) references Pizza.Size(SizeId);
alter table [Order].Pizza
    add constraint FK_Pizza_CrustId foreign key (CrustId) references Pizza.Crust(CrustId);


create table [Order].[OrderPizza]
(
    OrderPizzaId int not null identity(1,2),
    OrderId int not null,
    PizzaId int not null
);
alter table [Order].[OrderPizza]
    add constraint PK_OrderPizza_OrderPizzaId primary key (OrderPizzaId);
alter table [Order].[OrderPizza]
    add constraint FK_OrderPizza_OrderId foreign key (OrderId) references [Order].[Order](OrderId);
alter table [Order].[OrderPizza]
    add constraint FK_OrderPizza_PizzaId foreign key (PizzaId) references [Order].[Pizza](PizzaId);


create table Pizza.PizzaTopping
(
    PizzaToppingId int not null identity(1,2),
    PizzaId int not null,
    ToppingId int not null
)
alter table Pizza.PizzaTopping
    add constraint PK_PizzaTopping_PizzaToppingId primary key (PizzaToppingId);
alter table Pizza.PizzaTopping
    add constraint FK_PizzaTopping_PizzaId foreign key (PizzaId) references [Order].Pizza(PizzaId);
alter table Pizza.PizzaTopping
    add constraint FK_Pizza_ToppingId foreign key (ToppingId) references Pizza.Topping(ToppingId);


drop table [Order].OrderPizza
go

drop table Pizza.PizzaTopping
go

drop table [Order].Pizza;
go

drop table Pizza.Crust
go

drop table Pizza.[Size]
go

drop table [Order].[Order];
go

drop database Pizzabox




--alter



































--sequence allow column to generate its own value based on some logic
--identity is a sequence in TSQL, allowing us to auto-increment
--in other SQL it's just a sequence

--session-wide sequence means it will auto-increment as long as session is alive
--database-wide sequence: cross section, it goes up till the end

--drop means get rid of structure, delete records and strucutre of records
--drop table [Order].[OrderPizza];

--truncate returns brand new table with that same structure
--truncate table [Order].[OrderPizza];

--view, function, store procedure: three constructs available in sql to allow repeatability in a structured way
--view is a structured query that gives you the ability to read information: readonly query
--function, scalar, tabular:
    --scalar is a view with parameters for readonly data, returning on value not record, view with parameters
    --tabular is similar to a view, difference being that a function allows for parameters and arguments, returning record set, a view also with parameters
--function should not contain logic, or it should be minimal, reason that function should be injected as part of query
--function needs to be lightweight, because it is used by a query
--function should have stored procedure, logical workflow of a function that is repeatable 
--stored procedure can use view, functions, queries within its logical workflow
--stored procedure in SQL is an exact match for a method in C#

