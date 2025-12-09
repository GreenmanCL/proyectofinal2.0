create database if not exists Proyecto;
use Proyecto;
CREATE TABLE pasteleria (
    id INT AUTO_INCREMENT PRIMARY KEY,
    producto VARCHAR(100) NOT NULL,
    precio DECIMAL(10,2) NOT NULL,
    cantidad INT NOT NULL,
    total DECIMAL(10,2) AS (precio * cantidad) STORED
);


CREATE TABLE empleados (
    id INT AUTO_INCREMENT PRIMARY KEY,
    codigo INT NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    puesto VARCHAR(100) NOT NULL,
    fecha_nac DATE NOT NULL,
    sexo VARCHAR(20) NOT NULL,
    estado VARCHAR(50) NOT NULL,
    foto VARCHAR(255)
);




