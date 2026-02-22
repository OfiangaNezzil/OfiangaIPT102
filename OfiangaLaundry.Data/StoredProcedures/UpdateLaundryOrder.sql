CREATE PROCEDURE [dbo].[UpdateLaundryOrder]
	 @OrderID NVARCHAR(50),
    @ReceiptNumber NVARCHAR(50),
    @CustomerName NVARCHAR(100),
    @ServiceType NVARCHAR(50),
    @WeightInKg DECIMAL(5,2),
    @TotalPrice DECIMAL(10,2),
    @Status NVARCHAR(50)
AS
BEGIN
    UPDATE LaundryOrder
    SET
        ReceiptNumber = @ReceiptNumber,
        CustomerName = @CustomerName,
        ServiceType = @ServiceType,
        WeightInKg = @WeightInKg,
        TotalPrice = @TotalPrice,
        Status = @Status
    WHERE OrderID = @OrderID;
END;
