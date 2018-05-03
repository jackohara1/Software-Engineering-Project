

CREATE TABLE Customer(
Customer_ID numeric(4) NOT NULL,
Forename char(10) NOT NULL,
Surname char(10) NOT NULL,
Addressln1 char(30) NOT NULL,
Addressln2 char(30) NOT NULL,
Addressln3 char(30) NULL,
PRIMARY KEY (Customer_ID)
);

CREATE TABLE Department(
Department_ID numeric(1) NOT NULL,
Department_Name varchar2(10) NOT NULL,  
PRIMARY KEY (Department_ID)
);

CREATE TABLE Stock(
Stock_ID numeric(4) NOT NULL,
Stock_Name varchar2 (30) NOT NULL,
Qty numeric (4) NOT NULL,
Cost_P decimal(6,2) NOT NULL,
Sale_P decimal(6,2) NOT NULL,
Status varchar2 (1) NOT NULL, 
Department_ID numeric(1) NOT NULL,
PRIMARY KEY (Stock_ID),
FOREIGN KEY (Department_ID) REFERENCES Department(Department_ID)
);

CREATE TABLE Sale(
Sale_ID numeric(6) NOT NULL ,
Sale_Date Date NOT NULL,
Status varchar2 (1) NOT NULL,
Customer_ID numeric(4) NULL,
Sale_Value decimal(6,2) NULL,
PRIMARY KEY (Sale_ID),
FOREIGN KEY (Customer_ID) REFERENCES Customer(Customer_ID)
);

CREATE TABLE SaleItems(
QtySold numeric(3) NOT NULL,
Price decimal (4,2) NOT NULL,  
Sale_ID numeric(6) NOT NULL,
Stock_ID numeric (3)    NOT NULL,
FOREIGN KEY (Stock_ID) REFERENCES Stock(Stock_ID),
FOREIGN KEY (Sale_ID) REFERENCES Sale(Sale_ID)
);


INSERT INTO department
VALUES (05, 'Hardware');

INSERT INTO department
VALUES (01, 'Plumbing');

INSERT INTO department
VALUES (02, 'Tools');

INSERT INTO department
VALUES (03, 'Household');

INSERT INTO department
VALUES (04, 'Electrical');

INSERT INTO Customer
VALUES (1, 'JACK', 'O HARA', 'DIRTANE' , 'BALLYHEIU', 'KERRY');

INSERT INTO Customer
VALUES (2, 'JACK', 'TEAHAN', 'AHIDOE' , 'KILLARNEY', 'KERRY');

INSERT INTO Customer
VALUES (3, 'JARED', 'O SHEA', 'AVENUE' , 'KILLAR', 'KERRY');

INSERT INTO Customer
VALUES (4, 'DAVID', 'HERLIHY', 'PETRALROAD' , 'RATHMORE', 'CORK');

INSERT INTO Customer
VALUES (5, 'MARK', 'O DOUNIGHUE', 'BRENDANS' , 'TRALEE', 'KERRY');

INSERT INTO Customer
VALUES (6, 'CONOR', 'O BRIAN', 'CITY CENTRE' , 'LIMERICK CITY', 'LIMERICK');

INSERT INTO Customer
VALUES (7, 'KEVIN', 'MOSK', 'PARK' , 'TALLAH', 'DUBLIN');

INSERT INTO Stock
VALUES (1, 'Hammer', 70, 12.30 , 27.00, 'A', 02);

INSERT INTO Stock
VALUES (2, 'Screw Driver', 50, 7.95 , 15.00, 'A', 02);

INSERT INTO Stock
VALUES (3, 'drill', 20, 25.69 , 55.00, 'A', 02);