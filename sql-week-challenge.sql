CREATE TABLE ProductsEx(
	ID INT IDENTITY (1,1) PRIMARY KEY NOT NULL ,
	Name NVARCHAR(255) NOT NULL,
	Price DECIMAL(10, 2) NOT NULL
);
CREATE TABLE CustomersEx(
	ID INT NOT NULL PRIMARY KEY IDENTITY (1, 1),
	FirstName NVARCHAR(255) NOT NULL,
	LastName NVARCHAR(255) NOT NULL,
	CardNumber INT NOT NULL
);
CREATE TABLE OrdersEx(
	ID INT NOT NULL PRIMARY KEY IDENTITY (1,1),
	ProductID INT FOREIGN KEY REFERENCES ProductsEx(ID),
	CustomerID INT FOREIGN KEY REFERENCES CustomersEx(ID),
);
INSERT INTO ProductsEx(Name, Price)
VALUES ('iPhone' , 200.00);
INSERT INTO ProductsEx(Name, Price)
VALUES ('Samsung Galaxy', 1100.00);
INSERT INTO ProductsEx(Name, Price)
VALUES ('One Plus 7', 1800.00);

INSERT INTO CustomersEx (FirstName, LastName, CardNumber)
VALUES ('John', 'Doe', 123456789);
INSERT INTO CustomersEx (FirstName, LastName, CardNumber)
VALUES ('Jane', 'Doe', 987654321);
INSERT INTO CustomersEx (FirstName, LastName, CardNumber)
VALUES ('Wilfred', 'Brimley', 147258369);
INSERT INTO CustomersEx (FirstName, LastName, CardNumber)
VALUES ('Tina', 'Smith', 369852147);

select * from CustomersEx full join ProductsEx on CustomersEx.ID = CustomersEx.ID;

Insert Into OrdersEx(ProductID, CustomerID)
Values (