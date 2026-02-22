CREATE PROCEDURE [dbo].[GetLaundryOrderByReceipt]
	 @ReceiptNumber NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM LaundryOrder
    WHERE ReceiptNumber = @ReceiptNumber;
END;
