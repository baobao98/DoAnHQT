create database RealEstate
go
create function [dbo].[TuDongThemMa](@Type varchar(10))
returns varchar(10)
as
begin
declare @ID varchar(10)
	if(@Type = 'EMP')
				begin
						IF ((SELECT COUNT(id_emp) FROM Employee) = 0)
								SET @ID = '0'
							ELSE
								SELECT @ID = MAX(RIGHT(id_emp, 3)) FROM Employee
				end
	if(@Type = 'CUS')
				begin
						IF ((SELECT COUNT(id_cus) FROM customer) = 0)
								SET @ID = '0'
							ELSE
								SELECT @ID = MAX(RIGHT(id_cus, 3)) FROM customer
				end
	if(@Type = 'AC')
				begin
						IF ((SELECT COUNT(id) FROM account) = 0)
								SET @ID = '0'
							ELSE
								SELECT @ID = MAX(RIGHT(id, 3)) FROM account
				end
	if(@Type = 'PROJ')
				begin
						IF ((SELECT COUNT(id_proj) FROM project) = 0)
								SET @ID = '0'
							ELSE
								SELECT @ID = MAX(RIGHT(id_proj, 3)) FROM project
				end
	if(@Type = 'PROP')
				begin
						IF ((SELECT COUNT(id_prop) FROM property) = 0)
								SET @ID = '0'
							ELSE
								SELECT @ID = MAX(RIGHT(id_prop, 3)) FROM property
				end
	if(@Type = 'TRAN')
				begin
						IF ((SELECT COUNT(id_trans) FROM trannsaction) = 0)
								SET @ID = '0'
							ELSE
								SELECT @ID = MAX(RIGHT(id_trans, 3)) FROM trannsaction
				end
	if(@Type = 'ADV')
				begin
						IF ((SELECT COUNT(id_ad) FROM advertisement) = 0)
								SET @ID = '0'
							ELSE
								SELECT @ID = MAX(RIGHT(id_ad, 3)) FROM advertisement
				end
SELECT @ID = CASE
WHEN @ID >= 0 and @ID < 9 THEN @Type+'00' + CONVERT(varchar, CONVERT(INT, @ID) + 1)
WHEN @ID >= 9 and @ID <99 THEN @Type+'0' + CONVERT(varchar, CONVERT(INT, @ID) + 1)
WHEN @ID >= 99 THEN @Type + CONVERT(varchar, CONVERT(INT, @ID) + 1)
END
			return @ID

end
go
create table typeAccount(
	id int not null IDENTITY(1,1),
	NameOfTypeAcc nvarchar(50),
	primary key(id)
)
go
create table account(
	id varchar(10) primary key constraint id default dbo.TuDongThemMa('AC'),
	nameAcc nvarchar(150),
	type_ac int,
	password varchar(15),
	foreign key(type_ac) references typeAccount(id)
)
go
create table employee(
	id_emp varchar(10)  primary key constraint id_emp default dbo.TuDongThemMa('EMP'),
	name_emp nvarchar(255),
	email_emp varchar(50),
	phone_emp varchar(15),
	birthday date,
	create_date datetime,
	account varchar(10),
	foreign key(account) references account(id)
)
go
create table townRegion(
	id int not null IDENTITY(1,1),
	name nvarchar(150),
	primary key(id)
)
go
create table area(
	id int not null IDENTITY(1,1),
	name nvarchar(50),
	id_town_region int,
	primary key(id),
	foreign key(id_town_region) references townRegion(id)
)
go
create table district(
	id int not null IDENTITY(1,1),
	name nvarchar(150),
	id_area int,
	primary key(id),
	foreign key(id_area) references area(id)
)
go
create table customer(
	id_cus varchar(10) primary key constraint id_cus default dbo.TuDongThemMa('CUS'),
	name_cus nvarchar(255),
	email_cus varchar(50),
	phone_cus varchar(15),
	birthday date,
	create_date datetime
)
go
create table appointment(
	id int not null IDENTITY(1,1),
	description varchar(255),
	status varchar(50),
	id_cus varchar(10),
	primary key(id),
	foreign key(id_cus) references customer(id_cus)
)
go
create table realEstateType(
	id int not null IDENTITY(1,1),
	name nvarchar(255),
	primary key(id)
)
go
create table project(
	id_proj varchar(10) primary key constraint id_proj default dbo.TuDongThemMa('PROJ'),
	name_project nvarchar(255),
	id_real_estate_type int,
	address nvarchar(255),
	license_number varchar(50),
	dateOfIssue date,
	PlaceOfIssue varchar(50),
	foreign key(id_real_estate_type) references realEstateType(id)
)
go
create table advertisement(
	id_ad varchar(10) primary key constraint id_ad default dbo.TuDongThemMa('ADV'),
	name_ad nvarchar(255),
	information text,
	discount varchar(10)
)
go
create table property(
	id_prop varchar(10) primary key constraint id_prop default dbo.TuDongThemMa('PROP'),
	name nvarchar(255),
	id_real_estate_type int,
	id_project varchar(10),
	floor int,
	room int,
	price float,
	create_date datetime,
	id_town_region int,
	id_area int,
	id_district int,
	id_ad varchar(10),
	foreign key(id_real_estate_type) references realEstateType(id),
	foreign key(id_town_region) references townRegion(id),
	foreign key(id_area) references area(id),
	foreign key(id_district) references district(id),
	foreign key(id_ad) references advertisement(id_ad)
)
go
create table trannsaction(
	id_trans varchar(10) primary key constraint id_trans default dbo.TuDongThemMa('TRANS'),
	id_prop varchar(10),
	id_cus varchar(10),
	amount float,
	status varchar(50),
	payment varchar(50),
	foreign key(id_prop) references property(id_prop),
	foreign key(id_cus) references customer(id_cus)
)
go
create table contact(
	id_ct int not null IDENTITY(1,1),
	phone varchar(15),
	status int,
	primary key(id_ct)
)
go
create trigger [dbo].[create_current_date]
on [dbo].[property] after insert
 as
begin 
update property
set create_date=GETDATE()
where property.id_prop in (select id_prop from inserted)
end

go
create trigger [dbo].[create_current_date]
on [dbo].[property] after insert
 as
begin 
update property
set create_date=GETDATE()
where property.id_prop in (select id_prop from inserted)
end
go
create trigger [dbo].[create_current_date_customer]
on [dbo].[customer] after insert
 as
begin 
update customer
set create_date=GETDATE()
where customer.id_cus in (select id_cus from inserted)
end
go
create trigger [dbo].[create_current_date_employee]
on [dbo].[employee] after insert
 as
begin 
update employee
set create_date=GETDATE()
where employee.id_emp in (select id_emp from inserted)
end
go