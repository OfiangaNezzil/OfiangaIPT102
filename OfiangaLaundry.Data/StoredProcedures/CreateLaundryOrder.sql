CREATE PROCEDURE [dbo].[CreateLaundryOrder]
	@OrderID NVARCHAR(50),
    @ReceiptNumber NVARCHAR(50),
    @CustomerName NVARCHAR(100),
    @ServiceType NVARCHAR(50),
    @WeightInKg DECIMAL(5,2),
    @TotalPrice DECIMAL(10,2),
    @Status NVARCHAR(50)
AS
BEGIN
    INSERT INTO LaundryOrder
    VALUES (
        @OrderID,
        @ReceiptNumber,
        @CustomerName,
        @ServiceType,
        @WeightInKg,
        @TotalPrice,
        @Status
    );
END;
