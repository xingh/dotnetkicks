USE [DotNetKicks]
GO

ALTER TABLE dbo.Kick_Host ADD [ReCaptchaPublicKey] [nvarchar](100) NULL
GO

ALTER TABLE dbo.Kick_Host ADD [ReCaptchaPrivateKey] [nvarchar](100) NULL
GO

