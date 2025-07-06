CREATE DATABASE SalesMarketingDB;
GO
USE SalesMarketingDB;
GO

-- Customers table
CREATE TABLE Customers (
    CustomerId INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Email NVARCHAR(100),
    City NVARCHAR(50)
);

-- Products table
CREATE TABLE Products (
    ProductId INT PRIMARY KEY IDENTITY,
    ProductName NVARCHAR(100),
    Category NVARCHAR(50),
    Price DECIMAL(10,2)
);

-- Sales table
CREATE TABLE Sales (
    SaleId INT PRIMARY KEY IDENTITY,
    CustomerId INT,
    ProductId INT,
    SaleDate DATE,
    Quantity INT,
    TotalAmount DECIMAL(10,2),
    FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId),
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
);

-- Marketing Campaigns table
CREATE TABLE Campaigns (
    CampaignId INT PRIMARY KEY IDENTITY,
    CampaignName NVARCHAR(100),
    StartDate DATE,
    EndDate DATE,
    Budget DECIMAL(12,2)
);

-- Sample data for Customers
INSERT INTO Customers (Name, Email, City) VALUES
('Alice Smith', 'alice@example.com', 'New York'),
('Bob Johnson', 'bob@example.com', 'Los Angeles'),
('Carol Lee', 'carol@example.com', 'Chicago');

-- Sample data for Products
INSERT INTO Products (ProductName, Category, Price) VALUES
('Laptop', 'Electronics', 1200.00),
('Smartphone', 'Electronics', 800.00),
('Desk Chair', 'Furniture', 150.00);

-- Sample data for Sales
INSERT INTO Sales (CustomerId, ProductId, SaleDate, Quantity, TotalAmount) VALUES
(1, 1, '2025-06-01', 1, 1200.00),
(2, 2, '2025-06-02', 2, 1600.00),
(3, 3, '2025-06-03', 3, 450.00);

-- Sample data for Campaigns
INSERT INTO Campaigns (CampaignName, StartDate, EndDate, Budget) VALUES
('Summer Sale', '2025-06-01', '2025-06-30', 5000.00),
('Back to School', '2025-08-01', '2025-08-31', 3000.00);
