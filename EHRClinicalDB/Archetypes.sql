CREATE TABLE [dbo].[Archetypes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Term] VARCHAR(100) NOT NULL, 
    [ArchetypeID] VARCHAR(255) NOT NULL, 
    [Parent] INT NULL
)
