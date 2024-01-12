Create database OrderManagement;
use orderManagement;

//tablee
CREATE TABLE userr (
userid int primary key identity,
username varchar(25),
password varchar(25),
role varchar(25)
);



CREATE TABLE product (
productid int primary key identity,
productname varchar(25),
description varchar(25),
price decimal(10,2),
quantityinstock int,
type varchar(25)
);


create table orders(
orderid int primary key identity,
userid int,
productid int,
quantity int,
price decimal,
FOREIGN KEY (userid) REFERENCES userr(userid) on delete cascade,
FOREIGN KEY (productid) REFERENCES product(productid) on delete cascade);







