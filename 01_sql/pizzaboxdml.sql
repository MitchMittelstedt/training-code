use PizzaBox;
go


select *
from Account.Account;
go

select *
from Account.Address;
go

select *
from Account.Location;
go

select *
from Account.[User];
go

select *
from Pizza.Topping;
go

select *
from [Order].Pizza
go

select *
from Pizza.Size
go

select *
from Pizza.Crust
go

select *
from Pizza.Topping
go

select *
from Pizza.PizzaTopping
go

select *
from [Order].[Order]
go

select *
from [Order].OrderPizza
go

insert into Account.Account
values ('Mitch', 'password');
go
insert into Account.Account
values ('PizzaHat', 'password');
go

insert into Account.Address
values ('123 S Beefheart Ave.');
go
insert into Account.Address
values ('456 N Doc Dr.');
go

insert into Account.[Location]
values (3, 3);
go

insert into Account.[User]
values (1, 1);
go

insert into Pizza.Crust
values ('thin crust')
go
insert into Pizza.Crust
values ('deep dish')
go

insert into Pizza.Topping
values ('pepperoni');
go
insert into Pizza.Topping
values ('mushrooms');
go
insert into Pizza.Topping
values ('peppers');
go
insert into Pizza.Topping
values ('black olives');
go
insert into Pizza.Topping
values ('bison');
go

insert into Pizza.Size
values (10);
go
insert into Pizza.Size
values (12);
go
insert into Pizza.Size
values (14);
go
insert into Pizza.Size
values (16);
go

insert into [Order].Pizza
values (3, 1, 10.00)
go
insert into [Order].Pizza
values (3, 1, 10.50)
go

insert into Pizza.PizzaTopping
values (3, 1)