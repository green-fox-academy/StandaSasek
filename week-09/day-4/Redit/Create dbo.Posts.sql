USE [Redit]
GO

/****** Object: Table [dbo].[Posts] Script Date: 30.10.2020 22:34:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Posts] (
    [Id]      INT            IDENTITY (1, 1) NOT NULL,
    [Created] DATETIME2 (7)  NOT NULL,
    [Text]    NVARCHAR (MAX) NULL,
    [Link]    NVARCHAR (MAX) NULL,
    [UserId]  INT            NOT NULL
);


GO
CREATE NONCLUSTERED INDEX [IX_Posts_UserId]
    ON [dbo].[Posts]([UserId] ASC);


GO
ALTER TABLE [dbo].[Posts]
    ADD CONSTRAINT [PK_Posts] PRIMARY KEY CLUSTERED ([Id] ASC);


GO
ALTER TABLE [dbo].[Posts]
    ADD CONSTRAINT [FK_Posts_User_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id]);

INSERT INTO [dbo].[Posts] (Created, Text, Link, UserId) VALUES (GETDATE(), 'breakfast and cofee', 'www.link.com', 1)
INSERT INTO [dbo].[Posts] (Created, Text, Link, UserId) VALUES (GETDATE(), 'lunch and cofee', 'www.link.com', 1)
INSERT INTO [dbo].[Posts] (Created, Text, Link, UserId) VALUES (GETDATE(), 'dinner and cofee', 'www.link.com', 1)
