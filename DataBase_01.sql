CREATE DATABASE GestorUsuario_db;
USE GestorUsuario_db;

-- Tabla de roles
CREATE TABLE Roles (
    IdRol INT PRIMARY KEY IDENTITY(1,1),
    NombreRol NVARCHAR(50) NOT NULL UNIQUE
);

-- Tabla de usuarios
CREATE TABLE Usuarios (
    IdUsuario INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Correo NVARCHAR(100) NOT NULL UNIQUE,
    pwd NVARCHAR(256) NOT NULL,
    IdRol INT NOT NULL,
    FOREIGN KEY (IdRol) REFERENCES Roles(IdRol)
);

-- Tabla de empleados (datos cargados desde CSV)
CREATE TABLE Empleados (
    IdEmpleado INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Cargo NVARCHAR(100) NOT NULL,
    Salario DECIMAL(10,2) NULL,
    Correo NVARCHAR(100) NULL
);

GO
CREATE VIEW Vista_Empleados_UsuarioComun AS
SELECT Nombre, Cargo
FROM Empleados;
GO

-- Vista para administradores (todos los campos)
CREATE VIEW Vista_Empleados_Administrador AS
SELECT Nombre, Cargo, Salario, Correo
FROM Empleados;
GO

-- Insertar roles base
INSERT INTO Roles (NombreRol) VALUES ('Administrador'), ('UsuarioComun');

-- Ejemplo de inserción de usuario con contraseña hasheada (SHA256)
-- En la app, se debe hashear antes de insertar
INSERT INTO Usuarios (Nombre, Correo, pwd, IdRol)
VALUES ('Ana Torres', 'ana@example.com', 'E3AFED0047B08059D0FADA10F400C1E5', 1); -- SHA256 de '123456'

-- Ejemplo de empleado cargado desde CSV
INSERT INTO Empleados (Nombre, Cargo, Salario, Correo)
VALUES ('Carlos Ruiz', 'Contador', 4500000, 'carlos.ruiz@empresa.com');

--
GO
CREATE PROCEDURE VerEmpleadosPorRol
    @IdUsuario INT
AS
BEGIN
    DECLARE @Rol NVARCHAR(50);

    -- Obtener el rol del usuario
    SELECT @Rol = R.NombreRol
    FROM Usuarios U
    INNER JOIN Roles R ON U.IdRol = R.IdRol
    WHERE U.IdUsuario = @IdUsuario;

    -- Mostrar vista según el rol
    IF @Rol = 'Administrador'
    BEGIN
        SELECT * FROM Vista_Empleados_Administrador;
    END
    ELSE IF @Rol = 'UsuarioComun'
    BEGIN
        SELECT * FROM Vista_Empleados_UsuarioComun;
    END
    ELSE
    BEGIN
        RAISERROR('Rol no reconocido o usuario inválido.', 16, 1);
    END
END;
GO

