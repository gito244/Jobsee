CREATE DATABASE Empleos
GO
USE Empleos
GO
--DROP DATABASE Empleos
CREATE TABLE Empresa
(
	nEmpresaId INT PRIMARY KEY IDENTITY(1,1),
	cNombre VARCHAR(300),
	cDescripcion VARCHAR(MAX),
	cUrlWeb VARCHAR(300),
	cUrlLinkedin VARCHAR(300),
	bActivo BIT
)
GO
CREATE TABLE Modalidad
(
	nModalidadId INT PRIMARY KEY IDENTITY(1,1),
	cDescripcion VARCHAR(300),
	bActivo BIT
)
GO
INSERT INTO Modalidad(cDescripcion,bActivo)
VALUES 
('Remoto', 1),
('Híbrido', 1),
('No definido', 1)
GO
CREATE TABLE Nivel
(
	nNivelId INT PRIMARY KEY IDENTITY(1,1),
	cDescripcion VARCHAR(300),
	bActivo BIT
)
GO
INSERT INTO Nivel(cDescripcion,bActivo)
VALUES ('Trainer', 1),
('Traenee', 1),
('Junior', 1),
('Semi Senior', 1),
('Senior', 1),
('Principal', 1)
GO
CREATE TABLE Moneda
(
	nMonedaId INT PRIMARY KEY IDENTITY(1,1),
	cDescripcion VARCHAR(300),
	bActivo BIT
)
GO
INSERT INTO Moneda(cDescripcion,bActivo)
VALUES ('Soles', 1),
('Dólares', 1),
('Euros', 1)
GO
CREATE TABLE PortalEmpleo
(
	nPortalEmpleoId INT PRIMARY KEY IDENTITY(1,1),
	cDescripcion VARCHAR(300),
	cUrl VARCHAR(500),
	dFechaCreacion DATETIME,
	cUsuarioCreacion VARCHAR(100),
	dFechaActualización DATETIME,
	cUsuarioActualizacion VARCHAR(100),
	bActivo BIT
)
GO
INSERT INTO PortalEmpleo(cDescripcion,cUrl,bActivo,dFechaCreacion,cUsuarioCreacion)
VALUES ('Getonbrd', 'https://www.getonbrd.com/', 1, GETDATE(), 'SIST'),
('Linkedin','', 1, GETDATE(), 'SIST'),
('Indeed', '', 1, GETDATE(), 'SIST'),
('Computrabajo', '', 1, GETDATE(), 'SIST'),
('Bumeran', '', 1, GETDATE(), 'SIST'),
('Glassdoor', '', 1, GETDATE(), 'SIST'),
('BuscoJobs', '', 1, GETDATE(), 'SIST'),
('Torre', '', 1, GETDATE(), 'SIST')
GO
CREATE TABLE Empleo
(
	nEmpleoId INT PRIMARY KEY IDENTITY(1,1),
	nEmpresaId INT,
	nModalidadId INT,
	nNivelId INT,
	nMonedaId INT,
	nPortalEmpleoId INT,
	dFechaProceso DATETIME,
	dFechaPublicacion DATETIME,
	cTitulo VARCHAR(300),
	cDescripcion VARCHAR(MAX),
	cFunciones VARCHAR(MAX),
	cRequerimientos VARCHAR(MAX),
	cOpcionales VARCHAR(MAX),
	cBeneficios VARCHAR(MAX),
	cNacionalidad VARCHAR(300),
	cRangoSalarial VARCHAR(100),
	cHerramientas VARCHAR(500),
	cTeconologias VARCHAR(MAX),
	cUrl VARCHAR(500),
	dFechaCreacion DATETIME,
	cUsuarioCreacion VARCHAR(100),
	dFechaActualización DATETIME,
	cUsuarioActualizacion VARCHAR(100),
	bActivo BIT,

	CONSTRAINT PK_Empleo_Empresa FOREIGN KEY (nEmpresaId) REFERENCES Empresa(nEmpresaId),
	CONSTRAINT PK_Empleo_Modalidad FOREIGN KEY (nModalidadId) REFERENCES Modalidad(nModalidadId),
	CONSTRAINT PK_Empleo_Nivel FOREIGN KEY (nNivelId) REFERENCES Nivel(nNivelId),
	CONSTRAINT PK_Empleo_Moneda FOREIGN KEY (nMonedaId) REFERENCES Moneda(nMonedaId),
	CONSTRAINT PK_Empleo_PortalEmpleo FOREIGN KEY (nPortalEmpleoId) REFERENCES PortalEmpleo(nPortalEmpleoId)
)
GO
--14	dFechaAct	Fecha del Sistema	datetime	2024-09-21	1	3	1
CREATE TABLE Constante
(
	nConstanteId INT PRIMARY KEY IDENTITY(1,1),
	nConstanteValor INT NOT NULL,
	cVariable VARCHAR(300),
	cDescripcion VARCHAR(300),
	cTipoVariable VARCHAR(100),
	cValVar VARCHAR(300),
	dFechaCreacion DATETIME,
	cUsuarioCreacion VARCHAR(100),
	dFechaActualización DATETIME,
	cUsuarioActualizacion VARCHAR(100),
	bActivo	BIT
)
GO
CREATE TABLE ProcesoScapping
(
	nProcesoScappingId INT PRIMARY KEY IDENTITY(1,1),
	nPortalEmpleoId INT,
	cUrlDinamica VARCHAR(200),
	dFechaCreacion DATETIME,
	cUsuarioCreacion VARCHAR(100),
	dFechaActualización DATETIME,
	cUsuarioActualizacion VARCHAR(100),
	bActivo BIT,

	CONSTRAINT FK_ProcesoScapping_PortalEmpleo FOREIGN KEY (nPortalEmpleoId) REFERENCES PortalEmpleo(nPortalEmpleoId)
)
GO
INSERT INTO ProcesoScapping (cUrlDinamica,nPortalEmpleoId,bActivo,dFechaCreacion,cUsuarioCreacion)
VALUES ('empleos-net', 1, 1, GETDATE(), 'SIST')
GO
CREATE TABLE LogProcesoScapping
(
	cLogProcesoScappingId VARCHAR(200),
	nEmpleoId INT,
	dFecha DATETIME,
	cDescripcion VARCHAR(MAX),
	bProcesado BIT,

	CONSTRAINT PK_LogProcesoScapping PRIMARY KEY (cLogProcesoScappingId,nEmpleoId),
	CONSTRAINT FK_LogProcesoScapping_Empleo FOREIGN KEY (nEmpleoId) REFERENCES Empleo(nEmpleoId)
)
GO
CREATE TABLE ProcesoScappingError
(
	nProcesoScappingErrorId INT PRIMARY KEY IDENTITY(1,1),
	cLogProcesoScappingId VARCHAR(200),
	nEmpleoId INT,
	dFecha DATETIME,
	cDescripcion VARCHAR(MAX),
	bActivo BIT,

	CONSTRAINT FK_ProcesoScappingError_LogProcesoScapping FOREIGN KEY (cLogProcesoScappingId,nEmpleoId) REFERENCES LogProcesoScapping(cLogProcesoScappingId,nEmpleoId)
)