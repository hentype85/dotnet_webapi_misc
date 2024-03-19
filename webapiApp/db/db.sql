-- crear la base de datos solo si no existe
CREATE DATABASE IF NOT EXISTS MiBaseDeDatos;

-- seleccionar la base de datos
USE MiBaseDeDatos;

-- crear una tabla de ejemplo llamada 'Usuarios' solo si no existe
CREATE TABLE IF NOT EXISTS Usuarios (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    Edad INT
);

-- insertar datos en la tabla Usuarios
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Juan', 'Pérez', 25);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('María', 'Gómez', 30);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Carlos', 'Rodríguez', 22);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Laura', 'Fernández', 28);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Juan', 'Pérez', 25);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('María', 'Gómez', 30);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Carlos', 'Rodríguez', 22);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Laura', 'Fernández', 28);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Pedro', 'Martínez', 26);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Ana', 'López', 29);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Diego', 'Ramírez', 27);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Sofía', 'Hernández', 31);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Luis', 'Gutiérrez', 32);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Isabel', 'Díaz', 24);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Alejandro', 'González', 35);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Valentina', 'Jiménez', 33);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Lucas', 'Torres', 26);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Camila', 'Cruz', 30);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Mateo', 'Vargas', 28);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Mariana', 'Molina', 29);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Daniel', 'Castillo', 31);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Catalina', 'Ruiz', 27);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('David', 'Ortega', 28);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Elena', 'Sánchez', 30);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Hugo', 'Flores', 32);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Renata', 'Herrera', 26);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Javier', 'Moreno', 29);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Carolina', 'Aguilar', 34);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Francisco', 'Reyes', 31);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Paula', 'Lara', 27);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Andrés', 'Gallego', 29);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Gabriela', 'Ríos', 30);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Raúl', 'Ochoa', 33);
INSERT INTO Usuarios (Nombre, Apellido, Edad) VALUES ('Isabella', 'Silva', 28);
