-- ========================================================
-- BASE DE DATOS COMANDATO
-- ========================================================
CREATE DATABASE BDComandato;
GO
USE BDComandato;
GO

-- ========================================================
-- TABLA DE CLIENTES
-- ========================================================
CREATE TABLE Clientes (
    IdCliente INT IDENTITY(1,1) PRIMARY KEY,
    Cedula VARCHAR(10) UNIQUE NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,
    Direccion NVARCHAR(200),
    Telefono VARCHAR(20),
    FechaRegistro DATETIME DEFAULT GETDATE()
);

-- ========================================================
-- TABLA DE VENTAS
-- ========================================================
CREATE TABLE Ventas (
    IdVenta INT IDENTITY(1,1) PRIMARY KEY,
    IdCliente INT NOT NULL,
    Fecha DATETIME DEFAULT GETDATE(),
    Total DECIMAL(10,2),
    FOREIGN KEY (IdCliente) REFERENCES Clientes(IdCliente)
);

-- ========================================================
-- TABLA DE CRÉDITOS
-- ========================================================
CREATE TABLE Creditos (
    IdCredito INT IDENTITY(1,1) PRIMARY KEY,
    IdCliente INT NOT NULL,
    Monto DECIMAL(10,2) NOT NULL,
    PlazoMeses INT NOT NULL,
    Estado VARCHAR(20) DEFAULT 'Pendiente',
    FechaSolicitud DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (IdCliente) REFERENCES Clientes(IdCliente)
);

-- ========================================================
-- TABLA DE PAGOS (COBRANZAS)
-- ========================================================
CREATE TABLE Pagos (
    IdPago INT IDENTITY(1,1) PRIMARY KEY,
    IdCredito INT NOT NULL,
    MontoPagado DECIMAL(10,2),
    FechaPago DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (IdCredito) REFERENCES Creditos(IdCredito)
);

-- ========================================================
-- PROCEDIMIENTO: Insertar cliente
-- ========================================================
CREATE PROCEDURE sp_InsertarCliente
    @Cedula VARCHAR(10),
    @Nombre NVARCHAR(100),
    @Direccion NVARCHAR(200),
    @Telefono VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM Clientes WHERE Cedula = @Cedula)
    BEGIN
        RAISERROR('El cliente ya existe.', 16, 1);
        RETURN;
    END;

    INSERT INTO Clientes (Cedula, Nombre, Direccion, Telefono)
    VALUES (@Cedula, @Nombre, @Direccion, @Telefono);
END;
GO

-- ========================================================
-- PROCEDIMIENTO: Insertar venta
-- ========================================================
CREATE PROCEDURE sp_InsertarVenta
    @IdCliente INT,
    @Total DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM Clientes WHERE IdCliente = @IdCliente)
    BEGIN
        RAISERROR('El cliente no existe.', 16, 1);
        RETURN;
    END;

    INSERT INTO Ventas (IdCliente, Total)
    VALUES (@IdCliente, @Total);
END;
GO

-- ========================================================
-- PROCEDIMIENTO: Insertar crédito
-- ========================================================
CREATE PROCEDURE sp_InsertarCredito
    @IdCliente INT,
    @Monto DECIMAL(10,2),
    @PlazoMeses INT
AS
BEGIN
    SET NOCOUNT ON;
    IF NOT EXISTS (SELECT 1 FROM Clientes WHERE IdCliente = @IdCliente)
    BEGIN
        RAISERROR('El cliente no existe.', 16, 1);
        RETURN;
    END;

    INSERT INTO Creditos (IdCliente, Monto, PlazoMeses)
    VALUES (@IdCliente, @Monto, @PlazoMeses);
END;
GO

-- ========================================================
-- PROCEDIMIENTO: Registrar pago (cobranza)
-- ========================================================
CREATE PROCEDURE sp_RegistrarPago
    @IdCredito INT,
    @MontoPagado DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM Creditos WHERE IdCredito = @IdCredito)
    BEGIN
        RAISERROR('El crédito no existe.', 16, 1);
        RETURN;
    END;

    INSERT INTO Pagos (IdCredito, MontoPagado) VALUES (@IdCredito, @MontoPagado);

    DECLARE @TotalPagado DECIMAL(10,2) = (SELECT SUM(MontoPagado) FROM Pagos WHERE IdCredito = @IdCredito);
    DECLARE @MontoCredito DECIMAL(10,2) = (SELECT Monto FROM Creditos WHERE IdCredito = @IdCredito);

    IF @TotalPagado >= @MontoCredito
        UPDATE Creditos SET Estado = 'Cancelado' WHERE IdCredito = @IdCredito;
END;
GO
