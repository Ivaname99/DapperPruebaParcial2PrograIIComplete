CREATE DATABASE Parcial02
GO

USE Parcial02
GO

CREATE TABLE Productos(
Id INT PRIMARY KEY NOT NULL,
Nombre VARCHAR(100) NOT NULL,
Descripcion VARCHAR(100) NOT NULL,
Precio DECIMAL(10,2) NOT NULL,
Stock INT NOT NULL,
Marca VARCHAR(50) NOT NULL,
Categoria VARCHAR(50) NOT NULL
);
GO

INSERT INTO Productos (Id, Nombre, Descripcion, Precio, Stock, Marca, Categoria)
VALUES 
(1, 'Laptop Gaming', 'Laptop de alto rendimiento para gamers', 1200.99, 15, 'Asus', 'Electr�nica'),
(2, 'Tel�fono Inteligente', 'Tel�fono con c�mara de alta resoluci�n', 799.50, 30, 'Samsung', 'Electr�nica'),
(3, 'Auriculares Bluetooth', 'Auriculares inal�mbricos con cancelaci�n de ruido', 150.00, 50, 'Sony', 'Accesorios'),
(4, 'Teclado Mec�nico', 'Teclado mec�nico retroiluminado para gamers', 120.00, 20, 'Razer', 'Accesorios'),
(5, 'Monitor 4K', 'Monitor Ultra HD de 27 pulgadas', 450.75, 10, 'LG', 'Electr�nica'),
(6, 'C�mara DSLR', 'C�mara profesional con lentes intercambiables', 800.00, 12, 'Canon', 'Fotograf�a'),
(7, 'Impresora Inal�mbrica', 'Impresora multifuncional con conectividad Wi-Fi', 200.00, 25, 'HP', 'Oficina'),
(8, 'Smartwatch', 'Reloj inteligente con seguimiento de actividad', 199.99, 40, 'Apple', 'Electr�nica'),
(9, 'Mochila para Laptop', 'Mochila resistente con compartimento para laptop', 45.00, 35, 'Targus', 'Accesorios'),
(10, 'SSD 1TB', 'Unidad de estado s�lido de 1TB', 100.00, 60, 'Crucial', 'Almacenamiento'),
(11, 'Router Wi-Fi', 'Router con doble banda para alta velocidad', 80.00, 22, 'Netgear', 'Redes'),
(12, 'Cargador Solar', 'Cargador port�til alimentado por energ�a solar', 50.00, 15, 'Anker', 'Accesorios'),
(13, 'Altavoces Bluetooth', 'Altavoces port�tiles con sonido envolvente', 130.00, 18, 'JBL', 'Audio'),
(14, 'Laptop Ultraligera', 'Laptop liviana ideal para estudiantes', 950.00, 20, 'Dell', 'Electr�nica'),
(15, 'C�mara de Seguridad', 'C�mara de vigilancia con visi�n nocturna', 120.00, 10, 'Arlo', 'Seguridad');
GO