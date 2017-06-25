CREATE TABLE [dbo].[OperationalsTemplates]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(200) NOT NULL, 
    [Template] VARCHAR(150) NOT NULL, 
    [IsController] SMALLINT NOT NULL DEFAULT 0
)
