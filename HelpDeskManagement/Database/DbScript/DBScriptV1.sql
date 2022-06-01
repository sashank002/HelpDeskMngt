CREATE TABLE UserMst (
    Id int primary key identity(1,1),
    UserName nvarchar(255) not null,
	Email nvarchar(255) not null,
	[Address] nvarchar(255),
	Contact nvarchar(255),
	Passwrod nvarchar(255),
	HintQue nvarchar(255),
	HintAns nvarchar(255),
	UserTypeId int not null
);