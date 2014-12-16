/****** Object:  StoredProcedure [dbo].[DeleteAmigo]    Script Date: 16/12/2014 01:15:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteAmigo] 
	 @IDUsuario			int
	,@IDUsuarioAmigo	int
AS
BEGIN

	DELETE FROM [dbo].[Amigos]
		  WHERE IDUsuario = @IDUsuario AND IDUsuarioAmigo = @IDUsuarioAmigo

END

GO
/****** Object:  StoredProcedure [dbo].[DeleteJuego]    Script Date: 16/12/2014 01:15:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteJuego] 
		@IDJuego int
AS
BEGIN
	UPDATE Juego set bActivo = 0 WHERE IDJuego = @IDJuego
END

GO
/****** Object:  StoredProcedure [dbo].[InsertAmigo]    Script Date: 16/12/2014 01:15:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertAmigo] 
	 @IDUsuario			int
	,@IDUsuarioAmigo	int
AS
BEGIN
	IF (SELECT COUNT(IDUsuarioAmigo) FROM Amigos WHERE IDUsuario = @IDUsuario AND IDUsuarioAmigo = @IDUsuarioAmigo) = 0
	BEGIN
		INSERT INTO [dbo].[Amigos]
				   ([IDUsuario]
				   ,[IDUsuarioAmigo])
			 VALUES
				   (@IDUsuario		
				   ,@IDUsuarioAmigo)
	END
END

GO
/****** Object:  StoredProcedure [dbo].[InsertCanica]    Script Date: 16/12/2014 01:15:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertCanica] 
	 @IDUsuario			int
	,@IDJuego			int
	,@IDCatalogoCanica	int
	,@fX				float
	,@fY				float
	,@fZ				float
AS
BEGIN

	INSERT INTO [dbo].[Canica]
			   ([IDUsuario]
			   ,[IDJuego]
			   ,[IDCatalogoCanica]
			   ,[fX]
			   ,[fY]
			   ,[fZ])
		 VALUES
			   (@IDUsuario			
			   ,@IDJuego			
			   ,@IDCatalogoCanica	
			   ,@fX					
			   ,@fY					
			   ,@fZ)

END

GO
/****** Object:  StoredProcedure [dbo].[InsertJuego]    Script Date: 16/12/2014 01:15:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertJuego] 
	 @IDUsuario				int
	,@IDCatalogoEscenario	int
	,@sNombre				nvarchar(50)
	,@dFecha				datetime
	,@bActivo				bit
AS
BEGIN
	DECLARE @IDJuego int

	IF (SELECT COUNT(IDJuego) FROM Juego WHERE sNombre = @sNombre and IDUsuario = @IDUsuario) = 0
	BEGIN
		INSERT INTO [dbo].[Juego]
				   ([IDUsuario]
				   ,[IDCatalogoEscenario]
				   ,[sNombre]
				   ,[bActivo])
			 VALUES
				   (@IDUsuario				
				   ,@IDCatalogoEscenario	
				   ,@sNombre				
				   ,@bActivo)	

		SET @IDJuego = IDENT_CURRENT('Juego')
		
		SELECT IDJuego,sNombre,dFecha FROM Juego WHERE IDJuego = @IDJuego
	END	
	ELSE
	BEGIN
		SELECT -1 AS IDJuego,'El nombre del juego ya existe' AS sNombre,GETDATE()
	END		

END

GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateUsuarios]    Script Date: 16/12/2014 01:15:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertUpdateUsuarios] 
	 @EMail		nvarchar(500)
	,@sAlias	nvarchar(50)
	,@sPass		nvarchar(50)
	,@sConfirm	nvarchar(50)
	,@bActivo	bit
AS
BEGIN
	DECLARE @IDUsuario	int
	SET @IDUsuario = 0

	SELECT @IDUsuario = ISNULL(IDUsuario,0) FROM Usuarios WHERE EMail = @EMail

	IF (SELECT COUNT(IDUsuario) FROM Usuarios WHERE sAlias = @sAlias AND IDUsuario <> @IDUsuario) = 0
	BEGIN

		IF @IDUsuario = 0
		BEGIN
			INSERT INTO [dbo].[Usuarios]
					   ([EMail]
					   ,[sAlias]
					   ,[sPass]
					   ,[bActivo])
				 VALUES
					   (@EMail		
					   ,@sAlias		
					   ,dbo.fn_getVarCharMD5(@sPass)			
					   ,@bActivo)
			SET @IDUsuario =  IDENT_CURRENT('Usuarios')

			SELECT IDUsuario,EMail,sAlias FROM Usuarios WHERE IDUsuario = @IDUsuario
		END
		ELSE
		BEGIN
		
			IF dbo.fn_getVarCharMD5(@sConfirm) = (SELECT dbo.fn_getVarCharMD5(sPass) FROM Usuarios WHERE IDUsuario = @IDUsuario)
			BEGIN
				UPDATE [dbo].[Usuarios]
				   SET [sPass]		= dbo.fn_getVarCharMD5(@sPass)		
					  ,[bActivo]	= @bActivo		
				 WHERE IDUsuario = @IDUsuario
			 
				 SELECT IDUsuario,EMail,sAlias FROM Usuarios WHERE IDUsuario = @IDUsuario
			END
			ELSE
			BEGIN
				SELECT -1 AS IDUsuario,'ERROR' AS EMail, 'Contraseña incorrecta' as sAlias --FROM Usuarios WHERE IDUsuario = @IDUsuario
			END
		END
	END
	ELSE
	BEGIN
		SELECT -1 AS IDUsuario,'ERROR' AS EMail, 'El Alias ya existe' as sAlias --FROM Usuarios WHERE IDUsuario = @IDUsuario
	END
	
END

GO
/****** Object:  StoredProcedure [dbo].[SelectJuegoXIDJuego]    Script Date: 16/12/2014 01:15:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SelectJuegoXIDJuego] 
	@IDJuego int
AS
BEGIN
	SELECT [IDJuego]
		  ,[IDUsuario]
		  ,[IDCatalogoEscenario]
		  ,[sNombre]
		  ,[dFecha]
		  ,[bActivo]
	  FROM [dbo].[Juego]
	WHERE IDJuego = @IDJuego
END

GO
/****** Object:  StoredProcedure [dbo].[SelectLstCanicasXIDJuego]    Script Date: 16/12/2014 01:15:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SelectLstCanicasXIDJuego] 
	@IDJuego int
AS
BEGIN

	SELECT [IDUsuario]
		  ,[IDJuego]
		  ,[IDCatalogoCanica]
		  ,[fX]
		  ,[fY]
		  ,[fZ]
	  FROM [dbo].[Canica]
	WHERE IDJuego = @IDJuego

END

GO
/****** Object:  StoredProcedure [dbo].[SelectLstCatalogoCanica]    Script Date: 16/12/2014 01:15:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SelectLstCatalogoCanica]
AS
BEGIN
	SELECT [IDCatalogoCanica]
		  ,[IDCatalogoTamanio]
		  ,[sNombre]
		  ,[sDescripción]
		  ,[bActiva]
	  FROM [dbo].[CatalogoCanica]
END

GO
/****** Object:  StoredProcedure [dbo].[SelectLstCatalogoEscenarios]    Script Date: 16/12/2014 01:15:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SelectLstCatalogoEscenarios]
AS
BEGIN
	SELECT [IDCatalogoEscenario]
		  ,[sNombre]
		  ,[sDescripcion]
		  ,[bActivo]
	  FROM [dbo].[CatalogoEscenario]
	ORDER BY sNombre
END

GO
/****** Object:  StoredProcedure [dbo].[SelectLstCatalogoTamanio]    Script Date: 16/12/2014 01:15:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SelectLstCatalogoTamanio]
AS
BEGIN
	SELECT [IDCatalogoTamanio]
		  ,[sDescripcion]
		  ,[bActiva]
	  FROM [dbo].[CatalogoTamanio]
END

GO
/****** Object:  StoredProcedure [dbo].[SelectLstJuegosXsAlias]    Script Date: 16/12/2014 01:15:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SelectLstJuegosXsAlias] 
	@sAlias nvarchar(50)
AS
BEGIN
	SELECT [IDJuego]
		  ,[IDUsuario]
		  ,[IDCatalogoEscenario]
		  ,[sNombre]
		  ,[dFecha]
		  ,[bActivo]
	  FROM [dbo].[Juego]
	  WHERE bActivo = 1
	  AND (IDUsuario = (SELECT TOP 1 IDUsuario FROM Usuarios WHERE sAlias = @sAlias) OR @sAlias = '.')
	  ORDER BY sNombre
END

GO
/****** Object:  StoredProcedure [dbo].[UsuarioLogin]    Script Date: 16/12/2014 01:15:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UsuarioLogin] 
	 @EMail	nvarchar(500)
	,@sPass		nvarchar(50)
AS
BEGIN
	SELECT IDUsuario,EMail,sAlias 
	FROM Usuarios 
	WHERE EMail = @Email AND sPass = dbo.fn_getVarCharMD5(@sPass)
END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_getVarCharMD5]    Script Date: 16/12/2014 01:15:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[fn_getVarCharMD5] 
(
	@textoOriginal varchar(50)
)
RETURNS varchar(50)
AS
BEGIN
	DECLARE @hash varchar(50)
	SET @hash = CONVERT(varchar(50),HASHBYTES('MD5',@textoOriginal),2)
	-- Return the result of the function
	RETURN @hash

END



GO
/****** Object:  Table [dbo].[Amigos]    Script Date: 16/12/2014 01:15:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Amigos](
	[IDUsuario] [int] NOT NULL,
	[IDUsuarioAmigo] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Canica]    Script Date: 16/12/2014 01:15:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Canica](
	[IDUsuario] [int] NOT NULL,
	[IDJuego] [int] NOT NULL,
	[IDCatalogoCanica] [int] NOT NULL,
	[fX] [float] NOT NULL,
	[fY] [float] NOT NULL,
	[fZ] [float] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CatalogoCanica]    Script Date: 16/12/2014 01:15:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CatalogoCanica](
	[IDCatalogoCanica] [int] IDENTITY(1,1) NOT NULL,
	[IDCatalogoTamanio] [int] NOT NULL,
	[sNombre] [nvarchar](50) NOT NULL,
	[sDescripción] [nvarchar](250) NULL,
	[bActiva] [bit] NOT NULL,
 CONSTRAINT [PK_CatalogoCanica] PRIMARY KEY CLUSTERED 
(
	[IDCatalogoCanica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CatalogoEscenario]    Script Date: 16/12/2014 01:15:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CatalogoEscenario](
	[IDCatalogoEscenario] [int] IDENTITY(1,1) NOT NULL,
	[sNombre] [nvarchar](50) NOT NULL,
	[sDescripcion] [nvarchar](250) NULL,
	[bActivo] [bit] NOT NULL,
 CONSTRAINT [PK_CatalogoEscenario] PRIMARY KEY CLUSTERED 
(
	[IDCatalogoEscenario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CatalogoTamanio]    Script Date: 16/12/2014 01:15:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CatalogoTamanio](
	[IDCatalogoTamanio] [int] IDENTITY(1,1) NOT NULL,
	[sDescripcion] [nvarchar](50) NOT NULL,
	[bActiva] [bit] NOT NULL,
 CONSTRAINT [PK_CatalogoTamanio] PRIMARY KEY CLUSTERED 
(
	[IDCatalogoTamanio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Juego]    Script Date: 16/12/2014 01:15:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Juego](
	[IDJuego] [int] IDENTITY(1,1) NOT NULL,
	[IDUsuario] [int] NOT NULL,
	[IDCatalogoEscenario] [int] NOT NULL,
	[sNombre] [nvarchar](50) NOT NULL,
	[dFecha] [datetime] NOT NULL,
	[bActivo] [bit] NOT NULL,
 CONSTRAINT [PK_Juego] PRIMARY KEY CLUSTERED 
(
	[IDJuego] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 16/12/2014 01:15:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IDUsuario] [int] IDENTITY(1,1) NOT NULL,
	[EMail] [nvarchar](500) NOT NULL,
	[sAlias] [nvarchar](50) NOT NULL,
	[sPass] [nvarchar](50) NOT NULL,
	[bActivo] [bit] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[IDUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Amigos] ([IDUsuario], [IDUsuarioAmigo]) VALUES (1, 2)
INSERT [dbo].[Amigos] ([IDUsuario], [IDUsuarioAmigo]) VALUES (2, 1)
INSERT [dbo].[Canica] ([IDUsuario], [IDJuego], [IDCatalogoCanica], [fX], [fY], [fZ]) VALUES (1, 1, 2, 1, 0, 1)
INSERT [dbo].[Canica] ([IDUsuario], [IDJuego], [IDCatalogoCanica], [fX], [fY], [fZ]) VALUES (1, 1, 2, 2, 0, 2)
SET IDENTITY_INSERT [dbo].[CatalogoCanica] ON 

INSERT [dbo].[CatalogoCanica] ([IDCatalogoCanica], [IDCatalogoTamanio], [sNombre], [sDescripción], [bActiva]) VALUES (1, 1, N'Chiquis', N'Rápida y furiosa', 1)
INSERT [dbo].[CatalogoCanica] ([IDCatalogoCanica], [IDCatalogoTamanio], [sNombre], [sDescripción], [bActiva]) VALUES (2, 1, N'Hacha', N'Veloz  y certera', 1)
INSERT [dbo].[CatalogoCanica] ([IDCatalogoCanica], [IDCatalogoTamanio], [sNombre], [sDescripción], [bActiva]) VALUES (3, 2, N'Johny', N'¿Qué diablos?', 1)
INSERT [dbo].[CatalogoCanica] ([IDCatalogoCanica], [IDCatalogoTamanio], [sNombre], [sDescripción], [bActiva]) VALUES (4, 3, N'La Mole', N'Oh yea!', 1)
SET IDENTITY_INSERT [dbo].[CatalogoCanica] OFF
SET IDENTITY_INSERT [dbo].[CatalogoEscenario] ON 

INSERT [dbo].[CatalogoEscenario] ([IDCatalogoEscenario], [sNombre], [sDescripcion], [bActivo]) VALUES (1, N'DEFAULT', N'Escenario por defecto', 1)
SET IDENTITY_INSERT [dbo].[CatalogoEscenario] OFF
SET IDENTITY_INSERT [dbo].[CatalogoTamanio] ON 

INSERT [dbo].[CatalogoTamanio] ([IDCatalogoTamanio], [sDescripcion], [bActiva]) VALUES (1, N'CHICA', 1)
INSERT [dbo].[CatalogoTamanio] ([IDCatalogoTamanio], [sDescripcion], [bActiva]) VALUES (2, N'MEDIANA', 1)
INSERT [dbo].[CatalogoTamanio] ([IDCatalogoTamanio], [sDescripcion], [bActiva]) VALUES (3, N'GRANDE', 1)
SET IDENTITY_INSERT [dbo].[CatalogoTamanio] OFF
SET IDENTITY_INSERT [dbo].[Juego] ON 

INSERT [dbo].[Juego] ([IDJuego], [IDUsuario], [IDCatalogoEscenario], [sNombre], [dFecha], [bActivo]) VALUES (1, 1, 1, N'PRIMER JUEGO', CAST(0x0000A40300D2665A AS DateTime), 1)
INSERT [dbo].[Juego] ([IDJuego], [IDUsuario], [IDCatalogoEscenario], [sNombre], [dFecha], [bActivo]) VALUES (2, 1, 1, N'SEGUNDO JUEGO', CAST(0x0000A40300D293EB AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Juego] OFF
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([IDUsuario], [EMail], [sAlias], [sPass], [bActivo]) VALUES (1, N'soporte@lulamb.com', N'Astucia', N'81DC9BDB52D04DC20036DBD8313ED055', 1)
INSERT [dbo].[Usuarios] ([IDUsuario], [EMail], [sAlias], [sPass], [bActivo]) VALUES (2, N'astucia.huitzilopochtli@gmail.com', N'AstuciaH', N'81DC9BDB52D04DC20036DBD8313ED055', 1)
INSERT [dbo].[Usuarios] ([IDUsuario], [EMail], [sAlias], [sPass], [bActivo]) VALUES (3, N'astucia_huitzilopochtli@hotmail.com', N'AstuciaH1', N'81DC9BDB52D04DC20036DBD8313ED055', 1)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
ALTER TABLE [dbo].[CatalogoCanica] ADD  CONSTRAINT [DF_CatalogoCanica_IDCatalogoTamanio]  DEFAULT ((2)) FOR [IDCatalogoTamanio]
GO
ALTER TABLE [dbo].[CatalogoCanica] ADD  CONSTRAINT [DF_CatalogoCanica_bActiva]  DEFAULT ((1)) FOR [bActiva]
GO
ALTER TABLE [dbo].[CatalogoEscenario] ADD  CONSTRAINT [DF_CatalogoEscenario_bActivo]  DEFAULT ((1)) FOR [bActivo]
GO
ALTER TABLE [dbo].[CatalogoTamanio] ADD  CONSTRAINT [DF_CatalogoTamanio_bActiva]  DEFAULT ((1)) FOR [bActiva]
GO
ALTER TABLE [dbo].[Juego] ADD  CONSTRAINT [DF_Juego_IDCatalogoEscenario]  DEFAULT ((1)) FOR [IDCatalogoEscenario]
GO
ALTER TABLE [dbo].[Juego] ADD  CONSTRAINT [DF_Juego_dFecha]  DEFAULT (getdate()) FOR [dFecha]
GO
ALTER TABLE [dbo].[Juego] ADD  CONSTRAINT [DF_Juego_bActivo]  DEFAULT ((1)) FOR [bActivo]
GO
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_bActivo]  DEFAULT ((1)) FOR [bActivo]
GO
ALTER TABLE [dbo].[Canica]  WITH CHECK ADD  CONSTRAINT [FK_Canica_CatalogoCanica] FOREIGN KEY([IDCatalogoCanica])
REFERENCES [dbo].[CatalogoCanica] ([IDCatalogoCanica])
GO
ALTER TABLE [dbo].[Canica] CHECK CONSTRAINT [FK_Canica_CatalogoCanica]
GO
ALTER TABLE [dbo].[Canica]  WITH CHECK ADD  CONSTRAINT [FK_Canica_Juego] FOREIGN KEY([IDJuego])
REFERENCES [dbo].[Juego] ([IDJuego])
GO
ALTER TABLE [dbo].[Canica] CHECK CONSTRAINT [FK_Canica_Juego]
GO
ALTER TABLE [dbo].[Canica]  WITH CHECK ADD  CONSTRAINT [FK_Canica_Usuarios] FOREIGN KEY([IDUsuario])
REFERENCES [dbo].[Usuarios] ([IDUsuario])
GO
ALTER TABLE [dbo].[Canica] CHECK CONSTRAINT [FK_Canica_Usuarios]
GO
ALTER TABLE [dbo].[CatalogoCanica]  WITH CHECK ADD  CONSTRAINT [FK_CatalogoCanica_CatalogoTamanio] FOREIGN KEY([IDCatalogoTamanio])
REFERENCES [dbo].[CatalogoTamanio] ([IDCatalogoTamanio])
GO
ALTER TABLE [dbo].[CatalogoCanica] CHECK CONSTRAINT [FK_CatalogoCanica_CatalogoTamanio]
GO
ALTER TABLE [dbo].[Juego]  WITH CHECK ADD  CONSTRAINT [FK_Juego_CatalogoEscenario] FOREIGN KEY([IDCatalogoEscenario])
REFERENCES [dbo].[CatalogoEscenario] ([IDCatalogoEscenario])
GO
ALTER TABLE [dbo].[Juego] CHECK CONSTRAINT [FK_Juego_CatalogoEscenario]
GO
ALTER TABLE [dbo].[Juego]  WITH CHECK ADD  CONSTRAINT [FK_Juego_Usuarios] FOREIGN KEY([IDUsuario])
REFERENCES [dbo].[Usuarios] ([IDUsuario])
GO
ALTER TABLE [dbo].[Juego] CHECK CONSTRAINT [FK_Juego_Usuarios]
GO

