CREATE PROCEDURE [dbo].[DeleteLaundryOrder]
	@OrderID NVARCHAR(50)
AS
BEGIN
    DELETE FROM LaundryOrder
    WHERE OrderID = @OrderID;
END;
