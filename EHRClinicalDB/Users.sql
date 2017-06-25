CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserName] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(100) NOT NULL, 
    [Password] NCHAR(8) NOT NULL, 
    [Token] VARCHAR(MAX) NULL, 
    [Organization] NCHAR(10) NULL, 
    [RoleGroupID] INT NOT NULL, 
    [Status] SMALLINT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_Users_ToRolesGroup] FOREIGN KEY (RoleGroupID) REFERENCES RolesGroup(Id)
)
