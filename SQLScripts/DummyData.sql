-- Dummy data para la tabla Buildings
INSERT INTO Buildings (Building) VALUES 
('Edificio A'),
('Edificio B'),
('Edificio C');

-- Dummy data para la tabla Customers
INSERT INTO Customers (Customer, Prefix, FKBuilding) VALUES
('Cliente 1', 'ABC', 1),
('Cliente 2', 'DEF', 2),
('Cliente 3', 'GHI', 3);

-- Dummy data para la tabla PartNumbers
INSERT INTO PartNumbers (PartNumber, FKCustomer, Available) VALUES
('Parte 001', 1, 1),
('Parte 002', 2, 0),
('Parte 003', 3, 1);