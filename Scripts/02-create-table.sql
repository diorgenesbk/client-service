USE ClientDb;
CREATE TABLE User(
	UserID INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    UserName VARCHAR(20) NOT NULL,
    Password VARCHAR(30) NOT NULL,
	AccessKey VARCHAR(32) NOT NULL	
);


CREATE TABLE Person(
	PersonId INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Cpf VARCHAR(11) NOT NULL,
    Name VARCHAR (50) NOT NULL
);

CREATE TABLE Adress(
	AdressId INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    PersonId INT NOT NULL,
    Country VARCHAR(50),
    State VARCHAR(50),
    City VARCHAR(50),
    District VARCHAR(50),
    Street VARCHAR(50),
    PostCode VARCHAR(8),
    Number INT,
    FOREIGN KEY (PersonId) REFERENCES Person (PersonId)
);

CREATE TABLE Debt(
	DebtId INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    PersonId INT NOT NULL,
    Value DECIMAL(10,2),
    Description VARCHAR(50),
    FOREIGN KEY (PersonId) REFERENCES Person (PersonId)
);


