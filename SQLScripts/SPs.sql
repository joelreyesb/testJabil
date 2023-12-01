CREATE PROCEDURE sp_InsertBuilding
    @Building VARCHAR(255)
AS
BEGIN
    INSERT INTO Buildings (Building) VALUES (@Building);
END;
GO


CREATE PROCEDURE sp_InsertCustomers
	@Customer VARCHAR(255),
	@Prefix VARCHAR(5),
	@FKBuilding INT
AS
BEGIN
	INSERT INTO Customers (
		Customer,
		Prefix,
		FKBuilding)
	VALUES (
		@Customer,
		@Prefix,
		@FKBuilding);
END;
GO

CREATE PROCEDURE sp_InsertPartNumbers
	@PartNumber VARCHAR (50),
	@FKCustomer INT,
	@Available BIT
AS
BEGIN
	INSERT INTO PartNumbers (
		PartNumber,
		FKCustomer,
		Available)
	VALUES (
		@PartNumber,
		@FKCustomer,
		@Available);
END;
GO

CREATE PROCEDURE sp_SearchPartNumber
	@Param VARCHAR(255)
AS
BEGIN
	SELECT p.PartNumber, p.Available, c.Customer, b.Building
	FROM PartNumbers as p
	JOIN Customers as c ON p.FKCustomer = c.PKCustomers
	JOIN Buildings as b ON b.Building = c.FKBuilding
	WHERE p.PartNumber = @Param OR c.Customer = @Param;
END;
GO

exec sp_SearchPartNumber @Param = 'ssdas'