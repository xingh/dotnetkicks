USE [DotNetKicks]
GO
/****** Object:  Table [dbo].[Kick_BlockedReferral]    Script Date: 10/05/2007 04:46:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kick_BlockedReferral](
	[BlockedReferralID] [smallint] IDENTITY(1,1) NOT NULL,
	[BlockedReferralHostname] [nvarchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_Kick_BlockedReferral] PRIMARY KEY CLUSTERED 
(
	[BlockedReferralID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
