CREATE PROCEDURE [dbo].[GetLaundryOrderById]
	@OrderID NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM LaundryOrder
    WHERE OrderID = @OrderID;
END;
