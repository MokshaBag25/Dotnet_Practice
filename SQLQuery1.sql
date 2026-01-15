CREATE DATABASE mok123;

USE mok123;

-- 1. Creating the Users Table
CREATE TABLE Users (
    user_id INT PRIMARY KEY,
    username VARCHAR(50) UNIQUE NOT NULL,
    email VARCHAR(255) UNIQUE NOT NULL,
    password_hash VARCHAR(255) NOT NULL,
    created_at DATETIME DEFAULT GETDATE()
);
 
-- 2. Creating the Products Table (No Category dependency)
CREATE TABLE Products (
    product_id INT PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    brand VARCHAR(100),
    price DECIMAL(10, 2) NOT NULL,
    stock_quantity INT DEFAULT 0
);
 
-- 3. Creating the Orders Table
CREATE TABLE Orders (
    order_id INT PRIMARY KEY,
    user_id INT,
    order_date DATETIME DEFAULT GETDATE(),
    total_amount DECIMAL(10, 2),
    status VARCHAR(50),
    FOREIGN KEY (user_id) REFERENCES Users(user_id)
);
 
-- 4. Creating the Order_Items Table (The "Bridge")
CREATE TABLE Order_Items (
    order_item_id INT PRIMARY KEY,
    order_id INT,
    product_id INT,
    quantity INT NOT NULL,
    price_at_purchase DECIMAL(10, 2),
    FOREIGN KEY (order_id) REFERENCES Orders(order_id),
    FOREIGN KEY (product_id) REFERENCES Products(product_id)
);

INSERT INTO Users (user_id, username, email, password_hash) VALUES
(1, 'alex_j', 'alex@email.com', 'hash_1'), (2, 'sarah_m', 'sarah@email.com', 'hash_2'),
(3, 'mike_d', 'mike@email.com', 'hash_3'), (4, 'emily_w', 'emily@email.com', 'hash_4'),
(5, 'john_d', 'john@email.com', 'hash_5'), (6, 'lisa_k', 'lisa@email.com', 'hash_6'),
(7, 'kevin_b', 'kevin@email.com', 'hash_7'), (8, 'anna_s', 'anna@email.com', 'hash_8'),
(9, 'ryan_p', 'ryan@email.com', 'hash_9'), (10, 'clara_z', 'clara@email.com', 'hash_10'),
(11, 'tom_h', 'tom@email.com', 'hash_11'), (12, 'nina_v', 'nina@email.com', 'hash_12'),
(13, 'oscar_f', 'oscar@email.com', 'hash_13'), (14, 'bella_g', 'bella@email.com', 'hash_14'),
(15, 'victor_r', 'victor@email.com', 'hash_15'), (16, 'maya_l', 'maya@email.com', 'hash_16'),
(17, 'ethan_c', 'ethan@email.com', 'hash_17'), (18, 'sophie_t', 'sophie@email.com', 'hash_18'),
(19, 'noah_k', 'noah@email.com', 'hash_19'), (20, 'olivia_p', 'olivia@email.com', 'hash_20');

INSERT INTO Products (product_id, name, brand, price, stock_quantity) VALUES
(101, 'iPhone 15', 'Apple', 999.00, 50), (102, 'Galaxy S23', 'Samsung', 899.00, 45),
(103, 'MacBook Air', 'Apple', 1199.00, 30), (104, 'Surface Pro', 'Microsoft', 950.00, 25),
(105, 'WH-1000XM5', 'Sony', 349.00, 100), (106, 'Pixel 8', 'Google', 699.00, 60),
(107, 'Kindle Paperwhite', 'Amazon', 139.00, 150), (108, 'iPad Pro', 'Apple', 799.00, 40),
(109, 'Nintendo Switch', 'Nintendo', 299.00, 80), (110, 'Xbox Series X', 'Microsoft', 499.00, 20),
(111, 'PS5', 'Sony', 499.00, 15), (112, 'AirPods Pro', 'Apple', 249.00, 200),
(113, 'GoPro Hero 12', 'GoPro', 399.00, 55), (114, 'Monitor 27', 'Dell', 299.00, 35),
(115, 'Mechanical Keyboard', 'Logitech', 129.00, 75), (116, 'Gaming Mouse', 'Razer', 79.00, 120),
(117, 'Smart Watch', 'Fitbit', 199.00, 90), (118, 'External SSD', 'Samsung', 159.00, 110),
(119, 'Bluetooth Speaker', 'JBL', 99.00, 130), (120, 'Webcam 4K', 'Logitech', 199.00, 45);

INSERT INTO Orders (order_id, user_id, total_amount, status) VALUES

(501, 1, 1248.00, 'Shipped'), (502, 2, 899.00, 'Pending'),

(503, 3, 349.00, 'Processing'), (504, 4, 1199.00, 'Delivered'),

(505, 5, 278.00, 'Shipped'), (506, 6, 799.00, 'Processing'),

(507, 7, 499.00, 'Cancelled'), (508, 8, 139.00, 'Delivered'),

(509, 9, 299.00, 'Shipped'), (510, 10, 999.00, 'Pending'),

(511, 1, 199.00, 'Processing'), (512, 11, 499.00, 'Delivered'),

(513, 12, 1048.00, 'Shipped'), (514, 13, 399.00, 'Delivered'),

(515, 14, 129.00, 'Pending'), (516, 15, 79.00, 'Shipped'),

(517, 16, 199.00, 'Processing'), (518, 17, 159.00, 'Delivered'),

(519, 18, 99.00, 'Shipped'), (520, 19, 199.00, 'Delivered');
 
INSERT INTO Order_Items (order_item_id, order_id, product_id, quantity, price_at_purchase) VALUES

(1, 501, 101, 1, 999.00), (2, 501, 112, 1, 249.00),

(3, 502, 102, 1, 899.00), (4, 503, 105, 1, 349.00),

(5, 504, 103, 1, 1199.00), (6, 505, 107, 2, 139.00),

(7, 506, 108, 1, 799.00), (8, 507, 111, 1, 499.00),

(9, 508, 107, 1, 139.00), (10, 509, 109, 1, 299.00),

(11, 510, 101, 1, 999.00), (12, 511, 117, 1, 199.00),

(13, 512, 110, 1, 499.00), (14, 513, 102, 1, 899.00),

(15, 513, 118, 1, 159.00), (16, 514, 113, 1, 399.00),

(17, 515, 115, 1, 129.00), (18, 516, 116, 1, 79.00),

(19, 517, 120, 1, 199.00), (20, 518, 118, 1, 159.00);
 