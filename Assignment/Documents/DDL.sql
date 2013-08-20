-- DROP DATABASE WEBAssignment
CREATE DATABASE WEBAssignment
GO
USE WEBAssignment
GO
-- DROP TABLE Product
CREATE TABLE Product (
	id int PRIMARY KEY IDENTITY,
	name varchar(256) NOT NULL,
	alias varchar(256) NOT NULL UNIQUE,
	old_price money,
	price money NOT NULL,
	description text,
	number_in_stock int CHECK (number_in_stock >= 0),
	properties text, -- JSON
	publish bit DEFAULT 1,
	created datetime NOT NULL DEFAULT GETDATE(),
	modified timestamp
)
GO
-- DROP TABLE CategoryParent
CREATE TABLE CategoryParent (
	id int PRIMARY KEY IDENTITY,
	name varchar(256) NOT NULL,
	alias varchar(256) NOT NULL UNIQUE,
	publish bit DEFAULT 1,
	created datetime NOT NULL DEFAULT GETDATE(),
	modified timestamp
)
GO
-- DROP TABLE Category
CREATE TABLE Category (
	id int PRIMARY KEY IDENTITY,
	name varchar(256) NOT NULL,
	alias varchar(256) NOT NULL UNIQUE,
	categoryParent_id int NOT NULL REFERENCES CategoryParent(id),
	publish bit DEFAULT 1,
	created datetime NOT NULL DEFAULT GETDATE(),
	modified timestamp,
	CONSTRAINT unCategory UNIQUE (id, categoryParent_id),
)
GO 
-- DROP TABLE CategoryDetail
CREATE TABLE CategoryDetail (
	id int PRIMARY KEY IDENTITY,
	product_id int NOT NULL REFERENCES Product(id),
	category_id int NOT NULL,
	categoryParent_id int NOT NULL,
	CONSTRAINT unCategoryDetail UNIQUE (product_id, categoryParent_id),
	CONSTRAINT fkCategoryDetail_Category FOREIGN KEY (category_id, categoryParent_id) REFERENCES Category(id, categoryParent_id)
)
GO
-- DROP TABLE Contact
CREATE TABLE Contact (
	id int PRIMARY KEY IDENTITY,
	email varchar(64) NOT NULL,
	fullname varchar(64) NOT NULL,
	telephone varchar(16) NOT NULL,
	address text, -- JSON
	publish bit DEFAULT 1,
	created datetime NOT NULL DEFAULT GETDATE(),
	modified timestamp
)
GO
-- DROP TABLE [Order]
CREATE TABLE [Order] (
	id int PRIMARY KEY IDENTITY,
	order_contact_id int NOT NULL REFERENCES Contact(id),
	receiver_email varchar(64),
	receiver_fullname varchar(64),
	receiver_telephone varchar(16),
	receiver_address text NOT NULL, -- JSON
--	company bit DEFAULT 0,
--	company_name varchar(256),
--	company_address text, -- JSON
--	company_taxcode varchar(256),
--	creditcard bit DEFAULT 0,
--	creditcard_name varchar(256),
--	creditcard_no varchar(32),
--	creditcard_expired date,
--	creditcard_ccv varchar(8),
	[status] int NOT NULL CHECK ([status] IN (1, 2, 3)) DEFAULT 1, -- 1: pending; 2: confirmed, 3: done
	created datetime NOT NULL DEFAULT GETDATE(),
	modified timestamp
)
GO
-- DROP TABLE OrderDetail
CREATE TABLE OrderDetail (
	id int PRIMARY KEY IDENTITY,
	order_id int NOT NULL REFERENCES [Order](id),
	product_id int NOT NULL REFERENCES Product(id),
	CONSTRAINT unOrderDetail UNIQUE(order_id, product_id),
	number int NOT NULL CHECK (number > 0)
)

SELECT * FROM [Order]
SELECT * FROM Contact