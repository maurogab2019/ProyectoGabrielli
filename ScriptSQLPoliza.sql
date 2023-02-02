--SCRIP DE CREACION BASE DE DATOS -
--LA BASE DE DATOS ESTA EN UN SERVIDOR AZURE PROPIO POR LO QUE FUNCIONA EN CUALQUIER PC SIN NECESIDAD DE TOCAR NADA

CREATE TABLE PRODUCTO(
IdProducto int identity primary key,
Nombre varchar(50)
)
CREATE TABLE TipoProducto(
IdTipoProducto int identity primary key,
Nombre varchar(50)
)
CREATE TABLE Poliza(
IdPoliza int primary key,
IdProducto int ,
IdTipoProducto int,
Estado varchar(20),
CONSTRAINT fk_producto FOREIGN KEY(IdProducto) references PRODUCTO(IdProducto),
CONSTRAINT fk_tipoProducto FOREIGN KEY(IdTipoProducto) references TipoProducto(IdTipoProducto),
)
CREATE TABLE Asegurados(
IdPoliza int,
IdAsegurado int primary key,
Dni int,
Nombre varchar(30),
FechaNacimiento DATE,
Estado varchar(20),
CONSTRAINT fk_poliza FOREIGN KEY(IdPoliza) REFERENCES Poliza(IdPoliza)
)

-- consultas utilizadas para el proyecto
select * from PRODUCTO
select * from Asegurados

INSERT INTO PRODUCTO  VALUES('Camion')
INSERT INTO PRODUCTO  VALUES('Departamento')
INSERT INTO TipoProducto VALUES('Inmueble')
INSERT INTO Poliza VALUES(4,4,2,'Activa')

INSERT INTO Asegurados(IdPoliza,IdAsegurado,Dni,Nombre,FechaNacimiento,Estado) VALUES(1,8,456555894,'Juana Lopez','1970-10-30','Activo')


select a.IdAsegurado,a.Dni,a.Nombre,a.FechaNacimiento from Asegurados a where IdPoliza = 1 and Estado='Activo'
select po.IdPoliza,po.Estado,p.Nombre as NombreProducto,t.Nombre from Poliza po JOIN PRODUCTO p on(p.IdProducto=po.IdProducto) JOIN TipoProducto t on(t.IdTipoProducto = po.IdTipoProducto)  where IdPoliza = 1
UPDATE Asegurados set Estado='Inactivo' where IdAsegurado=3
UPDATE Asegurados set Estado='Activo' where IdAsegurado=8

UPDATE Asegurados set IdPoliza=1 where IdAsegurado= 8