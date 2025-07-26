CREATE PROCEDURE GetCustomersByEmail
    @Email NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Customers WHERE Email = @Email;
END;
GO

CREATE INDEX IX_Customers_Email ON Customers(Email);
GO
