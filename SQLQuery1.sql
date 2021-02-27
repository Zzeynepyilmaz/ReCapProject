CREATE TABLE Colors(
	Id int PRIMARY KEY IDENTITY(1,1),
	[Name] nvarchar(25),
)

CREATE TABLE Brands(
	Id int PRIMARY KEY IDENTITY(1,1),
	[Name] nvarchar(25),
)

CREATE TABLE Cars(
	Id int PRIMARY KEY IDENTITY(1,1),
	BrandId int,
	ColorId int,
	DailyPrice decimal,
	ModelYear int,
	Descriptions nvarchar(50),
	FOREIGN KEY (ColorId) REFERENCES Brands(Id),
	FOREIGN KEY (BrandId) REFERENCES Colors(Id)

)

CREATE TABLE Users(
	Id int PRIMARY KEY IDENTITY(1,1),
	FirstName nvarchar(50),
	LastName nvarchar(50),
	Email nvarchar(50),
	Password nvarchar(50)
)

CREATE TABLE Customers(
	Id int PRIMARY KEY IDENTITY(1,1),
	UserId int,
	CompanyName nvarchar(50),
	FOREIGN KEY (UserId) REFERENCES Users(Id)
)


CREATE TABLE Rentals(
	Id int PRIMARY KEY IDENTITY(1,1),
	CarId int,
	CustomerId int,
	RentDate datetime,
	ReturnDate datetime,
	FOREIGN KEY (CarId) REFERENCES Cars(Id),
	FOREIGN KEY (CustomerId) REFERENCES Customers(Id)
)

CREATE TABLE CarImages(
    Id int PRIMARY KEY IDENTITY(1,1),
	CarId int,
	ImagePath nvarchar(50),
	Date datetime,
	FOREIGN KEY (CarId) REFERENCES Cars(Id),

)


INSERT INTO Car(BrandId,ColorId,ModelYear,DailyPrice,Descriptions)
VALUES
	('1','1','2016','180','Araç km sınırı 750 kmdir'),
	('2','2','2010','150','Araç km sınırı 900 kmdir'),
	('3','3','2010','145','Araç km sınırı 800 kmdir'),
	('4','4','2018','200','Araç km sınırı 600 kmdir');


INSERT INTO Color
VALUES
	('Siyah'),
	('Beyaz'),
	('Gri'),
	('Mavi'),
	('Kırmızı');


INSERT INTO Brand
VALUES
	('Fiat'),
	('Hundai'),
	('Renault'),
	('Mercedes');

