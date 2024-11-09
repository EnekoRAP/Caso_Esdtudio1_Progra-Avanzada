-- Crear base de datos
CREATE DATABASE Caso_practico1;
USE Caso_practico1;

-- Crear tabla Curso
CREATE TABLE Curso (
    CursoID INT PRIMARY KEY AUTO_INCREMENT,
    NombreCurso VARCHAR(100) NOT NULL,
    CodigoCurso VARCHAR(10) NOT NULL UNIQUE,
    Descripcion VARCHAR(200) NOT NULL
);

-- Crear tabla Estudiante
CREATE TABLE Estudiante (
    EstudianteID INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    NumeroIdentificacion VARCHAR(20) NOT NULL UNIQUE,
    CursoID INT,
    FOREIGN KEY (CursoID) REFERENCES Curso(CursoID)
);

-- Crear tabla Profesor
CREATE TABLE Profesor (
    ProfesorID INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    Correo VARCHAR(100) NOT NULL UNIQUE,
    CursoID INT,
    FOREIGN KEY (CursoID) REFERENCES Curso(CursoID)
);

-- Insert
-- Insertar registros en la tabla Curso
INSERT INTO Curso (NombreCurso, CodigoCurso, Descripcion) VALUES 
('Estadística', 'MATH101', 'Curso introductorio a la Estadística.'),
('Psicología Social', 'PHYS101', 'Aborda la interacción entre el individuo y el grupo.'),
('Introducción a la Programación', 'CS101', 'Curso básico de programación en Python.'),
('Derecho Penal General', 'DPG101', 'Materia fundamental para la justicia y el orden social.'),
('Química General', 'CHEM101', 'Conceptos fundamentales de la química.');

-- Insertar registros en la tabla Estudiante
INSERT INTO Estudiante (CursoID, Nombre, Apellido, NumeroIdentificacion) VALUES 
('1','Juan', 'Pérez', '212345549'),
('2','Ana', 'Martínez', '623456219'),
('3','Carlos', 'López', '543456774'),
('4','María', 'González', '145067801'),
('5','Luis', 'Ramírez', '745705678');

-- Insertar registros en la tabla Profesor
INSERT INTO Profesor (CursoID, Nombre, Apellido, Correo) VALUES 
('1', 'Laura', 'Jiménez', 'ljimenez@escuela.com'),
('2', 'Pedro', 'Hernández', 'phernandez@escuela.com'),
('3', 'Silvia', 'Ruiz', 'sruiz@escuela.com'),
('4', 'José', 'Mendoza', 'jmendoza@escuela.com'),
('5', 'Raquel', 'Vargas', 'rvargas@escuela.com');