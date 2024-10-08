-- Table for Customers
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(100),
    Email VARCHAR(100) UNIQUE,
    PhoneNumber VARCHAR(20)
);

-- Table for Merchants
CREATE TABLE Merchants (
    MerchantID INT PRIMARY KEY AUTO_INCREMENT,
    MerchantName VARCHAR(100),
    ContactEmail VARCHAR(100),
    ContactPhone VARCHAR(20)
);

-- Table for Transactions
CREATE TABLE Transactions (
    TransactionID INT PRIMARY KEY AUTO_INCREMENT,
    CustomerID INT,
    MerchantID INT,
    TransactionAmount DECIMAL(10, 2),
    TransactionDate DATETIME,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (MerchantID) REFERENCES Merchants(MerchantID)
);
