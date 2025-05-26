/* ============================================================*/
/*   Database name:  AEROUNED                                   */
/*   DBMS name:      Microsoft SQL Server 7.x                  */
/*   Created on:     20/06/2024  07:00 PM                      */
/*   Generada Por:   Tutor Marlon Dixon Gomez              */
/* =========================================================== */
Create database GAMES4U2
go


USE [GAMES4U2]
GO


CREATE TABLE Administrador(
	Identificacion numeric(11, 0) NOT NULL,
	Nombre varchar(40) NOT NULL,
	PrimerApellido varchar(40) NOT NULL,
	SegundoApellido varchar(40) NOT NULL,
	FechaNacimiento datetime2(7) NOT NULL,
	FechaContratacion datetime2(7) NOT NULL,
 CONSTRAINT PK_Administrador PRIMARY KEY (Identificacion)
)

CREATE TABLE Cliente(
	Identificacion numeric(11, 0) NOT NULL,
	Nombre nvarchar(40) NOT NULL,
	PrimerApellido nvarchar(40) NOT NULL,
	SegundoApellido nvarchar(40) NOT NULL,
	FechaNacimiento datetime2(7) NOT NULL,
	JugadorEnLinea bit NOT NULL,
 CONSTRAINT PK_Cliente PRIMARY KEY (Identificacion)
)

CREATE TABLE Reserva(
	Id numeric(11, 0) IDENTITY(1,1) NOT NULL,
	Id_Tienda numeric(4, 0) NOT NULL,
	Id_Videojuego numeric(11, 0) NOT NULL,
	Id_Cliente numeric(11, 0) NOT NULL,
	FechaReserva datetime2(7) NOT NULL,
	Cantidad numeric(4, 0) NOT NULL,
 CONSTRAINT PK_Reserva PRIMARY KEY (Id)
)

CREATE TABLE Tienda(
	Id numeric(4, 0) IDENTITY(1,1) NOT NULL,
	Nombre nvarchar(40) NOT NULL,
	Id_Administrador numeric(11, 0) NOT NULL,
	Direccion nvarchar(40) NOT NULL,
	Telefono varchar(12) NOT NULL,
	Activa bit NOT NULL,
 CONSTRAINT PK_Tienda PRIMARY KEY (Id)
)

CREATE TABLE TipoVideojuego(
	Id numeric(4, 0) IDENTITY(1,1) NOT NULL,
	Nombre nvarchar(40) NOT NULL,
	Descripcion nvarchar(80) NOT NULL,
 CONSTRAINT PK_TipoVideojuego PRIMARY KEY (Id)
)

CREATE TABLE Videojuego(
	Id numeric(11, 0) IDENTITY(1,1) NOT NULL,
	Nombre nvarchar(40) NOT NULL,
	Id_TipoVideojuego numeric(4, 0) NOT NULL,
	Desarrollador nvarchar(80) NOT NULL,
	Lanzamiento numeric(4, 0) NOT NULL,
	Fisico bit NOT NULL,
 CONSTRAINT PK_Videojuego PRIMARY KEY (Id)
)

CREATE TABLE VideojuegosXTienda(
	Id_Tienda numeric(4, 0) NOT NULL,
	Id_Videojuego numeric(11, 0) NOT NULL,
	Existencias numeric(4, 0) NOT NULL,
 CONSTRAINT PK_VideojuegosXTienda PRIMARY KEY (Id_Tienda, Id_Videojuego)
)

ALTER TABLE Reserva  WITH CHECK ADD  CONSTRAINT FK_Reserva_Cliente FOREIGN KEY(Id_Cliente)
REFERENCES Cliente (Identificacion)

ALTER TABLE Reserva CHECK CONSTRAINT FK_Reserva_Cliente

ALTER TABLE Reserva  WITH CHECK ADD  CONSTRAINT FK_Reserva_Tienda FOREIGN KEY(Id_Tienda)
REFERENCES Tienda (Id)

ALTER TABLE Reserva CHECK CONSTRAINT FK_Reserva_Tienda

ALTER TABLE Reserva  WITH CHECK ADD  CONSTRAINT FK_Reserva_Videojuego FOREIGN KEY(Id_Videojuego)
REFERENCES Videojuego (Id)

ALTER TABLE Reserva CHECK CONSTRAINT FK_Reserva_Videojuego

ALTER TABLE Tienda  WITH CHECK ADD  CONSTRAINT FK_Tienda_Administrador FOREIGN KEY(Id_Administrador)
REFERENCES Administrador (Identificacion)

ALTER TABLE Tienda CHECK CONSTRAINT FK_Tienda_Administrador

ALTER TABLE Videojuego  WITH CHECK ADD  CONSTRAINT FK_Videojuego_TipoVideojuego FOREIGN KEY(Id_TipoVideojuego)
REFERENCES TipoVideojuego (Id)

ALTER TABLE Videojuego CHECK CONSTRAINT FK_Videojuego_TipoVideojuego

ALTER TABLE VideojuegosXTienda  WITH CHECK ADD  CONSTRAINT FK_VideojuegosXTienda_Tienda FOREIGN KEY(Id_Tienda)
REFERENCES Tienda (Id)

ALTER TABLE VideojuegosXTienda CHECK CONSTRAINT FK_VideojuegosXTienda_Tienda

ALTER TABLE VideojuegosXTienda  WITH CHECK ADD  CONSTRAINT FK_VideojuegosXTienda_Videojuego FOREIGN KEY(Id_Videojuego)
REFERENCES Videojuego (Id)

ALTER TABLE VideojuegosXTienda CHECK CONSTRAINT FK_VideojuegosXTienda_Videojuego