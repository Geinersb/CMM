USE [master]
GO

create database db_cmm
go

use db_cmm
go



create table historico
(
	id_historico int identity(1,1) primary key,
	id_departamento int,
	id_proceso int,
	accion varchar(100),
	fecha datetime,
	id_empleado int
)
go







--Creacion de tabla PROCESOS
 create table procesos
	(
		id_proceso int identity(1,1) primary key,
		nombre varchar(50),
		descripcion varchar(50) not null,
		id_departamento int,
		id_nivel int,
		inicial varchar(100),
		repetible varchar(100),
		definido varchar(100),
		gestionado varchar(100),
		optimizado varchar(100),
		id_empleado int,
		fecha_creacion datetime,
		estado int  --estado 1 'activo' estado 0 'archivado'

	)
go

--Creacion tabla de niveles
create table niveles
(
	id_nivel int primary key,
	descripcion varchar(50) not null,

)
go

--creatacion table Departamento
create table Departamentos
(
	id_departamento int identity(1,1) primary key,
	nombre varchar(50) not null,
	codigo varchar(50) not null
)
go


--Creacion de la tabla de Puestos
create table perfil
(
  id_perfil int identity(1,1) primary key,
  nombre varchar(50),
  
)
go


--creacion Tabla Auditorias
create table auditorias
(
	
	id_auditoria int identity(1,1) primary key,
	id_empleado int not null,
	id_departamento int not null,
	id_proceso int not null,
	hallasgoz01 varchar(256) not null,
	recomendaciones varchar(256) not null,
	fecha_limite datetime, 
	fecha_auditoria datetime	
) 
go





create table Empleados
(
	id_empleado int identity(1,1) primary key not null,
	nombre varchar(50) not null,
	apellido1 varchar(50) not null,
	apellido2 varchar(50) not null,
	cedula varchar(50) not null,
    telefono varchar(20) not null,
    correo varchar(20) not null,
	usuario varchar(20) not null,
	pass varchar(20) not null,
	id_perfil int not null,
	id_departamento int not null,

)
go

--Creacion de procedimientos 
 

 
CREATE PROCEDURE [dbo].[CONSULTAEMPLEADOPERFIL]
as
SELECT E.nombre, E.apellido1,E.apellido2,E.usuario,E.pass ,P.nombre
FROM Empleados AS E
JOIN perfil AS P
ON E.id_perfil = P.id_perfil
WHERE usuario = E.usuario AND pass = E.pass
GO

 
CREATE PROCEDURE [dbo].[CONSULTA_EMPLEADOS]
(
       @id_empleado INT
      ,@nombre VARCHAR(50)
      ,@apellido1 VARCHAR(50)
      ,@apellido2 VARCHAR(50)
      ,@cedula VARCHAR(50)
      ,@telefono VARCHAR(50)
      ,@correo VARCHAR(20)
      ,@usuario VARCHAR(20)
      ,@pass VARCHAR(20)
      ,@id_perfil INT
      ,@id_departamento INT
)
AS
BEGIN 
SELECT [id_empleado]
      ,[nombre]
      ,[apellido1]
      ,[apellido2]
      ,[cedula]
      ,[telefono]
      ,[correo]
      ,[usuario]
      ,[pass]
      ,[id_perfil]
      ,[id_departamento]
  FROM [dbo].[Empleados]
  END
  go


CREATE PROCEDURE [dbo].[SP_FILTRAR_Departamentos]
(
@nombre varchar(50)
)
as
begin
SELECT E.id_departamento, E.nombre, E.codigo
FROM Departamentos AS E
WHERE e.nombre LIKE '%'+@Nombre+'%' or LEN(ISNULL(@nombre, '')) = 0
END
GO


CREATE PROCEDURE [dbo].[SP_FILTRAR_EMPLEADOS]
(
@nombre varchar(50)
)
as
begin
SELECT E.id_empleado, E.nombre, E.apellido1,E.apellido2,E.cedula,E.telefono,E.correo,E.usuario,E.pass ,P.nombre as Perfil, D.nombre as Departamento
FROM Empleados AS E
INNER JOIN perfil AS P ON E.id_perfil = P.id_perfil 
INNER JOIN Departamentos as D on e.id_empleado = D.id_departamento
WHERE e.nombre LIKE '%'+@Nombre+'%' or LEN(ISNULL(@nombre, '')) = 0

END
GO

CREATE PROCEDURE [dbo].[sp_INSERTAR_DEPARTAMENTOS]

@nombre varchar(50),
@codigo varchar(50)


as insert into Departamentos(nombre,codigo)
values (@nombre,@codigo)
GO
 



CREATE PROCEDURE [dbo].[sp_insertar_empleados]

@nombre varchar(50),
@apellido1 varchar(50),
@apellido2 varchar(50),
@cedula varchar(50),
@telefono varchar(20),
@correo varchar(50),
@usuario varchar(20),
@pass varchar(20),
@perfil int,
@departamento int
AS
BEGIN
insert into Empleados(nombre,apellido1,apellido2,cedula,telefono,correo,usuario,pass,id_perfil,id_departamento)
values (@nombre,@apellido1,@apellido2,@cedula,@telefono,@correo,@usuario,@pass,@perfil,@departamento)
END
GO
-------



CREATE PROCEDURE [dbo].[sp_login]
@usuario varchar(20),
@pass varchar(20)

AS
BEGIN

SELECT * FROM  Empleados 
WHERE usuario = @usuario AND pass = @pass

END
GO

-----
CREATE PROCEDURE [dbo].[SP_MODIFICAR_DEPARTAMENTOS] 
(
@id_departamento int,
@nombre varchar(50),
@codigo varchar(50)
)
AS
BEGIN
UPDATE [dbo].[Departamentos]
   SET [nombre] = @nombre
      ,[codigo] = @codigo
 WHERE id_departamento = @id_departamento
 END

GO















--Creacion de Llaves foraneas/relaciones entre tablas.

alter table procesos
add constraint FK_empleado_proceso
foreign key (id_empleado) references empleados(id_empleado)
on update cascade
on delete cascade
go


alter table procesos
add constraint FK_nivel_proceso
foreign key (id_nivel) references niveles(id_nivel)
on update cascade
on delete cascade
go



alter table empleados
add constraint FK_detalle_puesto_empleado
foreign key (id_perfil) references perfil(id_perfil)
on update cascade
on delete cascade
go

alter table empleados
add constraint FK_detalle_departamento
foreign key (id_departamento) references departamentos(id_departamento)
on update cascade
on delete cascade
go

alter table auditorias
add constraint FK_detalle_proceso
foreign key (id_proceso) references procesos(id_proceso)
on update cascade
on delete cascade
go

--inserts

INSERT INTO [dbo].[perfil]
           ([nombre])
     VALUES
           ('Administrador')
GO

INSERT INTO [dbo].[perfil]
           ([nombre])
     VALUES
           ('Auditor')
GO

INSERT INTO [dbo].[perfil]
           ([nombre])
     VALUES
           ('Usuario')
GO


INSERT INTO [dbo].[Departamentos]
           ([nombre]
           ,[codigo])
     VALUES
           ('Soporte','SPT')
GO



INSERT INTO [dbo].[Departamentos]
           ([nombre]
           ,[codigo])
     VALUES
           ('Auditoria',
           'ADT')
GO



exec dbo.sp_insertar_empleados 'Juan','Jimenez','Perez','402525874','84759658','cavaal93@gmail.com','juan','juan00',2,2


