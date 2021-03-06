USE [DotNetKicks]
GO
/****** Object:  Table [dbo].[Kick_ReservedUsername]    Script Date: 09/29/2007 03:04:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kick_ReservedUsername](
	[UsernameID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_Kick_ReservedUsername] PRIMARY KEY CLUSTERED 
(
	[UsernameID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
