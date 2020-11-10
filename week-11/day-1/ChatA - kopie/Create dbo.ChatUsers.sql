USE [ChatUsers]
GO

/****** Object: Table [dbo].[ChatUsers] Script Date: 09.11.2020 17:39:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ChatUsers] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [UserId]    INT            NOT NULL,
    [ApiKey]    NVARCHAR (MAX) NULL,
    [Login]     NVARCHAR (MAX) NULL,
    [UserName]  NVARCHAR (MAX) NULL,
    [Password]  NVARCHAR (MAX) NULL,
    [AvatarUrl] NVARCHAR (MAX) NULL
);
INSERT INTO [dbo].ChatUsers (Login, UserName, Password, UserId) VALUES ('Standa', 'Standa', 'pass', 16)

