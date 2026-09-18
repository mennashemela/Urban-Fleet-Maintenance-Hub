/* =========================================================
   TransportDB — Urban Fleet & Maintenance Hub
   Schema built from the exact SQL queries used by the app
   (TransportDB_GUI), cross-checked against the project's
   original ER diagram (see docs/er-diagram.png) for
   attributes the current UI doesn't touch directly
   (Depot.location, Spare_Part.serial_number/unit_cost,
   Inspection.result).
   ========================================================= */

IF DB_ID('TransportDB') IS NULL
BEGIN
    CREATE DATABASE TransportDB;
END
GO

USE TransportDB;
GO

-- ============ DEPOT ============
CREATE TABLE Depot (
    depot_id    INT IDENTITY(1,1) PRIMARY KEY,
    name        NVARCHAR(100) NOT NULL,
    location    NVARCHAR(150) NULL
);
GO

-- ============ VEHICLE ============
CREATE TABLE Vehicle (
    vehicle_id  INT IDENTITY(1,1) PRIMARY KEY,
    model       NVARCHAR(100) NOT NULL,
    fuel_type   NVARCHAR(50)  NOT NULL,
    capacity    INT           NOT NULL,
    status      NVARCHAR(50)  NOT NULL
);
GO

-- ============ MECHANIC ============
CREATE TABLE Mechanic (
    mechanic_id     INT IDENTITY(1,1) PRIMARY KEY,
    full_name       NVARCHAR(100) NOT NULL,
    specialization  NVARCHAR(100) NOT NULL,
    depot_id        INT NOT NULL
        REFERENCES Depot(depot_id)
);
GO

-- ============ MAINTENANCE_LOG ============
CREATE TABLE Maintenance_Log (
    log_id              INT IDENTITY(1,1) PRIMARY KEY,
    vehicle_id          INT NOT NULL REFERENCES Vehicle(vehicle_id),
    mechanic_id         INT NOT NULL REFERENCES Mechanic(mechanic_id),
    depot_id            INT NOT NULL REFERENCES Depot(depot_id),
    issue_description   NVARCHAR(255) NOT NULL,
    open_date           DATE NOT NULL,
    close_date          DATE NULL
);
GO

-- ============ SPARE_PART ============
CREATE TABLE Spare_Part (
    part_id         INT IDENTITY(1,1) PRIMARY KEY,
    name            NVARCHAR(100) NOT NULL,
    serial_number   NVARCHAR(50) NULL,
    unit_cost       DECIMAL(10,2) NULL,
    depot_id        INT NOT NULL REFERENCES Depot(depot_id)
);
GO

-- ============ LOG_PART (junction: Maintenance_Log <-> Spare_Part) ============
CREATE TABLE Log_Part (
    log_id      INT NOT NULL REFERENCES Maintenance_Log(log_id),
    part_id     INT NOT NULL REFERENCES Spare_Part(part_id),
    qty_part    INT NOT NULL,
    total_cost  DECIMAL(10,2) NOT NULL,
    PRIMARY KEY (log_id, part_id)
);
GO

-- ============ INSPECTION ============
CREATE TABLE Inspection (
    inspection_id       INT IDENTITY(1,1) PRIMARY KEY,
    vehicle_id          INT NOT NULL REFERENCES Vehicle(vehicle_id),
    inspection_date      DATE NOT NULL,
    result               NVARCHAR(100) NULL
);
GO
