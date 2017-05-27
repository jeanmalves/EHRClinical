CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [UserName] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(100) NOT NULL, 
    [Password] NCHAR(8) NOT NULL, 
    [Token] VARCHAR(MAX) NOT NULL, 
    [Organization] NCHAR(10) NOT NULL, 
    [Access] SMALLINT NOT NULL, 
    [Status] SMALLINT NOT NULL DEFAULT 0
)
