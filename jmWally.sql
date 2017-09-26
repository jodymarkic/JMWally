--
-- FILENAME: JmWally.sql
-- PROJECT: JMWally
-- PROGRAMMER: Jody Markic
-- FIRST VERSION : 2016-12-08
-- DESCRIPTION: this file holds sql scripts to create the databse JMwally,
-- along with its tables
--
DROP SCHEMA IF EXISTS JMWally;
CREATE DATABASE JMWally;
USE JMWally;

CREATE TABLE customer
(
	Customer_ID BIGINT NOT NULL AUTO_INCREMENT,
    First_Name VARCHAR(50),
    Last_Name VARCHAR(50),
    Telephone VARCHAR(10),
	PRIMARY KEY (Customer_ID)
);

CREATE TABLE branch
(
	Branch_ID BIGINT NOT NULL AUTO_INCREMENT,
    Branch_Name VARCHAR(50),
    PRIMARY KEY (Branch_ID)
);

CREATE TABLE product
(
	Product_ID BIGINT NOT NULL AUTO_INCREMENT,
	Product_Name VARCHAR(50),
    Price FLOAT,
    Quantity INTEGER,
    PRIMARY KEY (Product_ID)
);

CREATE TABLE orders
(
	Order_ID BIGINT NOT NULL AUTO_INCREMENT,
    Customer_ID BIGINT NOT NULL,
    Branch_ID BIGINT NOT NULL,
    Order_Date TIMESTAMP,
    Status_ID CHAR(4),
    PRIMARY KEY (Order_ID),
    FOREIGN KEY (Customer_ID) REFERENCES customer(Customer_ID),
    FOREIGN KEY (Branch_ID) REFERENCES branch(Branch_ID)
);

CREATE TABLE orderline (
    Order_ID BIGINT NOT NULL,
    Product_ID BIGINT NOT NULL,
    Order_Quantity INTEGER,
    FOREIGN KEY (Order_ID)
        REFERENCES orders (Order_ID),
    FOREIGN KEY (Product_ID)
        REFERENCES product (Product_ID)
);

INSERT INTO customer (First_Name, Last_Name, Telephone)
VALUES ('Norbert', 'Mika', '4165551111'),
	   ('Russell', 'Foubert', '5195552222'),
       ('Sean', 'Clarke', '5195553333');
       
       
INSERT INTO branch (Branch_Name)
VALUES ('Sports World'),
	   ('Cambridge Mall'),
       ('St.Jacobs');
	
    
INSERT INTO product (Product_Name, Price, Quantity)
VALUES ('Disco Queen Wallpaper (roll)', 12.95, 56),
	   ('Countryside Wallpaper (roll)', 11.95, 24),
       ('Victorian Lace Wallpaper (roll)', 14.95, 44),
       ('Drywall Tape (roll)', 3.95, 120),
       ('Drywall Tape (pkg 10)', 36.95, 30),
       ('Drywall Repair Compound (tube)', 6.95, 90);


INSERT INTO orders (Customer_ID, Branch_ID, Order_Date, Status_ID)
VALUES (3, 1, '2016-09-20', 'PAID'),
		(2, 2, '2016-10-06', 'CNCL'),
        (1, 3, '2016-11-04', 'RFND');
        
INSERT INTO orderline (Order_ID, Product_ID, Order_Quantity)
VALUES (1, 3, 4),
	   (1, 6, 1),
       (1, 4, 2);
       


SELECT * FROM product;
SELECT * FROM orderline;
SELECT * FROM orders;