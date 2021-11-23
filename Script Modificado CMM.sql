USE [db_cmm]
GO
/****** Object:  Table [dbo].[auditorias]    Script Date: 22/11/2021 09:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[auditorias](
	[id_auditoria] [int] IDENTITY(1,1) NOT NULL,
	[id_empleado] [int] NOT NULL,
	[id_departamento] [int] NOT NULL,
	[id_proceso] [int] NOT NULL,
	[hallasgoz01] [varchar](256) NOT NULL,
	[recomendaciones] [varchar](256) NOT NULL,
	[fecha_limite] [datetime] NULL,
	[fecha_auditoria] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_auditoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 22/11/2021 09:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamentos](
	[id_departamento] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[codigo] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_departamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 22/11/2021 09:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[id_empleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido1] [varchar](50) NOT NULL,
	[apellido2] [varchar](50) NOT NULL,
	[cedula] [varchar](50) NOT NULL,
	[telefono] [varchar](20) NOT NULL,
	[correo] [varchar](20) NOT NULL,
	[usuario] [varchar](20) NOT NULL,
	[pass] [varchar](20) NOT NULL,
	[id_perfil] [int] NOT NULL,
	[id_departamento] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[historico]    Script Date: 22/11/2021 09:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[historico](
	[id_historico] [int] IDENTITY(1,1) NOT NULL,
	[id_departamento] [int] NULL,
	[id_proceso] [int] NULL,
	[accion] [varchar](100) NULL,
	[fecha] [datetime] NULL,
	[id_empleado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_historico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[niveles]    Script Date: 22/11/2021 09:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[niveles](
	[id_nivel] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_nivel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[perfil]    Script Date: 22/11/2021 09:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[perfil](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[procesos]    Script Date: 22/11/2021 09:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[procesos](
	[id_proceso] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](50) NOT NULL,
	[id_departamento] [int] NULL,
	[id_nivel] [int] NULL,
	[inicial] [varchar](100) NULL,
	[repetible] [varchar](100) NULL,
	[definido] [varchar](100) NULL,
	[gestionado] [varchar](100) NULL,
	[optimizado] [varchar](100) NULL,
	[id_empleado] [int] NULL,
	[fecha_creacion] [datetime] NULL,
	[estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_proceso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[auditorias]  WITH CHECK ADD  CONSTRAINT [FK_detalle_proceso] FOREIGN KEY([id_proceso])
REFERENCES [dbo].[procesos] ([id_proceso])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[auditorias] CHECK CONSTRAINT [FK_detalle_proceso]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_detalle_departamento] FOREIGN KEY([id_departamento])
REFERENCES [dbo].[Departamentos] ([id_departamento])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_detalle_departamento]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_detalle_puesto_empleado] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[perfil] ([id_perfil])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_detalle_puesto_empleado]
GO
ALTER TABLE [dbo].[procesos]  WITH CHECK ADD  CONSTRAINT [FK_empleado_proceso] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[Empleados] ([id_empleado])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[procesos] CHECK CONSTRAINT [FK_empleado_proceso]
GO
ALTER TABLE [dbo].[procesos]  WITH CHECK ADD  CONSTRAINT [FK_nivel_proceso] FOREIGN KEY([id_nivel])
REFERENCES [dbo].[niveles] ([id_nivel])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[procesos] CHECK CONSTRAINT [FK_nivel_proceso]
GO
/****** Object:  StoredProcedure [dbo].[CONSULTA_EMPLEADOS]    Script Date: 22/11/2021 09:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
GO
/****** Object:  StoredProcedure [dbo].[CONSULTAEMPLEADOPERFIL]    Script Date: 22/11/2021 09:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CONSULTAEMPLEADOPERFIL]
as
SELECT E.nombre, E.apellido1,E.apellido2,E.usuario,E.pass ,P.nombre
FROM Empleados AS E
JOIN perfil AS P
ON E.id_perfil = P.id_perfil
WHERE usuario = E.usuario AND pass = E.pass
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTA_EMPLEADOS]    Script Date: 22/11/2021 09:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTA_EMPLEADOS]
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
GO
/****** Object:  StoredProcedure [dbo].[SP_FILTRAR_Departamentos]    Script Date: 22/11/2021 09:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



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
/****** Object:  StoredProcedure [dbo].[SP_FILTRAR_EMPLEADOS]    Script Date: 22/11/2021 09:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  StoredProcedure [dbo].[sp_INSERTAR_DEPARTAMENTOS]    Script Date: 22/11/2021 09:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Creacion de procedimientos 
 



CREATE PROCEDURE [dbo].[sp_INSERTAR_DEPARTAMENTOS]

@nombre varchar(50),
@codigo varchar(50)


as insert into Departamentos(nombre,codigo)
values (@nombre,@codigo)
GO
/****** Object:  StoredProcedure [dbo].[sp_insertar_empleados]    Script Date: 22/11/2021 09:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Creacion de procedimientos 
 



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

as insert into Empleados(nombre,apellido1,apellido2,cedula,telefono,correo,usuario,pass,id_perfil,id_departamento)
values (@nombre,@apellido1,@apellido2,@cedula,@telefono,@correo,@usuario,@pass,@perfil,@departamento)
GO
/****** Object:  StoredProcedure [dbo].[sp_login]    Script Date: 22/11/2021 09:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[sp_login]
@usuario varchar(20),
@pass varchar(20)

AS
BEGIN

SELECT * FROM  Empleados 
WHERE usuario = @usuario AND pass = @pass

END
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICAR_DEPARTAMENTOS]    Script Date: 22/11/2021 09:08:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
