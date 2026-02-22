CREATE TABLE [dbo].[LaundryOrder]
(
    OrderID NVARCHAR(50) PRIMARY KEY,
    ReceiptNumber NVARCHAR(50) NOT NULL UNIQUE,
    CustomerName NVARCHAR(100) NOT NULL,
    ServiceType NVARCHAR(50) NOT NULL,
    WeightInKg DECIMAL(5,2) NOT NULL,
    TotalPrice DECIMAL(10,2) NOT NULL,
    Status NVARCHAR(50) NOT NULL
);
