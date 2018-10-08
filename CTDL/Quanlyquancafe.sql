CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO
--Food
--TableFood
--FoodCategory
--Account
--Bill
--Billinfo

CREATE TABLE TableFood
(
	id INT IDENTITY PRIMARY KEY,
	name nvarchar(100) NOT NULL DEFAULT N'Bàn chưa đặt tên',
	status nvarchar(100) NOT NULL DEFAULT N'Trống'		--Trống || Đầy
)
GO

CREATE TABLE Account
(
	UserName nvarchar(100) PRIMARY KEY,
	DisplayName nvarchar(100) NOT NULL,
	PassWord nvarchar(1000) NOT NULL DEFAULT 0,
	TYPE INT NOT NULL DEFAULT 0	-- 1: Admin && 0: staff
)
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name nvarchar(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name nvarchar(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0

	FOREIGN KEY (idCategory) REFERENCES FoodCategory(id)

)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	status INT NOT NULL	DEFAULT 0		-- 1: đã thanh toán && 0: chưa thanh toán

	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE Billinfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY (idBill) REFERENCES Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id),

)
GO
