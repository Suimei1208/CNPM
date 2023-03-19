create database ticketmachine
CREATE TABLE destination (
  id varchar(50) PRIMARY KEY,
  name VARCHAR(255),
  cost int
);

CREATE TABLE ticket (
  id_ticket varchar(50) PRIMARY KEY,
  name VARCHAR(255),
  cost int,
  payment VARCHAR(50),
  destination varchar(50)
);

INSERT INTO destination
VALUES ('1', 'Ho Chi Minh city', 10),
       ('2', 'Ha Noi', 150),
       ('3', 'Binh Duong', 20);

select * from ticket
